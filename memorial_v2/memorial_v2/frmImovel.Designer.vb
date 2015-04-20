<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImovel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImovel))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboFuso = New System.Windows.Forms.ComboBox()
        Me.cboMC = New System.Windows.Forms.ComboBox()
        Me.label46 = New System.Windows.Forms.Label()
        Me.cboLongitude = New System.Windows.Forms.ComboBox()
        Me.label45 = New System.Windows.Forms.Label()
        Me.cboHemisferio = New System.Windows.Forms.ComboBox()
        Me.label44 = New System.Windows.Forms.Label()
        Me.label34 = New System.Windows.Forms.Label()
        Me.txtDatum = New System.Windows.Forms.TextBox()
        Me.label36 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumDecPer = New System.Windows.Forms.NumericUpDown()
        Me.chkArea = New System.Windows.Forms.CheckBox()
        Me.label42 = New System.Windows.Forms.Label()
        Me.label28 = New System.Windows.Forms.Label()
        Me.NumDecAreaha = New System.Windows.Forms.NumericUpDown()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.label41 = New System.Windows.Forms.Label()
        Me.chkPer = New System.Windows.Forms.CheckBox()
        Me.NumDecAream = New System.Windows.Forms.NumericUpDown()
        Me.label38 = New System.Windows.Forms.Label()
        Me.label40 = New System.Windows.Forms.Label()
        Me.txtAreaha = New System.Windows.Forms.TextBox()
        Me.chkAreaha = New System.Windows.Forms.CheckBox()
        Me.label39 = New System.Windows.Forms.Label()
        Me.txtPerimetro = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtProprietario = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label47 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtCartorio = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.txtCodIncra = New System.Windows.Forms.TextBox()
        Me.txtComarca = New System.Windows.Forms.TextBox()
        Me.label27 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.txtImovel = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.ToolStripImo = New System.Windows.Forms.ToolStrip()
        Me.ToolStrSaveImo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrLoadImo = New System.Windows.Forms.ToolStripButton()
        Me.ToolLimparImo = New System.Windows.Forms.ToolStripButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.txtAssinatura = New System.Windows.Forms.TextBox()
        Me.txtNomeProf = New System.Windows.Forms.TextBox()
        Me.txtRegistro = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.label30 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.OptOutra = New System.Windows.Forms.RadioButton()
        Me.optHoje = New System.Windows.Forms.RadioButton()
        Me.chkData = New System.Windows.Forms.CheckBox()
        Me.ToolStripProf = New System.Windows.Forms.ToolStrip()
        Me.ToolStrBtnSaveProf = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrBtnLoadProf = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrBtnLimpaProf = New System.Windows.Forms.ToolStripButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnExpCSV = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripBtnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnDel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrAzimute = New System.Windows.Forms.ToolStripButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.RichTxtMemo = New System.Windows.Forms.RichTextBox()
        Me.ToolStripMemorial = New System.Windows.Forms.ToolStrip()
        Me.ToolStrBtnGeraMemo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileGridCsv = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileImovel = New System.Windows.Forms.SaveFileDialog()
        Me.lblVersaoAtual = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumDecPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDecAreaha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDecAream, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStripImo.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ToolStripProf.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.ToolStripMemorial.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(100, 38)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1049, 621)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ToolStripImo)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 42)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1041, 575)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalhes do Imóvel"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.cboFuso)
        Me.GroupBox3.Controls.Add(Me.cboMC)
        Me.GroupBox3.Controls.Add(Me.label46)
        Me.GroupBox3.Controls.Add(Me.cboLongitude)
        Me.GroupBox3.Controls.Add(Me.label45)
        Me.GroupBox3.Controls.Add(Me.cboHemisferio)
        Me.GroupBox3.Controls.Add(Me.label44)
        Me.GroupBox3.Controls.Add(Me.label34)
        Me.GroupBox3.Controls.Add(Me.txtDatum)
        Me.GroupBox3.Controls.Add(Me.label36)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1035, 81)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informações Cartográficas"
        '
        'cboFuso
        '
        Me.cboFuso.FormattingEnabled = True
        Me.cboFuso.Items.AddRange(New Object() {"18", "19", "20", "21", "22", "23", "24", "25"})
        Me.cboFuso.Location = New System.Drawing.Point(228, 44)
        Me.cboFuso.Name = "cboFuso"
        Me.cboFuso.Size = New System.Drawing.Size(48, 23)
        Me.cboFuso.TabIndex = 18
        Me.cboFuso.Text = "22"
        '
        'cboMC
        '
        Me.cboMC.FormattingEnabled = True
        Me.cboMC.Items.AddRange(New Object() {"33", "39", "45", "51", "57", "63", "69", "75"})
        Me.cboMC.Location = New System.Drawing.Point(9, 44)
        Me.cboMC.Name = "cboMC"
        Me.cboMC.Size = New System.Drawing.Size(47, 23)
        Me.cboMC.TabIndex = 16
        Me.cboMC.Text = "51"
        '
        'label46
        '
        Me.label46.AutoSize = True
        Me.label46.Location = New System.Drawing.Point(124, 28)
        Me.label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label46.Name = "label46"
        Me.label46.Size = New System.Drawing.Size(62, 15)
        Me.label46.TabIndex = 110
        Me.label46.Text = "Longitude"
        '
        'cboLongitude
        '
        Me.cboLongitude.FormattingEnabled = True
        Me.cboLongitude.Items.AddRange(New Object() {"W", "E"})
        Me.cboLongitude.Location = New System.Drawing.Point(124, 44)
        Me.cboLongitude.Name = "cboLongitude"
        Me.cboLongitude.Size = New System.Drawing.Size(56, 23)
        Me.cboLongitude.TabIndex = 17
        Me.cboLongitude.Text = "W"
        '
        'label45
        '
        Me.label45.AutoSize = True
        Me.label45.Location = New System.Drawing.Point(299, 28)
        Me.label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label45.Name = "label45"
        Me.label45.Size = New System.Drawing.Size(67, 15)
        Me.label45.TabIndex = 109
        Me.label45.Text = "Hemisfério"
        '
        'cboHemisferio
        '
        Me.cboHemisferio.FormattingEnabled = True
        Me.cboHemisferio.Items.AddRange(New Object() {"Sul", "Norte"})
        Me.cboHemisferio.Location = New System.Drawing.Point(299, 44)
        Me.cboHemisferio.Name = "cboHemisferio"
        Me.cboHemisferio.Size = New System.Drawing.Size(56, 23)
        Me.cboHemisferio.TabIndex = 19
        Me.cboHemisferio.Text = "Sul"
        '
        'label44
        '
        Me.label44.AutoSize = True
        Me.label44.Location = New System.Drawing.Point(227, 28)
        Me.label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label44.Name = "label44"
        Me.label44.Size = New System.Drawing.Size(34, 15)
        Me.label44.TabIndex = 108
        Me.label44.Text = "Fuso"
        '
        'label34
        '
        Me.label34.AutoSize = True
        Me.label34.Location = New System.Drawing.Point(5, 28)
        Me.label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(105, 15)
        Me.label34.TabIndex = 107
        Me.label34.Text = "Meridiano Central"
        '
        'txtDatum
        '
        Me.txtDatum.Location = New System.Drawing.Point(382, 44)
        Me.txtDatum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDatum.Name = "txtDatum"
        Me.txtDatum.Size = New System.Drawing.Size(267, 21)
        Me.txtDatum.TabIndex = 20
        Me.txtDatum.Text = "SIRGAS-2000"
        '
        'label36
        '
        Me.label36.AutoSize = True
        Me.label36.Location = New System.Drawing.Point(382, 28)
        Me.label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label36.Name = "label36"
        Me.label36.Size = New System.Drawing.Size(44, 15)
        Me.label36.TabIndex = 106
        Me.label36.Text = "Datum"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.NumDecPer)
        Me.GroupBox2.Controls.Add(Me.chkArea)
        Me.GroupBox2.Controls.Add(Me.label42)
        Me.GroupBox2.Controls.Add(Me.label28)
        Me.GroupBox2.Controls.Add(Me.NumDecAreaha)
        Me.GroupBox2.Controls.Add(Me.txtArea)
        Me.GroupBox2.Controls.Add(Me.label41)
        Me.GroupBox2.Controls.Add(Me.chkPer)
        Me.GroupBox2.Controls.Add(Me.NumDecAream)
        Me.GroupBox2.Controls.Add(Me.label38)
        Me.GroupBox2.Controls.Add(Me.label40)
        Me.GroupBox2.Controls.Add(Me.txtAreaha)
        Me.GroupBox2.Controls.Add(Me.chkAreaha)
        Me.GroupBox2.Controls.Add(Me.label39)
        Me.GroupBox2.Controls.Add(Me.txtPerimetro)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1035, 107)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Área e Perímetro"
        '
        'NumDecPer
        '
        Me.NumDecPer.Enabled = False
        Me.NumDecPer.Location = New System.Drawing.Point(814, 64)
        Me.NumDecPer.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumDecPer.Name = "NumDecPer"
        Me.NumDecPer.Size = New System.Drawing.Size(40, 21)
        Me.NumDecPer.TabIndex = 15
        Me.NumDecPer.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'chkArea
        '
        Me.chkArea.AutoSize = True
        Me.chkArea.Location = New System.Drawing.Point(8, 29)
        Me.chkArea.Name = "chkArea"
        Me.chkArea.Size = New System.Drawing.Size(114, 19)
        Me.chkArea.TabIndex = 7
        Me.chkArea.Text = "Inserir área (m²)"
        Me.chkArea.UseVisualStyleBackColor = True
        '
        'label42
        '
        Me.label42.AutoSize = True
        Me.label42.Location = New System.Drawing.Point(811, 48)
        Me.label42.Name = "label42"
        Me.label42.Size = New System.Drawing.Size(97, 15)
        Me.label42.TabIndex = 101
        Me.label42.Text = "Casas decimais:"
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.Location = New System.Drawing.Point(5, 49)
        Me.label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(58, 15)
        Me.label28.TabIndex = 96
        Me.label28.Text = "Área (m²)"
        '
        'NumDecAreaha
        '
        Me.NumDecAreaha.Enabled = False
        Me.NumDecAreaha.Location = New System.Drawing.Point(488, 65)
        Me.NumDecAreaha.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumDecAreaha.Name = "NumDecAreaha"
        Me.NumDecAreaha.Size = New System.Drawing.Size(40, 21)
        Me.NumDecAreaha.TabIndex = 12
        Me.NumDecAreaha.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'txtArea
        '
        Me.txtArea.Enabled = False
        Me.txtArea.Location = New System.Drawing.Point(8, 65)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(2)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(150, 21)
        Me.txtArea.TabIndex = 8
        '
        'label41
        '
        Me.label41.AutoSize = True
        Me.label41.Location = New System.Drawing.Point(485, 49)
        Me.label41.Name = "label41"
        Me.label41.Size = New System.Drawing.Size(97, 15)
        Me.label41.TabIndex = 100
        Me.label41.Text = "Casas decimais:"
        '
        'chkPer
        '
        Me.chkPer.AutoSize = True
        Me.chkPer.Location = New System.Drawing.Point(656, 29)
        Me.chkPer.Name = "chkPer"
        Me.chkPer.Size = New System.Drawing.Size(116, 19)
        Me.chkPer.TabIndex = 13
        Me.chkPer.Text = "Inserir perímetro"
        Me.chkPer.UseVisualStyleBackColor = True
        '
        'NumDecAream
        '
        Me.NumDecAream.Enabled = False
        Me.NumDecAream.Location = New System.Drawing.Point(166, 65)
        Me.NumDecAream.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumDecAream.Name = "NumDecAream"
        Me.NumDecAream.Size = New System.Drawing.Size(40, 21)
        Me.NumDecAream.TabIndex = 9
        Me.NumDecAream.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'label38
        '
        Me.label38.AutoSize = True
        Me.label38.Location = New System.Drawing.Point(327, 49)
        Me.label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(57, 15)
        Me.label38.TabIndex = 97
        Me.label38.Text = "Área (ha)"
        '
        'label40
        '
        Me.label40.AutoSize = True
        Me.label40.Location = New System.Drawing.Point(163, 49)
        Me.label40.Name = "label40"
        Me.label40.Size = New System.Drawing.Size(97, 15)
        Me.label40.TabIndex = 99
        Me.label40.Text = "Casas decimais:"
        '
        'txtAreaha
        '
        Me.txtAreaha.Enabled = False
        Me.txtAreaha.Location = New System.Drawing.Point(329, 65)
        Me.txtAreaha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAreaha.Name = "txtAreaha"
        Me.txtAreaha.Size = New System.Drawing.Size(150, 21)
        Me.txtAreaha.TabIndex = 11
        '
        'chkAreaha
        '
        Me.chkAreaha.AutoSize = True
        Me.chkAreaha.Location = New System.Drawing.Point(329, 29)
        Me.chkAreaha.Name = "chkAreaha"
        Me.chkAreaha.Size = New System.Drawing.Size(113, 19)
        Me.chkAreaha.TabIndex = 10
        Me.chkAreaha.Text = "Inserir área (ha)"
        Me.chkAreaha.UseVisualStyleBackColor = True
        '
        'label39
        '
        Me.label39.AutoSize = True
        Me.label39.Location = New System.Drawing.Point(657, 49)
        Me.label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label39.Name = "label39"
        Me.label39.Size = New System.Drawing.Size(83, 15)
        Me.label39.TabIndex = 98
        Me.label39.Text = "Perímetro (m)"
        '
        'txtPerimetro
        '
        Me.txtPerimetro.Enabled = False
        Me.txtPerimetro.Location = New System.Drawing.Point(656, 64)
        Me.txtPerimetro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPerimetro.Name = "txtPerimetro"
        Me.txtPerimetro.Size = New System.Drawing.Size(150, 21)
        Me.txtPerimetro.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.txtProprietario)
        Me.GroupBox1.Controls.Add(Me.label11)
        Me.GroupBox1.Controls.Add(Me.label47)
        Me.GroupBox1.Controls.Add(Me.label10)
        Me.GroupBox1.Controls.Add(Me.txtCartorio)
        Me.GroupBox1.Controls.Add(Me.label12)
        Me.GroupBox1.Controls.Add(Me.txtCodIncra)
        Me.GroupBox1.Controls.Add(Me.txtComarca)
        Me.GroupBox1.Controls.Add(Me.label27)
        Me.GroupBox1.Controls.Add(Me.label14)
        Me.GroupBox1.Controls.Add(Me.txtImovel)
        Me.GroupBox1.Controls.Add(Me.label13)
        Me.GroupBox1.Controls.Add(Me.txtMatricula)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações do Imóvel"
        '
        'txtProprietario
        '
        Me.txtProprietario.Location = New System.Drawing.Point(7, 138)
        Me.txtProprietario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProprietario.Name = "txtProprietario"
        Me.txtProprietario.Size = New System.Drawing.Size(900, 21)
        Me.txtProprietario.TabIndex = 6
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(7, 123)
        Me.label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(85, 15)
        Me.label11.TabIndex = 101
        Me.label11.Text = "Proprietário(s)"
        '
        'label47
        '
        Me.label47.AutoSize = True
        Me.label47.Location = New System.Drawing.Point(437, 73)
        Me.label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label47.Name = "label47"
        Me.label47.Size = New System.Drawing.Size(50, 15)
        Me.label47.TabIndex = 99
        Me.label47.Text = "Cartório"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(5, 26)
        Me.label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(43, 15)
        Me.label10.TabIndex = 94
        Me.label10.Text = "Imóvel"
        '
        'txtCartorio
        '
        Me.txtCartorio.Location = New System.Drawing.Point(439, 90)
        Me.txtCartorio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCartorio.Name = "txtCartorio"
        Me.txtCartorio.Size = New System.Drawing.Size(210, 21)
        Me.txtCartorio.TabIndex = 4
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(514, 23)
        Me.label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(61, 15)
        Me.label12.TabIndex = 95
        Me.label12.Text = "Município"
        '
        'txtCodIncra
        '
        Me.txtCodIncra.Location = New System.Drawing.Point(653, 90)
        Me.txtCodIncra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodIncra.Name = "txtCodIncra"
        Me.txtCodIncra.Size = New System.Drawing.Size(254, 21)
        Me.txtCodIncra.TabIndex = 5
        '
        'txtComarca
        '
        Me.txtComarca.Location = New System.Drawing.Point(223, 90)
        Me.txtComarca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtComarca.Name = "txtComarca"
        Me.txtComarca.Size = New System.Drawing.Size(210, 21)
        Me.txtComarca.TabIndex = 3
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Location = New System.Drawing.Point(653, 73)
        Me.label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(85, 15)
        Me.label27.TabIndex = 98
        Me.label27.Text = "Código INCRA"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(221, 73)
        Me.label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(57, 15)
        Me.label14.TabIndex = 97
        Me.label14.Text = "Comarca"
        '
        'txtImovel
        '
        Me.txtImovel.Location = New System.Drawing.Point(7, 42)
        Me.txtImovel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtImovel.Name = "txtImovel"
        Me.txtImovel.Size = New System.Drawing.Size(506, 21)
        Me.txtImovel.TabIndex = 0
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(4, 73)
        Me.label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(58, 15)
        Me.label13.TabIndex = 96
        Me.label13.Text = "Matrícula"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(7, 90)
        Me.txtMatricula.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(210, 21)
        Me.txtMatricula.TabIndex = 2
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(517, 42)
        Me.txtMunicipio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(390, 21)
        Me.txtMunicipio.TabIndex = 1
        '
        'ToolStripImo
        '
        Me.ToolStripImo.AutoSize = False
        Me.ToolStripImo.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStripImo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrSaveImo, Me.ToolStrLoadImo, Me.ToolLimparImo})
        Me.ToolStripImo.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripImo.Name = "ToolStripImo"
        Me.ToolStripImo.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripImo.Size = New System.Drawing.Size(1035, 50)
        Me.ToolStripImo.TabIndex = 0
        Me.ToolStripImo.Text = "ToolStrip2"
        '
        'ToolStrSaveImo
        '
        Me.ToolStrSaveImo.Image = CType(resources.GetObject("ToolStrSaveImo.Image"), System.Drawing.Image)
        Me.ToolStrSaveImo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrSaveImo.Name = "ToolStrSaveImo"
        Me.ToolStrSaveImo.Size = New System.Drawing.Size(81, 47)
        Me.ToolStrSaveImo.Tag = ""
        Me.ToolStrSaveImo.Text = "Salvar imóvel"
        Me.ToolStrSaveImo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStrSaveImo.ToolTipText = "Salva num arquivo texto os dados do imóvel."
        '
        'ToolStrLoadImo
        '
        Me.ToolStrLoadImo.Image = CType(resources.GetObject("ToolStrLoadImo.Image"), System.Drawing.Image)
        Me.ToolStrLoadImo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrLoadImo.Name = "ToolStrLoadImo"
        Me.ToolStrLoadImo.Size = New System.Drawing.Size(95, 47)
        Me.ToolStrLoadImo.Tag = ""
        Me.ToolStrLoadImo.Text = "Carregar imóvel"
        Me.ToolStrLoadImo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStrLoadImo.ToolTipText = "Carregar dados do imóvel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de um arquivo previamente salvo."
        '
        'ToolLimparImo
        '
        Me.ToolLimparImo.Image = CType(resources.GetObject("ToolLimparImo.Image"), System.Drawing.Image)
        Me.ToolLimparImo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolLimparImo.Name = "ToolLimparImo"
        Me.ToolLimparImo.Size = New System.Drawing.Size(83, 47)
        Me.ToolLimparImo.Text = "Limpar dados"
        Me.ToolLimparImo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.ToolStripProf)
        Me.TabPage3.Location = New System.Drawing.Point(4, 42)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1041, 575)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Dados do profissional"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Me.label18)
        Me.GroupBox4.Controls.Add(Me.label17)
        Me.GroupBox4.Controls.Add(Me.txtAssinatura)
        Me.GroupBox4.Controls.Add(Me.txtNomeProf)
        Me.GroupBox4.Controls.Add(Me.txtRegistro)
        Me.GroupBox4.Controls.Add(Me.label16)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 176)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1035, 142)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Profissional"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(5, 16)
        Me.label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(115, 15)
        Me.label18.TabIndex = 32
        Me.label18.Text = "Linha de assinatura"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(5, 92)
        Me.label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(53, 15)
        Me.label17.TabIndex = 30
        Me.label17.Text = "Registro"
        '
        'txtAssinatura
        '
        Me.txtAssinatura.Location = New System.Drawing.Point(8, 32)
        Me.txtAssinatura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAssinatura.Name = "txtAssinatura"
        Me.txtAssinatura.Size = New System.Drawing.Size(409, 21)
        Me.txtAssinatura.TabIndex = 5
        Me.txtAssinatura.Text = "____________________________________________"
        '
        'txtNomeProf
        '
        Me.txtNomeProf.Location = New System.Drawing.Point(8, 70)
        Me.txtNomeProf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomeProf.Name = "txtNomeProf"
        Me.txtNomeProf.Size = New System.Drawing.Size(409, 21)
        Me.txtNomeProf.TabIndex = 6
        '
        'txtRegistro
        '
        Me.txtRegistro.Location = New System.Drawing.Point(7, 108)
        Me.txtRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(411, 21)
        Me.txtRegistro.TabIndex = 7
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(5, 54)
        Me.label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(41, 15)
        Me.label16.TabIndex = 30
        Me.label16.Text = "Nome"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox5.Controls.Add(Me.label30)
        Me.GroupBox5.Controls.Add(Me.txtCidade)
        Me.GroupBox5.Controls.Add(Me.txtData)
        Me.GroupBox5.Controls.Add(Me.OptOutra)
        Me.GroupBox5.Controls.Add(Me.optHoje)
        Me.GroupBox5.Controls.Add(Me.chkData)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(3, 53)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1035, 123)
        Me.GroupBox5.TabIndex = 37
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data"
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Location = New System.Drawing.Point(6, 22)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(46, 15)
        Me.label30.TabIndex = 5
        Me.label30.Text = "Cidade"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(52, 19)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(365, 21)
        Me.txtCidade.TabIndex = 0
        '
        'txtData
        '
        Me.txtData.Enabled = False
        Me.txtData.Location = New System.Drawing.Point(63, 90)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(355, 21)
        Me.txtData.TabIndex = 4
        '
        'OptOutra
        '
        Me.OptOutra.AutoSize = True
        Me.OptOutra.Enabled = False
        Me.OptOutra.Location = New System.Drawing.Point(6, 91)
        Me.OptOutra.Name = "OptOutra"
        Me.OptOutra.Size = New System.Drawing.Size(55, 19)
        Me.OptOutra.TabIndex = 3
        Me.OptOutra.Text = "Outra"
        Me.OptOutra.UseVisualStyleBackColor = True
        '
        'optHoje
        '
        Me.optHoje.AutoSize = True
        Me.optHoje.Checked = True
        Me.optHoje.Enabled = False
        Me.optHoje.Location = New System.Drawing.Point(6, 68)
        Me.optHoje.Name = "optHoje"
        Me.optHoje.Size = New System.Drawing.Size(51, 19)
        Me.optHoje.TabIndex = 2
        Me.optHoje.TabStop = True
        Me.optHoje.Text = "Hoje"
        Me.optHoje.UseVisualStyleBackColor = True
        '
        'chkData
        '
        Me.chkData.AutoSize = True
        Me.chkData.Location = New System.Drawing.Point(6, 45)
        Me.chkData.Name = "chkData"
        Me.chkData.Size = New System.Drawing.Size(87, 19)
        Me.chkData.TabIndex = 1
        Me.chkData.Text = "Inserir data"
        Me.chkData.UseVisualStyleBackColor = True
        '
        'ToolStripProf
        '
        Me.ToolStripProf.AutoSize = False
        Me.ToolStripProf.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStripProf.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrBtnSaveProf, Me.ToolStrBtnLoadProf, Me.ToolStrBtnLimpaProf})
        Me.ToolStripProf.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripProf.Name = "ToolStripProf"
        Me.ToolStripProf.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripProf.Size = New System.Drawing.Size(1035, 50)
        Me.ToolStripProf.TabIndex = 39
        Me.ToolStripProf.Text = "ToolStrip2"
        '
        'ToolStrBtnSaveProf
        '
        Me.ToolStrBtnSaveProf.Image = CType(resources.GetObject("ToolStrBtnSaveProf.Image"), System.Drawing.Image)
        Me.ToolStrBtnSaveProf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrBtnSaveProf.Name = "ToolStrBtnSaveProf"
        Me.ToolStrBtnSaveProf.Size = New System.Drawing.Size(144, 47)
        Me.ToolStrBtnSaveProf.Text = "Salvar dados na memória"
        Me.ToolStrBtnSaveProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStrBtnSaveProf.ToolTipText = "Salvar os dados do profissional na memória."
        '
        'ToolStrBtnLoadProf
        '
        Me.ToolStrBtnLoadProf.Image = CType(resources.GetObject("ToolStrBtnLoadProf.Image"), System.Drawing.Image)
        Me.ToolStrBtnLoadProf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrBtnLoadProf.Name = "ToolStrBtnLoadProf"
        Me.ToolStrBtnLoadProf.Size = New System.Drawing.Size(158, 47)
        Me.ToolStrBtnLoadProf.Text = "Carregar dados da memória"
        Me.ToolStrBtnLoadProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStrBtnLoadProf.ToolTipText = "Carregar dados da memória (Caso houver)."
        '
        'ToolStrBtnLimpaProf
        '
        Me.ToolStrBtnLimpaProf.Image = CType(resources.GetObject("ToolStrBtnLimpaProf.Image"), System.Drawing.Image)
        Me.ToolStrBtnLimpaProf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrBtnLimpaProf.Name = "ToolStrBtnLimpaProf"
        Me.ToolStrBtnLimpaProf.Size = New System.Drawing.Size(83, 47)
        Me.ToolStrBtnLimpaProf.Text = "Limpar dados"
        Me.ToolStrBtnLimpaProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStrBtnLimpaProf.ToolTipText = "Carregar dados do profissional de um arquivo previamente salvo."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 42)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1041, 575)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vértices do Imóvel"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1035, 519)
        Me.DataGridView1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripBtnExpCSV, Me.ToolStripBtnExcel, Me.ToolStripSeparator1, Me.ToolStripBtnAdd, Me.ToolStripBtnEdit, Me.ToolStripBtnDel, Me.ToolStripSeparator2, Me.ToolStrAzimute})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1035, 50)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(81, 47)
        Me.ToolStripButton1.Text = "Importar CSV"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton1.ToolTipText = "Importar dados de um arquvo CSV ou texto."
        '
        'ToolStripBtnExpCSV
        '
        Me.ToolStripBtnExpCSV.Enabled = False
        Me.ToolStripBtnExpCSV.Image = CType(resources.GetObject("ToolStripBtnExpCSV.Image"), System.Drawing.Image)
        Me.ToolStripBtnExpCSV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnExpCSV.Name = "ToolStripBtnExpCSV"
        Me.ToolStripBtnExpCSV.Size = New System.Drawing.Size(78, 47)
        Me.ToolStripBtnExpCSV.Text = "Exportar CSV"
        Me.ToolStripBtnExpCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripBtnExpCSV.ToolTipText = "Exportar os dados tabela para um arquivo CSV ou texto"
        '
        'ToolStripBtnExcel
        '
        Me.ToolStripBtnExcel.Image = CType(resources.GetObject("ToolStripBtnExcel.Image"), System.Drawing.Image)
        Me.ToolStripBtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnExcel.Name = "ToolStripBtnExcel"
        Me.ToolStripBtnExcel.Size = New System.Drawing.Size(85, 47)
        Me.ToolStripBtnExcel.Text = "Colar do Excel"
        Me.ToolStripBtnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripBtnExcel.ToolTipText = resources.GetString("ToolStripBtnExcel.ToolTipText")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'ToolStripBtnAdd
        '
        Me.ToolStripBtnAdd.Image = CType(resources.GetObject("ToolStripBtnAdd.Image"), System.Drawing.Image)
        Me.ToolStripBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnAdd.Name = "ToolStripBtnAdd"
        Me.ToolStripBtnAdd.Size = New System.Drawing.Size(62, 47)
        Me.ToolStripBtnAdd.Text = "Adicionar"
        Me.ToolStripBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripBtnAdd.ToolTipText = "Adicionar novo vértice."
        '
        'ToolStripBtnEdit
        '
        Me.ToolStripBtnEdit.Enabled = False
        Me.ToolStripBtnEdit.Image = CType(resources.GetObject("ToolStripBtnEdit.Image"), System.Drawing.Image)
        Me.ToolStripBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnEdit.Name = "ToolStripBtnEdit"
        Me.ToolStripBtnEdit.Size = New System.Drawing.Size(41, 47)
        Me.ToolStripBtnEdit.Text = "Editar"
        Me.ToolStripBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripBtnEdit.ToolTipText = "Editar um vértice da tabela abaixo."
        '
        'ToolStripBtnDel
        '
        Me.ToolStripBtnDel.Enabled = False
        Me.ToolStripBtnDel.Image = CType(resources.GetObject("ToolStripBtnDel.Image"), System.Drawing.Image)
        Me.ToolStripBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnDel.Name = "ToolStripBtnDel"
        Me.ToolStripBtnDel.Size = New System.Drawing.Size(49, 47)
        Me.ToolStripBtnDel.Text = "Apagar"
        Me.ToolStripBtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripBtnDel.ToolTipText = "Apagar um ou mais vértices. É necessário selecionar um ou mais linhas para apagar" & _
    "."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'ToolStrAzimute
        '
        Me.ToolStrAzimute.Image = CType(resources.GetObject("ToolStrAzimute.Image"), System.Drawing.Image)
        Me.ToolStrAzimute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrAzimute.Name = "ToolStrAzimute"
        Me.ToolStrAzimute.Size = New System.Drawing.Size(171, 47)
        Me.ToolStrAzimute.Text = "Calcular Azimutes e Distâncias"
        Me.ToolStrAzimute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.RichTxtMemo)
        Me.TabPage4.Controls.Add(Me.ToolStripMemorial)
        Me.TabPage4.Location = New System.Drawing.Point(4, 42)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1041, 575)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Memorial Descritivo"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'RichTxtMemo
        '
        Me.RichTxtMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTxtMemo.Location = New System.Drawing.Point(3, 53)
        Me.RichTxtMemo.Name = "RichTxtMemo"
        Me.RichTxtMemo.ReadOnly = True
        Me.RichTxtMemo.Size = New System.Drawing.Size(1035, 519)
        Me.RichTxtMemo.TabIndex = 1
        Me.RichTxtMemo.Text = ""
        '
        'ToolStripMemorial
        '
        Me.ToolStripMemorial.AutoSize = False
        Me.ToolStripMemorial.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrBtnGeraMemo, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStripMemorial.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripMemorial.Name = "ToolStripMemorial"
        Me.ToolStripMemorial.Size = New System.Drawing.Size(1035, 50)
        Me.ToolStripMemorial.TabIndex = 0
        Me.ToolStripMemorial.Text = "ToolStrip2"
        '
        'ToolStrBtnGeraMemo
        '
        Me.ToolStrBtnGeraMemo.Image = CType(resources.GetObject("ToolStrBtnGeraMemo.Image"), System.Drawing.Image)
        Me.ToolStrBtnGeraMemo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrBtnGeraMemo.Name = "ToolStrBtnGeraMemo"
        Me.ToolStrBtnGeraMemo.Size = New System.Drawing.Size(93, 47)
        Me.ToolStrBtnGeraMemo.Text = "Gerar Memorial"
        Me.ToolStrBtnGeraMemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStrBtnGeraMemo.ToolTipText = "Gerar Memorial"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(71, 47)
        Me.ToolStripButton3.Text = "Salvar texto"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(184, 47)
        Me.ToolStripButton4.Text = "Copiar para área de transferência"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblVersaoAtual
        '
        Me.lblVersaoAtual.AutoSize = True
        Me.lblVersaoAtual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblVersaoAtual.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblVersaoAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersaoAtual.ForeColor = System.Drawing.Color.Blue
        Me.lblVersaoAtual.Location = New System.Drawing.Point(979, 0)
        Me.lblVersaoAtual.Margin = New System.Windows.Forms.Padding(4, 3, 20, 3)
        Me.lblVersaoAtual.Name = "lblVersaoAtual"
        Me.lblVersaoAtual.Padding = New System.Windows.Forms.Padding(3, 4, 20, 3)
        Me.lblVersaoAtual.Size = New System.Drawing.Size(70, 22)
        Me.lblVersaoAtual.TabIndex = 5
        Me.lblVersaoAtual.Text = "Status"
        '
        'frmImovel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 621)
        Me.Controls.Add(Me.lblVersaoAtual)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmImovel"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumDecPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDecAreaha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDecAream, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStripImo.ResumeLayout(False)
        Me.ToolStripImo.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ToolStripProf.ResumeLayout(False)
        Me.ToolStripProf.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.ToolStripMemorial.ResumeLayout(False)
        Me.ToolStripMemorial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label47 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label27 As System.Windows.Forms.Label
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label42 As System.Windows.Forms.Label
    Private WithEvents label28 As System.Windows.Forms.Label
    Private WithEvents label41 As System.Windows.Forms.Label
    Private WithEvents label38 As System.Windows.Forms.Label
    Private WithEvents label40 As System.Windows.Forms.Label
    Private WithEvents label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents label46 As System.Windows.Forms.Label
    Private WithEvents label45 As System.Windows.Forms.Label
    Private WithEvents label44 As System.Windows.Forms.Label
    Private WithEvents label34 As System.Windows.Forms.Label
    Private WithEvents label36 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripBtnExpCSV As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripBtnExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrAzimute As System.Windows.Forms.ToolStripButton
    Protected Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripBtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripBtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripBtnDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveFileGridCsv As System.Windows.Forms.SaveFileDialog
    Private WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents txtAssinatura As System.Windows.Forms.TextBox
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents label30 As System.Windows.Forms.Label
    Private WithEvents OptOutra As System.Windows.Forms.RadioButton
    Private WithEvents optHoje As System.Windows.Forms.RadioButton
    Private WithEvents chkData As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripImo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrSaveImo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrLoadImo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripProf As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrBtnSaveProf As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrBtnLimpaProf As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolLimparImo As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileImovel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripMemorial As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrBtnGeraMemo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RichTxtMemo As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCartorio As System.Windows.Forms.TextBox
    Friend WithEvents txtCodIncra As System.Windows.Forms.TextBox
    Friend WithEvents txtComarca As System.Windows.Forms.TextBox
    Friend WithEvents txtImovel As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents txtProprietario As System.Windows.Forms.TextBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents txtAreaha As System.Windows.Forms.TextBox
    Friend WithEvents txtPerimetro As System.Windows.Forms.TextBox
    Friend WithEvents cboFuso As System.Windows.Forms.ComboBox
    Friend WithEvents cboMC As System.Windows.Forms.ComboBox
    Friend WithEvents cboLongitude As System.Windows.Forms.ComboBox
    Friend WithEvents cboHemisferio As System.Windows.Forms.ComboBox
    Friend WithEvents txtDatum As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeProf As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistro As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents lblVersaoAtual As System.Windows.Forms.Label
    Friend WithEvents chkArea As System.Windows.Forms.CheckBox
    Friend WithEvents chkPer As System.Windows.Forms.CheckBox
    Friend WithEvents chkAreaha As System.Windows.Forms.CheckBox
    Friend WithEvents NumDecPer As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumDecAreaha As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumDecAream As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStrBtnLoadProf As System.Windows.Forms.ToolStripButton
End Class
