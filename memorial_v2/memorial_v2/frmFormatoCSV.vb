Public Class frmFormatoCSV

    Private Sub frmFormatoCSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.BringToFront()

        'Coletar as informações salvas na memória
        'Delimidator
        Select Case My.Settings.Delimitador
            Case "esp"
                DeliEsp.Checked = True
            Case ";"
                DeliPtV.Checked = True
            Case "tab"
                DeliTab.Checked = True
            Case ","
                DeliVir.Checked = True
        End Select

        'Separador Decimal
        Select Case My.Settings.SepDecimal
            Case "."
                OptPonto.Checked = True
            Case ","
                OptVirgula.Checked = True
        End Select
    End Sub

    Private Sub BtnCancelaFormato_Click(sender As Object, e As EventArgs) Handles BtnCancelaFormato.Click
        Me.Close()
    End Sub

    'Salva as opções na memória
    Private Sub BtnSalvaFormato_Click(sender As Object, e As EventArgs) Handles BtnSalvaFormato.Click

        'Delimitadores
        If DeliEsp.Checked = True Then 'Espaço
            My.Settings.Delimitador = "esp"
        ElseIf DeliPtV.Checked = True Then 'Ponto e vírgula (;)
            My.Settings.Delimitador = ";"
        ElseIf DeliTab.Checked = True Then 'Tabulação
            My.Settings.Delimitador = "tab"
        ElseIf DeliVir.Checked = True Then 'Vírgula
            My.Settings.Delimitador = ","
        End If

        'Separador decimal
        If OptVirgula.Checked = True Then
            My.Settings.SepDecimal = ","
        ElseIf OptPonto.Checked = True Then
            My.Settings.SepDecimal = "."
        End If

        My.Settings.Save()
        Me.Close()
    End Sub
End Class