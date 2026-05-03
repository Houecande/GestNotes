Imports System.Data.OleDb

Public Class FormImpressions

    Private Sub FormImpressions_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        ' Type de document
        cmbTypeDoc.Items.Clear()
        cmbTypeDoc.Items.Add("Bulletins individuels")
        cmbTypeDoc.Items.Add("Relevé collectif (ordre de mérite)")
        cmbTypeDoc.SelectedIndex = 0

        ' Charger les classes
        ChargerComboClasses()

        btnImprimer.Enabled = False
        btnExporterPDF.Enabled = False
        btnApercu.Enabled = False
    End Sub

    ' ── Charger les classes ───────────────────────────────────
    Private Sub ChargerComboClasses()
        Dim dt = ModuleBDD.GetDataTable(
            "SELECT code_classe, libelle_classe " &
            "FROM Classe ORDER BY libelle_classe")

        cmbClasseImp.Items.Clear()
        For Each row As DataRow In dt.Rows
            cmbClasseImp.Items.Add(row("code_classe").ToString())
        Next
        cmbClasseImp.SelectedIndex = -1
    End Sub

    ' ── Changement type document ──────────────────────────────
    Private Sub cmbTypeDoc_SelectedIndexChanged(
        sender As Object, e As EventArgs) _
        Handles cmbTypeDoc.SelectedIndexChanged

        Dim estBulletin = (cmbTypeDoc.SelectedIndex = 0)
        cmbEtudiantImp.Visible = estBulletin
        rtbApercu.Clear()
        btnApercu.Enabled = (cmbClasseImp.SelectedIndex >= 0)
        btnImprimer.Enabled = False
        btnExporterPDF.Enabled = False
    End Sub

    ' ── Changement de classe ──────────────────────────────────
    Private Sub cmbClasseImp_SelectedIndexChanged(
        sender As Object, e As EventArgs) _
        Handles cmbClasseImp.SelectedIndexChanged

        cmbEtudiantImp.Items.Clear()
        cmbEtudiantImp.Items.Add("Tous les étudiants")

        If cmbClasseImp.SelectedIndex < 0 Then
            btnApercu.Enabled = False
            Exit Sub
        End If

        ' Charger les étudiants de la classe
        Dim dt = ModuleBDD.GetDataTable(
            "SELECT num_matricule, nom_prenom " &
            "FROM Etudiant WHERE code_classe = ? " &
            "ORDER BY nom_prenom",
            New OleDbParameter("@classe",
                cmbClasseImp.SelectedItem.ToString()))

        For Each row As DataRow In dt.Rows
            cmbEtudiantImp.Items.Add(
                row("num_matricule").ToString() &
                " — " & row("nom_prenom").ToString())
        Next

        cmbEtudiantImp.SelectedIndex = 0
        btnApercu.Enabled = True
        rtbApercu.Clear()
        btnImprimer.Enabled = False
        btnExporterPDF.Enabled = False
    End Sub

    ' ── Bouton Aperçu ─────────────────────────────────────────
    Private Sub btnApercu_Click(sender As Object, e As EventArgs) _
        Handles btnApercu.Click

        If cmbClasseImp.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner une classe.",
                   MsgBoxStyle.Exclamation, "Classe requise")
            Exit Sub
        End If

        rtbApercu.Clear()

        If cmbTypeDoc.SelectedIndex = 0 Then
            GenererBulletin()
        Else
            GenererReleveCollectif()
        End If

        btnImprimer.Enabled = True
        btnExporterPDF.Enabled = True
    End Sub

    ' ══════════════════════════════════════════════════════════
    '  GÉNÉRATION BULLETIN INDIVIDUEL
    ' ══════════════════════════════════════════════════════════
    Private Sub GenererBulletin()
        Dim classe = cmbClasseImp.SelectedItem.ToString()
        Dim annee = txtAnneeScolaire.Text

        ' Récupérer infos institut
        Dim dtParam = ModuleBDD.GetDataTable(
            "SELECT nom_institut, adresse " &
            "FROM Parametres")
        Dim nomInstitut = If(dtParam.Rows.Count > 0,
            dtParam.Rows(0)("nom_institut").ToString(),
            "INSTITUT")
        Dim adresse = If(dtParam.Rows.Count > 0,
            dtParam.Rows(0)("adresse").ToString(), "")

        ' Déterminer quels étudiants afficher
        Dim dtEtudiants As DataTable
        If cmbEtudiantImp.SelectedIndex = 0 Then
            ' Tous les étudiants
            dtEtudiants = ModuleBDD.GetDataTable(
                "SELECT * FROM Etudiant " &
                "WHERE code_classe = ? ORDER BY nom_prenom",
                New OleDbParameter("@classe", classe))
        Else
            ' Un seul étudiant
            Dim item = cmbEtudiantImp.SelectedItem.ToString()
            Dim matricule = item.Split("—"c)(0).Trim()
            dtEtudiants = ModuleBDD.GetDataTable(
                "SELECT * FROM Etudiant " &
                "WHERE num_matricule = ?",
                New OleDbParameter("@mat", matricule))
        End If

        Dim sb As New System.Text.StringBuilder()

        For Each etudRow As DataRow In dtEtudiants.Rows
            Dim matricule = etudRow("num_matricule").ToString()
            Dim nom = etudRow("nom_prenom").ToString()
            Dim sexe = etudRow("sexe").ToString()
            Dim dateNaiss = ""
            Try
                dateNaiss = CDate(
                    etudRow("date_naissance")).ToString("dd/MM/yyyy")
            Catch
                dateNaiss = "—"
            End Try
            Dim lieuNaiss = etudRow("lieu_naissance").ToString()

            ' Récupérer les notes de cet étudiant
            Dim dtNotes = ModuleBDD.GetDataTable(
                "SELECT n.code_matiere, m.libelle_matiere, " &
                "m.coefficient, n.note_interro, " &
                "n.note_devoir, n.moyenne_matiere " &
                "FROM [Note] n " &
                "INNER JOIN Matiere m " &
                "ON n.code_matiere = m.code_matiere " &
                "WHERE n.num_matricule = ? " &
                "ORDER BY m.libelle_matiere",
                New OleDbParameter("@mat", matricule))

            ' Calculer moyenne générale pondérée
            Dim totalPoints As Double = 0
            Dim totalCoefs As Integer = 0
            For Each noteRow As DataRow In dtNotes.Rows
                Dim coef = CInt(noteRow("coefficient"))
                Dim moy As Double = 0
                Double.TryParse(
                    noteRow("moyenne_matiere").ToString().
                    Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    moy)
                totalPoints += moy * coef
                totalCoefs += coef
            Next

            Dim moyGen As Double = 0
            If totalCoefs > 0 Then
                moyGen = Math.Round(totalPoints / totalCoefs, 2)
            End If

            ' Calculer le rang dans la classe
            Dim rang = CalculerRang(matricule, classe)

            ' Décision
            Dim decision = If(moyGen >= 10, "ADMIS(E) ✓",
                              "AJOURNÉ(E) ✗")

            ' ── Construction du bulletin ──────────────────
            sb.AppendLine(New String("═"c, 60))
            sb.AppendLine(CentrerTexte(nomInstitut, 60))
            sb.AppendLine(CentrerTexte(adresse, 60))
            sb.AppendLine(New String("═"c, 60))
            sb.AppendLine()
            sb.AppendLine(CentrerTexte("BULLETIN DE NOTES", 60))
            sb.AppendLine(CentrerTexte(
                "Année scolaire : " & annee, 60))
            sb.AppendLine()
            sb.AppendLine(New String("─"c, 60))
            sb.AppendLine("  Matricule  : " & matricule &
                          "       Classe : " & classe)
            sb.AppendLine("  Nom        : " & nom)
            sb.AppendLine("  Naissance  : " & dateNaiss &
                          "  à  " & lieuNaiss)
            sb.AppendLine("  Sexe       : " & sexe)
            sb.AppendLine(New String("─"c, 60))
            sb.AppendLine()

            ' En-tête tableau notes
            sb.AppendLine(
                PadCol("MATIÈRE", 22) &
                PadCol("COEF", 6) &
                PadCol("INTERRO", 9) &
                PadCol("DEVOIR", 8) &
                PadCol("MOY.", 7) &
                "APPRÉCIATION")
            sb.AppendLine(New String("─"c, 60))

            For Each noteRow As DataRow In dtNotes.Rows
                Dim matiere = noteRow("libelle_matiere").ToString()
                Dim coef = noteRow("coefficient").ToString()
                Dim interro As Double = 0
                Dim devoir As Double = 0
                Dim moy As Double = 0
                Double.TryParse(
                    noteRow("note_interro").ToString().
                    Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    interro)
                Double.TryParse(
                    noteRow("note_devoir").ToString().
                    Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    devoir)
                Double.TryParse(
                    noteRow("moyenne_matiere").ToString().
                    Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    moy)

                Dim appreciation = GetAppreciation(moy)

                sb.AppendLine(
                    PadCol(matiere, 22) &
                    PadCol(coef, 6) &
                    PadCol(interro.ToString("F2"), 9) &
                    PadCol(devoir.ToString("F2"), 8) &
                    PadCol(moy.ToString("F2"), 7) &
                    appreciation)
            Next

            sb.AppendLine(New String("─"c, 60))
            sb.AppendLine()

            ' Résumé
            sb.AppendLine(
                "  ► Moyenne générale : " &
                moyGen.ToString("F2") & " / 20")
            sb.AppendLine(
                "  ► Rang              : " & rang)
            sb.AppendLine(
                "  ► Décision          : " & decision)
            sb.AppendLine()
            sb.AppendLine(New String("─"c, 60))
            sb.AppendLine(
                "  Édité le : " &
                DateTime.Now.ToString("dd/MM/yyyy"))
            sb.AppendLine()
            sb.AppendLine("  Signature du Directeur :")
            sb.AppendLine()
            sb.AppendLine("  " & New String("_"c, 25))
            sb.AppendLine(New String("═"c, 60))
            sb.AppendLine()
            sb.AppendLine()
        Next

        rtbApercu.Text = sb.ToString()
    End Sub

    ' ══════════════════════════════════════════════════════════
    '  GÉNÉRATION RELEVÉ COLLECTIF PAR MÉRITE
    ' ══════════════════════════════════════════════════════════
    Private Sub GenererReleveCollectif()
        Dim classe = cmbClasseImp.SelectedItem.ToString()
        Dim annee = txtAnneeScolaire.Text

        ' Infos institut
        Dim dtParam = ModuleBDD.GetDataTable(
            "SELECT nom_institut FROM Parametres")
        Dim nomInstitut = If(dtParam.Rows.Count > 0,
            dtParam.Rows(0)("nom_institut").ToString(),
            "INSTITUT")

        ' Récupérer tous les étudiants de la classe
        Dim dtEtudiants = ModuleBDD.GetDataTable(
            "SELECT num_matricule, nom_prenom " &
            "FROM Etudiant WHERE code_classe = ?",
            New OleDbParameter("@classe", classe))

        ' Calculer la moyenne générale de chaque étudiant
        Dim listeEtudiants As New List(Of (
            String, String, Double))

        For Each row As DataRow In dtEtudiants.Rows
            Dim matricule = row("num_matricule").ToString()
            Dim nom = row("nom_prenom").ToString()

            Dim dtNotes = ModuleBDD.GetDataTable(
                "SELECT n.moyenne_matiere, m.coefficient " &
                "FROM [Note] n " &
                "INNER JOIN Matiere m " &
                "ON n.code_matiere = m.code_matiere " &
                "WHERE n.num_matricule = ? " &
                "AND m.code_classe = ?",
                New OleDbParameter("@mat", matricule),
                New OleDbParameter("@classe", classe))

            Dim totalPoints As Double = 0
            Dim totalCoefs As Integer = 0
            For Each noteRow As DataRow In dtNotes.Rows
                Dim coef = CInt(noteRow("coefficient"))
                Dim moy As Double = 0
                Double.TryParse(
                    noteRow("moyenne_matiere").ToString().
                    Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    moy)
                totalPoints += moy * coef
                totalCoefs += coef
            Next

            Dim moyGen As Double = 0
            If totalCoefs > 0 Then
                moyGen = Math.Round(totalPoints / totalCoefs, 2)
            End If

            listeEtudiants.Add((matricule, nom, moyGen))
        Next

        ' Trier par mérite (moyenne décroissante)
        Dim listeTrie = listeEtudiants.
            OrderByDescending(Function(x) x.Item3).ToList()

        ' Construction du relevé
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine(New String("═"c, 65))
        sb.AppendLine(CentrerTexte(nomInstitut, 65))
        sb.AppendLine(New String("═"c, 65))
        sb.AppendLine()
        sb.AppendLine(CentrerTexte(
            "RELEVÉ DE NOTES COLLECTIF — PAR ORDRE DE MÉRITE", 65))
        sb.AppendLine(CentrerTexte(
            "Classe : " & classe &
            "     Année : " & annee, 65))
        sb.AppendLine()
        sb.AppendLine(
            PadCol("RANG", 7) &
            PadCol("MATRICULE", 12) &
            PadCol("NOM & PRÉNOM", 26) &
            PadCol("MOY. GÉN.", 12) &
            "DÉCISION")
        sb.AppendLine(New String("─"c, 65))

        Dim rang As Integer = 1
        Dim nbAdmis As Integer = 0
        Dim nbAjournes As Integer = 0

        For Each etud In listeTrie
            Dim decision = If(etud.Item3 >= 10,
                              "ADMIS(E)", "AJOURNÉ(E)")
            Dim rangStr = rang & GetSuffixeRang(rang)

            sb.AppendLine(
                PadCol(rangStr, 7) &
                PadCol(etud.Item1, 12) &
                PadCol(etud.Item2, 26) &
                PadCol(etud.Item3.ToString("F2"), 12) &
                decision)

            If etud.Item3 >= 10 Then
                nbAdmis += 1
            Else
                nbAjournes += 1
            End If
            rang += 1
        Next

        sb.AppendLine(New String("─"c, 65))
        sb.AppendLine()

        ' Statistiques globales
        Dim moyClasse As Double = 0
        If listeTrie.Count > 0 Then
            moyClasse = Math.Round(
                listeTrie.Average(Function(x) x.Item3), 2)
        End If

        sb.AppendLine("  Effectif total  : " &
                      listeTrie.Count & " étudiant(s)")
        sb.AppendLine("  Admis           : " & nbAdmis)
        sb.AppendLine("  Ajournés        : " & nbAjournes)
        sb.AppendLine("  Taux de réussite: " &
                      If(listeTrie.Count > 0,
                         Math.Round(nbAdmis * 100.0 /
                         listeTrie.Count, 1).ToString() & "%",
                         "—"))
        sb.AppendLine("  Moyenne classe  : " &
                      moyClasse.ToString("F2") & " / 20")
        sb.AppendLine()
        sb.AppendLine("  Édité le : " &
                      DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
        sb.AppendLine()
        sb.AppendLine("  Signature du Directeur :")
        sb.AppendLine()
        sb.AppendLine("  " & New String("_"c, 25))
        sb.AppendLine(New String("═"c, 65))

        rtbApercu.Text = sb.ToString()
    End Sub

    ' ══════════════════════════════════════════════════════════
    '  FONCTIONS UTILITAIRES
    ' ══════════════════════════════════════════════════════════

    ' Calculer le rang d'un étudiant dans sa classe
    Private Function CalculerRang(matricule As String,
        classe As String) As String
        Dim dtTous = ModuleBDD.GetDataTable(
            "SELECT e.num_matricule, " &
            "SUM(n.moyenne_matiere * m.coefficient) / " &
            "SUM(m.coefficient) AS moy_gen " &
            "FROM Etudiant e " &
            "INNER JOIN [Note] n " &
            "ON e.num_matricule = n.num_matricule " &
            "INNER JOIN Matiere m " &
            "ON n.code_matiere = m.code_matiere " &
            "WHERE e.code_classe = ? " &
            "GROUP BY e.num_matricule " &
            "ORDER BY moy_gen DESC",
            New OleDbParameter("@classe", classe))

        Dim rang As Integer = 1
        For Each row As DataRow In dtTous.Rows
            If row("num_matricule").ToString() = matricule Then
                Return rang & GetSuffixeRang(rang) &
                       " / " & dtTous.Rows.Count
            End If
            rang += 1
        Next
        Return "— / " & dtTous.Rows.Count
    End Function

    Private Function GetSuffixeRang(rang As Integer) As String
        If rang = 1 Then Return "er"
        Return "ème"
    End Function

    Private Function GetAppreciation(moy As Double) As String
        If moy >= 16 Then Return "Très Bien"
        If moy >= 14 Then Return "Bien"
        If moy >= 12 Then Return "Assez Bien"
        If moy >= 10 Then Return "Passable"
        If moy >= 7 Then Return "Insuffisant"
        Return "Très Insuffisant"
    End Function

    Private Function PadCol(texte As String,
        largeur As Integer) As String
        If texte Is Nothing Then texte = ""
        If texte.Length >= largeur Then
            Return texte.Substring(0, largeur - 1) & " "
        End If
        Return texte.PadRight(largeur)
    End Function

    Private Function CentrerTexte(texte As String,
        largeur As Integer) As String
        If texte Is Nothing Then texte = ""
        If texte.Length >= largeur Then Return texte
        Dim espaces = (largeur - texte.Length) \ 2
        Return New String(" "c, espaces) & texte
    End Function

    ' ── Impression ────────────────────────────────────────────
    Private Sub btnImprimer_Click(sender As Object,
        e As EventArgs) Handles btnImprimer.Click

        If String.IsNullOrEmpty(rtbApercu.Text) Then
            MsgBox("Générez d'abord un aperçu.",
                   MsgBoxStyle.Exclamation, "Aperçu requis")
            Exit Sub
        End If

        Dim pd As New Printing.PrintDocument()
        Dim contenu = rtbApercu.Text
        Dim lignes = contenu.Split(
            New String() {vbCrLf, vbLf},
            StringSplitOptions.None)
        Dim ligneCourante As Integer = 0

        AddHandler pd.PrintPage, Sub(s, ev)
                                     Dim font As New Font("Courier New", 8)
                                     Dim x As Single = ev.MarginBounds.Left
                                     Dim y As Single = ev.MarginBounds.Top
                                     Dim hauteurLigne = font.GetHeight(ev.Graphics)

                                     While ligneCourante < lignes.Length
                                         If y + hauteurLigne > ev.MarginBounds.Bottom Then
                                             ev.HasMorePages = True
                                             Exit Sub
                                         End If
                                         ev.Graphics.DrawString(
                                             lignes(ligneCourante), font,
                                             Brushes.Black, x, y)
                                         y += hauteurLigne
                                         ligneCourante += 1
                                     End While
                                     ev.HasMorePages = False
                                 End Sub

        Dim dlg As New PrintDialog()
        dlg.Document = pd
        If dlg.ShowDialog() = DialogResult.OK Then
            pd.Print()
        End If
    End Sub

    ' ── Export texte ──────────────────────────────────────────
    Private Sub btnExporterPDF_Click(sender As Object,
        e As EventArgs) Handles btnExporterPDF.Click

        If String.IsNullOrEmpty(rtbApercu.Text) Then
            MsgBox("Générez d'abord un aperçu.",
                   MsgBoxStyle.Exclamation, "Aperçu requis")
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Fichier texte (*.txt)|*.txt"
        sfd.FileName = If(cmbTypeDoc.SelectedIndex = 0,
            "Bulletin_" & DateTime.Now.ToString("yyyyMMdd"),
            "Releve_" & DateTime.Now.ToString("yyyyMMdd"))

        If sfd.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(sfd.FileName,
                rtbApercu.Text,
                System.Text.Encoding.UTF8)
            MsgBox("Document exporté avec succès !" &
                   vbCrLf & sfd.FileName,
                   MsgBoxStyle.Information, "Export réussi")
        End If
    End Sub

End Class