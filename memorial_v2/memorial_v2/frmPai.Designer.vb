<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPai))
        Me.ribbon1 = New System.Windows.Forms.Ribbon()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.ribBtnNovo = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton4 = New System.Windows.Forms.RibbonButton()
        Me.RibBtnAbre = New System.Windows.Forms.RibbonButton()
        Me.RibBtnSave = New System.Windows.Forms.RibbonButton()
        Me.RibBtnSaveAs = New System.Windows.Forms.RibbonButton()
        Me.RibBtnSair = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.ribBtnImoNovo = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton3 = New System.Windows.Forms.RibbonButton()
        Me.ribBtnDefTexto = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel()
        Me.RibArredCoo = New System.Windows.Forms.RibbonUpDown()
        Me.RibArredDist = New System.Windows.Forms.RibbonUpDown()
        Me.RibArredAzi = New System.Windows.Forms.RibbonUpDown()
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel()
        Me.ribBtnSobre = New System.Windows.Forms.RibbonButton()
        Me.ribBtnAjuda = New System.Windows.Forms.RibbonButton()
        Me.ribBtnAtualiza = New System.Windows.Forms.RibbonButton()
        Me.AbreProjeto = New System.Windows.Forms.OpenFileDialog()
        Me.SaveProjeto = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'ribbon1
        '
        Me.ribbon1.BorderMode = System.Windows.Forms.RibbonWindowMode.NonClientAreaCustomDrawn
        Me.ribbon1.CaptionBarVisible = False
        Me.ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.ribbon1.Minimized = False
        Me.ribbon1.Name = "ribbon1"
        '
        '
        '
        Me.ribbon1.OrbDropDown.BorderRoundness = 8
        Me.ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.ribbon1.OrbDropDown.Name = ""
        Me.ribbon1.OrbDropDown.TabIndex = 0
        Me.ribbon1.OrbImage = Nothing
        Me.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010
        Me.ribbon1.OrbVisible = False
        '
        '
        '
        Me.ribbon1.QuickAcessToolbar.Visible = False
        Me.ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.ribbon1.Size = New System.Drawing.Size(934, 116)
        Me.ribbon1.TabIndex = 0
        Me.ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 2, 20, 0)
        Me.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel2)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel3)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel4)
        Me.RibbonTab1.Text = "Projeto"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ButtonMoreVisible = False
        Me.RibbonPanel1.Items.Add(Me.ribBtnNovo)
        Me.RibbonPanel1.Items.Add(Me.RibBtnAbre)
        Me.RibbonPanel1.Items.Add(Me.RibBtnSave)
        Me.RibbonPanel1.Items.Add(Me.RibBtnSaveAs)
        Me.RibbonPanel1.Items.Add(Me.RibBtnSair)
        Me.RibbonPanel1.Text = "Ação"
        '
        'ribBtnNovo
        '
        Me.ribBtnNovo.DropDownArrowSize = New System.Drawing.Size(5, 5)
        Me.ribBtnNovo.DropDownItems.Add(Me.RibbonButton1)
        Me.ribBtnNovo.DropDownItems.Add(Me.RibbonButton4)
        Me.ribBtnNovo.Image = CType(resources.GetObject("ribBtnNovo.Image"), System.Drawing.Image)
        Me.ribBtnNovo.MaximumSize = New System.Drawing.Size(85, 50)
        Me.ribBtnNovo.MinimumSize = New System.Drawing.Size(85, 50)
        Me.ribBtnNovo.SmallImage = CType(resources.GetObject("ribBtnNovo.SmallImage"), System.Drawing.Image)
        Me.ribBtnNovo.Text = "Novo Projeto"
        Me.ribBtnNovo.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "RibbonButton1"
        '
        'RibbonButton4
        '
        Me.RibbonButton4.Image = CType(resources.GetObject("RibbonButton4.Image"), System.Drawing.Image)
        Me.RibbonButton4.SmallImage = CType(resources.GetObject("RibbonButton4.SmallImage"), System.Drawing.Image)
        Me.RibbonButton4.Text = "RibbonButton4"
        '
        'RibBtnAbre
        '
        Me.RibBtnAbre.Image = CType(resources.GetObject("RibBtnAbre.Image"), System.Drawing.Image)
        Me.RibBtnAbre.MaximumSize = New System.Drawing.Size(82, 50)
        Me.RibBtnAbre.MinimumSize = New System.Drawing.Size(82, 50)
        Me.RibBtnAbre.SmallImage = CType(resources.GetObject("RibBtnAbre.SmallImage"), System.Drawing.Image)
        Me.RibBtnAbre.Text = "Abrir projeto"
        '
        'RibBtnSave
        '
        Me.RibBtnSave.DropDownArrowSize = New System.Drawing.Size(10, 10)
        Me.RibBtnSave.Image = CType(resources.GetObject("RibBtnSave.Image"), System.Drawing.Image)
        Me.RibBtnSave.MaximumSize = New System.Drawing.Size(72, 50)
        Me.RibBtnSave.MinimumSize = New System.Drawing.Size(72, 50)
        Me.RibBtnSave.SmallImage = CType(resources.GetObject("RibBtnSave.SmallImage"), System.Drawing.Image)
        Me.RibBtnSave.Text = "Salvar"
        Me.RibBtnSave.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'RibBtnSaveAs
        '
        Me.RibBtnSaveAs.Image = CType(resources.GetObject("RibBtnSaveAs.Image"), System.Drawing.Image)
        Me.RibBtnSaveAs.MaximumSize = New System.Drawing.Size(82, 50)
        Me.RibBtnSaveAs.MinimumSize = New System.Drawing.Size(82, 50)
        Me.RibBtnSaveAs.SmallImage = CType(resources.GetObject("RibBtnSaveAs.SmallImage"), System.Drawing.Image)
        Me.RibBtnSaveAs.Text = "Salvar Como"
        Me.RibBtnSaveAs.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'RibBtnSair
        '
        Me.RibBtnSair.Image = CType(resources.GetObject("RibBtnSair.Image"), System.Drawing.Image)
        Me.RibBtnSair.MaximumSize = New System.Drawing.Size(72, 50)
        Me.RibBtnSair.MinimumSize = New System.Drawing.Size(72, 50)
        Me.RibBtnSair.SmallImage = CType(resources.GetObject("RibBtnSair.SmallImage"), System.Drawing.Image)
        Me.RibBtnSair.Text = "Sair"
        Me.RibBtnSair.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ButtonMoreEnabled = False
        Me.RibbonPanel2.ButtonMoreVisible = False
        Me.RibbonPanel2.Items.Add(Me.ribBtnImoNovo)
        Me.RibbonPanel2.Items.Add(Me.ribBtnDefTexto)
        Me.RibbonPanel2.Text = "Definições"
        '
        'ribBtnImoNovo
        '
        Me.ribBtnImoNovo.DropDownItems.Add(Me.RibbonButton3)
        Me.ribBtnImoNovo.Image = CType(resources.GetObject("ribBtnImoNovo.Image"), System.Drawing.Image)
        Me.ribBtnImoNovo.MaximumSize = New System.Drawing.Size(84, 50)
        Me.ribBtnImoNovo.MinimumSize = New System.Drawing.Size(84, 50)
        Me.ribBtnImoNovo.SmallImage = CType(resources.GetObject("ribBtnImoNovo.SmallImage"), System.Drawing.Image)
        Me.ribBtnImoNovo.Text = "Formato CSV"
        Me.ribBtnImoNovo.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'RibbonButton3
        '
        Me.RibbonButton3.Image = CType(resources.GetObject("RibbonButton3.Image"), System.Drawing.Image)
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        Me.RibbonButton3.Text = "RibbonButton3"
        '
        'ribBtnDefTexto
        '
        Me.ribBtnDefTexto.Image = CType(resources.GetObject("ribBtnDefTexto.Image"), System.Drawing.Image)
        Me.ribBtnDefTexto.MaximumSize = New System.Drawing.Size(98, 50)
        Me.ribBtnDefTexto.MinimumSize = New System.Drawing.Size(98, 50)
        Me.ribBtnDefTexto.SmallImage = CType(resources.GetObject("ribBtnDefTexto.SmallImage"), System.Drawing.Image)
        Me.ribBtnDefTexto.Text = "Texto Memorial"
        Me.ribBtnDefTexto.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ButtonMoreEnabled = False
        Me.RibbonPanel3.ButtonMoreVisible = False
        Me.RibbonPanel3.Items.Add(Me.RibArredCoo)
        Me.RibbonPanel3.Items.Add(Me.RibArredDist)
        Me.RibbonPanel3.Items.Add(Me.RibArredAzi)
        Me.RibbonPanel3.Text = "Azimute e Distância - Casas decimais"
        '
        'RibArredCoo
        '
        Me.RibArredCoo.AllowTextEdit = False
        Me.RibArredCoo.LabelWidth = 80
        Me.RibArredCoo.Tag = ""
        Me.RibArredCoo.Text = "Coordenadas:"
        Me.RibArredCoo.TextBoxText = "3"
        Me.RibArredCoo.TextBoxWidth = 20
        Me.RibArredCoo.Value = "3"
        '
        'RibArredDist
        '
        Me.RibArredDist.AllowTextEdit = False
        Me.RibArredDist.LabelWidth = 80
        Me.RibArredDist.Text = "Distâncias:"
        Me.RibArredDist.TextBoxText = "2"
        Me.RibArredDist.TextBoxWidth = 20
        Me.RibArredDist.Value = "1"
        '
        'RibArredAzi
        '
        Me.RibArredAzi.AllowTextEdit = False
        Me.RibArredAzi.LabelWidth = 80
        Me.RibArredAzi.Text = "Azimutes:"
        Me.RibArredAzi.TextBoxText = "2"
        Me.RibArredAzi.TextBoxWidth = 20
        Me.RibArredAzi.Value = "1"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.ButtonMoreEnabled = False
        Me.RibbonPanel4.ButtonMoreVisible = False
        Me.RibbonPanel4.FlowsTo = System.Windows.Forms.RibbonPanelFlowDirection.Left
        Me.RibbonPanel4.Items.Add(Me.ribBtnSobre)
        Me.RibbonPanel4.Items.Add(Me.ribBtnAjuda)
        Me.RibbonPanel4.Items.Add(Me.ribBtnAtualiza)
        Me.RibbonPanel4.Text = "Informação   "
        '
        'ribBtnSobre
        '
        Me.ribBtnSobre.DrawIconsBar = False
        Me.ribBtnSobre.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Up
        Me.ribBtnSobre.DropDownArrowSize = New System.Drawing.Size(0, 0)
        Me.ribBtnSobre.DropDownResizable = True
        Me.ribBtnSobre.Image = CType(resources.GetObject("ribBtnSobre.Image"), System.Drawing.Image)
        Me.ribBtnSobre.MaximumSize = New System.Drawing.Size(100, 10)
        Me.ribBtnSobre.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.ribBtnSobre.MinimumSize = New System.Drawing.Size(100, 10)
        Me.ribBtnSobre.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.ribBtnSobre.SmallImage = CType(resources.GetObject("ribBtnSobre.SmallImage"), System.Drawing.Image)
        Me.ribBtnSobre.Text = "Sobre"
        '
        'ribBtnAjuda
        '
        Me.ribBtnAjuda.DrawIconsBar = False
        Me.ribBtnAjuda.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.ribBtnAjuda.DropDownArrowSize = New System.Drawing.Size(0, 0)
        Me.ribBtnAjuda.Image = CType(resources.GetObject("ribBtnAjuda.Image"), System.Drawing.Image)
        Me.ribBtnAjuda.MaximumSize = New System.Drawing.Size(100, 20)
        Me.ribBtnAjuda.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.ribBtnAjuda.MinimumSize = New System.Drawing.Size(100, 20)
        Me.ribBtnAjuda.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.ribBtnAjuda.SmallImage = CType(resources.GetObject("ribBtnAjuda.SmallImage"), System.Drawing.Image)
        Me.ribBtnAjuda.Text = "Ajuda"
        '
        'ribBtnAtualiza
        '
        Me.ribBtnAtualiza.DropDownArrowSize = New System.Drawing.Size(0, 0)
        Me.ribBtnAtualiza.Image = CType(resources.GetObject("ribBtnAtualiza.Image"), System.Drawing.Image)
        Me.ribBtnAtualiza.MaximumSize = New System.Drawing.Size(100, 20)
        Me.ribBtnAtualiza.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.ribBtnAtualiza.MinimumSize = New System.Drawing.Size(100, 20)
        Me.ribBtnAtualiza.SmallImage = CType(resources.GetObject("ribBtnAtualiza.SmallImage"), System.Drawing.Image)
        Me.ribBtnAtualiza.Text = "Atualizar"
        '
        'AbreProjeto
        '
        Me.AbreProjeto.FileName = "OpenFileDialog1"
        '
        'frmPai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 602)
        Me.Controls.Add(Me.ribbon1)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(950, 640)
        Me.Name = "frmPai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerar Memorial Descritivo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ribbon1 As System.Windows.Forms.Ribbon
    Friend WithEvents RibbonTab1 As System.Windows.Forms.RibbonTab
    Friend WithEvents ribBtnNovo As System.Windows.Forms.RibbonButton
    Friend WithEvents RibBtnSave As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel1 As System.Windows.Forms.RibbonPanel
    Friend WithEvents AbreProjeto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RibbonPanel2 As System.Windows.Forms.RibbonPanel
    Friend WithEvents ribBtnImoNovo As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton3 As System.Windows.Forms.RibbonButton
    Friend WithEvents ribBtnDefTexto As System.Windows.Forms.RibbonButton
    Friend WithEvents RibBtnSaveAs As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel3 As System.Windows.Forms.RibbonPanel
    Friend WithEvents RibArredCoo As System.Windows.Forms.RibbonUpDown
    Friend WithEvents RibArredDist As System.Windows.Forms.RibbonUpDown
    Friend WithEvents RibArredAzi As System.Windows.Forms.RibbonUpDown
    Friend WithEvents RibBtnSair As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton1 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton4 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibBtnAbre As System.Windows.Forms.RibbonButton
    Friend WithEvents SaveProjeto As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RibbonPanel4 As System.Windows.Forms.RibbonPanel
    Friend WithEvents ribBtnAjuda As System.Windows.Forms.RibbonButton
    Friend WithEvents ribBtnSobre As System.Windows.Forms.RibbonButton
    Friend WithEvents ribBtnAtualiza As System.Windows.Forms.RibbonButton

End Class
