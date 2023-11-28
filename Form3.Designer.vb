<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Suprimer = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColonnePrenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColonneSexe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColonneDateNaissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColonneAnneeInscription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColonneFiliere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Matricule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Modifier.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Modifier.ForeColor = System.Drawing.Color.White
        Me.Modifier.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Modifier.Location = New System.Drawing.Point(326, 442)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(122, 54)
        Me.Modifier.TabIndex = 8
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = False
        '
        'Suprimer
        '
        Me.Suprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Suprimer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Suprimer.ForeColor = System.Drawing.Color.White
        Me.Suprimer.Location = New System.Drawing.Point(582, 442)
        Me.Suprimer.Name = "Suprimer"
        Me.Suprimer.Size = New System.Drawing.Size(122, 54)
        Me.Suprimer.TabIndex = 7
        Me.Suprimer.Text = "Supprimer"
        Me.Suprimer.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ajouter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Ajouter.ForeColor = System.Drawing.Color.White
        Me.Ajouter.Location = New System.Drawing.Point(83, 442)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(122, 54)
        Me.Ajouter.TabIndex = 6
        Me.Ajouter.Text = "Ajouter"
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom, Me.ColonnePrenom, Me.ColonneSexe, Me.ColonneDateNaissance, Me.ColonneAnneeInscription, Me.ColonneFiliere, Me.Matricule})
        Me.DataGridView1.Location = New System.Drawing.Point(53, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(694, 407)
        Me.DataGridView1.TabIndex = 5
        '
        'Nom
        '
        Me.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.Width = 59
        '
        'ColonnePrenom
        '
        Me.ColonnePrenom.HeaderText = "Prenom"
        Me.ColonnePrenom.Name = "ColonnePrenom"
        '
        'ColonneSexe
        '
        Me.ColonneSexe.HeaderText = "Sexe"
        Me.ColonneSexe.Name = "ColonneSexe"
        '
        'ColonneDateNaissance
        '
        Me.ColonneDateNaissance.HeaderText = "DateNaissance"
        Me.ColonneDateNaissance.Name = "ColonneDateNaissance"
        '
        'ColonneAnneeInscription
        '
        Me.ColonneAnneeInscription.HeaderText = "Année Scolaire"
        Me.ColonneAnneeInscription.Name = "ColonneAnneeInscription"
        '
        'ColonneFiliere
        '
        Me.ColonneFiliere.HeaderText = "Filière"
        Me.ColonneFiliere.Name = "ColonneFiliere"
        '
        'Matricule
        '
        Me.Matricule.HeaderText = "Matricule"
        Me.Matricule.Name = "Matricule"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(800, 507)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Suprimer)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Modifier As Button
    Friend WithEvents Suprimer As Button
    Friend WithEvents Ajouter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents ColonnePrenom As DataGridViewTextBoxColumn
    Friend WithEvents ColonneSexe As DataGridViewTextBoxColumn
    Friend WithEvents ColonneDateNaissance As DataGridViewTextBoxColumn
    Friend WithEvents ColonneAnneeInscription As DataGridViewTextBoxColumn
    Friend WithEvents ColonneFiliere As DataGridViewTextBoxColumn
    Friend WithEvents Matricule As DataGridViewTextBoxColumn
End Class
