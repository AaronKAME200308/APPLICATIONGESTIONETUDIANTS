<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListeEtudiant = New System.Windows.Forms.Button()
        Me.inscription = New System.Windows.Forms.Button()
        Me.Accueil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListeEtudiant
        '
        Me.ListeEtudiant.BackColor = System.Drawing.Color.Blue
        Me.ListeEtudiant.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListeEtudiant.ForeColor = System.Drawing.Color.White
        Me.ListeEtudiant.Location = New System.Drawing.Point(442, 254)
        Me.ListeEtudiant.Name = "ListeEtudiant"
        Me.ListeEtudiant.Size = New System.Drawing.Size(153, 69)
        Me.ListeEtudiant.TabIndex = 5
        Me.ListeEtudiant.Text = "Liste Etudiants"
        Me.ListeEtudiant.UseVisualStyleBackColor = False
        '
        'inscription
        '
        Me.inscription.BackColor = System.Drawing.Color.Blue
        Me.inscription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inscription.ForeColor = System.Drawing.Color.White
        Me.inscription.Location = New System.Drawing.Point(206, 254)
        Me.inscription.Name = "inscription"
        Me.inscription.Size = New System.Drawing.Size(153, 69)
        Me.inscription.TabIndex = 4
        Me.inscription.Text = "S'inscrire"
        Me.inscription.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.Accueil.AutoSize = True
        Me.Accueil.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Accueil.ForeColor = System.Drawing.Color.Blue
        Me.Accueil.Location = New System.Drawing.Point(283, 127)
        Me.Accueil.Name = "Accueil"
        Me.Accueil.Size = New System.Drawing.Size(227, 32)
        Me.Accueil.TabIndex = 3
        Me.Accueil.Text = "BIENVENUE A ISTAG"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListeEtudiant)
        Me.Controls.Add(Me.inscription)
        Me.Controls.Add(Me.Accueil)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListeEtudiant As Button
    Friend WithEvents inscription As Button
    Friend WithEvents Accueil As Label
End Class
