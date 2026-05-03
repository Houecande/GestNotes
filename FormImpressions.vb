Imports System.Data.OleDb
Imports System.Linq

Public Class FormImpressions

    Private Sub FormImpressions_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        cmbTypeDoc.Items.Clear()
        cmbTypeDoc.Items.Add("Bulletins individuels")
        cmbTypeDoc.Items.Add("Relevé collectif (ordre de mérite)")
        cmbTypeDoc.SelectedIndex = 0

        ChargerComboClasses()

        btnImprimer.Enabled = False
        btnExporterPDF.Enabled = False
        btnApercu.Enabled = False

        ' Page d'accueil du WebBrowser
        wbApercu.DocumentText = PageAccueil()
    End Sub

    ' Page d'accueil 
    Private Function PageAccueil() As String
        Return "<!DOCTYPE html><html><head>" &
               "<style>" &
               "body{font-family:Segoe UI,sans-serif;" &
               "display:flex;align-items:center;" &
               "justify-content:center;height:90vh;" &
               "background:#F0F4F8;margin:0;}" &
               ".msg{text-align:center;color:#B5D4F4;}" &
               ".msg h2{color:#185FA5;font-size:22px;}" &
               ".msg p{font-size:13px;color:#888780;}" &
               ".icon{font-size:48px;margin-bottom:10px;}" &
               "</style></head><body>" &
               "<div class='msg'>" &
               "<div class='icon'>🖨️</div>" &
               "<h2>Impressions</h2>" &
               "<p>Sélectionnez une classe puis " &
               "cliquez sur Aperçu</p>" &
               "</div></body></html>"
    End Function

    ' Charger les classes
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

    ' Changement type document 
    Private Sub cmbTypeDoc_SelectedIndexChanged(
        sender As Object, e As EventArgs) _
        Handles cmbTypeDoc.SelectedIndexChanged
        Dim estBulletin = (cmbTypeDoc.SelectedIndex = 0)
        cmbEtudiantImp.Visible = estBulletin
        wbApercu.DocumentText = PageAccueil()
        btnApercu.Enabled = (cmbClasseImp.SelectedIndex >= 0)
        btnImprimer.Enabled = False
        btnExporterPDF.Enabled = False
    End Sub

    ' Changement de classe 
    Private Sub cmbClasseImp_SelectedIndexChanged(
        sender As Object, e As EventArgs) _
        Handles cmbClasseImp.SelectedIndexChanged

        cmbEtudiantImp.Items.Clear()
        cmbEtudiantImp.Items.Add("Tous les étudiants")

        If cmbClasseImp.SelectedIndex < 0 Then
            btnApercu.Enabled = False : Exit Sub
        End If

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
        wbApercu.DocumentText = PageAccueil()
        btnImprimer.Enabled = False
        btnExporterPDF.Enabled = False
    End Sub

    ' Bouton Aperçu 
    Private Sub btnApercu_Click(sender As Object, e As EventArgs) _
        Handles btnApercu.Click

        If cmbClasseImp.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner une classe.",
                   MsgBoxStyle.Exclamation, "Classe requise")
            Exit Sub
        End If

        If cmbTypeDoc.SelectedIndex = 0 Then
            wbApercu.DocumentText = GenererHTMLBulletin()
        Else
            wbApercu.DocumentText = GenererHTMLReleve()
        End If

        btnImprimer.Enabled = True
        btnExporterPDF.Enabled = True
    End Sub

    ' CSS COMMUN
    Private Function GetCSS() As String
        Return "<style>" &
            "* { box-sizing: border-box; margin: 0; padding: 0; }" &
            "body { font-family: 'Segoe UI', Arial, sans-serif;" &
            "background: #F0F4F8; padding: 20px; }" &
            ".bulletin { background: white; max-width: 750px;" &
            "margin: 0 auto 30px; border-radius: 8px;" &
            "overflow: hidden;" &
            "box-shadow: 0 2px 12px rgba(0,0,0,0.1); }" &
            ".header { background: #0C447C; color: white;" &
            "padding: 20px; text-align: center; }" &
            ".header h1 { font-size: 16px; font-weight: 600;" &
            "letter-spacing: 1px; margin-bottom: 4px; }" &
            ".header p { font-size: 11px; opacity: 0.8; }" &
            ".doc-title { background: #185FA5; color: white;" &
            "text-align: center; padding: 10px;" &
            "font-size: 14px; font-weight: 600;" &
            "letter-spacing: 2px; }" &
            ".doc-annee { background: #E6F1FB; color: #0C447C;" &
            "text-align: center; padding: 6px;" &
            "font-size: 12px; }" &
            ".info-grid { display: grid;" &
            "grid-template-columns: 1fr 1fr;" &
            "gap: 0; border-bottom: 1px solid #E6F1FB; }" &
            ".info-item { padding: 8px 16px;" &
            "font-size: 12px; color: #333;" &
            "border-bottom: 1px solid #F0F4F8; }" &
            ".info-item span { color: #185FA5;" &
            "font-weight: 600; margin-right: 6px; }" &
            ".section { padding: 16px; }" &
            "table { width: 100%; border-collapse: collapse;" &
            "font-size: 12px; }" &
            "thead tr { background: #185FA5; color: white; }" &
            "thead th { padding: 10px 12px; text-align: left;" &
            "font-weight: 600; }" &
            "tbody tr:nth-child(even) { background: #F8FBFF; }" &
            "tbody tr:hover { background: #E6F1FB; }" &
            "tbody td { padding: 9px 12px;" &
            "border-bottom: 1px solid #EEF2F7; }" &
            ".moy-cell { font-weight: 700; border-radius: 4px;" &
            "padding: 3px 8px !important;" &
            "text-align: center; }" &
            ".moy-tb { background: #E1F5EE; color: #085041; }" &
            ".moy-b { background: #D1FAE5; color: #065F46; }" &
            ".moy-ab { background: #E6F1FB; color: #0C447C; }" &
            ".moy-p { background: #FEF3C7; color: #92400E; }" &
            ".moy-i { background: #FEE2E2; color: #991B1B; }" &
            ".resume { background: #E6F1FB;" &
            "border-left: 4px solid #185FA5;" &
            "padding: 14px 16px; margin: 0 16px 16px;" &
            "border-radius: 0 6px 6px 0;" &
            "display: flex; justify-content: space-between;" &
            "align-items: center; }" &
            ".resume-item { text-align: center; }" &
            ".resume-label { font-size: 10px; color: #888;" &
            "text-transform: uppercase; letter-spacing: 1px; }" &
            ".resume-value { font-size: 18px; font-weight: 700;" &
            "color: #0C447C; }" &
            ".decision-admis { background: #059669;" &
            "color: white; padding: 8px 20px;" &
            "border-radius: 20px; font-weight: 600;" &
            "font-size: 13px; }" &
            ".decision-ajourn { background: #DC2626;" &
            "color: white; padding: 8px 20px;" &
            "border-radius: 20px; font-weight: 600;" &
            "font-size: 13px; }" &
            ".footer { border-top: 1px solid #E6F1FB;" &
            "padding: 14px 16px;" &
            "display: flex; justify-content: space-between;" &
            "font-size: 11px; color: #888; }" &
            ".signature { text-align: center; }" &
            ".sig-line { border-top: 1px solid #333;" &
            "width: 160px; margin: 30px auto 4px; }" &
            ".page-break { page-break-after: always; }" &
            "@media print { body { background: white; padding: 0; }" &
            ".bulletin { box-shadow: none; } }" &
            "</style>"
    End Function

    '  GÉNÉRATION HTML BULLETIN
    Private Function GenererHTMLBulletin() As String
        Dim classe = cmbClasseImp.SelectedItem.ToString()
        Dim annee = txtAnneeScolaire.Text

        ' Infos institut
        Dim dtParam = ModuleBDD.GetDataTable(
            "SELECT nom_institut, adresse FROM Parametres")
        Dim nomInstitut = If(dtParam.Rows.Count > 0,
            dtParam.Rows(0)("nom_institut").ToString(),
            "INSTITUT")
        Dim adresse = If(dtParam.Rows.Count > 0,
            dtParam.Rows(0)("adresse").ToString(), "")

        ' Étudiants à afficher
        Dim dtEtudiants As DataTable
        If cmbEtudiantImp.SelectedIndex = 0 Then
            dtEtudiants = ModuleBDD.GetDataTable(
                "SELECT * FROM Etudiant " &
                "WHERE code_classe = ? ORDER BY nom_prenom",
                New OleDbParameter("@classe", classe))
        Else
            Dim matricule = cmbEtudiantImp.SelectedItem.
                ToString().Split("—"c)(0).Trim()
            dtEtudiants = ModuleBDD.GetDataTable(
                "SELECT * FROM Etudiant WHERE num_matricule = ?",
                New OleDbParameter("@mat", matricule))
        End If

        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("<!DOCTYPE html><html><head>")
        sb.AppendLine("<meta charset='utf-8'>")
        sb.AppendLine(GetCSS())
        sb.AppendLine("</head><body>")

        Dim nbBulletins = dtEtudiants.Rows.Count

        For idx As Integer = 0 To dtEtudiants.Rows.Count - 1
            Dim etudRow = dtEtudiants.Rows(idx)
            Dim matricule = etudRow("num_matricule").ToString()
            Dim nom = etudRow("nom_prenom").ToString()
            Dim sexe = etudRow("sexe").ToString()
            Dim dateNaiss = "—"
            Try
                dateNaiss = CDate(etudRow(
                    "date_naissance")).ToString("dd/MM/yyyy")
            Catch : End Try
            Dim lieuNaiss = etudRow("lieu_naissance").ToString()

            ' Notes de l'étudiant
            Dim dtNotes = ModuleBDD.GetDataTable(
                "SELECT m.libelle_matiere, m.coefficient, " &
                "n.note_interro, n.note_devoir, " &
                "n.moyenne_matiere " &
                "FROM ([Note] n INNER JOIN Matiere m " &
                "ON n.code_matiere = m.code_matiere) " &
                "WHERE n.num_matricule = ? " &
                "ORDER BY m.libelle_matiere",
                New OleDbParameter("@mat", matricule))

            ' Calcul moyenne générale
            Dim totalPts As Double = 0
            Dim totalCoefs As Integer = 0
            For Each nr As DataRow In dtNotes.Rows
                Dim coef = CInt(nr("coefficient"))
                Dim moy As Double = 0
                Double.TryParse(
                    nr("moyenne_matiere").ToString().
                    Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    moy)
                totalPts += moy * coef
                totalCoefs += coef
            Next
            Dim moyGen As Double = 0
            If totalCoefs > 0 Then
                moyGen = Math.Round(totalPts / totalCoefs, 2)
            End If

            Dim rang = CalculerRang(matricule, classe)
            Dim estAdmis = moyGen >= 10

            ' Construction HTML du bulletin 
            sb.AppendLine("<div class='bulletin" &
                If(idx < nbBulletins - 1,
                   " page-break", "") & "'>")

            ' En-tête institut
            sb.AppendLine("<div class='header'>")
            sb.AppendLine("<h1>" & HtmlEncode(nomInstitut) &
                          "</h1>")
            sb.AppendLine("<p>" & HtmlEncode(adresse) & "</p>")
            sb.AppendLine("</div>")

            ' Titre document
            sb.AppendLine("<div class='doc-title'>" &
                          "BULLETIN DE NOTES</div>")
            sb.AppendLine("<div class='doc-annee'>" &
                          "Année scolaire : " & annee & "</div>")

            ' Infos étudiant
            sb.AppendLine("<div class='info-grid'>")
            sb.AppendLine("<div class='info-item'>" &
                "<span>Matricule :</span>" &
                HtmlEncode(matricule) & "</div>")
            sb.AppendLine("<div class='info-item'>" &
                "<span>Classe :</span>" &
                HtmlEncode(classe) & "</div>")
            sb.AppendLine("<div class='info-item'>" &
                "<span>Nom & Prénom :</span>" &
                HtmlEncode(nom) & "</div>")
            sb.AppendLine("<div class='info-item'>" &
                "<span>Sexe :</span>" &
                HtmlEncode(sexe) & "</div>")
            sb.AppendLine("<div class='info-item'>" &
                "<span>Date de naissance :</span>" &
                dateNaiss & "</div>")
            sb.AppendLine("<div class='info-item'>" &
                "<span>Lieu de naissance :</span>" &
                HtmlEncode(lieuNaiss) & "</div>")
            sb.AppendLine("</div>")

            ' Tableau des notes
            sb.AppendLine("<div class='section'>")
            sb.AppendLine("<table>")
            sb.AppendLine("<thead><tr>" &
                "<th>Matière</th>" &
                "<th>Coef.</th>" &
                "<th>Interrogation</th>" &
                "<th>Devoir</th>" &
                "<th>Moyenne</th>" &
                "<th>Appréciation</th>" &
                "</tr></thead>")
            sb.AppendLine("<tbody>")

            For Each nr As DataRow In dtNotes.Rows
                Dim matiere = nr("libelle_matiere").ToString()
                Dim coef = nr("coefficient").ToString()
                Dim interro As Double = 0
                Dim devoir As Double = 0
                Dim moy As Double = 0
                Double.TryParse(
                    nr("note_interro").ToString().
                    Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    interro)
                Double.TryParse(
                    nr("note_devoir").ToString().
                    Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    devoir)
                Double.TryParse(
                    nr("moyenne_matiere").ToString().
                    Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    moy)

                Dim cssClass = GetMoyCSS(moy)
                Dim appr = GetAppreciation(moy)

                sb.AppendLine("<tr>")
                sb.AppendLine("<td>" & HtmlEncode(matiere) &
                              "</td>")
                sb.AppendLine("<td style='text-align:center'>" &
                              coef & "</td>")
                sb.AppendLine("<td style='text-align:center'>" &
                              interro.ToString("F2") & "</td>")
                sb.AppendLine("<td style='text-align:center'>" &
                              devoir.ToString("F2") & "</td>")
                sb.AppendLine("<td><span class='moy-cell " &
                              cssClass & "'>" &
                              moy.ToString("F2") &
                              "</span></td>")
                sb.AppendLine("<td>" & appr & "</td>")
                sb.AppendLine("</tr>")
            Next

            sb.AppendLine("</tbody></table>")
            sb.AppendLine("</div>")

            ' Résumé
            sb.AppendLine("<div class='resume'>")
            sb.AppendLine("<div class='resume-item'>" &
                "<div class='resume-label'>Moyenne générale</div>" &
                "<div class='resume-value'>" &
                moyGen.ToString("F2") & "/20</div></div>")
            sb.AppendLine("<div class='resume-item'>" &
                "<div class='resume-label'>Rang</div>" &
                "<div class='resume-value'>" &
                rang & "</div></div>")
            sb.AppendLine("<div class='resume-item'>")
            If estAdmis Then
                sb.AppendLine("<span class='decision-admis'>" &
                              "✓ ADMIS(E)</span>")
            Else
                sb.AppendLine("<span class='decision-ajourn'>" &
                              "✗ AJOURNÉ(E)</span>")
            End If
            sb.AppendLine("</div></div>")

            ' Pied de page
            sb.AppendLine("<div class='footer'>")
            sb.AppendLine("<span>Édité le : " &
                DateTime.Now.ToString("dd/MM/yyyy") & "</span>")
            sb.AppendLine("<div class='signature'>" &
                "<div class='sig-line'></div>" &
                "<div>Le Directeur</div></div>")
            sb.AppendLine("</div>")
            sb.AppendLine("</div>") ' fin bulletin
        Next

        sb.AppendLine("</body></html>")
        Return sb.ToString()
    End Function

    '  GÉNÉRATION HTML RELEVÉ COLLECTIF
    Private Function GenererHTMLReleve() As String
        Dim classe = cmbClasseImp.SelectedItem.ToString()
        Dim annee = txtAnneeScolaire.Text

        Dim dtParam = ModuleBDD.GetDataTable(
            "SELECT nom_institut FROM Parametres")
        Dim nomInstitut = If(dtParam.Rows.Count > 0,
            dtParam.Rows(0)("nom_institut").ToString(),
            "INSTITUT")

        ' Récupérer étudiants
        Dim dtEtudiants = ModuleBDD.GetDataTable(
            "SELECT num_matricule, nom_prenom " &
            "FROM Etudiant WHERE code_classe = ?",
            New OleDbParameter("@classe", classe))

        ' Calculer moyennes générales
        Dim liste As New List(Of (String, String, Double))
        For Each row As DataRow In dtEtudiants.Rows
            Dim mat = row("num_matricule").ToString()
            Dim nom = row("nom_prenom").ToString()
            Dim dtN = ModuleBDD.GetDataTable(
                "SELECT n.moyenne_matiere, m.coefficient " &
                "FROM ([Note] n INNER JOIN Matiere m " &
                "ON n.code_matiere = m.code_matiere) " &
                "WHERE n.num_matricule = ? AND m.code_classe = ?",
                New OleDbParameter("@mat", mat),
                New OleDbParameter("@classe", classe))

            Dim pts As Double = 0
            Dim coefs As Integer = 0
            For Each nr As DataRow In dtN.Rows
                Dim c = CInt(nr("coefficient"))
                Dim m As Double = 0
                Double.TryParse(
                    nr("moyenne_matiere").ToString().
                    Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    m)
                pts += m * c : coefs += c
            Next
            Dim mg As Double = If(coefs > 0,
                Math.Round(pts / coefs, 2), 0)
            liste.Add((mat, nom, mg))
        Next

        ' Trier par mérite
        Dim trie = liste.OrderByDescending(Function(x) x.Item3).ToList()

        ' Correction des erreurs .Count soulignées en rouge
        Dim nbAdmis = trie.Where(Function(x) x.Item3 >= 10).Count()
        Dim nbAj = trie.Where(Function(x) x.Item3 < 10).Count()

        Dim moyC As Double = 0
        If trie.Count > 0 Then
            moyC = Math.Round(trie.Average(Function(x) x.Item3), 2)
        End If

        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("<!DOCTYPE html><html><head>")
        sb.AppendLine("<meta charset='utf-8'>")
        sb.AppendLine(GetCSS())
        sb.AppendLine("</head><body>")
        sb.AppendLine("<div class='bulletin'>")

        ' En-tête
        sb.AppendLine("<div class='header'>")
        sb.AppendLine("<h1>" & HtmlEncode(nomInstitut) & "</h1>")
        sb.AppendLine("</div>")
        sb.AppendLine("<div class='doc-title'>" &
                      "RELEVÉ DE NOTES — PAR ORDRE DE MÉRITE</div>")
        sb.AppendLine("<div class='doc-annee'>Classe : " &
                      classe & " &nbsp;|&nbsp; Année : " &
                      annee & "</div>")

        ' Tableau
        sb.AppendLine("<div class='section'>")
        sb.AppendLine("<table><thead><tr>" &
            "<th>Rang</th><th>Matricule</th>" &
            "<th>Nom & Prénom</th>" &
            "<th>Moy. Générale</th>" &
            "<th>Décision</th>" &
            "</tr></thead><tbody>")

        Dim rang As Integer = 1
        For Each etud In trie
            Dim cssM = GetMoyCSS(etud.Item3)
            Dim dec = If(etud.Item3 >= 10,
                "<span class='decision-admis' " &
                "style='padding:3px 10px;font-size:11px'>" &
                "ADMIS</span>",
                "<span class='decision-ajourn' " &
                "style='padding:3px 10px;font-size:11px'>" &
                "AJOURNÉ</span>")
            sb.AppendLine("<tr>")
            sb.AppendLine("<td style='text-align:center;" &
                "font-weight:700;color:#185FA5'>" &
                rang & GetSuffixeRang(rang) & "</td>")
            sb.AppendLine("<td>" & etud.Item1 & "</td>")
            sb.AppendLine("<td><b>" &
                HtmlEncode(etud.Item2) & "</b></td>")
            sb.AppendLine("<td style='text-align:center'>" &
                "<span class='moy-cell " & cssM & "'>" &
                etud.Item3.ToString("F2") & "</span></td>")
            sb.AppendLine("<td>" & dec & "</td>")
            sb.AppendLine("</tr>")
            rang += 1
        Next

        sb.AppendLine("</tbody></table></div>")

        ' Stats globales
        sb.AppendLine("<div class='resume'>")
        sb.AppendLine("<div class='resume-item'>" &
            "<div class='resume-label'>Effectif</div>" &
            "<div class='resume-value'>" &
            trie.Count & "</div></div>")
        sb.AppendLine("<div class='resume-item'>" &
            "<div class='resume-label'>Admis</div>" &
            "<div class='resume-value' " &
            "style='color:#059669'>" &
            nbAdmis & "</div></div>")
        sb.AppendLine("<div class='resume-item'>" &
            "<div class='resume-label'>Ajournés</div>" &
            "<div class='resume-value' " &
            "style='color:#DC2626'>" &
            nbAj & "</div></div>")
        sb.AppendLine("<div class='resume-item'>" &
            "<div class='resume-label'>Moy. classe</div>" &
            "<div class='resume-value'>" &
            moyC.ToString("F2") & "</div></div>")
        sb.AppendLine("<div class='resume-item'>" &
            "<div class='resume-label'>Taux réussite</div>" &
            "<div class='resume-value'>" &
            If(trie.Count > 0,
               Math.Round(nbAdmis * 100.0 /
               trie.Count, 0) & "%", "—") &
            "</div></div>")
        sb.AppendLine("</div>")

        ' Pied de page
        sb.AppendLine("<div class='footer'>")
        sb.AppendLine("<span>Édité le : " &
            DateTime.Now.ToString("dd/MM/yyyy HH:mm") &
            "</span>")
        sb.AppendLine("<div class='signature'>" &
            "<div class='sig-line'></div>" &
            "<div>Le Directeur</div></div>")
        sb.AppendLine("</div>")
        sb.AppendLine("</div></body></html>")

        Return sb.ToString()
    End Function

    '  FONCTIONS UTILITAIRES
    Private Function GetMoyCSS(moy As Double) As String
        If moy >= 16 Then Return "moy-tb"
        If moy >= 14 Then Return "moy-b"
        If moy >= 12 Then Return "moy-ab"
        If moy >= 10 Then Return "moy-p"
        Return "moy-i"
    End Function

    Private Function GetAppreciation(moy As Double) As String
        If moy >= 16 Then Return "Très Bien"
        If moy >= 14 Then Return "Bien"
        If moy >= 12 Then Return "Assez Bien"
        If moy >= 10 Then Return "Passable"
        If moy >= 7 Then Return "Insuffisant"
        Return "Très Insuffisant"
    End Function

    Private Function GetSuffixeRang(rang As Integer) As String
        Return If(rang = 1, "er", "ème")
    End Function

    Private Function CalculerRang(matricule As String,
        classe As String) As String
        Dim dtTous = ModuleBDD.GetDataTable(
            "SELECT e.num_matricule, " &
            "SUM(n.moyenne_matiere * m.coefficient) / " &
            "SUM(m.coefficient) AS moy_gen " &
            "FROM (Etudiant e INNER JOIN [Note] n " &
            "ON e.num_matricule = n.num_matricule) " &
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

    Private Function HtmlEncode(texte As String) As String
        If String.IsNullOrEmpty(texte) Then Return ""
        Return texte.Replace("&", "&amp;").
                     Replace("<", "&lt;").
                     Replace(">", "&gt;").
                     Replace("'", "&#39;")
    End Function

    ' Impression 
    Private Sub btnImprimer_Click(sender As Object,
        e As EventArgs) Handles btnImprimer.Click
        If wbApercu.Document IsNot Nothing Then
            wbApercu.ShowPrintDialog()
        Else
            MsgBox("Générez d'abord un aperçu.",
                   MsgBoxStyle.Exclamation, "Aperçu requis")
        End If
    End Sub

    ' Export HTML 
    Private Sub btnExporterPDF_Click(sender As Object,
    e As EventArgs) Handles btnExporterPDF.Click

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Fichier PDF (*.pdf)|*.pdf"
        sfd.FileName = If(cmbTypeDoc.SelectedIndex = 0,
        "Bulletin_" & DateTime.Now.ToString("yyyyMMdd"),
        "Releve_" & DateTime.Now.ToString("yyyyMMdd"))

        If sfd.ShowDialog() <> DialogResult.OK Then Exit Sub

        Try
            ' 1. Générer et sauvegarder le HTML temp
            Dim html = If(cmbTypeDoc.SelectedIndex = 0,
            GenererHTMLBulletin(), GenererHTMLReleve())

            Dim tempHtml = IO.Path.Combine(
            IO.Path.GetTempPath(), "bulletin_temp.html")

            IO.File.WriteAllText(tempHtml, html,
            System.Text.Encoding.UTF8)

            ' 2. Chercher Edge dans plusieurs emplacements possibles
            Dim edgePaths() As String = {
            "C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe",
            "C:\Program Files\Microsoft\Edge\Application\msedge.exe",
            IO.Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ProgramFilesX86),
                "Microsoft\Edge\Application\msedge.exe"),
            IO.Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ProgramFiles),
                "Microsoft\Edge\Application\msedge.exe")
        }

            Dim edgePath As String = ""
            For Each p In edgePaths
                If IO.File.Exists(p) Then
                    edgePath = p
                    Exit For
                End If
            Next

            ' 3. Si Edge introuvable, chercher Chrome
            If edgePath = "" Then
                Dim chromePaths() As String = {
                "C:\Program Files\Google\Chrome\Application\chrome.exe",
                "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
            }
                For Each p In chromePaths
                    If IO.File.Exists(p) Then
                        edgePath = p
                        Exit For
                    End If
                Next
            End If

            If edgePath = "" Then
                MsgBox("Edge et Chrome introuvables." & vbCrLf &
                   "Le fichier HTML a été sauvegardé ici :" &
                   vbCrLf & tempHtml & vbCrLf & vbCrLf &
                   "Ouvrez-le manuellement dans un navigateur" &
                   vbCrLf & "et faites Ctrl+P → Enregistrer en PDF.",
                   MsgBoxStyle.Information, "Navigateur requis")
                Exit Sub
            End If

            ' 4. Utiliser un profil temporaire pour éviter les conflits
            Dim tempProfile = IO.Path.Combine(
            IO.Path.GetTempPath(), "edge_pdf_profile")

            Dim pdfOutput = sfd.FileName

            Dim args = "--headless=new " &
           "--disable-gpu " &
           "--no-sandbox " &
           "--disable-extensions " &
           $"--user-data-dir=""{tempProfile}"" " &
           $"--print-to-pdf=""{pdfOutput}"" " &
           "--print-to-pdf-no-header " &
           "--no-pdf-header-footer " &
           "--run-all-compositor-stages-before-draw " &
           $"""file:///{tempHtml.Replace("\", "/")}"""

            Dim psi As New ProcessStartInfo() With {
            .FileName = edgePath,
            .Arguments = args,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }

            Dim proc = Process.Start(psi)
            proc.WaitForExit(5000)

            ' 5. Vérifier si le PDF a bien été créé
            If IO.File.Exists(pdfOutput) AndAlso
           New IO.FileInfo(pdfOutput).Length > 0 Then

                ' Nettoyage
                Try
                    IO.File.Delete(tempHtml)
                    IO.Directory.Delete(tempProfile, True)
                Catch : End Try

                MsgBox("✅ PDF exporté avec succès !" &
                   vbCrLf & pdfOutput,
                   MsgBoxStyle.Information, "Export réussi")

                Process.Start(New ProcessStartInfo(pdfOutput) With {
                .UseShellExecute = True
            })
            Else
                ' Plan B : ouvrir dans le navigateur pour impression manuelle
                MsgBox("La génération automatique a échoué." &
                   vbCrLf & vbCrLf &
                   "Le document va s'ouvrir dans votre navigateur." &
                   vbCrLf & "Faites Ctrl+P → choisir" &
                   " ""Enregistrer en PDF"".",
                   MsgBoxStyle.Information, "Export manuel")

                Process.Start(New ProcessStartInfo(tempHtml) With {
                .UseShellExecute = True
            })
            End If

        Catch ex As Exception
            MsgBox("Erreur : " & ex.Message,
               MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

End Class