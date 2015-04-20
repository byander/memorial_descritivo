<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefMemorial
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label43 = New System.Windows.Forms.Label()
        Me.chkRepeticao = New System.Windows.Forms.CheckBox()
        Me.txtDivisa = New System.Windows.Forms.TextBox()
        Me.label35 = New System.Windows.Forms.Label()
        Me.txtConfronto = New System.Windows.Forms.TextBox()
        Me.label29 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtFim = New System.Windows.Forms.TextBox()
        Me.txtLigacao = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtDist = New System.Windows.Forms.TextBox()
        Me.txtNorte = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtAzimute = New System.Windows.Forms.TextBox()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtEste = New System.Windows.Forms.TextBox()
        Me.txtCoord = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkNReg = New System.Windows.Forms.CheckBox()
        Me.chkNNom = New System.Windows.Forms.CheckBox()
        Me.chkNDat = New System.Windows.Forms.CheckBox()
        Me.chkNCid = New System.Windows.Forms.CheckBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkNDiv = New System.Windows.Forms.CheckBox()
        Me.chkNPto = New System.Windows.Forms.CheckBox()
        Me.chkNCoo = New System.Windows.Forms.CheckBox()
        Me.chkNDis = New System.Windows.Forms.CheckBox()
        Me.chkNAzi = New System.Windows.Forms.CheckBox()
        Me.chkNCon = New System.Windows.Forms.CheckBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkNCar = New System.Windows.Forms.CheckBox()
        Me.chkNCarV = New System.Windows.Forms.CheckBox()
        Me.chkNTit = New System.Windows.Forms.CheckBox()
        Me.chkNImo = New System.Windows.Forms.CheckBox()
        Me.chkNImoV = New System.Windows.Forms.CheckBox()
        Me.chkNMun = New System.Windows.Forms.CheckBox()
        Me.chkNMunV = New System.Windows.Forms.CheckBox()
        Me.chkNMat = New System.Windows.Forms.CheckBox()
        Me.chkNProV = New System.Windows.Forms.CheckBox()
        Me.chkNMatV = New System.Windows.Forms.CheckBox()
        Me.chkNPro = New System.Windows.Forms.CheckBox()
        Me.chkNCom = New System.Windows.Forms.CheckBox()
        Me.chkNPerV = New System.Windows.Forms.CheckBox()
        Me.chkNComV = New System.Windows.Forms.CheckBox()
        Me.chkNPer = New System.Windows.Forms.CheckBox()
        Me.chkNInc = New System.Windows.Forms.CheckBox()
        Me.chkNAreV = New System.Windows.Forms.CheckBox()
        Me.chkNIncV = New System.Windows.Forms.CheckBox()
        Me.chkNAre = New System.Windows.Forms.CheckBox()
        Me.BtnSalvaDef = New System.Windows.Forms.Button()
        Me.BtnCancelaFormato = New System.Windows.Forms.Button()
        Me.BtnValorPadrao = New System.Windows.Forms.Button()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.TimerLblStatus = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(100, 30)
        Me.TabControl1.Location = New System.Drawing.Point(8, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(769, 443)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(761, 405)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Textos de ligação"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.label43)
        Me.GroupBox1.Controls.Add(Me.chkRepeticao)
        Me.GroupBox1.Controls.Add(Me.txtDivisa)
        Me.GroupBox1.Controls.Add(Me.label35)
        Me.GroupBox1.Controls.Add(Me.txtConfronto)
        Me.GroupBox1.Controls.Add(Me.label29)
        Me.GroupBox1.Controls.Add(Me.txtTitulo)
        Me.GroupBox1.Controls.Add(Me.label9)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.txtUnidade)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.txtFim)
        Me.GroupBox1.Controls.Add(Me.txtLigacao)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.txtDist)
        Me.GroupBox1.Controls.Add(Me.txtNorte)
        Me.GroupBox1.Controls.Add(Me.label15)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.txtAzimute)
        Me.GroupBox1.Controls.Add(Me.txtInicio)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.txtEste)
        Me.GroupBox1.Controls.Add(Me.txtCoord)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 396)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Definição dos textos de ligação"
        '
        'label43
        '
        Me.label43.AutoSize = True
        Me.label43.Location = New System.Drawing.Point(12, 292)
        Me.label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label43.Name = "label43"
        Me.label43.Size = New System.Drawing.Size(228, 15)
        Me.label43.TabIndex = 61
        Me.label43.Text = "Ocultar confrontante e divisa consecutivo"
        '
        'chkRepeticao
        '
        Me.chkRepeticao.Location = New System.Drawing.Point(16, 312)
        Me.chkRepeticao.Name = "chkRepeticao"
        Me.chkRepeticao.Size = New System.Drawing.Size(495, 28)
        Me.chkRepeticao.TabIndex = 11
        Me.chkRepeticao.Text = "Se confrontante e tipo de divisa for consecutivo, é exibido uma única vez."
        Me.chkRepeticao.UseVisualStyleBackColor = True
        '
        'txtDivisa
        '
        Me.txtDivisa.Location = New System.Drawing.Point(457, 257)
        Me.txtDivisa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDivisa.Name = "txtDivisa"
        Me.txtDivisa.Size = New System.Drawing.Size(280, 21)
        Me.txtDivisa.TabIndex = 10
        Me.txtDivisa.Text = "segue por"
        '
        'label35
        '
        Me.label35.AutoSize = True
        Me.label35.Location = New System.Drawing.Point(455, 240)
        Me.label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(65, 15)
        Me.label35.TabIndex = 60
        Me.label35.Text = "Tipo divisa"
        '
        'txtConfronto
        '
        Me.txtConfronto.Location = New System.Drawing.Point(13, 257)
        Me.txtConfronto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConfronto.Name = "txtConfronto"
        Me.txtConfronto.Size = New System.Drawing.Size(436, 21)
        Me.txtConfronto.TabIndex = 9
        Me.txtConfronto.Text = "confrontando com terras de"
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.Location = New System.Drawing.Point(10, 240)
        Me.label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(77, 15)
        Me.label29.TabIndex = 59
        Me.label29.Text = "Confrontante"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(13, 42)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(436, 21)
        Me.txtTitulo.TabIndex = 0
        Me.txtTitulo.Text = "Memorial descritivo"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(10, 24)
        Me.label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(37, 15)
        Me.label9.TabIndex = 57
        Me.label9.Text = "Título"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(10, 77)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 15)
        Me.label1.TabIndex = 36
        Me.label1.Text = "Texto inicial"
        '
        'txtUnidade
        '
        Me.txtUnidade.Location = New System.Drawing.Point(439, 200)
        Me.txtUnidade.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(119, 21)
        Me.txtUnidade.TabIndex = 8
        Me.txtUnidade.Text = "m"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(299, 131)
        Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(51, 15)
        Me.label5.TabIndex = 47
        Me.label5.Text = "Ligação"
        '
        'txtFim
        '
        Me.txtFim.Location = New System.Drawing.Point(13, 360)
        Me.txtFim.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFim.Name = "txtFim"
        Me.txtFim.Size = New System.Drawing.Size(436, 21)
        Me.txtFim.TabIndex = 12
        Me.txtFim.Text = "encerrando este perímetro."
        '
        'txtLigacao
        '
        Me.txtLigacao.Location = New System.Drawing.Point(302, 149)
        Me.txtLigacao.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLigacao.Name = "txtLigacao"
        Me.txtLigacao.Size = New System.Drawing.Size(436, 21)
        Me.txtLigacao.TabIndex = 5
        Me.txtLigacao.Text = "até o vértice"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(435, 182)
        Me.label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(106, 15)
        Me.label8.TabIndex = 56
        Me.label8.Text = "Unidade distância"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(143, 127)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(41, 15)
        Me.label4.TabIndex = 44
        Me.label4.Text = "Tipo Y"
        '
        'txtDist
        '
        Me.txtDist.Location = New System.Drawing.Point(250, 200)
        Me.txtDist.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDist.Name = "txtDist"
        Me.txtDist.Size = New System.Drawing.Size(184, 21)
        Me.txtDist.TabIndex = 7
        Me.txtDist.Text = "e distância de"
        '
        'txtNorte
        '
        Me.txtNorte.Location = New System.Drawing.Point(143, 149)
        Me.txtNorte.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNorte.Name = "txtNorte"
        Me.txtNorte.Size = New System.Drawing.Size(123, 21)
        Me.txtNorte.TabIndex = 4
        Me.txtNorte.Text = "N:"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(10, 343)
        Me.label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(71, 15)
        Me.label15.TabIndex = 58
        Me.label15.Text = "Encerrando"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(13, 182)
        Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(51, 15)
        Me.label6.TabIndex = 51
        Me.label6.Text = "Azimute"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(246, 182)
        Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(58, 15)
        Me.label7.TabIndex = 53
        Me.label7.Text = "Distância"
        '
        'txtAzimute
        '
        Me.txtAzimute.Location = New System.Drawing.Point(13, 200)
        Me.txtAzimute.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAzimute.Name = "txtAzimute"
        Me.txtAzimute.Size = New System.Drawing.Size(226, 21)
        Me.txtAzimute.TabIndex = 6
        Me.txtAzimute.Text = "com azimute"
        '
        'txtInicio
        '
        Me.txtInicio.Location = New System.Drawing.Point(13, 97)
        Me.txtInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(436, 21)
        Me.txtInicio.TabIndex = 1
        Me.txtInicio.Text = "Inicia-se a descrição deste perímetro no vértice"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 131)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(42, 15)
        Me.label3.TabIndex = 42
        Me.label3.Text = "Tipo X"
        '
        'txtEste
        '
        Me.txtEste.Location = New System.Drawing.Point(13, 149)
        Me.txtEste.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEste.Name = "txtEste"
        Me.txtEste.Size = New System.Drawing.Size(123, 21)
        Me.txtEste.TabIndex = 3
        Me.txtEste.Text = "E:"
        '
        'txtCoord
        '
        Me.txtCoord.Location = New System.Drawing.Point(455, 97)
        Me.txtCoord.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCoord.Name = "txtCoord"
        Me.txtCoord.Size = New System.Drawing.Size(283, 21)
        Me.txtCoord.TabIndex = 2
        Me.txtCoord.Text = "definido pelas coordenadas"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(451, 77)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(81, 15)
        Me.label2.TabIndex = 38
        Me.label2.Text = "Coordenadas"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.groupBox4)
        Me.TabPage2.Controls.Add(Me.groupBox3)
        Me.TabPage2.Controls.Add(Me.groupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(761, 405)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Negritos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'groupBox4
        '
        Me.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.groupBox4.Controls.Add(Me.chkNReg)
        Me.groupBox4.Controls.Add(Me.chkNNom)
        Me.groupBox4.Controls.Add(Me.chkNDat)
        Me.groupBox4.Controls.Add(Me.chkNCid)
        Me.groupBox4.Location = New System.Drawing.Point(568, 6)
        Me.groupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox4.Size = New System.Drawing.Size(183, 305)
        Me.groupBox4.TabIndex = 25
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Cidade, data e assinatura"
        '
        'chkNReg
        '
        Me.chkNReg.AutoSize = True
        Me.chkNReg.Checked = True
        Me.chkNReg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNReg.Location = New System.Drawing.Point(22, 138)
        Me.chkNReg.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNReg.Name = "chkNReg"
        Me.chkNReg.Size = New System.Drawing.Size(72, 19)
        Me.chkNReg.TabIndex = 28
        Me.chkNReg.Text = "Registro"
        Me.chkNReg.UseVisualStyleBackColor = True
        '
        'chkNNom
        '
        Me.chkNNom.AutoSize = True
        Me.chkNNom.Checked = True
        Me.chkNNom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNNom.Location = New System.Drawing.Point(22, 114)
        Me.chkNNom.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNNom.Name = "chkNNom"
        Me.chkNNom.Size = New System.Drawing.Size(60, 19)
        Me.chkNNom.TabIndex = 27
        Me.chkNNom.Text = "Nome"
        Me.chkNNom.UseVisualStyleBackColor = True
        '
        'chkNDat
        '
        Me.chkNDat.AutoSize = True
        Me.chkNDat.Location = New System.Drawing.Point(22, 90)
        Me.chkNDat.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNDat.Name = "chkNDat"
        Me.chkNDat.Size = New System.Drawing.Size(52, 19)
        Me.chkNDat.TabIndex = 26
        Me.chkNDat.Text = "Data"
        Me.chkNDat.UseVisualStyleBackColor = True
        '
        'chkNCid
        '
        Me.chkNCid.AutoSize = True
        Me.chkNCid.Location = New System.Drawing.Point(22, 66)
        Me.chkNCid.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNCid.Name = "chkNCid"
        Me.chkNCid.Size = New System.Drawing.Size(65, 19)
        Me.chkNCid.TabIndex = 25
        Me.chkNCid.Text = "Cidade"
        Me.chkNCid.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.groupBox3.Controls.Add(Me.chkNDiv)
        Me.groupBox3.Controls.Add(Me.chkNPto)
        Me.groupBox3.Controls.Add(Me.chkNCoo)
        Me.groupBox3.Controls.Add(Me.chkNDis)
        Me.groupBox3.Controls.Add(Me.chkNAzi)
        Me.groupBox3.Controls.Add(Me.chkNCon)
        Me.groupBox3.Location = New System.Drawing.Point(369, 6)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox3.Size = New System.Drawing.Size(183, 305)
        Me.groupBox3.TabIndex = 24
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Memorial"
        '
        'chkNDiv
        '
        Me.chkNDiv.AutoSize = True
        Me.chkNDiv.Checked = True
        Me.chkNDiv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNDiv.Location = New System.Drawing.Point(19, 166)
        Me.chkNDiv.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNDiv.Name = "chkNDiv"
        Me.chkNDiv.Size = New System.Drawing.Size(84, 19)
        Me.chkNDiv.TabIndex = 24
        Me.chkNDiv.Text = "Tipo divisa"
        Me.chkNDiv.UseVisualStyleBackColor = True
        '
        'chkNPto
        '
        Me.chkNPto.AutoSize = True
        Me.chkNPto.Checked = True
        Me.chkNPto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNPto.Location = New System.Drawing.Point(19, 42)
        Me.chkNPto.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNPto.Name = "chkNPto"
        Me.chkNPto.Size = New System.Drawing.Size(58, 19)
        Me.chkNPto.TabIndex = 19
        Me.chkNPto.Text = "Ponto"
        Me.chkNPto.UseVisualStyleBackColor = True
        '
        'chkNCoo
        '
        Me.chkNCoo.AutoSize = True
        Me.chkNCoo.Checked = True
        Me.chkNCoo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNCoo.Location = New System.Drawing.Point(19, 66)
        Me.chkNCoo.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNCoo.Name = "chkNCoo"
        Me.chkNCoo.Size = New System.Drawing.Size(100, 19)
        Me.chkNCoo.TabIndex = 20
        Me.chkNCoo.Text = "Coordenadas"
        Me.chkNCoo.UseVisualStyleBackColor = True
        '
        'chkNDis
        '
        Me.chkNDis.AutoSize = True
        Me.chkNDis.Checked = True
        Me.chkNDis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNDis.Location = New System.Drawing.Point(19, 91)
        Me.chkNDis.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNDis.Name = "chkNDis"
        Me.chkNDis.Size = New System.Drawing.Size(77, 19)
        Me.chkNDis.TabIndex = 21
        Me.chkNDis.Text = "Distância"
        Me.chkNDis.UseVisualStyleBackColor = True
        '
        'chkNAzi
        '
        Me.chkNAzi.AutoSize = True
        Me.chkNAzi.Checked = True
        Me.chkNAzi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNAzi.Location = New System.Drawing.Point(19, 117)
        Me.chkNAzi.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNAzi.Name = "chkNAzi"
        Me.chkNAzi.Size = New System.Drawing.Size(70, 19)
        Me.chkNAzi.TabIndex = 22
        Me.chkNAzi.Text = "Azimute"
        Me.chkNAzi.UseVisualStyleBackColor = True
        '
        'chkNCon
        '
        Me.chkNCon.AutoSize = True
        Me.chkNCon.Checked = True
        Me.chkNCon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNCon.Location = New System.Drawing.Point(19, 142)
        Me.chkNCon.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNCon.Name = "chkNCon"
        Me.chkNCon.Size = New System.Drawing.Size(96, 19)
        Me.chkNCon.TabIndex = 23
        Me.chkNCon.Text = "Confrontante"
        Me.chkNCon.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.groupBox2.Controls.Add(Me.chkNCar)
        Me.groupBox2.Controls.Add(Me.chkNCarV)
        Me.groupBox2.Controls.Add(Me.chkNTit)
        Me.groupBox2.Controls.Add(Me.chkNImo)
        Me.groupBox2.Controls.Add(Me.chkNImoV)
        Me.groupBox2.Controls.Add(Me.chkNMun)
        Me.groupBox2.Controls.Add(Me.chkNMunV)
        Me.groupBox2.Controls.Add(Me.chkNMat)
        Me.groupBox2.Controls.Add(Me.chkNProV)
        Me.groupBox2.Controls.Add(Me.chkNMatV)
        Me.groupBox2.Controls.Add(Me.chkNPro)
        Me.groupBox2.Controls.Add(Me.chkNCom)
        Me.groupBox2.Controls.Add(Me.chkNPerV)
        Me.groupBox2.Controls.Add(Me.chkNComV)
        Me.groupBox2.Controls.Add(Me.chkNPer)
        Me.groupBox2.Controls.Add(Me.chkNInc)
        Me.groupBox2.Controls.Add(Me.chkNAreV)
        Me.groupBox2.Controls.Add(Me.chkNIncV)
        Me.groupBox2.Controls.Add(Me.chkNAre)
        Me.groupBox2.Location = New System.Drawing.Point(8, 6)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox2.Size = New System.Drawing.Size(344, 305)
        Me.groupBox2.TabIndex = 23
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Título e cabeçalho"
        '
        'chkNCar
        '
        Me.chkNCar.AutoSize = True
        Me.chkNCar.Checked = True
        Me.chkNCar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNCar.Location = New System.Drawing.Point(16, 168)
        Me.chkNCar.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNCar.Name = "chkNCar"
        Me.chkNCar.Size = New System.Drawing.Size(69, 19)
        Me.chkNCar.TabIndex = 9
        Me.chkNCar.Text = "Cartório"
        Me.chkNCar.UseVisualStyleBackColor = True
        '
        'chkNCarV
        '
        Me.chkNCarV.AutoSize = True
        Me.chkNCarV.Location = New System.Drawing.Point(171, 168)
        Me.chkNCarV.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNCarV.Name = "chkNCarV"
        Me.chkNCarV.Size = New System.Drawing.Size(98, 19)
        Me.chkNCarV.TabIndex = 10
        Me.chkNCarV.Text = "Valor cartório"
        Me.chkNCarV.UseVisualStyleBackColor = True
        '
        'chkNTit
        '
        Me.chkNTit.AutoSize = True
        Me.chkNTit.Checked = True
        Me.chkNTit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNTit.Location = New System.Drawing.Point(16, 42)
        Me.chkNTit.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNTit.Name = "chkNTit"
        Me.chkNTit.Size = New System.Drawing.Size(56, 19)
        Me.chkNTit.TabIndex = 0
        Me.chkNTit.Text = "Título"
        Me.chkNTit.UseVisualStyleBackColor = True
        '
        'chkNImo
        '
        Me.chkNImo.AutoSize = True
        Me.chkNImo.Checked = True
        Me.chkNImo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNImo.Location = New System.Drawing.Point(16, 67)
        Me.chkNImo.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNImo.Name = "chkNImo"
        Me.chkNImo.Size = New System.Drawing.Size(62, 19)
        Me.chkNImo.TabIndex = 1
        Me.chkNImo.Text = "Imóvel"
        Me.chkNImo.UseVisualStyleBackColor = True
        '
        'chkNImoV
        '
        Me.chkNImoV.AutoSize = True
        Me.chkNImoV.Location = New System.Drawing.Point(171, 67)
        Me.chkNImoV.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNImoV.Name = "chkNImoV"
        Me.chkNImoV.Size = New System.Drawing.Size(93, 19)
        Me.chkNImoV.TabIndex = 2
        Me.chkNImoV.Text = "Valor imóvel"
        Me.chkNImoV.UseVisualStyleBackColor = True
        '
        'chkNMun
        '
        Me.chkNMun.AutoSize = True
        Me.chkNMun.Checked = True
        Me.chkNMun.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNMun.Location = New System.Drawing.Point(16, 92)
        Me.chkNMun.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNMun.Name = "chkNMun"
        Me.chkNMun.Size = New System.Drawing.Size(80, 19)
        Me.chkNMun.TabIndex = 3
        Me.chkNMun.Text = "Município"
        Me.chkNMun.UseVisualStyleBackColor = True
        '
        'chkNMunV
        '
        Me.chkNMunV.AutoSize = True
        Me.chkNMunV.Location = New System.Drawing.Point(171, 92)
        Me.chkNMunV.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNMunV.Name = "chkNMunV"
        Me.chkNMunV.Size = New System.Drawing.Size(111, 19)
        Me.chkNMunV.TabIndex = 4
        Me.chkNMunV.Text = "Valor município"
        Me.chkNMunV.UseVisualStyleBackColor = True
        '
        'chkNMat
        '
        Me.chkNMat.AutoSize = True
        Me.chkNMat.Checked = True
        Me.chkNMat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNMat.Location = New System.Drawing.Point(16, 118)
        Me.chkNMat.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNMat.Name = "chkNMat"
        Me.chkNMat.Size = New System.Drawing.Size(77, 19)
        Me.chkNMat.TabIndex = 5
        Me.chkNMat.Text = "Matrícula"
        Me.chkNMat.UseVisualStyleBackColor = True
        '
        'chkNProV
        '
        Me.chkNProV.AutoSize = True
        Me.chkNProV.Location = New System.Drawing.Point(171, 270)
        Me.chkNProV.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNProV.Name = "chkNProV"
        Me.chkNProV.Size = New System.Drawing.Size(120, 19)
        Me.chkNProV.TabIndex = 18
        Me.chkNProV.Text = "Valor proprietário"
        Me.chkNProV.UseVisualStyleBackColor = True
        '
        'chkNMatV
        '
        Me.chkNMatV.AutoSize = True
        Me.chkNMatV.Location = New System.Drawing.Point(171, 118)
        Me.chkNMatV.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNMatV.Name = "chkNMatV"
        Me.chkNMatV.Size = New System.Drawing.Size(108, 19)
        Me.chkNMatV.TabIndex = 6
        Me.chkNMatV.Text = "Valor matrícula"
        Me.chkNMatV.UseVisualStyleBackColor = True
        '
        'chkNPro
        '
        Me.chkNPro.AutoSize = True
        Me.chkNPro.Checked = True
        Me.chkNPro.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNPro.Location = New System.Drawing.Point(16, 270)
        Me.chkNPro.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNPro.Name = "chkNPro"
        Me.chkNPro.Size = New System.Drawing.Size(90, 19)
        Me.chkNPro.TabIndex = 17
        Me.chkNPro.Text = "Proprietário"
        Me.chkNPro.UseVisualStyleBackColor = True
        '
        'chkNCom
        '
        Me.chkNCom.AutoSize = True
        Me.chkNCom.Checked = True
        Me.chkNCom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNCom.Location = New System.Drawing.Point(16, 143)
        Me.chkNCom.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNCom.Name = "chkNCom"
        Me.chkNCom.Size = New System.Drawing.Size(76, 19)
        Me.chkNCom.TabIndex = 7
        Me.chkNCom.Text = "Comarca"
        Me.chkNCom.UseVisualStyleBackColor = True
        '
        'chkNPerV
        '
        Me.chkNPerV.AutoSize = True
        Me.chkNPerV.Location = New System.Drawing.Point(171, 245)
        Me.chkNPerV.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNPerV.Name = "chkNPerV"
        Me.chkNPerV.Size = New System.Drawing.Size(110, 19)
        Me.chkNPerV.TabIndex = 16
        Me.chkNPerV.Text = "Valor perímetro"
        Me.chkNPerV.UseVisualStyleBackColor = True
        '
        'chkNComV
        '
        Me.chkNComV.AutoSize = True
        Me.chkNComV.Location = New System.Drawing.Point(171, 143)
        Me.chkNComV.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNComV.Name = "chkNComV"
        Me.chkNComV.Size = New System.Drawing.Size(105, 19)
        Me.chkNComV.TabIndex = 8
        Me.chkNComV.Text = "Valor comarca"
        Me.chkNComV.UseVisualStyleBackColor = True
        '
        'chkNPer
        '
        Me.chkNPer.AutoSize = True
        Me.chkNPer.Checked = True
        Me.chkNPer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNPer.Location = New System.Drawing.Point(16, 245)
        Me.chkNPer.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNPer.Name = "chkNPer"
        Me.chkNPer.Size = New System.Drawing.Size(80, 19)
        Me.chkNPer.TabIndex = 15
        Me.chkNPer.Text = "Perímetro"
        Me.chkNPer.UseVisualStyleBackColor = True
        '
        'chkNInc
        '
        Me.chkNInc.AutoSize = True
        Me.chkNInc.Checked = True
        Me.chkNInc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNInc.Location = New System.Drawing.Point(16, 194)
        Me.chkNInc.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNInc.Name = "chkNInc"
        Me.chkNInc.Size = New System.Drawing.Size(95, 19)
        Me.chkNInc.TabIndex = 11
        Me.chkNInc.Text = "Código Incra"
        Me.chkNInc.UseVisualStyleBackColor = True
        '
        'chkNAreV
        '
        Me.chkNAreV.AutoSize = True
        Me.chkNAreV.Location = New System.Drawing.Point(171, 219)
        Me.chkNAreV.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNAreV.Name = "chkNAreV"
        Me.chkNAreV.Size = New System.Drawing.Size(82, 19)
        Me.chkNAreV.TabIndex = 14
        Me.chkNAreV.Text = "Valor área"
        Me.chkNAreV.UseVisualStyleBackColor = True
        '
        'chkNIncV
        '
        Me.chkNIncV.AutoSize = True
        Me.chkNIncV.Location = New System.Drawing.Point(171, 194)
        Me.chkNIncV.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNIncV.Name = "chkNIncV"
        Me.chkNIncV.Size = New System.Drawing.Size(124, 19)
        Me.chkNIncV.TabIndex = 12
        Me.chkNIncV.Text = "Valor código Incra"
        Me.chkNIncV.UseVisualStyleBackColor = True
        '
        'chkNAre
        '
        Me.chkNAre.AutoSize = True
        Me.chkNAre.Checked = True
        Me.chkNAre.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNAre.Location = New System.Drawing.Point(16, 219)
        Me.chkNAre.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNAre.Name = "chkNAre"
        Me.chkNAre.Size = New System.Drawing.Size(51, 19)
        Me.chkNAre.TabIndex = 13
        Me.chkNAre.Text = "Área"
        Me.chkNAre.UseVisualStyleBackColor = True
        '
        'BtnSalvaDef
        '
        Me.BtnSalvaDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvaDef.Location = New System.Drawing.Point(489, 472)
        Me.BtnSalvaDef.Name = "BtnSalvaDef"
        Me.BtnSalvaDef.Size = New System.Drawing.Size(87, 52)
        Me.BtnSalvaDef.TabIndex = 13
        Me.BtnSalvaDef.Text = "Salvar"
        Me.BtnSalvaDef.UseVisualStyleBackColor = True
        '
        'BtnCancelaFormato
        '
        Me.BtnCancelaFormato.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelaFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelaFormato.Location = New System.Drawing.Point(678, 472)
        Me.BtnCancelaFormato.Name = "BtnCancelaFormato"
        Me.BtnCancelaFormato.Size = New System.Drawing.Size(87, 52)
        Me.BtnCancelaFormato.TabIndex = 15
        Me.BtnCancelaFormato.Text = "Fechar"
        Me.BtnCancelaFormato.UseVisualStyleBackColor = True
        '
        'BtnValorPadrao
        '
        Me.BtnValorPadrao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValorPadrao.Location = New System.Drawing.Point(583, 472)
        Me.BtnValorPadrao.Name = "BtnValorPadrao"
        Me.BtnValorPadrao.Size = New System.Drawing.Size(87, 52)
        Me.BtnValorPadrao.TabIndex = 14
        Me.BtnValorPadrao.Text = "Valores Padrão"
        Me.BtnValorPadrao.UseVisualStyleBackColor = True
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.ForeColor = System.Drawing.Color.Green
        Me.LblStatus.Location = New System.Drawing.Point(5, 489)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(215, 15)
        Me.LblStatus.TabIndex = 16
        Me.LblStatus.Text = "Informações salvas na memória."
        Me.LblStatus.Visible = False
        '
        'TimerLblStatus
        '
        Me.TimerLblStatus.Enabled = True
        Me.TimerLblStatus.Interval = 5000
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(496, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Esta tela permite que você defina os textos de ligação do Memorial e o partes em " & _
    "Negrito."
        '
        'frmDefMemorial
        '
        Me.AcceptButton = Me.BtnSalvaDef
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnCancelaFormato
        Me.ClientSize = New System.Drawing.Size(769, 527)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.BtnValorPadrao)
        Me.Controls.Add(Me.BtnSalvaDef)
        Me.Controls.Add(Me.BtnCancelaFormato)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(785, 565)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(785, 565)
        Me.Name = "frmDefMemorial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definições do Memorial Descritivo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label43 As System.Windows.Forms.Label
    Private WithEvents chkRepeticao As System.Windows.Forms.CheckBox
    Private WithEvents txtDivisa As System.Windows.Forms.TextBox
    Private WithEvents label35 As System.Windows.Forms.Label
    Private WithEvents txtConfronto As System.Windows.Forms.TextBox
    Private WithEvents label29 As System.Windows.Forms.Label
    Private WithEvents txtTitulo As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtUnidade As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtFim As System.Windows.Forms.TextBox
    Private WithEvents txtLigacao As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtDist As System.Windows.Forms.TextBox
    Private WithEvents txtNorte As System.Windows.Forms.TextBox
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txtAzimute As System.Windows.Forms.TextBox
    Private WithEvents txtInicio As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtEste As System.Windows.Forms.TextBox
    Private WithEvents txtCoord As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents chkNReg As System.Windows.Forms.CheckBox
    Private WithEvents chkNNom As System.Windows.Forms.CheckBox
    Private WithEvents chkNDat As System.Windows.Forms.CheckBox
    Private WithEvents chkNCid As System.Windows.Forms.CheckBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents chkNDiv As System.Windows.Forms.CheckBox
    Private WithEvents chkNPto As System.Windows.Forms.CheckBox
    Private WithEvents chkNCoo As System.Windows.Forms.CheckBox
    Private WithEvents chkNDis As System.Windows.Forms.CheckBox
    Private WithEvents chkNAzi As System.Windows.Forms.CheckBox
    Private WithEvents chkNCon As System.Windows.Forms.CheckBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents chkNCar As System.Windows.Forms.CheckBox
    Private WithEvents chkNCarV As System.Windows.Forms.CheckBox
    Private WithEvents chkNTit As System.Windows.Forms.CheckBox
    Private WithEvents chkNImo As System.Windows.Forms.CheckBox
    Private WithEvents chkNImoV As System.Windows.Forms.CheckBox
    Private WithEvents chkNMun As System.Windows.Forms.CheckBox
    Private WithEvents chkNMunV As System.Windows.Forms.CheckBox
    Private WithEvents chkNMat As System.Windows.Forms.CheckBox
    Private WithEvents chkNProV As System.Windows.Forms.CheckBox
    Private WithEvents chkNMatV As System.Windows.Forms.CheckBox
    Private WithEvents chkNPro As System.Windows.Forms.CheckBox
    Private WithEvents chkNCom As System.Windows.Forms.CheckBox
    Private WithEvents chkNPerV As System.Windows.Forms.CheckBox
    Private WithEvents chkNComV As System.Windows.Forms.CheckBox
    Private WithEvents chkNPer As System.Windows.Forms.CheckBox
    Private WithEvents chkNInc As System.Windows.Forms.CheckBox
    Private WithEvents chkNAreV As System.Windows.Forms.CheckBox
    Private WithEvents chkNIncV As System.Windows.Forms.CheckBox
    Private WithEvents chkNAre As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSalvaDef As System.Windows.Forms.Button
    Friend WithEvents BtnCancelaFormato As System.Windows.Forms.Button
    Friend WithEvents BtnValorPadrao As System.Windows.Forms.Button
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents TimerLblStatus As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
