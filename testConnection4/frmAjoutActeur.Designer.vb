<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjoutActeur
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
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.TextBox()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.lblConfirmation = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(146, 7)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNom.Multiline = True
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(300, 43)
        Me.txtNom.TabIndex = 33
        '
        'txtPrenom
        '
        Me.txtPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(146, 51)
        Me.txtPrenom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrenom.Multiline = True
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(300, 43)
        Me.txtPrenom.TabIndex = 34
        '
        'lblNom
        '
        Me.lblNom.Enabled = False
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(12, 12)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(128, 38)
        Me.lblNom.TabIndex = 37
        Me.lblNom.Text = "Nom"
        Me.lblNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPrenom
        '
        Me.lblPrenom.Enabled = False
        Me.lblPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenom.Location = New System.Drawing.Point(12, 56)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(128, 38)
        Me.lblPrenom.TabIndex = 38
        Me.lblPrenom.Text = "Prenom"
        Me.lblPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAjout
        '
        Me.btnAjout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjout.Location = New System.Drawing.Point(274, 99)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(172, 40)
        Me.btnAjout.TabIndex = 40
        Me.btnAjout.Text = "Ajout"
        Me.btnAjout.UseVisualStyleBackColor = True
        '
        'lblConfirmation
        '
        Me.lblConfirmation.Enabled = False
        Me.lblConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(12, 101)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(256, 38)
        Me.lblConfirmation.TabIndex = 41
        Me.lblConfirmation.Text = "Ajout confirmé"
        Me.lblConfirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmAjoutActeur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 161)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.btnAjout)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Name = "frmAjoutActeur"
        Me.Text = "frmAjoutActeur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents lblNom As TextBox
    Friend WithEvents lblPrenom As TextBox
    Friend WithEvents btnAjout As Button
    Friend WithEvents lblConfirmation As TextBox
End Class
