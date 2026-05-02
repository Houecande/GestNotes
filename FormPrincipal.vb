Public Class FormPrincipal
    Private Sub pnlStatEtudiants_Paint(sender As Object, e As PaintEventArgs) Handles pnlStatEtudiants.Paint

    End Sub

    Private Sub pnlStatBulletins_Paint(sender As Object, e As PaintEventArgs) Handles pnlStatBulletins.Paint

    End Sub

    Private Sub btnMenuEtudiants_Click(sender As Object, e As EventArgs) Handles btnMenuEtudiants.Click
        FormEtudiants.Show()
    End Sub

    Private Sub btnMenuClasses_Click(sender As Object, e As EventArgs) Handles btnMenuClasses.Click
        FormClasses.Show()
    End Sub

    Private Sub btnMenuNotes_Click(sender As Object, e As EventArgs) Handles btnMenuNotes.Click
        FormNotes.Show()
    End Sub

    Private Sub btnMenuImpressions_Click(sender As Object, e As EventArgs) Handles btnMenuImpressions.Click
        FormImpressions.Show()
    End Sub

    Private Sub btnMenuParametres_Click(sender As Object, e As EventArgs) Handles btnMenuParametres.Click
        FormParametres.Show()
    End Sub

    Private Sub btnDeconnexion_Click(sender As Object, e As EventArgs) Handles btnDeconnexion.Click
        FormConnexion.Show()
    End Sub
End Class