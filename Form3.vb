Public Class Form3
    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Suprimer_Click(sender As Object, e As EventArgs) Handles Suprimer.Click
        Dim position = DataGridView1.CurrentRow.Index
        DataGridView1.Rows.RemoveAt(position)
    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        Dim NomEtudiant As String = DataGridView1.CurrentRow.Cells(0).Value
        Form2.TextBoxName.Text = NomEtudiant

        Dim PrenomEtudiant As String = DataGridView1.CurrentRow.Cells(1).Value
        Form2.TextBoxLastName.Text = PrenomEtudiant

        Dim SexeEtudiant As String = DataGridView1.CurrentRow.Cells(2).Value
        Form2.GroupBoxSexe.Text = SexeEtudiant

        Dim Filiere As String = DataGridView1.CurrentRow.Cells(5).Value
        Form2.GroupBoxFiliere.Text = Filiere
        Form2.Show()
        Form2.Modifier.Visible = True
        Form2.Enregistrer.Visible = False
        Me.Hide()

    End Sub
End Class