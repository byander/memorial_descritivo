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

    'Digitar apenas números em campos
    Public Sub so_numeros(e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ",", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
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
End Class
