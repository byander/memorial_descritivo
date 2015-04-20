Imports System.IO
Imports System.Text
Imports memorial_v2.funcoes

Imports System.Globalization
Imports System.Threading

Public Class frmImovel

    'Variáveis Globais
    Dim arquivo, nome_arquivo As String
    Dim codificacao As System.Text.Encoding = Nothing
    Dim dt As New DataTable()

    Public valorvertice2, valorconfrontante, valordivisa As String
    Dim valoreste, valornorte As Double

    'Variáveis de área e perímetro
    Public Shared Property Aream2() As Double
        Get
            Return m_Aream2
        End Get
        Set(value As Double)
            m_Aream2 = Value
        End Set
    End Property
    Public Shared m_Aream2 As Double

    Public Shared Property per() As Double
        Get
            Return m_per
        End Get
        Set(value As Double)
            m_per = Value
        End Set
    End Property
    Public Shared m_per As Double

    Private Sub frmImovel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Configurações regionais
        Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")

        'Versão no Label
        lblVersaoAtual.Text = "Há nova versão disponível. Clique aqui para download."
        lblVersaoAtual.Text = lblVersaoAtual.Text & vbNewLine & "Sua versão: " & frmPai.ProductVersion


        Me.ControlBox = False
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()

        'criando as colunas
        With dt
            .Columns.Add(New Data.DataColumn("Vértice", GetType(String)))
            .Columns.Add(New Data.DataColumn("Este", GetType(Double)))
            .Columns.Add(New Data.DataColumn("Norte", GetType(Double)))
            .Columns.Add(New Data.DataColumn("Distância", GetType(Double)))
            .Columns.Add(New Data.DataColumn("Azimute", GetType(String)))
            .Columns.Add(New Data.DataColumn("Confrontante", GetType(String)))
            .Columns.Add(New Data.DataColumn("Divisa", GetType(String)))

            'Deixando colunas bloqueadas para edição
            .Columns("Este").ReadOnly = True
            .Columns("Norte").ReadOnly = True
            .Columns("Distância").ReadOnly = True
            .Columns("Azimute").ReadOnly = True
        End With

        DataGridView1.DataSource = dt

        'Colorir os botões do ToolStrip diferente
        Dim t As MyColorTable = New MyColorTable
        ToolStripImo.Renderer = New ToolStripProfessionalRenderer(t)
        ToolStripProf.Renderer = New ToolStripProfessionalRenderer(t)
        ToolStrip1.Renderer = New ToolStripProfessionalRenderer(t)
        ToolStripMemorial.Renderer = New ToolStripProfessionalRenderer(t)

        'Carregar dados do profissional que podem existir na memória
        txtCidade.Text = My.Settings.Pcidade
        txtNomeProf.Text = My.Settings.Pprofissional
        txtRegistro.Text = My.Settings.Pregistro
        If My.Settings.Pdata <> "" Then
            chkData.Checked = True
            If My.Settings.Pdata = Now.Date Then
                optHoje.Checked = True
            Else
                OptOutra.Checked = True
            End If
            txtData.Text = My.Settings.Pdata
        ElseIf My.Settings.Pdata = "" Then
            txtData.Text = ""
        End If
    End Sub

    'Botão Importar CSV
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        With OpenFileDialog1
            .Filter = "Arquivo CSV (*.csv)|*.csv|Arquivo TXT (*.txt)|*.txt"
            .FileName = ""
            .Title = "Importar Vértices..."
            .RestoreDirectory = True
        End With

        Dim result As DialogResult = OpenFileDialog1.ShowDialog
        If (result = DialogResult.OK) Then
            arquivo = OpenFileDialog1.FileName
            nome_arquivo = Path.GetFileName(arquivo)

            'Ler dados do arquivo
            readCsv(arquivo)

            'Habilitar os botões para editar e apagar
            ToolStripBtnEdit.Enabled = True
            ToolStripBtnDel.Enabled = True
            ToolStripBtnExpCSV.Enabled = True
            verifica_salvo(False, frmPai.NomeProjeto)
        End If
    End Sub

    'Ler arquivo CSV e importar no Grid
    Public Sub readCsv(arquivo As String)
        Try
            codificacao = Encoding.UTF8
            Dim delimitador As Char = My.Settings.Delimitador

            Dim inputRecord As String = Nothing
            Dim inReader As StreamReader = File.OpenText(arquivo)

            Dim dados() As String
            Dim row As DataRow

            'Adiciona dados na grid
            inputRecord = inReader.ReadLine()
            While (inputRecord IsNot Nothing)
                If inputRecord.Contains(delimitador) Then
                    dados = inputRecord.Split(CChar(delimitador))

                    If dados.Count < 3 Or dados.Count > 7 Then 'Verifica se os dados contém o número de colunas padrão
                        MessageBox.Show("Erro ao importar tabela. Verifique se atende aos requisitos. ", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    row = dt.NewRow()
                    Select Case dados.Count
                        Case Is = 3
                            row("Vértice") = dados(0)
                            row("Este") = verifica_formatoCSV(dados(1))
                            row("Norte") = verifica_formatoCSV(dados(2))
                        Case Is = 4
                            row("Vértice") = dados(0)
                            row("Este") = verifica_formatoCSV(dados(1))
                            row("Norte") = verifica_formatoCSV(dados(2))
                            If NotNull(dados(3), "") = "" Then
                            Else
                                row("Distância") = dados(3)
                            End If
                        Case Is = 5
                            row("Vértice") = dados(0)
                            row("Este") = verifica_formatoCSV(dados(1))
                            row("Norte") = verifica_formatoCSV(dados(2))
                            If NotNull(dados(3), "") = "" Then
                            Else
                                row("Distância") = verifica_formatoCSV(dados(3))
                            End If
                            row("Azimute") = dados(4)
                        Case Is = 7
                            row("Vértice") = dados(0)
                            row("Este") = verifica_formatoCSV(dados(1))
                            row("Norte") = verifica_formatoCSV(dados(2))
                            If NotNull(dados(3), "") = "" Then
                            Else
                                row("Distância") = verifica_formatoCSV(dados(3))
                            End If
                            row("Azimute") = dados(4)
                            row("Confrontante") = dados(5)
                            row("Divisa") = dados(6)
                    End Select

                    dt.Rows.Add(row)
                End If
                'Ler próxima linha do arquivo
                inputRecord = inReader.ReadLine()
            End While

            'Formatação de Colunas
            'Casas decimais
            Dim CasaDecCoordenada As Integer = CInt(frmPai.RibArredCoo.TextBoxText)
            formataCoordenadaTabela(CasaDecCoordenada)

            Dim CasaDecDist As Integer = CInt(frmPai.RibArredDist.TextBoxText)
            formataDistanciaTabela(CasaDecDist)

        Catch ex As Exception
            MessageBox.Show("Erro ao importar tabela. Verifique se atende aos requisitos. " & ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function verifica_formatoCSV(valor As String) As String
        'Caso esteja no formato americano
        If My.Settings.SepDecimal = "." Then
            valor = valor.Replace(".", ",")
        End If
        Return valor
    End Function

    'Adicionar Vértice
    Private Sub ToolStripBtnAdd_Click(sender As Object, e As EventArgs) Handles ToolStripBtnAdd.Click
        'Primeiro, deixa as colunas Este e Norte para edição
        dt.Columns("Este").ReadOnly = False
        dt.Columns("Norte").ReadOnly = False

        Dim frmEdita As New frmEditVertice
        frmEdita.ShowInTaskbar = False

        'Total de linhas existens na tabela
        Dim j As Integer
        j = DataGridView1.Rows.Count

        'Soma +1 ao total de linhas para inserir um novo valor na última linha da tabela
        frmEdita.valorLinha = j + 1
        frmEdita.tipo = 0
        frmEdita.ShowDialog()
    End Sub

    'Editar Vértice
    Private Sub ToolStripBtnEdit_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEdit.Click
        'Primeiro, deixa as colunas Este e Norte para edição
        dt.Columns("Este").ReadOnly = False
        dt.Columns("Norte").ReadOnly = False

        Dim frmEdita As New frmEditVertice
        frmEdita.ShowInTaskbar = False

        Dim txtvertice, txtconfrontante, txtdivisa As String
        Dim txteste, txtnorte As Double

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index 'Marca a posição da linha na tabela

        txtvertice = DataGridView1.Item(0, i).Value
        txteste = DataGridView1.Item(1, i).Value
        txtnorte = DataGridView1.Item(2, i).Value
        txtconfrontante = DataGridView1.Item(5, i).Value.ToString
        txtdivisa = DataGridView1.Item(6, i).Value.ToString

        With frmEdita
            .txtVertice.Text = txtvertice
            .txtEste.Text = txteste
            .txtNorte.Text = txtnorte
            .txtConfrontante.Text = txtconfrontante
            .txtDivisa.Text = txtdivisa
            .valorLinha = i
            .tipo = 1
            .ShowDialog()
        End With
    End Sub

    'Exclusão de linhas da tabela apertando o botão 'Apagar'
    Private Sub ToolStripBtnDel_Click(sender As Object, e As EventArgs) Handles ToolStripBtnDel.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Você tem certeza que deseja apagar o(s) vértice(s) selecionado(s)?", "Confirmar exclusão", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                For Each dr As DataGridViewRow In DataGridView1.SelectedRows    ' delete selected records
                    If (DataGridView1.Rows.Count > 0) Then
                        DataGridView1.Rows.Remove(dr)
                    End If
                Next
                disable_btnApaga()
            End If
            verifica_salvo(False, frmPai.NomeProjeto)
        Else
            MessageBox.Show("Você deve selecionar uma ou mais linhas da tabela para apagar.", "Apagar vértice(s)", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Exclusão de linhas da tabela apertando a tecla DEL
    'Fonte: http://www.vbforums.com/showthread.php?761723-DataGridView-Delete-Rows-with-UserDeletingRow
    Private selectedRowCount As Integer? = Nothing
    Private cancelDeletion As Boolean = False

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        If Not Me.selectedRowCount.HasValue Then
            'This is the first row being deleted.
            Me.selectedRowCount = Me.DataGridView1.SelectedRows.Count
            Me.cancelDeletion = (MessageBox.Show("Você tem certeza que deseja apagar o(s) vértice(s) selecionado(s)?", "Confirmar exclusão", MessageBoxButtons.OKCancel) = DialogResult.Cancel)
        End If
        e.Cancel = Me.cancelDeletion

        If Me.DataGridView1.SelectedRows.Count = 1 OrElse e.Row.Index = Me.DataGridView1.SelectedRows.Cast(Of DataGridViewRow).Max(Function(r) r.Index) Then
            'This is the last row being deleted.
            Me.selectedRowCount = Nothing
            Me.cancelDeletion = False
        End If

        'Verifica se a tabela está vazia para desabilitar os botões 'Editar' e 'Apagar'
        If DataGridView1.Rows.Count <= 1 Then
            ToolStripBtnEdit.Enabled = False
            ToolStripBtnDel.Enabled = False
            ToolStripBtnExpCSV.Enabled = False
        End If
        verifica_salvo(False, frmPai.NomeProjeto)
    End Sub

    'Desabilitar o botão apagar caso a tabela esteja vazia
    Public Sub disable_btnApaga()
        'Verifica se a tabela está vazia para desabilitar o botão 'Apagar'
        If DataGridView1.Rows.Count = 0 Then
            ToolStripBtnEdit.Enabled = False
            ToolStripBtnDel.Enabled = False
            ToolStripBtnExpCSV.Enabled = False
        End If
    End Sub

    'Colar dados diretamente de uma planilha do Excel
    Private Sub ToolStripBtnExcel_Click(sender As Object, e As EventArgs) Handles ToolStripBtnExcel.Click
        Try
            'Primeiro, deixa as colunas Este e Norte para edição
            dt.Columns("Este").ReadOnly = False
            dt.Columns("Norte").ReadOnly = False

            Dim s As String
            s = Clipboard.GetText()
            Dim i, cont, total As Integer

            Dim tArr() As String = s.Split(CChar(ControlChars.NewLine))
            Dim dados() As String

            'Colunas
            dados = tArr(0).Split(CChar(vbTab))
            Dim numcol As Integer = 0
            numcol = dados.Length

            cont = 0
            total = tArr.Length - 1

            'Verifica se foi copiado pelo menos 3 colunas: Vértices, Este e Norte
            If numcol < 3 Then
                MessageBox.Show("Erro ao colar dados. Copie no mínimo as colunas que contém os Vértices e suas coordenadas Este e Norte.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            dt = DataGridView1.DataSource
            Dim row As DataRow

            'Percorre linhas
            For i = 0 To total - 1
                If tArr(i) <> "" Then
                    row = dt.NewRow()
                    dados = tArr(i).Split(CChar(vbTab))
                    Select Case dados.Count
                        Case Is = 3
                            row("Vértice") = dados(0)
                            row("Este") = dados(1)
                            row("Norte") = dados(2)
                        Case Is = 4
                            row("Vértice") = dados(0)
                            row("Este") = dados(1)
                            row("Norte") = dados(2)
                            row("Distância") = dados(3)
                        Case Is = 5
                            row("Vértice") = dados(0)
                            row("Este") = dados(1)
                            row("Norte") = dados(2)
                            row("Distância") = dados(3)
                            row("Azimute") = dados(4)
                        Case Is = 7
                            row("Vértice") = dados(0)
                            row("Este") = dados(1)
                            row("Norte") = dados(2)
                            row("Distância") = dados(3)
                            row("Azimute") = dados(4)
                            row("Confrontante") = dados(5)
                            row("Divisa") = dados(6)
                    End Select

                    dt.Rows.Add(row)
                End If
            Next
            'Verifica se a tabela está vazia para habilitar os botões 'Editar' e 'Apagar'
            If DataGridView1.Rows.Count > 0 Then
                ToolStripBtnEdit.Enabled = True
                ToolStripBtnDel.Enabled = True
                ToolStripBtnExpCSV.Enabled = True

                'Formatação de Colunas
                'Casas decimais
                Dim CasaDecCoordenada As Integer = CInt(frmPai.RibArredCoo.TextBoxText)
                Dim CasaDecDist As Integer = CInt(frmPai.RibArredDist.TextBoxText)
                formataCoordenadaTabela(CasaDecCoordenada)
                formataDistanciaTabela(CasaDecDist)

                verifica_salvo(False, frmPai.NomeProjeto)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao colar dados. Verifique se a ordem das colunas está correta. A coluna das coordenadas e distância devem ser numéricas.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Exportar a tabela de dados para texto
    Private Sub ToolStripBtnExpCSV_Click(sender As Object, e As EventArgs) Handles ToolStripBtnExpCSV.Click
        With SaveFileGridCsv
            .Title = "Exportar tabela para CSV ou texto..."
            .Filter = "Arquivo texto (*.txt)|*.txt|Arquivo csv (*.csv)|*.csv"
            .FilterIndex = 2
            .RestoreDirectory = True
        End With

        If SaveFileGridCsv.ShowDialog() = DialogResult.OK Then
            salvargrid(SaveFileGridCsv.FileName)
        End If
    End Sub

    'Salva os dados da grid
    Public Sub salvargrid(arquivo As String)
        Try
            Dim streamWriter As New System.IO.StreamWriter(arquivo)
            Dim numcolunas As Integer = DataGridView1.Columns.Count

            'Percorre as linhas
            For m As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim strRowValue As String = ""

                For n As Integer = 0 To numcolunas - 1 'Percorre as colunas
                    If n = (numcolunas - 1) Then
                        strRowValue += DataGridView1.Rows(m).Cells(n).Value
                    Else
                        strRowValue += Convert.ToString(DataGridView1.Rows(m).Cells(n).Value) & ";"
                    End If
                Next
                streamWriter.WriteLine(strRowValue)
            Next
            streamWriter.Close()
            MessageBox.Show("Dados da tabela exportado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao colar dados. Verifique se a ordem das colunas está correta. A coluna das coordenadas e distância devem ser numéricas.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Calcular azimutes e distâncias
    Private Sub ToolStrAzimute_Click(sender As Object, e As EventArgs) Handles ToolStrAzimute.Click
        dt.Columns("Distância").ReadOnly = False
        dt.Columns("Azimute").ReadOnly = False

        'Formatação das casas decimais das coordenadas
        Dim CasaDecCoordenada As Integer = CInt(frmPai.RibArredCoo.TextBoxText)
        formataCoordenadaTabela(CasaDecCoordenada)
        Dim CasaDecDist As Integer = CInt(frmPai.RibArredDist.TextBoxText)
        formataDistanciaTabela(CasaDecDist)

        Dim numPontos As Integer = dt.Rows.Count - 1

        'Coordenadas primeiro ponto
        Dim xInicio As Double = Convert.ToDouble(dt.Rows(0)(1))
        Dim yInicio As Double = Convert.ToDouble(dt.Rows(0)(2))

        'Coordenadas último ponto
        Dim xUltimo As Double = Convert.ToDouble(dt.Rows(numPontos)(1))
        Dim yUlitmo As Double = Convert.ToDouble(dt.Rows(numPontos)(2))

        'Verifica se tem mais de um vértice na tabela
        If dt.Rows.Count < 2 Then
            MessageBox.Show("É necessário ter mais vértices para calcular.", "Memorial Descritivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        'verifica se o primeiro ponto é igual ao último. Caso for, não calcula
        If (xInicio = xUltimo) AndAlso (yInicio = yUlitmo) Then
            MessageBox.Show("A coordenada do último ponto é igual ao primeiro ponto, favor deletar último ponto.", "Memorial Descritivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        'Variáveis de área e perímetro
        Aream2 = 0
        per = 0

        'Percorre os pontos
        For i As Integer = 0 To dt.Rows.Count - 1
            If i = 0 Then
                'Cálculo da distância
                Dim X As Double = Convert.ToDouble(dt.Rows(i)(1))
                Dim Xant As Double = Convert.ToDouble(dt.Rows(dt.Rows.Count - 1)(1))
                Dim difX As Double = X - Xant
                Dim Y As Double = Convert.ToDouble(dt.Rows(i)(2))
                Dim Yant As Double = Convert.ToDouble(dt.Rows(dt.Rows.Count - 1)(2))
                Dim difY As Double = Y - Yant
                Dim dist As Double = Math.Sqrt(Math.Pow(difX, 2) + Math.Pow(difY, 2))

                dt.Rows(dt.Rows.Count - 1)("Distância") = formataDec(Math.Sqrt(Math.Pow(difX, 2) + Math.Pow(difY, 2)), "dist")

                'Cálculo da área
                Aream2 = (Xant * Y) - (Yant * X)

                'Perimetro
                per = dist

                'Cálculo do azimute
                Dim rprov1 As Double = Math.Atan(difX / difY) * (180 / Math.PI) * Math.Sign(difX / difY)
                Dim azprov1 As Double = rprov1
                Dim azprov2 As Double = 180 - rprov1
                Dim azprov3 As Double = 180 + rprov1
                Dim azprov4 As Double = 360 - rprov1
                Dim azprov1b As Double = ((Math.Truncate(azprov1 * Math.Sign(azprov1)) + (Math.Truncate((azprov1 - (Math.Truncate(azprov1 * Math.Sign(azprov1)) * Math.Sign(azprov1))) * 60 * Math.Sign(azprov1))) / 100) + (((azprov1 - (Math.Truncate(azprov1 * Math.Sign(azprov1)) * Math.Sign(azprov1))) * 60 * Math.Sign(azprov1) - Math.Truncate((azprov1 - (Math.Truncate(azprov1 * Math.Sign(azprov1)) * Math.Sign(azprov1))) * 60 * Math.Sign(azprov1))) * 60 / 10000)) * Math.Sign(azprov1)
                Dim azprov2b As Double = ((Math.Truncate(azprov2 * Math.Sign(azprov2)) + (Math.Truncate((azprov2 - (Math.Truncate(azprov2 * Math.Sign(azprov2)) * Math.Sign(azprov2))) * 60 * Math.Sign(azprov2))) / 100) + (((azprov2 - (Math.Truncate(azprov2 * Math.Sign(azprov2)) * Math.Sign(azprov2))) * 60 * Math.Sign(azprov2) - Math.Truncate((azprov2 - (Math.Truncate(azprov2 * Math.Sign(azprov2)) * Math.Sign(azprov2))) * 60 * Math.Sign(azprov2))) * 60 / 10000)) * Math.Sign(azprov2)
                Dim azprov3b As Double = ((Math.Truncate(azprov3 * Math.Sign(azprov3)) + (Math.Truncate((azprov3 - (Math.Truncate(azprov3 * Math.Sign(azprov3)) * Math.Sign(azprov3))) * 60 * Math.Sign(azprov3))) / 100) + (((azprov3 - (Math.Truncate(azprov3 * Math.Sign(azprov3)) * Math.Sign(azprov3))) * 60 * Math.Sign(azprov3) - Math.Truncate((azprov3 - (Math.Truncate(azprov3 * Math.Sign(azprov3)) * Math.Sign(azprov3))) * 60 * Math.Sign(azprov3))) * 60 / 10000)) * Math.Sign(azprov3)
                Dim azprov4b As Double = ((Math.Truncate(azprov4 * Math.Sign(azprov4)) + (Math.Truncate((azprov4 - (Math.Truncate(azprov4 * Math.Sign(azprov4)) * Math.Sign(azprov4))) * 60 * Math.Sign(azprov4))) / 100) + (((azprov4 - (Math.Truncate(azprov4 * Math.Sign(azprov4)) * Math.Sign(azprov4))) * 60 * Math.Sign(azprov4) - Math.Truncate((azprov4 - (Math.Truncate(azprov4 * Math.Sign(azprov4)) * Math.Sign(azprov4))) * 60 * Math.Sign(azprov4))) * 60 / 10000)) * Math.Sign(azprov4)

                'formatação do azimute
                Dim azprov1bf As String = dd2dms(azprov1b)
                Dim azprov2bf As String = dd2dms(azprov2b)
                Dim azprov3bf As String = dd2dms(azprov3b)
                Dim azprov4bf As String = dd2dms(azprov4b)

                If difY > 0 AndAlso difX > 0 Then
                    dt.Rows(dt.Rows.Count - 1)("Azimute") = azprov1bf
                End If
                If difY < 0 AndAlso difX > 0 Then
                    dt.Rows(dt.Rows.Count - 1)("Azimute") = azprov2bf
                End If
                If difY < 0 AndAlso difX < 0 Then
                    dt.Rows(dt.Rows.Count - 1)("Azimute") = azprov3bf
                End If
                If difY > 0 AndAlso difX < 0 Then
                    dt.Rows(dt.Rows.Count - 1)("Azimute") = azprov4bf
                End If

                'Casos especiais no cálculo do Azimute
                If difX < 0 AndAlso difY = 0 Then
                    dt.Rows(dt.Rows.Count - 1)("Azimute") = "270°"
                End If
                If difX > 0 AndAlso difY = 0 Then
                    dt.Rows(dt.Rows.Count - 1)("Azimute") = "90°"
                End If
                If difX = 0 AndAlso difY > 0 Then
                    dt.Rows(dt.Rows.Count - 1)("Azimute") = "0°"
                End If
                If difX = 0 AndAlso difY < 0 Then
                    dt.Rows(dt.Rows.Count - 1)("Azimute") = "180°"
                End If

            Else
                'Cálculo da distância
                Dim X As Double = Convert.ToDouble(dt.Rows(i)(1))
                Dim Xant As Double = Convert.ToDouble(dt.Rows(i - 1)(1))
                Dim difX As Double = X - Xant
                Dim Y As Double = Convert.ToDouble(dt.Rows(i)(2))
                Dim Yant As Double = Convert.ToDouble(dt.Rows(i - 1)(2))
                Dim difY As Double = Y - Yant
                Dim dist As Double = (Math.Sqrt(Math.Pow(difX, 2) + Math.Pow(difY, 2)))

                dt.Rows(i - 1)("Distância") = formataDec(Math.Sqrt(Math.Pow(difX, 2) + Math.Pow(difY, 2)), "dist")

                'Cálculo da área
                Aream2 = Aream2 + (Xant * Y) - (Yant * X)

                'Perimetro
                per = per + dist

                'Cálculo do azimute
                Dim rprov1 As Double = Math.Atan(difX / difY) * (180 / Math.PI) * Math.Sign(difX / difY)
                Dim azprov1 As Double = rprov1
                Dim azprov2 As Double = 180 - rprov1
                Dim azprov3 As Double = 180 + rprov1
                Dim azprov4 As Double = 360 - rprov1
                Dim azprov1b As Double = ((Math.Truncate(azprov1 * Math.Sign(azprov1)) + (Math.Truncate((azprov1 - (Math.Truncate(azprov1 * Math.Sign(azprov1)) * Math.Sign(azprov1))) * 60 * Math.Sign(azprov1))) / 100) + (((azprov1 - (Math.Truncate(azprov1 * Math.Sign(azprov1)) * Math.Sign(azprov1))) * 60 * Math.Sign(azprov1) - Math.Truncate((azprov1 - (Math.Truncate(azprov1 * Math.Sign(azprov1)) * Math.Sign(azprov1))) * 60 * Math.Sign(azprov1))) * 60 / 10000)) * Math.Sign(azprov1)
                Dim azprov2b As Double = ((Math.Truncate(azprov2 * Math.Sign(azprov2)) + (Math.Truncate((azprov2 - (Math.Truncate(azprov2 * Math.Sign(azprov2)) * Math.Sign(azprov2))) * 60 * Math.Sign(azprov2))) / 100) + (((azprov2 - (Math.Truncate(azprov2 * Math.Sign(azprov2)) * Math.Sign(azprov2))) * 60 * Math.Sign(azprov2) - Math.Truncate((azprov2 - (Math.Truncate(azprov2 * Math.Sign(azprov2)) * Math.Sign(azprov2))) * 60 * Math.Sign(azprov2))) * 60 / 10000)) * Math.Sign(azprov2)
                Dim azprov3b As Double = ((Math.Truncate(azprov3 * Math.Sign(azprov3)) + (Math.Truncate((azprov3 - (Math.Truncate(azprov3 * Math.Sign(azprov3)) * Math.Sign(azprov3))) * 60 * Math.Sign(azprov3))) / 100) + (((azprov3 - (Math.Truncate(azprov3 * Math.Sign(azprov3)) * Math.Sign(azprov3))) * 60 * Math.Sign(azprov3) - Math.Truncate((azprov3 - (Math.Truncate(azprov3 * Math.Sign(azprov3)) * Math.Sign(azprov3))) * 60 * Math.Sign(azprov3))) * 60 / 10000)) * Math.Sign(azprov3)
                Dim azprov4b As Double = ((Math.Truncate(azprov4 * Math.Sign(azprov4)) + (Math.Truncate((azprov4 - (Math.Truncate(azprov4 * Math.Sign(azprov4)) * Math.Sign(azprov4))) * 60 * Math.Sign(azprov4))) / 100) + (((azprov4 - (Math.Truncate(azprov4 * Math.Sign(azprov4)) * Math.Sign(azprov4))) * 60 * Math.Sign(azprov4) - Math.Truncate((azprov4 - (Math.Truncate(azprov4 * Math.Sign(azprov4)) * Math.Sign(azprov4))) * 60 * Math.Sign(azprov4))) * 60 / 10000)) * Math.Sign(azprov4)

                'formatação do azimute
                Dim azprov1bf As String = dd2dms(azprov1b)
                Dim azprov2bf As String = dd2dms(azprov2b)
                Dim azprov3bf As String = dd2dms(azprov3b)
                Dim azprov4bf As String = dd2dms(azprov4b)

                If difY > 0 AndAlso difX > 0 Then
                    dt.Rows(i - 1)("Azimute") = azprov1bf
                End If
                If difY < 0 AndAlso difX > 0 Then
                    dt.Rows(i - 1)("Azimute") = azprov2bf
                End If
                If difY < 0 AndAlso difX < 0 Then
                    dt.Rows(i - 1)("Azimute") = azprov3bf
                End If
                If difY > 0 AndAlso difX < 0 Then
                    dt.Rows(i - 1)("Azimute") = azprov4bf
                End If

                'Casos especiais no cálculo do Azimute
                If difX < 0 AndAlso difY = 0 Then
                    dt.Rows(i - 1)("Azimute") = "270°"
                End If
                If difX > 0 AndAlso difY = 0 Then
                    dt.Rows(i - 1)("Azimute") = "90°"
                End If
                If difX = 0 AndAlso difY > 0 Then
                    dt.Rows(i - 1)("Azimute") = "0°"
                End If
                If difX = 0 AndAlso difY < 0 Then
                    dt.Rows(i - 1)("Azimute") = "180°"
                End If
            End If
        Next

        verifica_salvo(False, frmPai.NomeProjeto)
    End Sub

    'Limpar todos os campos e voltar ao padrão
    Private Sub ToolLimparImo_Click(sender As Object, e As EventArgs) Handles ToolLimparImo.Click
        limpaDadosImovel()
    End Sub

    'Ativa ou desativa o campo da Área (m) e casas decimais do mesmo
    Private Sub chkArea_CheckedChanged(sender As Object, e As EventArgs) Handles chkArea.CheckedChanged
        If (chkArea.Checked = True) Then
            txtArea.Enabled = True
            NumDecAream.Enabled = True
        ElseIf (chkArea.Checked = False) Then
            txtArea.Enabled = False
            NumDecAream.Enabled = False
        End If
    End Sub

    'Ativa ou desativa o campo da �Área (ha) e casas decimais do mesmo
    Private Sub chkAreaha_CheckedChanged(sender As Object, e As EventArgs) Handles chkAreaha.CheckedChanged
        If (chkAreaha.Checked = True) Then
            txtAreaha.Enabled = True
            NumDecAreaha.Enabled = True
        ElseIf (chkAreaha.Checked = False) Then
            txtArea.Enabled = False
            NumDecAreaha.Enabled = False
        End If
    End Sub

    'Ativa ou desativa o campo do Perímetro (m) e casas decimais do mesmo
    Private Sub chkPer_CheckedChanged(sender As Object, e As EventArgs) Handles chkPer.CheckedChanged
        If (chkPer.Checked = True) Then
            txtPerimetro.Enabled = True
            NumDecPer.Enabled = True
        ElseIf (chkPer.Checked = False) Then
            txtPerimetro.Enabled = False
            NumDecPer.Enabled = False
        End If
    End Sub

    'Inserir data
    Private Sub chkData_CheckedChanged(sender As Object, e As EventArgs) Handles chkData.CheckedChanged
        If chkData.Checked = True Then
            optHoje.Enabled = True
            OptOutra.Enabled = True
            txtData.Enabled = True
            txtData.Text = Now.Date
        ElseIf chkData.Checked = False Then
            optHoje.Enabled = False
            OptOutra.Enabled = False
            txtData.Text = ""
            txtData.Enabled = False
        End If
    End Sub

    'Mostrar a data atual
    Private Sub optHoje_CheckedChanged(sender As Object, e As EventArgs) Handles optHoje.CheckedChanged
        txtData.Text = Now.Date
    End Sub

    'Salvar dados do imóvel num arquivo texto
    Private Sub ToolStrSaveImo_Click(sender As Object, e As EventArgs) Handles ToolStrSaveImo.Click
        Dim arquivo As String
        With SaveFileImovel
            .Title = "Salvar dados do imóvel..."
            .Filter = "Arquivo texto (*.txt)|*.txt|Arquivo Csv (*.csv)|*.csv"
            .FilterIndex = 2
            .RestoreDirectory = True
        End With
        If SaveFileImovel.ShowDialog() = DialogResult.OK Then
            arquivo = SaveFileImovel.FileName

            If [String].IsNullOrEmpty(arquivo) Then
                MessageBox.Show("Arquivo inválido", "Salvar Como", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim streamWriter As New System.IO.StreamWriter(arquivo)
                'Dim strHeader As String = ""
                'strHeader += "imovel;municipio;matricula;comarca;cartorio;cod_incra;area_m2;area_ha;perimetro;proprietarios;mc;longitude;fuso;hemisferio;datum"
                ' streamWriter.WriteLine(strHeader)

                Dim strRowValue As String = ""
                strRowValue += txtImovel.Text
                strRowValue += ";" & txtMunicipio.Text
                strRowValue += ";" & txtMatricula.Text
                strRowValue += ";" & txtComarca.Text
                strRowValue += ";" & txtCartorio.Text
                strRowValue += ";" & txtCodIncra.Text
                strRowValue += ";" & txtArea.Text
                strRowValue += ";" & txtAreaha.Text
                strRowValue += ";" & txtPerimetro.Text
                strRowValue += ";" & txtProprietario.Text
                strRowValue += ";" & cboMC.Text
                strRowValue += ";" & cboLongitude.Text
                strRowValue += ";" & cboFuso.Text
                strRowValue += ";" & cboHemisferio.Text
                strRowValue += ";" & txtDatum.Text
                streamWriter.WriteLine(strRowValue)
                streamWriter.Close()
            End If
        End If
    End Sub

    'Carrega dados do imóvel de um arquivo texto
    Private Sub ToolStrLoadImo_Click(sender As Object, e As EventArgs) Handles ToolStrLoadImo.Click
        Dim separador As Char = ";"
        codificacao = Encoding.UTF8

        With OpenFileDialog1
            .Filter = "Arquivo CSV (*.csv)|*.csv|Arquivo TXT (*.txt)|*.txt"
            .FileName = ""
            .Title = "Carregar dados do imóvel..."
            .RestoreDirectory = True
        End With
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If (result = DialogResult.OK) Then
            arquivo = OpenFileDialog1.FileName
            nome_arquivo = Path.GetFileName(arquivo)
            Try

                Dim inputRecord As String = Nothing
                Dim inReader As StreamReader = File.OpenText(arquivo)
                Dim dados() As String
                inputRecord = inReader.ReadLine()
                dados = inputRecord.Split(CChar(separador))
                If dados.Count = 15 Then
                    txtImovel.Text = dados(0)
                    txtMunicipio.Text = dados(1)
                    txtMatricula.Text = dados(2)
                    txtComarca.Text = dados(3)
                    txtCartorio.Text = dados(4)
                    txtCodIncra.Text = dados(5)
                    txtArea.Text = dados(6)
                    txtAreaha.Text = dados(7)
                    txtPerimetro.Text = dados(8)
                    txtProprietario.Text = dados(9)
                    cboMC.Text = dados(10)
                    cboLongitude.Text = dados(11)
                    cboFuso.Text = dados(12)
                    cboHemisferio.Text = dados(13)
                    txtDatum.Text = dados(14)
                Else
                    MessageBox.Show("Arquivo não contém dados do imóvel.", "Erro ao carregar dados...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("O arquivo está sendo usado por outro processo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    'Ao alterar o MC, calcula automaticamente o fuso
    Private Sub cboMC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMC.SelectedIndexChanged
        Dim fuso As Integer
        fuso = 30 - CInt(Math.Truncate(Double.Parse(cboMC.Text))) / 6
        cboFuso.Text = Convert.ToString(fuso)
    End Sub

    'Ao alterar o Fuso, calcula automaticamente o MC
    Private Sub cboFuso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFuso.SelectedIndexChanged
        Dim mc As Integer
        mc = 183 - 6 * Integer.Parse(cboFuso.Text)
        cboMC.Text = Convert.ToString(mc)
    End Sub

    'Salva dados do profissional na memória
    Private Sub ToolStrBtnSaveProf_Click(sender As Object, e As EventArgs) Handles ToolStrBtnSaveProf.Click
        My.Settings.Pprofissional = txtNomeProf.Text
        My.Settings.Pregistro = txtRegistro.Text
        My.Settings.Pcidade = txtCidade.Text
        If chkData.Checked = True Then
            My.Settings.Pdata = txtData.Text
        Else
            My.Settings.Pdata = ""
        End If
        My.Settings.Save()
        MessageBox.Show("Dados salvos na memória.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Carregar dados do Profissional da memória (Caso houver)
    Private Sub ToolStrBtnLoadProf_Click(sender As Object, e As EventArgs) Handles ToolStrBtnLoadProf.Click
        txtNomeProf.Text = My.Settings.Pprofissional
        txtRegistro.Text = My.Settings.Pregistro
        txtCidade.Text = My.Settings.Pcidade
        txtData.Text = My.Settings.Pdata
    End Sub

    'Limpa os dados dos campos e memória
    Private Sub ToolStrBtnLimpaProf_Click(sender As Object, e As EventArgs) Handles ToolStrBtnLimpaProf.Click
        limpaDadosProfi()
    End Sub

    'Gerar Memorial descritivo
    Private Sub ToolStrBtnGeraMemo_Click(sender As Object, e As EventArgs) Handles ToolStrBtnGeraMemo.Click
        If (DataGridView1.Rows.Count > 0) Then

            RichTxtMemo.Text = ""
            RichTxtMemo.Font = New Font("Calibri", 11)

            'Título
            RichTxtMemo.AppendText(vbNewLine)
            'RichTxtMemo.SelectionAlignment = HorizontalAlignment.Center
            If My.Settings.NchkNTit = True Then
                'AddTxtBold(RichTxtMemo, My.Settings.Mtitulo)
                AppendCenterBold(RichTxtMemo, My.Settings.Mtitulo)
            Else
                AppendCenter(RichTxtMemo, My.Settings.Mtitulo)
            End If

            RichTxtMemo.AppendText(vbNewLine)
            RichTxtMemo.AppendText(vbNewLine)

            RichTxtMemo.SelectionAlignment = HorizontalAlignment.Left

            'Imóvel
            If txtImovel.TextLength > 0 Then 'Verifica se tem algum imóvel antes
                If My.Settings.NchkNImo = True Then
                    AddTxtBold(RichTxtMemo, "Imóvel: ")
                Else
                    AddTxtRegular(RichTxtMemo, "Imóvel: ")
                End If
                If My.Settings.NchkNImoV = True Then
                    AddTxtBold(RichTxtMemo, txtImovel.Text)
                Else
                    AddTxtRegular(RichTxtMemo, txtImovel.Text)
                End If
                RichTxtMemo.AppendText(vbNewLine)
            End If

            ' Município
            If txtMunicipio.TextLength > 0 Then
                If My.Settings.NchkNMun = True Then
                    AddTxtBold(RichTxtMemo, "Município: ")
                Else
                    AddTxtRegular(RichTxtMemo, "Município: ")
                End If
                If My.Settings.NchkNMunV = True Then
                    AddTxtBold(RichTxtMemo, txtMunicipio.Text)
                Else
                    AddTxtRegular(RichTxtMemo, txtMunicipio.Text)
                End If
                RichTxtMemo.AppendText(vbNewLine)
            End If

            'Matrícula
            If txtMatricula.TextLength > 0 Then
                If My.Settings.NchkNMat = True Then
                    AddTxtBold(RichTxtMemo, "Matrícula: ")
                Else
                    AddTxtRegular(RichTxtMemo, "Matrícula: ")
                End If
                If My.Settings.NchkNMatV = True Then
                    AddTxtBold(RichTxtMemo, txtMatricula.Text)
                Else
                    AddTxtRegular(RichTxtMemo, txtMatricula.Text)
                End If
                RichTxtMemo.AppendText(vbNewLine)
            End If

            'Comarca
            If txtComarca.TextLength > 0 Then
                If My.Settings.NchkNCom = True Then
                    AddTxtBold(RichTxtMemo, "Comarca: ")
                Else
                    AddTxtRegular(RichTxtMemo, "Comarca: ")
                End If
                If My.Settings.NchkNComV = True Then
                    AddTxtBold(RichTxtMemo, txtComarca.Text)
                Else
                    AddTxtRegular(RichTxtMemo, txtComarca.Text)
                End If
                RichTxtMemo.AppendText(vbNewLine)
            End If

            'Cartório
            If txtCartorio.TextLength > 0 Then
                If My.Settings.NchkNCar = True Then
                    AddTxtBold(RichTxtMemo, "Cartório: ")
                Else
                    AddTxtRegular(RichTxtMemo, "Cartório: ")
                End If
                If My.Settings.NchkNCarV = True Then
                    AddTxtBold(RichTxtMemo, txtCartorio.Text)
                Else
                    AddTxtRegular(RichTxtMemo, txtCartorio.Text)
                End If
                RichTxtMemo.AppendText(vbNewLine)
            End If

            'Cód. Incra
            If txtCodIncra.TextLength > 0 Then
                If My.Settings.NchkNInc = True Then
                    AddTxtBold(RichTxtMemo, "Código INCRA: ")
                Else
                    AddTxtRegular(RichTxtMemo, "Código INCRA: ")
                End If
                If My.Settings.NchkNIncV = True Then
                    AddTxtBold(RichTxtMemo, txtCodIncra.Text)
                Else
                    AddTxtRegular(RichTxtMemo, txtCodIncra.Text)
                End If
                RichTxtMemo.AppendText(vbNewLine)
            End If

            'Se as duas áreas forem marcadas
            If chkArea.Checked = True AndAlso chkAreaha.Checked = True Then
                If txtArea.TextLength > 0 Then
                    If My.Settings.NchkNAre = True Then
                        AddTxtBold(RichTxtMemo, "Área: ")
                    Else
                        AddTxtRegular(RichTxtMemo, "Área: ")
                    End If
                    If My.Settings.NchkNAreV = True Then
                        AddTxtBold(RichTxtMemo, txtArea.Text & " m² ou " & txtAreaha.Text & " ha")
                    Else
                        AddTxtRegular(RichTxtMemo, txtArea.Text & " m² ou " & txtAreaha.Text & " ha")
                    End If
                    RichTxtMemo.AppendText(vbNewLine)
                End If
            ElseIf chkArea.Checked = True Then
                If txtArea.TextLength > 0 Then
                    If My.Settings.NchkNAre = True Then
                        AddTxtBold(RichTxtMemo, "Área: ")
                    Else
                        AddTxtRegular(RichTxtMemo, "Área: ")
                    End If
                    If My.Settings.NchkNAreV = True Then
                        AddTxtBold(RichTxtMemo, txtArea.Text & " m²")
                    Else
                        AddTxtRegular(RichTxtMemo, txtArea.Text & " m²")
                    End If
                    RichTxtMemo.AppendText(vbNewLine)
                End If
            ElseIf chkAreaha.Checked = True Then
                If txtAreaha.TextLength > 0 Then
                    If My.Settings.NchkNAre = True Then
                        AddTxtBold(RichTxtMemo, "Área: ")
                    Else
                        AddTxtRegular(RichTxtMemo, "Área: ")
                    End If
                    If My.Settings.NchkNAreV = True Then
                        AddTxtBold(RichTxtMemo, txtAreaha.Text & " ha")
                    Else
                        AddTxtRegular(RichTxtMemo, txtAreaha.Text & " ha")
                    End If
                    RichTxtMemo.AppendText(vbNewLine)
                End If
            End If

            'Perímetro
            If chkPer.Checked = True Then
                If txtPerimetro.TextLength > 0 Then
                    If My.Settings.NchkNPer = True Then
                        AddTxtBold(RichTxtMemo, "Perímetro: ") 'Negrito
                    Else
                        AddTxtRegular(RichTxtMemo, "Perímetro: ")
                    End If
                    If My.Settings.NchkNPerV = True Then
                        AddTxtBold(RichTxtMemo, txtPerimetro.Text & " m") 'Negrito
                    Else
                        AddTxtRegular(RichTxtMemo, txtPerimetro.Text & " m")
                    End If
                    RichTxtMemo.AppendText(vbNewLine)
                End If
            End If

            'Proprietário
            If txtProprietario.TextLength > 0 Then
                If My.Settings.NchkNPro = True Then
                    AddTxtBold(RichTxtMemo, "Proprietário: ")
                Else
                    AddTxtRegular(RichTxtMemo, "Proprietário: ")
                End If
                If My.Settings.NchkNProV = True Then
                    AddTxtBold(RichTxtMemo, txtProprietario.Text)
                Else
                    AddTxtRegular(RichTxtMemo, txtProprietario.Text)
                End If
                RichTxtMemo.AppendText(vbNewLine)
            End If

            'Começo do texto do memorial
            RichTxtMemo.AppendText(vbNewLine)

            'Parágrafo
            AddTxtRegular(RichTxtMemo, vbTab & My.Settings.Minicio & " ")

            'Variáveis
            Dim ponto As String = Nothing 'Nome ponto
            Dim X As String = Nothing 'Coodernada X
            Dim Y As String = Nothing 'Coodernada Y
            Dim azi As String = Nothing 'Azimute Inicial
            Dim dist As String = Nothing 'Distância Inicial
            Dim nome As String = Nothing 'Confrontante
            Dim nome2 As String = Nothing 'Confrontante (para verificar duplicidade)
            Dim divisa As String = Nothing 'Divisa
            Dim divisa2 As String = Nothing 'Divisa (para verificar duplicidade)

            'Percorre os pontos
            For i As Integer = 0 To DataGridView1.Rows.Count - 1

                ponto = DataGridView1.Rows(i).Cells(0).Value  'Nome ponto

                'Caso for o primeiro ponto, não coloca o texto de ligação
                If i = 0 Then
                    AddTxtRegular(RichTxtMemo, " ")
                Else
                    AddTxtRegular(RichTxtMemo, " " & My.Settings.Mligacao & " ")
                End If

                If My.Settings.NchkNPto = True Then
                    AddTxtBold(RichTxtMemo, ponto)
                Else
                    AddTxtRegular(RichTxtMemo, ponto)
                End If

                AddTxtRegular(RichTxtMemo, ", " & My.Settings.MCoord & " ")

                'Coodernadas
                X = DataGridView1.Rows(i).Cells(1).Value
                Y = DataGridView1.Rows(i).Cells(2).Value

                X = formataDec(Convert.ToDouble(X), "coord")
                Y = formataDec(Convert.ToDouble(Y), "coord")

                'Coord X
                If My.Settings.NchkNCoo = True Then
                    AddTxtBold(RichTxtMemo, My.Settings.Meste & " " & X & " " & My.Settings.Munidade)
                Else
                    AddTxtRegular(RichTxtMemo, My.Settings.Meste & " " & X & " " & My.Settings.Munidade)
                End If
                AddTxtRegular(RichTxtMemo, " e ")

                'Coord Y
                If My.Settings.NchkNCoo = True Then
                    AddTxtBold(RichTxtMemo, My.Settings.Mnorte & " " & Y & " " & My.Settings.Munidade)
                Else
                    AddTxtRegular(RichTxtMemo, My.Settings.Mnorte & " " & Y & " " & My.Settings.Munidade)
                End If

                'Confrontante
                nome = DataGridView1.Rows(i).Cells(5).Value

                'Divisa
                divisa = DataGridView1.Rows(i).Cells(6).Value

                If i < DataGridView1.Rows.Count Then
                    If i = 0 Then
                        nome2 = DataGridView1.Rows(i).Cells(5).Value
                        divisa2 = DataGridView1.Rows(i).Cells(6).Value
                    Else
                        nome2 = DataGridView1.Rows(i - 1).Cells(5).Value
                        divisa2 = DataGridView1.Rows(i - 1).Cells(6).Value
                    End If
                Else
                    nome2 = DataGridView1.Rows(0).Cells(5).Value
                    divisa2 = DataGridView1.Rows(0).Cells(6).Value
                End If

                If nome.Length > 0 Then
                    'Se a opção de ocultar confrontante e tipo de divisa estiver selecionada
                    If My.Settings.Mrepeticao = True Then
                        If i = 0 Then
                            AddTxtRegular(RichTxtMemo, ", " & My.Settings.Mconfronto)

                            If My.Settings.NchkNCon = True Then
                                'negrito em Confrontante
                                AddTxtBold(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(5).Value)
                                AddTxtRegular(RichTxtMemo, ", ")
                            Else
                                AddTxtRegular(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(5).Value)
                                AddTxtRegular(RichTxtMemo, ", ")
                            End If

                            If My.Settings.NchkNDiv = True Then
                                'negrito em Tipo de Divisa
                                AddTxtRegular(RichTxtMemo, My.Settings.Mdivisa)
                                AddTxtBold(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(6).Value)
                            Else
                                AddTxtRegular(RichTxtMemo, My.Settings.Mdivisa)
                                AddTxtRegular(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(6).Value)
                            End If
                        End If
                    End If

                    'Se a opção de ocultar confrontante e tipo de divisa estiver selecionada
                    If My.Settings.Mrepeticao = True Then
                        'Verifica se o nome anterior é igual, para não repetir o nome no texto
                        If nome = nome2 Then
                            If divisa.Length > 0 Then
                                If divisa = divisa2 Then
                                    If i > 0 Then
                                        If My.Settings.Mdivisa = True Then
                                            'negrito em Tipo de Divisa
                                            AddTxtBold(RichTxtMemo, ",")
                                        Else
                                            AddTxtRegular(RichTxtMemo, ",")
                                        End If
                                    End If
                                Else
                                    AddTxtRegular(RichTxtMemo, ", " & My.Settings.Mdivisa)
                                    If My.Settings.NchkNDiv = True Then
                                        'negrito em Tipo de Divisa
                                        AddTxtBold(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(6).Value)
                                    Else
                                        AddTxtRegular(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(6).Value)
                                    End If
                                End If
                            End If
                        Else
                            AddTxtRegular(RichTxtMemo, "; " & My.Settings.Mconfronto)
                            If My.Settings.NchkNCon = True Then
                                'negrito em Confrontante
                                AddTxtBold(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(5).Value)
                                AddTxtRegular(RichTxtMemo, ", ")
                            Else
                                AddTxtRegular(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(5).Value)
                                AddTxtRegular(RichTxtMemo, ", ")
                            End If
                            'Nome
                            If My.Settings.NchkNDiv = True Then
                                'negrito em Tipo de Divisa
                                AddTxtRegular(RichTxtMemo, My.Settings.Mdivisa)
                                AddTxtBold(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(6).Value)
                            Else
                                AddTxtRegular(RichTxtMemo, My.Settings.Mdivisa)
                                AddTxtRegular(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(6).Value)
                            End If
                        End If
                    Else
                        'Se a opção de ocultar confrontante e tipo de divisa estiver desmarcada
                        AddTxtRegular(RichTxtMemo, "; " & My.Settings.Mconfronto)

                        If My.Settings.NchkNCon = True Then
                            AddTxtBold(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(5).Value)
                        Else
                            AddTxtRegular(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(5).Value)
                        End If

                        'negrito em Tipo de Divisa - coloquei em 28/08/14
                        AddTxtRegular(RichTxtMemo, ", " & My.Settings.Mdivisa)
                        If My.Settings.NchkNDiv = True Then
                            AddTxtBold(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(6).Value)
                        Else
                            AddTxtRegular(RichTxtMemo, " " & DataGridView1.Rows(i).Cells(6).Value)
                        End If
                    End If
                End If

                'Azimute
                azi = DataGridView1.Rows(i).Cells(4).Value

                AddTxtRegular(RichTxtMemo, " " & My.Settings.Mazimute & " ")
                If My.Settings.NchkNAzi = True Then
                    AddTxtBold(RichTxtMemo, azi)
                Else
                    AddTxtRegular(RichTxtMemo, azi)
                End If

                'Distância
                dist = DataGridView1.Rows(i).Cells(3).Value
                dist = formataDec(dist, "dist") & " " & My.Settings.Munidade

                AddTxtRegular(RichTxtMemo, " " & My.Settings.Mdist & " ")
                If My.Settings.NchkNDis = True Then
                    AddTxtBold(RichTxtMemo, dist & " ")
                Else
                    AddTxtRegular(RichTxtMemo, dist & " ")
                End If
            Next 'Fim dos pontos

            'Volta ao primeiro ponto, para fechar o perímetro
            ponto = DataGridView1.Rows(0).Cells(0).Value

            'Nome ponto
            AddTxtRegular(RichTxtMemo, My.Settings.Mligacao & " ")
            If My.Settings.NchkNPto = True Then
                AddTxtBold(RichTxtMemo, ponto)
            Else
                AddTxtRegular(RichTxtMemo, ponto)
            End If

            AddTxtRegular(RichTxtMemo, ", " & My.Settings.Mfim)

            'Nova linha
            RichTxtMemo.AppendText(vbNewLine)

            'Coloca as informações cartográficas corretas
            Dim longitude As String
            Dim hemisferio As String

            If cboLongitude.Text = "W" Then
                longitude = cboMC.Text & " WGr, "
            Else
                longitude = cboMC.Text & " EGr, "
            End If

            If cboHemisferio.Text = "Sul" Then
                hemisferio = cboFuso.Text & "S"
            Else
                hemisferio = cboFuso.Text & "N"
            End If

            Dim paragFinal As String = "Todas as coordenadas aqui descritas estão georreferenciadas ao Sistema Geodésico Brasileiro e encontram-se representadas no Sistema UTM, referenciadas ao Meridiano Central " & longitude & "fuso " & hemisferio & ", tendo como datum o " & txtDatum.Text & ". Todos os azimutes e distâncias, área e perímetro foram calculados no plano de projeção UTM."
            AddTxtRegular(RichTxtMemo, vbTab & paragFinal)

            'Espaço entre texto e assinatura
            If txtCidade.TextLength > 0 OrElse chkData.Checked = True OrElse optHoje.Checked = True OrElse _
                OptOutra.Checked = True OrElse txtNomeProf.TextLength > 0 OrElse txtRegistro.TextLength > 0 Then
                With RichTxtMemo
                    .AppendText(vbNewLine)
                    .AppendText(vbNewLine)
                    .AppendText(vbNewLine)
                    .AppendText(vbNewLine)
                End With
            End If

            'Cidade
            If txtCidade.TextLength > 0 Then
                If My.Settings.NchkNCid = True Then
                    AppendCenterBold(RichTxtMemo, txtCidade.Text)
                Else
                    AppendCenter(RichTxtMemo, txtCidade.Text)
                End If
            End If

            'Data
            If chkData.Checked = True Then
                If optHoje.Checked = True Then
                    Dim culture As New CultureInfo("pt-BR")
                    Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat

                    Dim dia As Integer = DateTime.Now.Day
                    Dim ano As Integer = DateTime.Now.Year
                    Dim mes As String = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month))
                    Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek))
                    Dim data As String = diasemana & ", " & dia & " de " & mes & " de " & ano

                    If txtCidade.TextLength > 0 Then
                        If My.Settings.NchkNDat = True Then
                            AppendCenterBold(RichTxtMemo, ", " & data)
                        Else
                            AppendCenter(RichTxtMemo, ", " & data)
                        End If
                    Else
                        If My.Settings.NchkNDat = True Then
                            AppendCenterBold(RichTxtMemo, data)
                        Else
                            AppendCenter(RichTxtMemo, data)
                        End If
                    End If
                End If
                If OptOutra.Checked = True Then
                    If My.Settings.NchkNDat Then
                        AppendCenterBold(RichTxtMemo, txtData.Text)
                    Else
                        AppendCenter(RichTxtMemo, txtData.Text)
                    End If
                End If
            End If

            'Profissional
            If txtNomeProf.TextLength > 0 Then
                With RichTxtMemo
                    .AppendText(vbNewLine)
                    .AppendText(vbNewLine)
                    .AppendText(vbNewLine)
                    .AppendText(vbNewLine)
                End With
                AppendCenter(RichTxtMemo, txtAssinatura.Text)
            End If
            If txtNomeProf.TextLength > 0 Then
                RichTxtMemo.AppendText(vbNewLine)
                If My.Settings.NchkNPro = True Then
                    AppendCenterBold(RichTxtMemo, txtNomeProf.Text)
                Else
                    AppendCenter(RichTxtMemo, txtNomeProf.Text)
                End If
            End If
            If txtRegistro.TextLength > 0 Then
                RichTxtMemo.AppendText(vbNewLine)
                If My.Settings.NchkNReg = True Then
                    AppendCenterBold(RichTxtMemo, txtRegistro.Text)
                Else
                    AppendCenter(RichTxtMemo, txtRegistro.Text)
                End If
            End If

            RichTxtMemo.AppendText(vbNewLine)

        Else
            MessageBox.Show("Não há dados na tabela para gerar o Memorial Descritivo." & _
                               vbNewLine & "Você precisa adicionar os vértices do imóvel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TabControl1.SelectedTab = TabPage2
        End If
    End Sub

    'Ao selecionar a Guia 'Memorial Descritivo', verifica se antes tem dados na tabela para gerar texto
    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If Me.TabControl1.SelectedTab.Text = "Memorial Descritivo" Then
            If ToolStripBtnEdit.Enabled = False Then 'Para verificar se tem dados, resolvi ver se o botão 'Editar' está ativo
                MessageBox.Show("Não há dados na tabela para gerar o Memorial Descritivo." & _
                                vbNewLine & "Você precisa adicionar os vértices do imóvel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.TabControl1.SelectedTab = TabPage2
            End If
        End If
    End Sub

    'Caso haja alteração nos dados do Imóvel
    Private Sub txtImovel_TextChanged(sender As Object, e As EventArgs) Handles txtProprietario.TextChanged, txtPerimetro.TextChanged, txtMunicipio.TextChanged, txtMatricula.TextChanged, txtImovel.TextChanged, txtDatum.TextChanged, txtComarca.TextChanged, txtCodIncra.TextChanged, txtCartorio.TextChanged, txtAreaha.TextChanged, txtArea.TextChanged, cboMC.TextChanged, cboLongitude.TextChanged, cboHemisferio.TextChanged, cboFuso.TextChanged
        verifica_salvo(False, frmPai.NomeProjeto)
    End Sub

    'Caso haja alteração nos dados do Profissional
    Private Sub txtCidade_TextChanged(sender As Object, e As EventArgs) Handles txtRegistro.TextChanged, txtNomeProf.TextChanged, txtData.TextChanged, txtCidade.TextChanged
        verifica_salvo(False, frmPai.NomeProjeto)
    End Sub

    'Caso haja alteração na tabela
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        verifica_salvo(False, frmPai.NomeProjeto)
    End Sub

End Class

'Classe para colorir os botões do ToolStrip diferente
'Fonte: https://msdn.microsoft.com/pt-br/library/ms171698(v=vs.110).aspx
Class MyColorTable
    Inherits ProfessionalColorTable
    'Botão
    Public Overrides ReadOnly Property ButtonPressedGradientBegin() As Color
        Get
            Return Color.FromArgb(253, 204, 152)
        End Get
    End Property
    'Botão
    Public Overrides ReadOnly Property ButtonPressedGradientEnd() As System.Drawing.Color
        Get
            Return Color.FromArgb(248, 143, 44)
        End Get
    End Property
    'Botão
    Public Overrides ReadOnly Property ButtonSelectedGradientBegin() As Color
        Get
            Return Color.FromArgb(255, 250, 211)
        End Get
    End Property
    'Botão
    Public Overrides ReadOnly Property ButtonSelectedGradientEnd() As System.Drawing.Color
        Get
            Return Color.FromArgb(255, 216, 80)
        End Get
    End Property

    'Menu
    Public Overrides ReadOnly Property ToolStripGradientBegin() As Color
        Get
            Return Color.FromArgb(234, 244, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientMiddle() As Color
        Get
            Return Color.FromArgb(211, 226, 244)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientEnd() As Color
        Get
            Return Color.FromArgb(234, 244, 255)
        End Get
    End Property
End Class
