Imports System.Net  'Para conexão com a internet para atualizar o programa

Public Class funcoes

    'Mostrar no Título do form
    Public Shared Sub titulo_form(nomeProjeto As String, versao As String)
        frmPai.Text = "Gerar Memorial Descritivo - v" & versao & " - " & nomeProjeto
    End Sub

    'Verifica se o arquivo do projeto foi salvo
    Public Shared Sub verifica_salvo(status As Boolean, nomeProjeto As String)
        Dim ver As Version = My.Application.Info.Version
        Dim versao As String = ver.Major & "." & ver.Minor & "." & ver.MajorRevision & "." & ver.MinorRevision

        'Se o arquivo foi salvo
        If status = False Then
            titulo_form(nomeProjeto & " *", versao)
        Else
            titulo_form(nomeProjeto, versao)
        End If
    End Sub

    'Na importação do Verificação do CSV, verificar caso a distância esteja nulo
    'Fonte: http://stackoverflow.com/questions/222834/handling-dbnull-data-in-vb-net
    Public Shared Function NotNull(Of T)(ByVal Value As T, ByVal DefaultValue As T) As T
        If Value Is Nothing OrElse IsDBNull(Value) Then
            Return DefaultValue
        Else
            Return Value
        End If
    End Function

    'Somar nas caixas de Casas decimais
    'Foi necessário fazer esta função, pois as caixas do Ribbon não somam automaticamente
    Public Shared Function soma1(valor As String) As String
        If valor < 4 Then
            valor = CInt(valor) + 1
        End If
        Return valor
    End Function

    'Somar nas caixas de Casas decimais
    'Foi necessário fazer esta função, pois as caixas do Ribbon não somam automaticamente
    Public Shared Function subtrai1(valor As String) As String
        If valor > 0 Then
            valor = CInt(valor) - 1
        End If
        Return valor
    End Function

    'formatação de casas decimais na tabela de coordenada
    Public Shared Sub formataCoordenadaTabela(valor As Integer)
        Select Case valor
            Case 0
                With frmImovel.DataGridView1
                    .Columns(1).DefaultCellStyle.Format = "#,###."
                    .Columns(2).DefaultCellStyle.Format = "#,###."
                End With
            Case 1
                With frmImovel.DataGridView1
                    .Columns(1).DefaultCellStyle.Format = "#,###0.0"
                    .Columns(2).DefaultCellStyle.Format = "#,###0.0"
                End With
            Case 2
                With frmImovel.DataGridView1
                    .Columns(1).DefaultCellStyle.Format = "#,###0.00"
                    .Columns(2).DefaultCellStyle.Format = "#,###0.00"
                End With
            Case 3
                With frmImovel.DataGridView1
                    .Columns(1).DefaultCellStyle.Format = "#,###0.000"
                    .Columns(2).DefaultCellStyle.Format = "#,###0.000"
                End With
            Case 4
                With frmImovel.DataGridView1
                    .Columns(1).DefaultCellStyle.Format = "#,###0.0000"
                    .Columns(2).DefaultCellStyle.Format = "#,###0.0000"
                End With
        End Select
    End Sub

    'formatação de casas decimais da distância 2
    Public Shared Sub formataDistanciaTabela(valor As Integer)
        Select Case valor
            Case 0
                frmImovel.DataGridView1.Columns(3).DefaultCellStyle.Format = "#,###."
            Case 1
                frmImovel.DataGridView1.Columns(3).DefaultCellStyle.Format = "#,###0.0"
            Case 2
                frmImovel.DataGridView1.Columns(3).DefaultCellStyle.Format = "#,###0.00"
            Case 3
                frmImovel.DataGridView1.Columns(3).DefaultCellStyle.Format = "#,###0.000"
            Case 4
                frmImovel.DataGridView1.Columns(3).DefaultCellStyle.Format = "#,###0.0000"
        End Select
    End Sub

    'formatação de casas decimais da distância
    'tipo: dist, coord, azi
    Public Shared Function formataDec(valor As Double, tipo As String) As String
        Dim CasaDec As String = ""
        Select Case tipo
            Case "dist"
                CasaDec = frmPai.RibArredDist.TextBoxText
            Case "coord"
                CasaDec = frmPai.RibArredCoo.TextBoxText
            Case "azi"
                CasaDec = frmPai.RibArredAzi.TextBoxText
        End Select
        Select Case CasaDec
            Case "0"
                Return valor.ToString("#,###.")
            Case "1"
                Return valor.ToString("#,###0.0")
            Case "2"
                Return valor.ToString("#,###0.00")
            Case "3"
                Return valor.ToString("#,###0.000")
            Case "4"
                Return valor.ToString("#,###0.0000")
        End Select
        Return valor
    End Function

    'Função para mostrar Azimute em GMS
    Public Shared Function dd2dms(valor As Double) As String
        Dim CasaDec As String = frmPai.RibArredAzi.TextBoxText
        Select Case CasaDec
            Case "0"
                Return valor.ToString("0° .00´ 00´´").Replace("° ,", "° ").Replace("´", "'")
                Exit Select
            Case "1"
                Return valor.ToString("0° .00´ 00','0´´").Replace("° ,", "° ").Replace("´", "'")
                Exit Select
            Case "2"
                Return valor.ToString("0° .00´ 00','00´´").Replace("° ,", "° ").Replace("´", "'")
                Exit Select
            Case "3"
                Return valor.ToString("0° .00´ 00','000´´").Replace("° ,", "° ").Replace("´", "'")
                Exit Select
            Case "4"
                Return valor.ToString("0° .00´ 00','0000´´").Replace("° ,", "° ").Replace("´", "'")
                Exit Select
            Case Else
                Return valor.ToString("0° .00´ 00´´").Replace("° ,", "° ").Replace("´", "'")
                Exit Select
        End Select
    End Function

    'formatação de casas decimais no Memorial Descritivo para Área (m), Área (ha) e Perímetro (m)
    Public Shared Function formataCasaDecimais(valor As Double, CasaDec As String) As String
        Select Case CasaDec
            Case "0"
                Return valor.ToString("#,###.")
                Exit Select
            Case "1"
                Return valor.ToString("#,###0.0")
                Exit Select
            Case "2"
                Return valor.ToString("#,###0.00")
                Exit Select
            Case "3"
                Return valor.ToString("#,###0.000")
                Exit Select
            Case "4"
                Return valor.ToString("#,###0.0000")
                Exit Select
            Case Else
                Return valor.ToString("#,###0.00")
                '  return Convert.ToDouble(valor.ToString("#,###0.000"));
                Exit Select
        End Select
    End Function

    'Adicionar texto regular
    Public Shared Sub AddTxtRegular(ByVal RTC As RichTextBox, ByVal text As String)
        With RTC
            .Select(.TextLength, 0)
            .SelectionFont = New Font(.SelectionFont, FontStyle.Regular)
            .AppendText(text)
        End With
    End Sub

    'Adicionar texto regular no centro
    Public Shared Sub AppendCenter(ByVal RTC As RichTextBox, ByVal text As String)
        With RTC
            .SelectionAlignment = HorizontalAlignment.Center
            .AppendText(text)
            .SelectionFont = New Font(RTC.Font, FontStyle.Regular)
        End With
    End Sub

    'Adicionar texto em negrito
    Public Shared Sub AddTxtBold(ByVal RTC As RichTextBox, ByVal text As String)
        With RTC
            .Select(.TextLength, 0)
            .SelectionFont = New Font(.SelectionFont, FontStyle.Bold)
            .AppendText(text)
        End With
    End Sub

    'Adicionar texto em negrito no Centro
    Public Shared Sub AppendCenterBold(ByVal RTC As RichTextBox, ByVal text As String)
        With RTC
            .SelectionFont = New Font(RTC.Font, FontStyle.Bold)
            .SelectionAlignment = HorizontalAlignment.Center
            .AppendText(text)
            .SelectionFont = New Font(RTC.Font, FontStyle.Regular)
        End With
    End Sub

    'Limpar dados dos campos do Imóvel
    Public Shared Sub limpaDadosImovel()
        With frmImovel
            .txtImovel.Text = ""
            .txtMunicipio.Text = ""
            .txtMatricula.Text = ""
            .txtComarca.Text = ""
            .txtCartorio.Text = ""
            .txtCodIncra.Text = ""
            .txtProprietario.Text = ""
            .chkArea.Checked = False
            .txtArea.Text = ""
            .NumDecAream.Value = 2
            .chkAreaha.Checked = False
            .txtAreaha.Text = ""
            .NumDecAreaha.Value = 4
            .chkPer.Checked = False
            .txtPerimetro.Text = ""
            .NumDecPer.Value = 2
            .cboMC.Text = "51"
            .cboLongitude.Text = "W"
            .cboFuso.Text = "22"
            .cboHemisferio.Text = "Sul"
            .txtDatum.Text = "SIRGAS-2000"
        End With
    End Sub

    'Limpar dados dos campos do Profissional
    Public Shared Sub limpaDadosProfi()
        With frmImovel
            .txtNomeProf.Text = ""
            .txtRegistro.Text = ""
            .txtCidade.Text = ""
            .txtData.Text = ""
        End With
    End Sub

    'Limpar dados da tabela
    Public Shared Sub limpaDadosTabela()
        If (frmImovel.DataGridView1.Rows.Count > 0) Then
            frmImovel.DataGridView1.DataSource.rows.clear()
        End If
    End Sub

    'Desabilita Botões
    Public Shared Sub disable_botoes()
        With frmImovel
            .ToolStripBtnExpCSV.Enabled = False
            .ToolStripBtnEdit.Enabled = False
            .ToolStripBtnDel.Enabled = False
        End With
    End Sub

    Public Shared Sub checaAtualizacao()
        'Primeiro checa conexão se tem Internet
        Dim flag As Boolean
        Try
            My.Computer.Network.Ping("www.google.com.br", 500)
            flag = True
        Catch ex As Exception
            flag = False
        End Try

        'Caso houver a conexão
        If flag = True Then
            Dim web As New WebClient
            Dim ultimaVersao As String = web.DownloadString("https://raw.githubusercontent.com/byander/memorial_descritivo/publish/versao.txt")
            Dim versaoAtual As String = My.Application.Info.Version.ToString

            If versaoAtual < ultimaVersao Then
                If MessageBox.Show("Há uma nova versão disponível!" & vbNewLine & "Você deseja atualizar?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    System.Diagnostics.Process.Start("http://byander.github.io/memorial_descritivo/")
                Else
                End If
            Else
                MessageBox.Show("O programa já está atualizado.", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'Checa atualizacao no Label do form filho
    Public Shared Function checaAtualizacao2() As Boolean
        Dim flag As Boolean
        If checaConexao() = True Then
            Dim web As New WebClient
            Dim ultimaVersao As String = web.DownloadString("https://raw.githubusercontent.com/byander/memorial_descritivo/publish/versao.txt")
            Dim versaoAtual As String = My.Application.Info.Version.ToString

            If versaoAtual < ultimaVersao Then
                flag = True
            Else
                flag = False
            End If
        End If
        Return flag
    End Function

    'Checa conexão com internet no Label do form filho
    Public Shared Function checaConexao() As Boolean
        Try
            My.Computer.Network.Ping("www.google.com.br", 500)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
