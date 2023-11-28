Public Class Form2
    Dim count As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Enregistrer.Click
        Dim Etudiant As New Etudiant()

        Etudiant.NomEtudiant = TextBoxName.Text
        Etudiant.PrenomEtudiant = TextBoxLastName.Text

        If MASCULIN.Checked Then
            Etudiant.SexeEtudiant = MASCULIN.Text
        End If
        If FEMININ.Checked Then
            Etudiant.SexeEtudiant = FEMININ.Text
        End If

        Etudiant.DateNaissanceEtudiant = DateTimePickerDateNaissance.Text
        Etudiant.AnneeInscription = Year(DateTimePickerAnneeInscription.Value)

        If GLO.Checked Then
            Etudiant.Filiere = GLO.Text
        End If
        If GSI.Checked Then
            Etudiant.Filiere = GSI.Text
        End If
        If AMA.Checked Then
            Etudiant.Filiere = AMA.Text
        End If
        If BF.Checked Then
            Etudiant.Filiere = BF.Text
        End If
        If CG.Checked Then
            Etudiant.Filiere = CG.Text
        End If

        If Niveau1.Checked Then
            Etudiant.Niveau = Niveau1.Text
        End If
        If Niveau2.Checked Then
            Etudiant.Niveau = Niveau2.Text
        End If
        If Niveau3.Checked Then
            Etudiant.Niveau = Niveau3.Text
        End If
        If Niveau4.Checked Then
            Etudiant.Niveau = Niveau4.Text
        End If
        If Niveau5.Checked Then
            Etudiant.Niveau = Niveau5.Text
        End If

        Etudiant.Matricule = Etudiant.CreerMatricule(count)



        Form3.DataGridView1.Rows.Add(Etudiant.NomEtudiant, Etudiant.PrenomEtudiant, Etudiant.SexeEtudiant, Etudiant.DateNaissanceEtudiant, Etudiant.AnneeInscription, Etudiant.Filiere, Etudiant.Matricule)

        MsgBox("Inscription Validé")
        Form3.Show()

        TextBoxName.Clear()
        TextBoxLastName.Clear()

        count += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxName.Clear()
        TextBoxLastName.Clear()

    End Sub


    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        Dim Etudiant As New Etudiant()

        Etudiant.NomEtudiant = TextBoxName.Text
        Etudiant.PrenomEtudiant = TextBoxLastName.Text

        If MASCULIN.Checked Then
            Etudiant.SexeEtudiant = MASCULIN.Text
        End If
        If FEMININ.Checked Then
            Etudiant.SexeEtudiant = FEMININ.Text
        End If

        Etudiant.DateNaissanceEtudiant = DateTimePickerDateNaissance.Text
        Etudiant.AnneeInscription = Year(DateTimePickerAnneeInscription.Value)

        If GLO.Checked Then
            Etudiant.Filiere = GLO.Text
        End If
        If GSI.Checked Then
            Etudiant.Filiere = GSI.Text
        End If
        If AMA.Checked Then
            Etudiant.Filiere = AMA.Text
        End If
        If BF.Checked Then
            Etudiant.Filiere = BF.Text
        End If
        If CG.Checked Then
            Etudiant.Filiere = CG.Text
        End If

        If Niveau1.Checked Then
            Etudiant.Niveau = Niveau1.Text
        End If
        If Niveau2.Checked Then
            Etudiant.Niveau = Niveau2.Text
        End If
        If Niveau3.Checked Then
            Etudiant.Niveau = Niveau3.Text
        End If
        If Niveau4.Checked Then
            Etudiant.Niveau = Niveau4.Text
        End If
        If Niveau5.Checked Then
            Etudiant.Niveau = Niveau5.Text
        End If

        Etudiant.Matricule = Etudiant.CreerMatricule(count)

        Form3.DataGridView1.CurrentRow.Cells(0).Value = Etudiant.NomEtudiant
        Form3.DataGridView1.CurrentRow.Cells(1).Value = Etudiant.PrenomEtudiant
        Form3.DataGridView1.CurrentRow.Cells(2).Value = Etudiant.SexeEtudiant
        Form3.DataGridView1.CurrentRow.Cells(3).Value = Etudiant.DateNaissanceEtudiant
        Form3.DataGridView1.CurrentRow.Cells(4).Value = Etudiant.AnneeInscription
        Form3.DataGridView1.CurrentRow.Cells(5).Value = Etudiant.Filiere
        Form3.DataGridView1.CurrentRow.Cells(6).Value = Etudiant.Matricule

        MsgBox("Modification Validé")
        Form3.Show()

        count += 1
    End Sub
End Class