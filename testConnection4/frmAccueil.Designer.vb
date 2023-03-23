<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.dGV1 = New System.Windows.Forms.DataGridView()
        Me.Titre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAccueil = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAjoutActeur = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAjoutFilm = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.txtModif = New System.Windows.Forms.TextBox()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.dGVActeur = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lstCateg = New System.Windows.Forms.ListBox()
        Me.txtModifNom = New System.Windows.Forms.TextBox()
        Me.btnModifNom = New System.Windows.Forms.Button()
        Me.txtModifPrenom = New System.Windows.Forms.TextBox()
        Me.btnDesecCateg = New System.Windows.Forms.Button()
        Me.txtNbFilm = New System.Windows.Forms.TextBox()
        Me.btnDesecFilm = New System.Windows.Forms.Button()
        CType(Me.dGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dGVActeur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst1
        '
        Me.lst1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst1.FormattingEnabled = True
        Me.lst1.ItemHeight = 25
        Me.lst1.Location = New System.Drawing.Point(12, 100)
        Me.lst1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(300, 629)
        Me.lst1.TabIndex = 28
        '
        'dGV1
        '
        Me.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Titre, Me.Desc})
        Me.dGV1.Location = New System.Drawing.Point(631, 100)
        Me.dGV1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dGV1.Name = "dGV1"
        Me.dGV1.RowHeadersWidth = 51
        Me.dGV1.RowTemplate.Height = 24
        Me.dGV1.Size = New System.Drawing.Size(1185, 649)
        Me.dGV1.TabIndex = 29
        '
        'Titre
        '
        Me.Titre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Titre.HeaderText = "Film"
        Me.Titre.MinimumWidth = 6
        Me.Titre.Name = "Titre"
        Me.Titre.ReadOnly = True
        '
        'Desc
        '
        Me.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Desc.HeaderText = "Description"
        Me.Desc.MinimumWidth = 6
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        Me.Desc.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnQuit, Me.btnAccueil, Me.btnOption})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1864, 28)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnQuit
        '
        Me.btnQuit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(69, 24)
        Me.btnQuit.Text = "&Quitter"
        '
        'btnAccueil
        '
        Me.btnAccueil.Name = "btnAccueil"
        Me.btnAccueil.Size = New System.Drawing.Size(71, 24)
        Me.btnAccueil.Text = "&Accueil"
        '
        'btnOption
        '
        Me.btnOption.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAjoutActeur, Me.btnAjoutFilm})
        Me.btnOption.Name = "btnOption"
        Me.btnOption.Size = New System.Drawing.Size(69, 24)
        Me.btnOption.Text = "&Option"
        '
        'btnAjoutActeur
        '
        Me.btnAjoutActeur.Name = "btnAjoutActeur"
        Me.btnAjoutActeur.Size = New System.Drawing.Size(194, 26)
        Me.btnAjoutActeur.Text = "Créer un &Acteur"
        '
        'btnAjoutFilm
        '
        Me.btnAjoutFilm.Name = "btnAjoutFilm"
        Me.btnAjoutFilm.Size = New System.Drawing.Size(194, 26)
        Me.btnAjoutFilm.Text = "Créer un &Film"
        '
        'txtRecherche
        '
        Me.txtRecherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecherche.Location = New System.Drawing.Point(12, 50)
        Me.txtRecherche.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRecherche.Multiline = True
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(300, 43)
        Me.txtRecherche.TabIndex = 32
        '
        'txtModif
        '
        Me.txtModif.Enabled = False
        Me.txtModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModif.Location = New System.Drawing.Point(631, 753)
        Me.txtModif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModif.Multiline = True
        Me.txtModif.Name = "txtModif"
        Me.txtModif.Size = New System.Drawing.Size(311, 53)
        Me.txtModif.TabIndex = 33
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(948, 754)
        Me.btnModif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(117, 53)
        Me.btnModif.TabIndex = 34
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'dGVActeur
        '
        Me.dGVActeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVActeur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dGVActeur.Location = New System.Drawing.Point(631, 39)
        Me.dGVActeur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dGVActeur.Name = "dGVActeur"
        Me.dGVActeur.RowHeadersWidth = 51
        Me.dGVActeur.RowTemplate.Height = 24
        Me.dGVActeur.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dGVActeur.Size = New System.Drawing.Size(620, 55)
        Me.dGVActeur.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Prenom"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'lstCateg
        '
        Me.lstCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCateg.FormattingEnabled = True
        Me.lstCateg.ItemHeight = 25
        Me.lstCateg.Location = New System.Drawing.Point(319, 100)
        Me.lstCateg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstCateg.Name = "lstCateg"
        Me.lstCateg.Size = New System.Drawing.Size(300, 304)
        Me.lstCateg.TabIndex = 36
        '
        'txtModifNom
        '
        Me.txtModifNom.Enabled = False
        Me.txtModifNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModifNom.Location = New System.Drawing.Point(1472, 37)
        Me.txtModifNom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModifNom.Multiline = True
        Me.txtModifNom.Name = "txtModifNom"
        Me.txtModifNom.Size = New System.Drawing.Size(214, 57)
        Me.txtModifNom.TabIndex = 38
        '
        'btnModifNom
        '
        Me.btnModifNom.Location = New System.Drawing.Point(1692, 39)
        Me.btnModifNom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModifNom.Name = "btnModifNom"
        Me.btnModifNom.Size = New System.Drawing.Size(124, 55)
        Me.btnModifNom.TabIndex = 39
        Me.btnModifNom.Text = "Modifier"
        Me.btnModifNom.UseVisualStyleBackColor = True
        '
        'txtModifPrenom
        '
        Me.txtModifPrenom.Enabled = False
        Me.txtModifPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModifPrenom.Location = New System.Drawing.Point(1252, 37)
        Me.txtModifPrenom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModifPrenom.Multiline = True
        Me.txtModifPrenom.Name = "txtModifPrenom"
        Me.txtModifPrenom.Size = New System.Drawing.Size(214, 57)
        Me.txtModifPrenom.TabIndex = 40
        '
        'btnDesecCateg
        '
        Me.btnDesecCateg.Location = New System.Drawing.Point(319, 408)
        Me.btnDesecCateg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDesecCateg.Name = "btnDesecCateg"
        Me.btnDesecCateg.Size = New System.Drawing.Size(124, 36)
        Me.btnDesecCateg.TabIndex = 41
        Me.btnDesecCateg.Text = "Deselectionner"
        Me.btnDesecCateg.UseVisualStyleBackColor = True
        '
        'txtNbFilm
        '
        Me.txtNbFilm.Enabled = False
        Me.txtNbFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNbFilm.Location = New System.Drawing.Point(1291, 753)
        Me.txtNbFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNbFilm.Multiline = True
        Me.txtNbFilm.Name = "txtNbFilm"
        Me.txtNbFilm.Size = New System.Drawing.Size(525, 53)
        Me.txtNbFilm.TabIndex = 42
        '
        'btnDesecFilm
        '
        Me.btnDesecFilm.Location = New System.Drawing.Point(12, 733)
        Me.btnDesecFilm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDesecFilm.Name = "btnDesecFilm"
        Me.btnDesecFilm.Size = New System.Drawing.Size(124, 36)
        Me.btnDesecFilm.TabIndex = 43
        Me.btnDesecFilm.Text = "Deselectionner"
        Me.btnDesecFilm.UseVisualStyleBackColor = True
        '
        'frmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1864, 818)
        Me.Controls.Add(Me.btnDesecFilm)
        Me.Controls.Add(Me.txtNbFilm)
        Me.Controls.Add(Me.btnDesecCateg)
        Me.Controls.Add(Me.txtModifPrenom)
        Me.Controls.Add(Me.btnModifNom)
        Me.Controls.Add(Me.txtModifNom)
        Me.Controls.Add(Me.lstCateg)
        Me.Controls.Add(Me.dGVActeur)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.txtModif)
        Me.Controls.Add(Me.txtRecherche)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dGV1)
        Me.Controls.Add(Me.lst1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        CType(Me.dGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dGVActeur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst1 As ListBox
    Friend WithEvents dGV1 As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnOption As ToolStripMenuItem
    Friend WithEvents btnQuit As ToolStripMenuItem
    Friend WithEvents txtRecherche As TextBox
    Friend WithEvents txtModif As TextBox
    Friend WithEvents btnModif As Button
    Friend WithEvents btnAccueil As ToolStripMenuItem
    Friend WithEvents btnAjoutActeur As ToolStripMenuItem
    Friend WithEvents btnAjoutFilm As ToolStripMenuItem
    Friend WithEvents Titre As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents dGVActeur As DataGridView
    Friend WithEvents lstCateg As ListBox
    Friend WithEvents txtModifNom As TextBox
    Friend WithEvents btnModifNom As Button
    Friend WithEvents txtModifPrenom As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btnDesecCateg As Button
    Friend WithEvents txtNbFilm As TextBox
    Friend WithEvents btnDesecFilm As Button
End Class
