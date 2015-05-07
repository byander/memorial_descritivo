Imports gera_memorial.funcoes

Public Class frmEditVertice

    Public valorLinha As Integer 'Linha da tabela

    'Variável para verificar se o form vai abrir para inserir ou atualizar dado. 0 = Novo, 1 = Editar
    Public tipo As Integer
    Dim dt As New DataTable()

    Private Sub frmDefImovel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.BringToFront()
        If tipo = 0 Then
            Me.Text = "Adicionar Vértice"
        ElseIf tipo = 1 Then
            Me.Text = "Editar Vértice"
        End if 
    End Sub

    Private Sub BtnCancela_Click(sender As Object, e As EventArgs) Handles BtnCancela.Click
        Me.Close()
    End Sub

    'Salva/Atualiza os valores
    Private Sub BtnSalva_Click(sender As Object, e As EventArgs) Handles BtnSalva.Click
        Try
            'Veririca se os campos principais foram preenchidos
            If txtVertice.Text = "" Then
                MessageBox.Show("Entre com o vértice.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtVertice.Focus()
                Exit Sub
            ElseIf txtEste.Text = "" Then
                MessageBox.Show("Entre com a coordenada Este.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtEste.Focus()
                Exit Sub
            ElseIf txtNorte.Text = "" Then
                MessageBox.Show("Entre com a coordenada Norte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNorte.Focus()
                Exit Sub
            End If

            'Verifica se é para editar no inserir dado: 0 = Novo, 1 = Editar
            If tipo = 0 Then
                dt = frmImovel.DataGridView1.DataSource
                Dim row As DataRow
                row = dt.NewRow()
                row("Vértice") = txtVertice.Text
                row("Este") = txtEste.Text
                row("Norte") = txtNorte.Text
                row("Distância") = DBNull.Value
                row("Azimute") = ""
                row("Confrontante") = txtConfrontante.Text
                row("Divisa") = txtDivisa.Text
                dt.Rows.Add(row)
                'Verifica se a tabela está vazia para habilitar os botões 'Editar' e 'Apagar'
                If frmImovel.DataGridView1.Rows.Count > 0 Then
                    frmImovel.ToolStripBtnEdit.Enabled = True
                    frmImovel.ToolStripBtnDel.Enabled = True
                End If
                verifica_salvo(False, frmPai.NomeProjeto)
            ElseIf tipo = 1 Then
                frmImovel.DataGridView1.Item(0, valorLinha).Value() = txtVertice.Text
                frmImovel.DataGridView1.Item(1, valorLinha).Value() = txtEste.Text
                frmImovel.DataGridView1.Item(2, valorLinha).Value() = txtNorte.Text
                frmImovel.DataGridView1.Item(5, valorLinha).Value() = txtConfrontante.Text
                frmImovel.DataGridView1.Item(6, valorLinha).Value() = txtDivisa.Text
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Erro. " & ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Permitir somente número nas coordenadas Este
    Private Sub txtEste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEste.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ",", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    'Permitir somente número nas coordenadas Norte
    Private Sub txtNorte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNorte.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ",", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    'Fechar form com a tecla ESC
    Private Sub frmEditVertice_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub
End Class