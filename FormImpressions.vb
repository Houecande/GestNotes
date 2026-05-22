Imports System.Data.OleDb
Imports System.Diagnostics

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

        wbApercu.DocumentText = PageAccueil()
    End Sub

    Private Function PageAccueil() As String
        Return "<!DOCTYPE html><html><head>" &
               "<style>" &
               "body{font-family:Segoe UI,sans-serif;" &
               "display:flex;align-items:center;" &
               "justify-content:center;height:90vh;" &
               "background:#F0F4F8;margin:0;}" &
               ".msg{text-align:center;}" &
               ".msg h2{color:#185FA5;font-size:22px;}" &
               ".msg p{font-size:13px;color:#888780;}" &
               ".icon{font-size:48px;margin-bottom:10px;}" &
               "</style></head><body>" &
               "<div class='msg'>" &
               "<div class='icon'>&#128424;</div>" &
               "<h2>Impressions</h2>" &
               "<p>Sélectionnez une classe puis " &
               "cliquez sur Aperçu</p>" &
               "</div></body></html>"
    End Function

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
            "tbody td { padding: 9px 12px;" &
            "border-bottom: 1px solid #EEF2F7; }" &
            ".moy-cell { font-weight: 700; border-radius: 4px;" &
            "padding: 3px 8px; display: inline-block; }" &
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
            ".sig-line { border-top: 1px solid #333;" &
            "width: 160px; margin: 30px auto 4px; }" &
            ".page-break { page-break-after: always; }" &
            "@media print {" &
            "@page { margin: 1cm; size: A4; }" &
            "body { background: white !important; padding: 0; }" &
            ".bulletin { box-shadow: none !important; }" &
            ".header { background: #0C447C !important;" &
            "-webkit-print-color-adjust: exact !important;" &
            "print-color-adjust: exact !important; }" &
            ".doc-title { background: #185FA5 !important;" &
            "-webkit-print-color-adjust: exact !important;" &
            "print-color-adjust: exact !important; }" &
            ".doc-annee { background: #E6F1FB !important;" &
            "-webkit-print-color-adjust: exact !important;" &
            "print-color-adjust: exact !important; }" &
            ".moy-tb,.moy-b,.moy-ab,.moy-p,.moy-i {" &
            "-webkit-print-color-adjust: exact !important;" &
            "print-color-adjust: exact !important; }" &
            ".decision-admis,.decision-ajourn {" &
            "-webkit-print-color-adjust: exact !important;" &
            "print-color-adjust: exact !important; }" &
            ".resume { background: #E6F1FB !important;" &
            "-webkit-print-color-adjust: exact !important;" &
            "print-color-adjust: exact !important; }" &
            "thead tr { background: #185FA5 !important;" &
            "-webkit-print-color-adjust: exact !important;" &
            "print-color-adjust: exact !important; }" &
            "}" &
            "</style>"
    End Function

    Private Function GenererHTMLBulletin() As String
        Dim classe = cmbClasseImp.SelectedItem.ToString()
        Dim annee = txtAnneeScolaire.Text

        Dim dtParam = ModuleBDD.GetDataTable(
            "SELECT nom_institut, adresse FROM Parametres")
        Dim nomInstitut = If(dtParam.Rows.Count > 0,
            dtParam.Rows(0)("nom_institut").ToString(), "INSTITUT")
        Dim adresse = If(dtParam.Rows.Count > 0,
            dtParam.Rows(0)("adresse").ToString(), "")

        Dim dtEtudiants As DataTable
        If cmbEtudiantImp.SelectedIndex = 0 Then
            dtEtudiants = ModuleBDD.GetDataTable(
                "SELECT * FROM Etudiant " &
                "WHERE code_classe = ? ORDER BY nom_prenom",
                New OleDbParameter("@classe", classe))
        Else
            Dim mat = cmbEtudiantImp.SelectedItem.
                ToString().Split("—"c)(0).Trim()
            dtEtudiants = ModuleBDD.GetDataTable(
                "SELECT * FROM Etudiant WHERE num_matricule = ?",
                New OleDbParameter("@mat", mat))
        End If

        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("<!DOCTYPE html><html><head>")
        sb.AppendLine("<meta charset='utf-8'>")
        sb.AppendLine(GetCSS())
        sb.AppendLine("</head><body>")

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

            Dim dtNotes = ModuleBDD.GetDataTable(
                "SELECT m.libelle_matiere, m.coefficient, " &
                "n.note_interro, n.note_devoir, n.moyenne_matiere " &
                "FROM ([Note] n INNER JOIN Matiere m " &
                "ON n.code_matiere = m.code_matiere) " &
                "WHERE n.num_matricule = ? " &
                "ORDER BY m.libelle_matiere",
                New OleDbParameter("@mat", matricule))

            Dim totalPts As Double = 0
            Dim totalCoefs As Integer = 0
            For Each nr As DataRow In dtNotes.Rows
                Dim coef = CInt(nr("coefficient"))
                Dim moy As Double = 0
                Double.TryParse(
                    nr("moyenne_matiere").ToString().Replace(",", "."),
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
            Dim isLast = (idx = dtEtudiants.Rows.Count - 1)

            sb.AppendLine("<div class='bulletin" &
                If(Not isLast, " page-break", "") & "'>")
            sb.AppendLine("<div class='header'>")
            sb.AppendLine("<h1>" & HtmlEncode(nomInstitut) & "</h1>")
            sb.AppendLine("<p>" & HtmlEncode(adresse) & "</p>")
            sb.AppendLine("</div>")
            sb.AppendLine("<div class='doc-title'>BULLETIN DE NOTES</div>")
            sb.AppendLine("<div class='doc-annee'>Année scolaire : " &
                          annee & "</div>")
            sb.AppendLine("<div class='info-grid'>")
            sb.AppendLine("<div class='info-item'><span>Matricule :</span>" &
                HtmlEncode(matricule) & "</div>")
            sb.AppendLine("<div class='info-item'><span>Classe :</span>" &
                HtmlEncode(classe) & "</div>")
            sb.AppendLine("<div class='info-item'>" &
                "<span>Nom &amp; Prénom :</span>" &
                HtmlEncode(nom) & "</div>")
            sb.AppendLine("<div class='info-item'><span>Sexe :</span>" &
                HtmlEncode(sexe) & "</div>")
            sb.AppendLine("<div class='info-item'>" &
                "<span>Date de naissance :</span>" &
                dateNaiss & "</div>")
            sb.AppendLine("<div class='info-item'>" &
                "<span>Lieu de naissance :</span>" &
                HtmlEncode(lieuNaiss) & "</div>")
            sb.AppendLine("</div>")

            sb.AppendLine("<div class='section'>")
            sb.AppendLine("<table><thead><tr>" &
                "<th>Matière</th><th>Coef.</th>" &
                "<th>Interrogation</th><th>Devoir</th>" &
                "<th>Moyenne</th><th>Appréciation</th>" &
                "</tr></thead><tbody>")

            For Each nr As DataRow In dtNotes.Rows
                Dim matiere = nr("libelle_matiere").ToString()
                Dim coef = nr("coefficient").ToString()
                Dim interro As Double = 0
                Dim devoir As Double = 0
                Dim moy As Double = 0
                Double.TryParse(
                    nr("note_interro").ToString().Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    interro)
                Double.TryParse(
                    nr("note_devoir").ToString().Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    devoir)
                Double.TryParse(
                    nr("moyenne_matiere").ToString().Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    moy)
                sb.AppendLine("<tr>")
                sb.AppendLine("<td>" & HtmlEncode(matiere) & "</td>")
                sb.AppendLine("<td style='text-align:center'>" &
                    coef & "</td>")
                sb.AppendLine("<td style='text-align:center'>" &
                    interro.ToString("F2") & "</td>")
                sb.AppendLine("<td style='text-align:center'>" &
                    devoir.ToString("F2") & "</td>")
                sb.AppendLine("<td style='text-align:center'>" &
                    "<span class='moy-cell " & GetMoyCSS(moy) &
                    "'>" & moy.ToString("F2") & "</span></td>")
                sb.AppendLine("<td>" & GetAppreciation(moy) & "</td>")
                sb.AppendLine("</tr>")
            Next

            sb.AppendLine("</tbody></table></div>")
            sb.AppendLine("<div class='resume'>")
            sb.AppendLine("<div class='resume-item'>" &
                "<div class='resume-label'>Moyenne générale</div>" &
                "<div class='resume-value'>" &
                moyGen.ToString("F2") & "/20</div></div>")
            sb.AppendLine("<div class='resume-item'>" &
                "<div class='resume-label'>Rang</div>" &
                "<div class='resume-value'>" & rang & "</div></div>")
            sb.AppendLine("<div class='resume-item'>")
            If estAdmis Then
                sb.AppendLine("<span class='decision-admis'>" &
                              "&#10003; ADMIS(E)</span>")
            Else
                sb.AppendLine("<span class='decision-ajourn'>" &
                              "&#10007; AJOURNÉ(E)</span>")
            End If
            sb.AppendLine("</div></div>")
            sb.AppendLine("<div class='footer'>")
            sb.AppendLine("<span>Édité le : " &
                DateTime.Now.ToString("dd/MM/yyyy") & "</span>")
            sb.AppendLine("<div style='text-align:center'>" &
                "<div class='sig-line'></div>" &
                "<div>Le Directeur</div></div>")
            sb.AppendLine("</div></div>")
        Next

        sb.AppendLine("</body></html>")
        Return sb.ToString()
    End Function

    Private Function GenererHTMLReleve() As String
        Dim classe = cmbClasseImp.SelectedItem.ToString()
        Dim annee = txtAnneeScolaire.Text

        Dim dtParam = ModuleBDD.GetDataTable(
            "SELECT nom_institut FROM Parametres")
        Dim nomInstitut = If(dtParam.Rows.Count > 0,
            dtParam.Rows(0)("nom_institut").ToString(), "INSTITUT")

        Dim dtEtudiants = ModuleBDD.GetDataTable(
            "SELECT num_matricule, nom_prenom " &
            "FROM Etudiant WHERE code_classe = ?",
            New OleDbParameter("@classe", classe))

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
                    nr("moyenne_matiere").ToString().Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    m)
                pts += m * c : coefs += c
            Next
            Dim mg As Double = If(coefs > 0,
                Math.Round(pts / coefs, 2), 0)
            liste.Add((mat, nom, mg))
        Next

        Dim trie = liste.OrderByDescending(
            Function(x) x.Item3).ToList()
        Dim nbAdmis = trie.Where(
            Function(x) x.Item3 >= 10).Count()
        Dim nbAj = trie.Where(
            Function(x) x.Item3 < 10).Count()
        Dim moyC As Double = If(trie.Count > 0,
            Math.Round(trie.Average(Function(x) x.Item3), 2), 0)

        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("<!DOCTYPE html><html><head>")
        sb.AppendLine("<meta charset='utf-8'>")
        sb.AppendLine(GetCSS())
        sb.AppendLine("</head><body><div class='bulletin'>")
        sb.AppendLine("<div class='header'>")
        sb.AppendLine("<h1>" & HtmlEncode(nomInstitut) & "</h1>")
        sb.AppendLine("</div>")
        sb.AppendLine("<div class='doc-title'>" &
            "RELEVÉ DE NOTES — PAR ORDRE DE MÉRITE</div>")
        sb.AppendLine("<div class='doc-annee'>Classe : " &
            classe & " &nbsp;|&nbsp; Année : " & annee & "</div>")
        sb.AppendLine("<div class='section'>")
        sb.AppendLine("<table><thead><tr>" &
            "<th>Rang</th><th>Matricule</th>" &
            "<th>Nom &amp; Prénom</th>" &
            "<th>Moy. Générale</th>" &
            "<th>Décision</th>" &
            "</tr></thead><tbody>")

        Dim rang As Integer = 1
        For Each etud In trie
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
            sb.AppendLine("<td>" & HtmlEncode(etud.Item1) & "</td>")
            sb.AppendLine("<td><b>" &
                HtmlEncode(etud.Item2) & "</b></td>")
            sb.AppendLine("<td style='text-align:center'>" &
                "<span class='moy-cell " &
                GetMoyCSS(etud.Item3) & "'>" &
                etud.Item3.ToString("F2") & "</span></td>")
            sb.AppendLine("<td>" & dec & "</td>")
            sb.AppendLine("</tr>")
            rang += 1
        Next

        sb.AppendLine("</tbody></table></div>")
        sb.AppendLine("<div class='resume'>")
        sb.AppendLine("<div class='resume-item'>" &
            "<div class='resume-label'>Effectif</div>" &
            "<div class='resume-value'>" &
            trie.Count & "</div></div>")
        sb.AppendLine("<div class='resume-item'>" &
            "<div class='resume-label'>Admis</div>" &
            "<div class='resume-value' style='color:#059669'>" &
            nbAdmis & "</div></div>")
        sb.AppendLine("<div class='resume-item'>" &
            "<div class='resume-label'>Ajournés</div>" &
            "<div class='resume-value' style='color:#DC2626'>" &
            nbAj & "</div></div>")
        sb.AppendLine("<div class='resume-item'>" &
            "<div class='resume-label'>Moy. classe</div>" &
            "<div class='resume-value'>" &
            moyC.ToString("F2") & "</div></div>")
        sb.AppendLine("<div class='resume-item'>" &
            "<div class='resume-label'>Taux réussite</div>" &
            "<div class='resume-value'>" &
            If(trie.Count > 0,
               Math.Round(nbAdmis * 100.0 / trie.Count, 0) & "%",
               "—") & "</div></div>")
        sb.AppendLine("</div>")
        sb.AppendLine("<div class='footer'>")
        sb.AppendLine("<span>Édité le : " &
            DateTime.Now.ToString("dd/MM/yyyy HH:mm") & "</span>")
        sb.AppendLine("<div style='text-align:center'>" &
            "<div class='sig-line'></div>" &
            "<div>Le Directeur</div></div>")
        sb.AppendLine("</div></div></body></html>")
        Return sb.ToString()
    End Function

    ' ── Enregistrer dans BDD ──────────────────────────────────
    Private Sub EnregistrerEdition()
        Try
            Dim classe = cmbClasseImp.SelectedItem.ToString()
            Dim annee = txtAnneeScolaire.Text

            If cmbTypeDoc.SelectedIndex = 0 Then
                Dim dtEtudiants As DataTable
                If cmbEtudiantImp.SelectedIndex = 0 Then
                    dtEtudiants = ModuleBDD.GetDataTable(
                        "SELECT num_matricule FROM Etudiant " &
                        "WHERE code_classe = ?",
                        New OleDbParameter("@classe", classe))
                Else
                    Dim mat = cmbEtudiantImp.SelectedItem.
                        ToString().Split("—"c)(0).Trim()
                    dtEtudiants = ModuleBDD.GetDataTable(
                        "SELECT num_matricule FROM Etudiant " &
                        "WHERE num_matricule = ?",
                        New OleDbParameter("@mat", mat))
                End If

                For Each row As DataRow In dtEtudiants.Rows
                    Dim matricule = row("num_matricule").ToString()

                    Dim dtN = ModuleBDD.GetDataTable(
                        "SELECT n.moyenne_matiere, m.coefficient " &
                        "FROM ([Note] n INNER JOIN Matiere m " &
                        "ON n.code_matiere = m.code_matiere) " &
                        "WHERE n.num_matricule = ? " &
                        "AND m.code_classe = ?",
                        New OleDbParameter("@mat", matricule),
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
                    Dim moyGen As Double = If(coefs > 0,
                        Math.Round(pts / coefs, 2), 0)

                    Dim existe = CInt(ModuleBDD.GetValeur(
                        "SELECT COUNT(*) FROM Bulletin " &
                        "WHERE num_matricule = ? " &
                        "AND annee_scolaire = ?",
                        New OleDbParameter("@mat", matricule),
                        New OleDbParameter("@annee", annee)))

                    If existe > 0 Then
                        ModuleBDD.ExecuterRequete(
                            "UPDATE Bulletin SET " &
                            "moyenne = ?, date_edition = ? " &
                            "WHERE num_matricule = ? " &
                            "AND annee_scolaire = ?",
                            New OleDbParameter("@moy", moyGen),
                            New OleDbParameter("@date", DateTime.Now),
                            New OleDbParameter("@mat", matricule),
                            New OleDbParameter("@annee", annee))
                    Else
                        ModuleBDD.ExecuterRequete(
                            "INSERT INTO Bulletin " &
                            "(num_matricule, periode, " &
                            "annee_scolaire, moyenne, date_edition) " &
                            "VALUES (?, ?, ?, ?, ?)",
                            New OleDbParameter("@mat", matricule),
                            New OleDbParameter("@periode", "Annuel"),
                            New OleDbParameter("@annee", annee),
                            New OleDbParameter("@moy", moyGen),
                            New OleDbParameter("@date", DateTime.Now))
                    End If
                Next

            Else
                Dim existe = CInt(ModuleBDD.GetValeur(
                    "SELECT COUNT(*) FROM Releve " &
                    "WHERE code_classe = ? AND annee_scolaire = ?",
                    New OleDbParameter("@classe", classe),
                    New OleDbParameter("@annee", annee)))

                If existe > 0 Then
                    ModuleBDD.ExecuterRequete(
                        "UPDATE Releve SET date_edition = ? " &
                        "WHERE code_classe = ? AND annee_scolaire = ?",
                        New OleDbParameter("@date", DateTime.Now),
                        New OleDbParameter("@classe", classe),
                        New OleDbParameter("@annee", annee))
                Else
                    ModuleBDD.ExecuterRequete(
                        "INSERT INTO Releve " &
                        "(code_classe, annee_scolaire, date_edition) " &
                        "VALUES (?, ?, ?)",
                        New OleDbParameter("@classe", classe),
                        New OleDbParameter("@annee", annee),
                        New OleDbParameter("@date", DateTime.Now))
                End If
            End If

        Catch : End Try
    End Sub

    ' ── Fonctions utilitaires ─────────────────────────────────
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
        Try
            Dim dtEtuds = ModuleBDD.GetDataTable(
                "SELECT num_matricule FROM Etudiant " &
                "WHERE code_classe = ?",
                New OleDbParameter("@classe", classe))

            Dim moyennes As New List(Of (String, Double))
            For Each row As DataRow In dtEtuds.Rows
                Dim mat = row("num_matricule").ToString()
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
                        nr("moyenne_matiere").ToString().Replace(",", "."),
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture,
                        m)
                    pts += m * c : coefs += c
                Next
                Dim mg As Double = If(coefs > 0,
                    Math.Round(pts / coefs, 2), 0)
                moyennes.Add((mat, mg))
            Next

            Dim trie = moyennes.OrderByDescending(
                Function(x) x.Item2).ToList()

            Dim rang As Integer = 1
            For Each item In trie
                If item.Item1 = matricule Then
                    Return rang & GetSuffixeRang(rang) &
                           " / " & trie.Count
                End If
                rang += 1
            Next
            Return "— / " & trie.Count
        Catch
            Return "—"
        End Try
    End Function

    Private Function HtmlEncode(texte As String) As String
        If String.IsNullOrEmpty(texte) Then Return ""
        Return texte.Replace("&", "&amp;").
                     Replace("<", "&lt;").
                     Replace(">", "&gt;").
                     Replace("'", "&#39;")
    End Function

    Private Function TrouverNavigateur() As String
        Dim chemins() As String = {
            IO.Path.Combine(
                Environment.GetFolderPath(
                Environment.SpecialFolder.ProgramFilesX86),
                "Microsoft\Edge\Application\msedge.exe"),
            IO.Path.Combine(
                Environment.GetFolderPath(
                Environment.SpecialFolder.ProgramFiles),
                "Microsoft\Edge\Application\msedge.exe"),
            "C:\Program Files (x86)\Microsoft\Edge\" &
                "Application\msedge.exe",
            "C:\Program Files\Microsoft\Edge\" &
                "Application\msedge.exe",
            IO.Path.Combine(
                Environment.GetFolderPath(
                Environment.SpecialFolder.ProgramFiles),
                "Google\Chrome\Application\chrome.exe"),
            IO.Path.Combine(
                Environment.GetFolderPath(
                Environment.SpecialFolder.ProgramFilesX86),
                "Google\Chrome\Application\chrome.exe"),
            "C:\Program Files\Google\Chrome\" &
                "Application\chrome.exe",
            "C:\Program Files (x86)\Google\Chrome\" &
                "Application\chrome.exe"
        }
        For Each chemin In chemins
            If IO.File.Exists(chemin) Then Return chemin
        Next
        Return ""
    End Function

    ' ── Impression ────────────────────────────────────────────
    Private Sub btnImprimer_Click(sender As Object,
        e As EventArgs) Handles btnImprimer.Click

        If wbApercu.Document Is Nothing OrElse
           String.IsNullOrEmpty(wbApercu.DocumentText) OrElse
           wbApercu.DocumentText.Length < 100 Then
            MsgBox("Générez d'abord un aperçu.",
                   MsgBoxStyle.Exclamation, "Aperçu requis")
            Exit Sub
        End If

        EnregistrerEdition()

        Try
            Dim html = If(cmbTypeDoc.SelectedIndex = 0,
                GenererHTMLBulletin(), GenererHTMLReleve())

            Dim tempHtml = IO.Path.Combine(
                IO.Path.GetTempPath(), "gn_print_temp.html")
            IO.File.WriteAllText(tempHtml, html,
                System.Text.Encoding.UTF8)

            Process.Start(New ProcessStartInfo(tempHtml) With {
                .UseShellExecute = True})

            MsgBox("Le document s'est ouvert dans " &
                   "votre navigateur." & vbCrLf & vbCrLf &
                   "Pour imprimer avec les couleurs :" &
                   vbCrLf & "1. Faites Ctrl+P" & vbCrLf &
                   "2. Cliquez ""Plus de paramètres""" &
                   vbCrLf &
                   "3. Activez ""Graphiques d'arrière-plan""" &
                   vbCrLf & "4. Cliquez Imprimer",
                   MsgBoxStyle.Information,
                   "Instructions d'impression")
        Catch ex As Exception
            MsgBox("Erreur impression : " & ex.Message,
                   MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

    ' ── Export PDF ────────────────────────────────────────────
    Private Sub btnExporterPDF_Click(sender As Object,
        e As EventArgs) Handles btnExporterPDF.Click

        If cmbClasseImp.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner une classe.",
                   MsgBoxStyle.Exclamation, "Classe requise")
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Fichier PDF (*.pdf)|*.pdf"
        sfd.FileName = If(cmbTypeDoc.SelectedIndex = 0,
            "Bulletin_" & DateTime.Now.ToString("yyyyMMdd"),
            "Releve_" & DateTime.Now.ToString("yyyyMMdd"))

        If sfd.ShowDialog() <> DialogResult.OK Then Exit Sub

        EnregistrerEdition()

        Try
            Dim html = If(cmbTypeDoc.SelectedIndex = 0,
                GenererHTMLBulletin(), GenererHTMLReleve())

            Dim tempHtml = IO.Path.Combine(
                IO.Path.GetTempPath(), "gn_bulletin_temp.html")
            IO.File.WriteAllText(tempHtml, html,
                System.Text.Encoding.UTF8)

            Dim pdfOutput = sfd.FileName
            Dim browserPath As String = TrouverNavigateur()

            If String.IsNullOrEmpty(browserPath) Then
                MsgBox("Aucun navigateur compatible trouvé." &
                       vbCrLf & vbCrLf &
                       "Le document va s'ouvrir dans votre " &
                       "navigateur par défaut." & vbCrLf &
                       "Faites Ctrl+P → " &
                       """Enregistrer en PDF"".",
                       MsgBoxStyle.Information, "Export manuel")
                Process.Start(New ProcessStartInfo(tempHtml) With {
                    .UseShellExecute = True})
                Exit Sub
            End If

            Dim tempProfile = IO.Path.Combine(
                IO.Path.GetTempPath(), "gn_browser_profile_" &
                Guid.NewGuid().ToString("N").Substring(0, 8))

            Dim urlHtml = "file:///" & tempHtml.Replace("\", "/")

            Dim args = "--headless=new " &
                       "--disable-gpu " &
                       "--no-sandbox " &
                       "--disable-extensions " &
                       "--run-all-compositor-stages-before-draw " &
                       "--disable-dev-shm-usage " &
                       $"--user-data-dir=""{tempProfile}"" " &
                       $"--print-to-pdf=""{pdfOutput}"" " &
                       "--print-to-pdf-no-header " &
                       $"""{urlHtml}"""

            Dim psi As New ProcessStartInfo() With {
                .FileName = browserPath,
                .Arguments = args,
                .UseShellExecute = False,
                .CreateNoWindow = True,
                .RedirectStandardError = True
            }

            Dim lblAttente As New Label() With {
                .Text = "Génération du PDF en cours...",
                .Dock = DockStyle.Bottom,
                .Height = 24,
                .TextAlign = ContentAlignment.MiddleCenter,
                .BackColor = Color.FromArgb(230, 241, 251),
                .ForeColor = Color.FromArgb(12, 68, 124)
            }
            Me.Controls.Add(lblAttente)
            Me.Refresh()

            Dim proc = Process.Start(psi)
            proc.WaitForExit(15000)

            Me.Controls.Remove(lblAttente)
            System.Threading.Thread.Sleep(1000)

            Try
                If IO.Directory.Exists(tempProfile) Then
                    IO.Directory.Delete(tempProfile, True)
                End If
            Catch : End Try

            If IO.File.Exists(pdfOutput) AndAlso
               New IO.FileInfo(pdfOutput).Length > 100 Then

                Try : IO.File.Delete(tempHtml) : Catch : End Try

                Dim rep = MsgBox(
                    "PDF exporté avec succès !" &
                    vbCrLf & vbCrLf & pdfOutput &
                    vbCrLf & vbCrLf &
                    "Voulez-vous ouvrir le PDF ?",
                    MsgBoxStyle.YesNo + MsgBoxStyle.Information,
                    "Export réussi")

                If rep = MsgBoxResult.Yes Then
                    Process.Start(New ProcessStartInfo(
                        pdfOutput) With {
                        .UseShellExecute = True})
                End If
            Else
                MsgBox("La génération automatique a échoué." &
                       vbCrLf & vbCrLf &
                       "Le document va s'ouvrir dans " &
                       "votre navigateur." & vbCrLf &
                       "Faites Ctrl+P → " &
                       """Enregistrer en PDF"".",
                       MsgBoxStyle.Information, "Export manuel")
                Process.Start(New ProcessStartInfo(tempHtml) With {
                    .UseShellExecute = True})
            End If

        Catch ex As Exception
            MsgBox("Erreur lors de l'export :" &
                   vbCrLf & ex.Message,
                   MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

End Class