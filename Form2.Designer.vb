<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Enregistrer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Niveau1 = New System.Windows.Forms.RadioButton()
        Me.Niveau2 = New System.Windows.Forms.RadioButton()
        Me.Niveau3 = New System.Windows.Forms.RadioButton()
        Me.Niveau4 = New System.Windows.Forms.RadioButton()
        Me.Niveau5 = New System.Windows.Forms.RadioButton()
        Me.GroupBoxFiliere = New System.Windows.Forms.GroupBox()
        Me.GLO = New System.Windows.Forms.RadioButton()
        Me.GSI = New System.Windows.Forms.RadioButton()
        Me.BF = New System.Windows.Forms.RadioButton()
        Me.CG = New System.Windows.Forms.RadioButton()
        Me.AMA = New System.Windows.Forms.RadioButton()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.GroupBoxSexe = New System.Windows.Forms.GroupBox()
        Me.FEMININ = New System.Windows.Forms.RadioButton()
        Me.MASCULIN = New System.Windows.Forms.RadioButton()
        Me.DateTimePickerAnneeInscription = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDateNaissance = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxFiliere.SuspendLayout()
        Me.GroupBoxSexe.SuspendLayout()
        Me.SuspendLayout()
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.Color.Blue
        Me.Modifier.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Modifier.ForeColor = System.Drawing.Color.White
        Me.Modifier.Location = New System.Drawing.Point(428, 476)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(139, 47)
        Me.Modifier.TabIndex = 7
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = False
        Me.Modifier.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(612, 476)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 47)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Suprimer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Enregistrer
        '
        Me.Enregistrer.BackColor = System.Drawing.Color.Blue
        Me.Enregistrer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Enregistrer.ForeColor = System.Drawing.Color.White
        Me.Enregistrer.Location = New System.Drawing.Point(428, 476)
        Me.Enregistrer.Name = "Enregistrer"
        Me.Enregistrer.Size = New System.Drawing.Size(139, 47)
        Me.Enregistrer.TabIndex = 5
        Me.Enregistrer.Text = "Enregistrer"
        Me.Enregistrer.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBoxFiliere)
        Me.GroupBox1.Controls.Add(Me.TextBoxLastName)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.GroupBoxSexe)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerAnneeInscription)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerDateNaissance)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(36, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 433)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrez vos informations"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Niveau1)
        Me.GroupBox2.Controls.Add(Me.Niveau2)
        Me.GroupBox2.Controls.Add(Me.Niveau3)
        Me.GroupBox2.Controls.Add(Me.Niveau4)
        Me.GroupBox2.Controls.Add(Me.Niveau5)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(406, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 119)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filière"
        '
        'Niveau1
        '
        Me.Niveau1.AutoSize = True
        Me.Niveau1.Location = New System.Drawing.Point(51, 35)
        Me.Niveau1.Name = "Niveau1"
        Me.Niveau1.Size = New System.Drawing.Size(37, 25)
        Me.Niveau1.TabIndex = 16
        Me.Niveau1.TabStop = True
        Me.Niveau1.Text = "1"
        Me.Niveau1.UseVisualStyleBackColor = True
        '
        'Niveau2
        '
        Me.Niveau2.AutoSize = True
        Me.Niveau2.Location = New System.Drawing.Point(51, 66)
        Me.Niveau2.Name = "Niveau2"
        Me.Niveau2.Size = New System.Drawing.Size(37, 25)
        Me.Niveau2.TabIndex = 17
        Me.Niveau2.TabStop = True
        Me.Niveau2.Text = "2"
        Me.Niveau2.UseVisualStyleBackColor = True
        '
        'Niveau3
        '
        Me.Niveau3.AutoSize = True
        Me.Niveau3.Location = New System.Drawing.Point(51, 97)
        Me.Niveau3.Name = "Niveau3"
        Me.Niveau3.Size = New System.Drawing.Size(37, 25)
        Me.Niveau3.TabIndex = 18
        Me.Niveau3.TabStop = True
        Me.Niveau3.Text = "3"
        Me.Niveau3.UseVisualStyleBackColor = True
        '
        'Niveau4
        '
        Me.Niveau4.AutoSize = True
        Me.Niveau4.Location = New System.Drawing.Point(128, 39)
        Me.Niveau4.Name = "Niveau4"
        Me.Niveau4.Size = New System.Drawing.Size(37, 25)
        Me.Niveau4.TabIndex = 19
        Me.Niveau4.TabStop = True
        Me.Niveau4.Text = "4"
        Me.Niveau4.UseVisualStyleBackColor = True
        '
        'Niveau5
        '
        Me.Niveau5.AutoSize = True
        Me.Niveau5.Location = New System.Drawing.Point(128, 70)
        Me.Niveau5.Name = "Niveau5"
        Me.Niveau5.Size = New System.Drawing.Size(37, 25)
        Me.Niveau5.TabIndex = 20
        Me.Niveau5.TabStop = True
        Me.Niveau5.Text = "5"
        Me.Niveau5.UseVisualStyleBackColor = True
        '
        'GroupBoxFiliere
        '
        Me.GroupBoxFiliere.Controls.Add(Me.GLO)
        Me.GroupBoxFiliere.Controls.Add(Me.GSI)
        Me.GroupBoxFiliere.Controls.Add(Me.BF)
        Me.GroupBoxFiliere.Controls.Add(Me.CG)
        Me.GroupBoxFiliere.Controls.Add(Me.AMA)
        Me.GroupBoxFiliere.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxFiliere.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxFiliere.Location = New System.Drawing.Point(406, 115)
        Me.GroupBoxFiliere.Name = "GroupBoxFiliere"
        Me.GroupBoxFiliere.Size = New System.Drawing.Size(231, 187)
        Me.GroupBoxFiliere.TabIndex = 13
        Me.GroupBoxFiliere.TabStop = False
        Me.GroupBoxFiliere.Text = "Filière"
        '
        'GLO
        '
        Me.GLO.AutoSize = True
        Me.GLO.Location = New System.Drawing.Point(51, 35)
        Me.GLO.Name = "GLO"
        Me.GLO.Size = New System.Drawing.Size(58, 25)
        Me.GLO.TabIndex = 16
        Me.GLO.TabStop = True
        Me.GLO.Text = "GLO"
        Me.GLO.UseVisualStyleBackColor = True
        '
        'GSI
        '
        Me.GSI.AutoSize = True
        Me.GSI.Location = New System.Drawing.Point(51, 66)
        Me.GSI.Name = "GSI"
        Me.GSI.Size = New System.Drawing.Size(52, 25)
        Me.GSI.TabIndex = 17
        Me.GSI.TabStop = True
        Me.GSI.Text = "GSI"
        Me.GSI.UseVisualStyleBackColor = True
        '
        'BF
        '
        Me.BF.AutoSize = True
        Me.BF.Location = New System.Drawing.Point(51, 97)
        Me.BF.Name = "BF"
        Me.BF.Size = New System.Drawing.Size(45, 25)
        Me.BF.TabIndex = 18
        Me.BF.TabStop = True
        Me.BF.Text = "BF"
        Me.BF.UseVisualStyleBackColor = True
        '
        'CG
        '
        Me.CG.AutoSize = True
        Me.CG.Location = New System.Drawing.Point(51, 128)
        Me.CG.Name = "CG"
        Me.CG.Size = New System.Drawing.Size(49, 25)
        Me.CG.TabIndex = 19
        Me.CG.TabStop = True
        Me.CG.Text = "CG"
        Me.CG.UseVisualStyleBackColor = True
        '
        'AMA
        '
        Me.AMA.AutoSize = True
        Me.AMA.Location = New System.Drawing.Point(51, 159)
        Me.AMA.Name = "AMA"
        Me.AMA.Size = New System.Drawing.Size(62, 25)
        Me.AMA.TabIndex = 20
        Me.AMA.TabStop = True
        Me.AMA.Text = "AMA"
        Me.AMA.UseVisualStyleBackColor = True
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(25, 128)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(247, 29)
        Me.TextBoxLastName.TabIndex = 12
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(25, 72)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(247, 29)
        Me.TextBoxName.TabIndex = 11
        '
        'GroupBoxSexe
        '
        Me.GroupBoxSexe.Controls.Add(Me.FEMININ)
        Me.GroupBoxSexe.Controls.Add(Me.MASCULIN)
        Me.GroupBoxSexe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxSexe.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxSexe.Location = New System.Drawing.Point(25, 184)
        Me.GroupBoxSexe.Name = "GroupBoxSexe"
        Me.GroupBoxSexe.Size = New System.Drawing.Size(231, 124)
        Me.GroupBoxSexe.TabIndex = 10
        Me.GroupBoxSexe.TabStop = False
        Me.GroupBoxSexe.Text = "Sexe"
        '
        'FEMININ
        '
        Me.FEMININ.AutoSize = True
        Me.FEMININ.Location = New System.Drawing.Point(47, 73)
        Me.FEMININ.Name = "FEMININ"
        Me.FEMININ.Size = New System.Drawing.Size(90, 25)
        Me.FEMININ.TabIndex = 15
        Me.FEMININ.TabStop = True
        Me.FEMININ.Text = "FEMININ"
        Me.FEMININ.UseVisualStyleBackColor = True
        '
        'MASCULIN
        '
        Me.MASCULIN.AutoSize = True
        Me.MASCULIN.Location = New System.Drawing.Point(47, 28)
        Me.MASCULIN.Name = "MASCULIN"
        Me.MASCULIN.Size = New System.Drawing.Size(106, 25)
        Me.MASCULIN.TabIndex = 14
        Me.MASCULIN.TabStop = True
        Me.MASCULIN.Text = "MASCULIN"
        Me.MASCULIN.UseVisualStyleBackColor = True
        '
        'DateTimePickerAnneeInscription
        '
        Me.DateTimePickerAnneeInscription.Location = New System.Drawing.Point(406, 72)
        Me.DateTimePickerAnneeInscription.Name = "DateTimePickerAnneeInscription"
        Me.DateTimePickerAnneeInscription.Size = New System.Drawing.Size(237, 29)
        Me.DateTimePickerAnneeInscription.TabIndex = 6
        '
        'DateTimePickerDateNaissance
        '
        Me.DateTimePickerDateNaissance.Location = New System.Drawing.Point(25, 364)
        Me.DateTimePickerDateNaissance.Name = "DateTimePickerDateNaissance"
        Me.DateTimePickerDateNaissance.Size = New System.Drawing.Size(237, 29)
        Me.DateTimePickerDateNaissance.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Année d'inscription"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date de naissance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prenom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Enregistrer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxFiliere.ResumeLayout(False)
        Me.GroupBoxFiliere.PerformLayout()
        Me.GroupBoxSexe.ResumeLayout(False)
        Me.GroupBoxSexe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Modifier As Button
    Friend WithEvents Button2 As Button
    Public WithEvents Enregistrer As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Niveau1 As RadioButton
    Friend WithEvents Niveau2 As RadioButton
    Friend WithEvents Niveau3 As RadioButton
    Friend WithEvents Niveau4 As RadioButton
    Friend WithEvents Niveau5 As RadioButton
    Friend WithEvents GroupBoxFiliere As GroupBox
    Friend WithEvents GLO As RadioButton
    Friend WithEvents GSI As RadioButton
    Friend WithEvents BF As RadioButton
    Friend WithEvents CG As RadioButton
    Friend WithEvents AMA As RadioButton
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents GroupBoxSexe As GroupBox
    Friend WithEvents FEMININ As RadioButton
    Friend WithEvents MASCULIN As RadioButton
    Friend WithEvents DateTimePickerAnneeInscription As DateTimePicker
    Friend WithEvents DateTimePickerDateNaissance As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
