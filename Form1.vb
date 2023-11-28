Imports System.Windows

Public Class Form1
    Private Sub inscription_Click(sender As Object, e As EventArgs) Handles inscription.Click
        Form2.Show()
    End Sub

    Private Sub ListeEtudiant_Click(sender As Object, e As EventArgs) Handles ListeEtudiant.Click
        Form3.Show()
    End Sub
End Class
