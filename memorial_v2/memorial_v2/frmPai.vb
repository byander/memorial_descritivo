Imports System.IO
Imports System.Globalization
Imports System.Text

Imports System.Version
Imports System.Xml

Imports memorial_v2.funcoes

Public Class frmPai

    Public Shared Property arqProjeto() As String
        Get
            Return m_arqProjeto
        End Get
        Set(value As String)
            m_arqProjeto = value
        End Set
    End Property
    Public Shared m_arqProjeto As String

    Public Shared Property NomeProjeto() As String
        Get
            Return m_NomeProjeto
        End Get
        Set(value As String)
            m_NomeProjeto = value
        End Set
    End Property
    Public Shared m_NomeProjeto As String

    Dim ver As Version = My.Application.Info.Version
    Dim versao As String = ver.Major & "." & ver.Minor & "." & ver.MajorRevision & "." & ver.MinorRevision
    Public Initializing As Boolean = True 'Para prevenir que form verifique se houve alteração nos campos antes do carregamento total

    Public Sub New()
        InitializeComponent()
        Initializing = True
    End Sub

    'Carregando do form
    Private Sub frmPai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Application.OpenForms.OfType(Of frmImovel)().Count > 0 Then
        Else
            'Dim frmimovel As frmImovel
            frmImovel.MdiParent = Me
            frmImovel.Show()
        End If

        'Form
        NomeProjeto = "Sem título"
        titulo_form(NomeProjeto, versao)

        Initializing = False
    End Sub

    'Atalhos do teclado
    Private Sub frmPai_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Novo projeto
        If e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.N Then
                ribBtnNovo_Click(sender, e)
            End If
        End If

        'Abrir projeto
        If e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.O Then
                RibBtnAbre_Click(sender, e)
            End If
        End If

        'Salvar projeto
        If e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.S Then
                RibBtnSave_Click(sender, e)
            End If
        End If

        'Sair projeto
        If e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.W Then
                RibBtnSair_Click(sender, e)
            End If
        End If
    End Sub

    'Caixas das Casas Decimais
    'Caixa Distância
    Private Sub RibArredDist_UpButtonClicked(sender As Object, e As MouseEventArgs) Handles RibArredDist.UpButtonClicked
        RibArredDist.TextBoxText = soma1(RibArredDist.TextBoxText)
    End Sub

    Private Sub RibArredDist_DownButtonClicked(sender As Object, e As MouseEventArgs) Handles RibArredDist.DownButtonClicked
        RibArredDist.TextBoxText = subtrai1(RibArredDist.TextBoxText)
    End Sub

    'Caixa Coordenada
    Private Sub RibArredCoo_UpButtonClicked(sender As Object, e As MouseEventArgs) Handles RibArredCoo.UpButtonClicked
        RibArredCoo.TextBoxText = soma1(RibArredCoo.TextBoxText)
    End Sub

    Private Sub RibArredCoo_DownButtonClicked(sender As Object, e As MouseEventArgs) Handles RibArredCoo.DownButtonClicked
        RibArredCoo.TextBoxText = subtrai1(RibArredCoo.TextBoxText)
    End Sub

    'Caixa Azimute
    Private Sub RibArredAzi_UpButtonClicked(sender As Object, e As MouseEventArgs) Handles RibArredAzi.UpButtonClicked
        RibArredAzi.TextBoxText = soma1(RibArredAzi.TextBoxText)
    End Sub

    Private Sub RibArredAzi_DownButtonClicked(sender As Object, e As MouseEventArgs) Handles RibArredAzi.DownButtonClicked
        RibArredAzi.TextBoxText = subtrai1(RibArredAzi.TextBoxText)
    End Sub

    'Definições do memorial
    Private Sub ribBtnDefTexto_Click(sender As Object, e As EventArgs) Handles ribBtnDefTexto.Click
        Dim frmDefTxtMemorial As New frmDefMemorial
        frmDefTxtMemorial.ShowDialog()
    End Sub

    'Formato CSV
    Private Sub ribBtnImoNovo_Click(sender As Object, e As EventArgs) Handles ribBtnImoNovo.Click
        Dim frmFormato As New frmFormatoCSV
        frmFormato.ShowDialog()
    End Sub

    'Salvar Projeto
    Private Sub RibBtnSave_Click(sender As Object, e As EventArgs) Handles RibBtnSave.Click
        'Se o projeto nunca foi salvo, ou seja, ainda não existe um arquivo .pmd
        If NomeProjeto = "Sem título" Then
            arquivodoProjeto() 'Abrir janela para novo arquivo
        Else 'Caso o projeto já exista
            XMlSaveImovelDados(arqProjeto)
            verifica_salvo(True, NomeProjeto)
        End If
    End Sub

    'Salvar Projeto - Abrir janela para novo arquivo
    Public Sub arquivodoProjeto()
        Dim arquivo As String
        With SaveProjeto
            .Title = "Salvar Projeto"
            .Filter = "Projeto Memorial Descritivo (*.pmd)|*.pmd"
            .FilterIndex = 2
            .RestoreDirectory = True
        End With
        If SaveProjeto.ShowDialog() = DialogResult.OK Then
            arquivo = SaveProjeto.FileName
            If [String].IsNullOrEmpty(arquivo) Then
                MessageBox.Show("Arquivo inválido", "Salvar Como", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                XMlSaveImovelDados(arquivo)
            End If
        End If
    End Sub

    'Projeto Salvar Como
    Private Sub RibBtnSaveAs_Click(sender As Object, e As EventArgs) Handles RibBtnSaveAs.Click
        Dim arquivo As String
        With SaveProjeto
            .Title = "Salvar Cópia do Projeto"
            .Filter = "Projeto Memorial Descritivo (*.pmd)|*.pmd"
            .FilterIndex = 2
            .RestoreDirectory = True
            .FileName = NomeProjeto
        End With
        If SaveProjeto.ShowDialog() = DialogResult.OK Then
            arquivo = SaveProjeto.FileName
            If [String].IsNullOrEmpty(arquivo) Then
                MessageBox.Show("Arquivo inválido", "Salvar Como", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                XMlSaveImovelDados(arquivo)
            End If
        End If
    End Sub

    'Salvar dados do projeto
    Private Sub XMlSaveImovelDados(arquivo As String)
        Dim writer As New XmlTextWriter(arquivo, System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Dados_Memorial_Descritivo")
        writer.WriteStartElement("imovel_dados")

        'Imóvel - Vetor dos nomes dos campos
        Dim arrayImovel As New ArrayList
        With arrayImovel
            .Add("Imovel")
            .Add("Municipio")
            .Add("Matricula")
            .Add("Comarca")
            .Add("Cartorio")
            .Add("CodIncra")
            .Add("Area")
            .Add("Areaha")
            .Add("Perimetro")
            .Add("Proprietario")
            .Add("MC")
            .Add("Longitude")
            .Add("Fuso")
            .Add("Hemisferio")
            .Add("Datum")
        End With

        'Imóvel - Vetor dos dados
        Dim dadosImovel As New ArrayList
        With dadosImovel
            .Add(frmImovel.txtImovel.Text)
            .Add(frmImovel.txtMunicipio.Text)
            .Add(frmImovel.txtMatricula.Text)
            .Add(frmImovel.txtComarca.Text)
            .Add(frmImovel.txtCartorio.Text)
            .Add(frmImovel.txtCodIncra.Text)
            .Add(frmImovel.txtArea.Text)
            .Add(frmImovel.txtAreaha.Text)
            .Add(frmImovel.txtPerimetro.Text)
            .Add(frmImovel.txtProprietario.Text)
            .Add(frmImovel.cboMC.Text)
            .Add(frmImovel.cboLongitude.Text)
            .Add(frmImovel.cboFuso.Text)
            .Add(frmImovel.cboHemisferio.Text)
            .Add(frmImovel.txtDatum.Text)
        End With

        'Imóvel - Preencher os dados
        Dim CasaDec1 As String = Convert.ToString(frmImovel.NumDecAream.Value)
        Dim CasaDec2 As String = Convert.ToString(frmImovel.NumDecAreaha.Value)
        Dim CasaDec3 As String = Convert.ToString(frmImovel.NumDecPer.Value)

        Dim i As Integer = 0
        For Each valor In dadosImovel
            If i = 6 Then
                XMlSaveDadosAtri(arrayImovel(i), valor, "casas", CasaDec1, writer)
            ElseIf i = 7 Then
                XMlSaveDadosAtri(arrayImovel(i), valor, "casas", CasaDec2, writer)
            ElseIf i = 8 Then
                XMlSaveDadosAtri(arrayImovel(i), valor, "casas", CasaDec3, writer)
            Else
                XMlSaveDados(arrayImovel(i), valor, writer)
            End If
            i = i + 1
        Next
        writer.WriteEndElement() 'Fim 'imovel'

        'Profissional
        writer.WriteStartElement("profissional")

        'Profissional - Vetor dos nomes dos campos
        Dim arrayProfi As New ArrayList
        With arrayProfi
            .Add("Cidade")
            .Add("Data")
            .Add("NomeProf")
            .Add("Registro")
        End With

        'Profissional - Vetor dos dados
        Dim dadosProfi As New ArrayList
        With dadosProfi
            .Add(frmImovel.txtCidade.Text)
            .Add(frmImovel.txtData.Text)
            .Add(frmImovel.txtNomeProf.Text)
            .Add(frmImovel.txtRegistro.Text)
        End With

        'Profissional - Preencher os dados
        Dim j As Integer = 0
        For Each valor In dadosProfi
            XMlSaveDados(arrayProfi(j), valor, writer)
            j = j + 1
        Next
        writer.WriteEndElement() 'Fim 'imovel'

        'Vértices da tabela
        'Primeiro verifica se há dados na tabela
        If frmImovel.DataGridView1.Rows.Count > 0 Then
            writer.WriteStartElement("vertices")
            Dim col0, col1, col2, col3, col4, col5, col6 As String
            For Each row As DataGridViewRow In frmImovel.DataGridView1.Rows
                col0 = row.Cells(0).Value
                col1 = row.Cells(1).Value
                col2 = row.Cells(2).Value
                col3 = row.Cells(3).Value.ToString
                col4 = row.Cells(4).Value
                col5 = row.Cells(5).Value
                col6 = row.Cells(6).Value
                XMlSaveDadosTabela(col0, col1, col2, col3, col4, col5, col6, writer)
            Next
            writer.WriteEndElement() 'Fim 'vertices'
        End If

        writer.WriteEndDocument()
        writer.Close()
    End Sub

    'Salvar dados no arquivo XML
    Private Sub XMlSaveDados(campo As String, ByVal valor As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement(campo)
        ' writer.WriteAttributeString(idatributo, atributo)
        writer.WriteString(valor)
        writer.WriteEndElement()
    End Sub

    'Salvar dados no arquivo XML com atributos das casas decimais
    Private Sub XMlSaveDadosAtri(campo As String, ByVal valor As String, ByVal idatributo As String, ByVal atributo As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement(campo)
        writer.WriteAttributeString(idatributo, atributo)
        writer.WriteString(valor)
        writer.WriteEndElement()
    End Sub

    'Salvar dados da tabela no arquivo XML
    Private Sub XMlSaveDadosTabela(ByVal col0 As String, col1 As String, col2 As String, col3 As String, col4 As String, col5 As String, col6 As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("vertice")
        writer.WriteStartElement("vertice_id")
        writer.WriteString(col0)
        writer.WriteEndElement()
        writer.WriteStartElement("coord_x")
        writer.WriteString(col1)
        writer.WriteEndElement()
        writer.WriteStartElement("coord_y")
        writer.WriteString(col2)
        writer.WriteEndElement()
        writer.WriteStartElement("distancia")
        writer.WriteString(col3)
        writer.WriteEndElement()
        writer.WriteStartElement("azimute")
        writer.WriteString(col4)
        writer.WriteEndElement()
        writer.WriteStartElement("confrontate")
        writer.WriteString(col5)
        writer.WriteEndElement()
        writer.WriteStartElement("divisa")
        writer.WriteString(col6)
        writer.WriteEndElement()
        writer.WriteEndElement()
    End Sub

    'Abrir projeto salvo
    Private Sub RibBtnAbre_Click(sender As Object, e As EventArgs) Handles RibBtnAbre.Click
        Dim status As Boolean
        status = Me.Text.Contains("*")

        'Se o título do form Pai conter o caracter '*', significa que o projeto não está salvo
        If status = True Then
            Dim result As Integer = MessageBox.Show("O projeto atual não está salvo. Você deseja salvar agora?", "Salvar Projeto", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                If arqProjeto Is Nothing Then 'Caso o projeto ainda não tenha título
                    arquivodoProjeto() 'Abre janela para salvar novo arquivo
                Else
                    XMlSaveImovelDados(arqProjeto)
                End If
                limpaDadosImovel() 'Imóvel - Dados
                limpaDadosProfi() 'Imóvel - Profissional
                limpaDadosTabela() 'Tabela
                disable_botoes() 'Desabilita botões
                frmImovel.RichTxtMemo.Text = "" 'Texto Memorial  
                AbrirProjeto()
            ElseIf result = DialogResult.No Then
                limpaDadosImovel() 'Imóvel - Dados
                limpaDadosProfi() 'Imóvel - Profissional
                limpaDadosTabela() 'Tabela
                disable_botoes() 'Desabilita botões
                frmImovel.RichTxtMemo.Text = "" 'Texto Memorial  
                AbrirProjeto()
            End If
        Else
            limpaDadosTabela() 'Tabela
            AbrirProjeto()
        End If
    End Sub

    'Abrir projeto salvo (Arquivo)
    Public Sub AbrirProjeto()
        With AbreProjeto
            .Filter = "Projeto Memorial Descritivo (*.pmd)|*.pmd"
            .FileName = ""
            .Title = "Abrir Projeto"
            .RestoreDirectory = True
        End With

        Dim result As DialogResult = AbreProjeto.ShowDialog
        If (result = DialogResult.OK) Then
            arqProjeto = AbreProjeto.FileName
            NomeProjeto = Path.GetFileNameWithoutExtension(arqProjeto)

            'Lê os dados
            LerProjetoXML(arqProjeto)

            'Habilitar os botões para editar e apagar
            With frmImovel
                .ToolStripBtnEdit.Enabled = True
                .ToolStripBtnDel.Enabled = True
                .ToolStripBtnExpCSV.Enabled = True
            End With

            'Título do form Pai
            titulo_form(NomeProjeto, versao)
        End If
    End Sub

    'Ler arquivo de projeto
    Private Sub LerProjetoXML(arqProjeto As String)
        'Cria uma instância de um documento XML
        Dim oXML As New XmlDocument

        'Define o caminho do arquivo XML 
        Dim ArquivoXML As String = arqProjeto

        'carrega o arquivo XML
        oXML.Load(ArquivoXML)

        Dim CasaDec1 As String = Convert.ToString(frmImovel.NumDecAream.Value)
        Dim CasaDec2 As String = Convert.ToString(frmImovel.NumDecAreaha.Value)
        Dim CasaDec3 As String = Convert.ToString(frmImovel.NumDecPer.Value)

        'Imóvel - Dados
        With frmImovel
            .txtImovel.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(0).InnerText
            .txtMunicipio.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(1).InnerText
            .txtMatricula.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(2).InnerText
            .txtComarca.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(3).InnerText
            .txtCartorio.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(4).InnerText
            .txtCodIncra.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(5).InnerText
            .txtArea.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(6).InnerText
            .NumDecAream.Value = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(6).Attributes(0).InnerText
            .txtAreaha.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(7).InnerText
            .NumDecAreaha.Value = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(7).Attributes(0).InnerText
            .txtPerimetro.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(8).InnerText
            .NumDecPer.Value = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(8).Attributes(0).InnerText
            .txtProprietario.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(9).InnerText
            .cboMC.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(10).InnerText
            .cboLongitude.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(11).InnerText
            .cboFuso.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(12).InnerText
            .cboHemisferio.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(13).InnerText
            .txtDatum.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("imovel_dados").ChildNodes(14).InnerText
        End With

        'Imóvel - Profissional
        With frmImovel
            .txtCidade.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("profissional").ChildNodes(0).InnerText
            .txtData.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("profissional").ChildNodes(1).InnerText
            .txtNomeProf.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("profissional").ChildNodes(2).InnerText
            .txtRegistro.Text = oXML.SelectSingleNode("Dados_Memorial_Descritivo").SelectSingleNode("profissional").ChildNodes(3).InnerText
        End With

        'Tabela - Vértices
        ' Define o nó para nova leitura
        Dim oNoLista As XmlNodeList
        oNoLista = oXML.SelectNodes("/Dados_Memorial_Descritivo/vertices")
        Dim oNoColunas As XmlNodeList
        oNoColunas = oXML.SelectNodes("/Dados_Memorial_Descritivo/vertices/vertice")

        Dim dt As New DataTable()
        dt = frmImovel.DataGridView1.DataSource

        'Primeiro, deixa as colunas Este e Norte para edição
        dt.Columns("Este").ReadOnly = False
        dt.Columns("Norte").ReadOnly = False
        dt.Columns("Distância").ReadOnly = False
        dt.Columns("Azimute").ReadOnly = False

        Dim row As DataRow

        Dim oNo As XmlNode
        Dim oCol As XmlNode
        For Each oNo In oNoLista
            For Each oCol In oNoColunas

                'Adiciona nova linha
                row = dt.NewRow()
                row("Vértice") = oCol.ChildNodes.Item(0).InnerText
                row("Este") = oCol.ChildNodes.Item(1).InnerText
                row("Norte") = oCol.ChildNodes.Item(2).InnerText
                If NotNull(oCol.ChildNodes.Item(3).InnerText, "") = "" Then
                Else
                    row("Distância") = oCol.ChildNodes.Item(3).InnerText
                End If
                row("Azimute") = oCol.ChildNodes.Item(4).InnerText
                row("Confrontante") = oCol.ChildNodes.Item(5).InnerText
                row("Divisa") = oCol.ChildNodes.Item(6).InnerText

                dt.Rows.Add(row) 'Insere os dados nas células
            Next
        Next

        'Formatação de Colunas
        'Casas decimais
        Dim CasaDecCoordenada As Integer = CInt(RibArredCoo.TextBoxText)
        formataCoordenadaTabela(CasaDecCoordenada)
        Dim CasaDecDist As Integer = CInt(RibArredDist.TextBoxText)
        formataDistanciaTabela(CasaDecDist)
    End Sub

    'Novo Projeto
    Private Sub ribBtnNovo_Click(sender As Object, e As EventArgs) Handles ribBtnNovo.Click
        Dim status As Boolean
        status = Me.Text.Contains("*")

        'Se o título do form Pai conter o caracter '*', significa que o projeto não está salvo
        If status = True Then
            Dim result As Integer = MessageBox.Show("O projeto atual não está salvo. Você deseja salvar agora?", "Salvar Projeto", MessageBoxButtons.YesNoCancel)

            If result = DialogResult.Yes Then
                If arqProjeto Is Nothing Then 'Caso o projeto ainda não tenha título
                    arquivodoProjeto() 'Abre janela para salvar novo arquivo
                Else
                    XMlSaveImovelDados(arqProjeto)
                End If
                limpaDadosImovel() 'Imóvel - Dados
                limpaDadosProfi() 'Imóvel - Profissional
                limpaDadosTabela() 'Tabela
                disable_botoes() 'Desabilita botões
                frmImovel.RichTxtMemo.Text = "" 'Texto Memorial  
                NomeProjeto = "Sem título"
                titulo_form(NomeProjeto, versao)
            ElseIf result = DialogResult.No Then
                limpaDadosImovel() 'Imóvel - Dados
                limpaDadosProfi() 'Imóvel - Profissional
                limpaDadosTabela() 'Tabela
                disable_botoes() 'Desabilita botões
                frmImovel.RichTxtMemo.Text = "" 'Texto Memorial  
                NomeProjeto = "Sem título"
                titulo_form(NomeProjeto, versao)
            End If
        Else
            limpaDadosImovel() 'Imóvel - Dados
            limpaDadosProfi() 'Imóvel - Profissional
            limpaDadosTabela() 'Tabela
            disable_botoes() 'Desabilita botões
            frmImovel.RichTxtMemo.Text = "" 'Texto Memorial
            NomeProjeto = "Sem título"
            titulo_form(NomeProjeto, versao)
        End If
    End Sub

    'Sair do aplicativo
    Private Sub RibBtnSair_Click(sender As Object, e As EventArgs) Handles RibBtnSair.Click
        SairAplicativo()
    End Sub

    'Ao sair do aplicativo
    Public Sub SairAplicativo()
        Me.Close()
    End Sub

    'Ao clicar no X do form
    Private Sub frmPai_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim status As Boolean
        status = Me.Text.Contains("*")

        'Se o título do form Pai conter o caracter '*', significa que o projeto não está salvo
        If status = True Then
            Dim result As Integer = MessageBox.Show("O projeto atual não está salvo. Você deseja salvar agora?", "Salvar Projeto", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                If arqProjeto Is Nothing Then 'Caso o projeto ainda não tenha título
                    arquivodoProjeto() 'Abre janela para salvar novo arquivo
                Else
                    XMlSaveImovelDados(arqProjeto)
                End If
            ElseIf result = DialogResult.No Then
            Else
                e.Cancel = True
            End If
        Else
        End If
    End Sub

    'Informação do programa
    Private Sub ribBtnSobre_Click(sender As Object, e As EventArgs) Handles ribBtnSobre.Click
        Dim frmSobre1 As New frmSobre
        frmSobre1.ShowDialog()
    End Sub

    'Verificar atualização
    Private Sub ribBtnAtualiza_Click(sender As Object, e As EventArgs) Handles ribBtnAtualiza.Click
        checaAtualizacao()
    End Sub
End Class
