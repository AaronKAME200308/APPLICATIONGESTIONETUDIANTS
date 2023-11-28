Public Class Etudiant
    Public NomEtudiant As String
    Public PrenomEtudiant As String
    Public SexeEtudiant As String
    Public DateNaissanceEtudiant As String
    Public AnneeInscription As String
    Public Filiere As String
    Public Niveau As String
    Public Matricule As String



    Public Function CreerMatricule(count As Integer) As String

        Dim derniereAnnee As String
        derniereAnnee = Right(Me.AnneeInscription, 2)

        Dim sexe As String
        sexe = "T"
        If Me.SexeEtudiant = "MASCULIN" Then
            sexe = "M"
        End If
        If Me.SexeEtudiant = "FEMININ" Then
            sexe = "F"
        End If

        CreerMatricule = Me.Filiere & Me.Niveau & "-" & sexe & count & "-" & derniereAnnee
    End Function
End Class
