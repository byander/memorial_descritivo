Public Class frmDefMemorial

    Private Sub frmDefMemorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.BringToFront()

        'Carregar dados salvos na memória
        'Memorial descritivo - Textos de ligação
        txtTitulo.Text = My.Settings.Mtitulo
        txtInicio.Text = My.Settings.Minicio
        txtCoord.Text = My.Settings.MCoord
        txtEste.Text = My.Settings.Meste
        txtNorte.Text = My.Settings.Mnorte
        txtLigacao.Text = My.Settings.Mligacao
        txtAzimute.Text = My.Settings.Mazimute
        txtDist.Text = My.Settings.Mdist
        txtUnidade.Text = My.Settings.Munidade
        txtConfronto.Text = My.Settings.Mconfronto
        txtDivisa.Text = My.Settings.Mdivisa
        txtFim.Text = My.Settings.Mfim
        chkRepeticao.Checked = My.Settings.Mrepeticao

        'Negritos
        chkNTit.Checked = My.Settings.NchkNTit
        chkNImo.Checked = My.Settings.NchkNImo
        chkNImoV.Checked = My.Settings.NchkNImoV
        chkNMun.Checked = My.Settings.NchkNMun
        chkNMunV.Checked = My.Settings.NchkNMunV
        chkNMat.Checked = My.Settings.NchkNMat
        chkNMatV.Checked = My.Settings.NchkNMatV
        chkNCom.Checked = My.Settings.NchkNCom
        chkNComV.Checked = My.Settings.NchkNComV
        chkNCar.Checked = My.Settings.NchkNCar
        chkNCarV.Checked = My.Settings.NchkNCarV
        chkNInc.Checked = My.Settings.NchkNInc
        chkNIncV.Checked = My.Settings.NchkNIncV
        chkNAre.Checked = My.Settings.NchkNAre
        chkNAreV.Checked = My.Settings.NchkNAreV
        chkNPer.Checked = My.Settings.NchkNPer
        chkNPerV.Checked = My.Settings.NchkNPerV
        chkNPro.Checked = My.Settings.NchkNPro
        chkNProV.Checked = My.Settings.NchkNProV
        chkNPto.Checked = My.Settings.NchkNPto
        chkNCoo.Checked = My.Settings.NchkNCoo
        chkNDis.Checked = My.Settings.NchkNDis
        chkNAzi.Checked = My.Settings.NchkNAzi
        chkNCon.Checked = My.Settings.NchkNCon
        chkNDiv.Checked = My.Settings.NchkNDiv
        chkNCid.Checked = My.Settings.NchkNCid
        chkNDat.Checked = My.Settings.NchkNDat
        chkNNom.Checked = My.Settings.NchkNNom
        chkNReg.Checked = My.Settings.NchkNReg

    End Sub

    Private Sub BtnCancelaFormato_Click(sender As Object, e As EventArgs) Handles BtnCancelaFormato.Click
        Me.Close()
    End Sub

    'Salva os dados na memória
    Private Sub BtnSalvaDef_Click(sender As Object, e As EventArgs) Handles BtnSalvaDef.Click
        'Memorial descritivo - Textos de ligação
        My.Settings.Mtitulo = txtTitulo.Text
        My.Settings.Minicio = txtInicio.Text
        My.Settings.MCoord = txtCoord.Text
        My.Settings.Meste = txtEste.Text
        My.Settings.Mnorte = txtNorte.Text
        My.Settings.Mligacao = txtLigacao.Text
        My.Settings.Mazimute = txtAzimute.Text
        My.Settings.Mdist = txtDist.Text
        My.Settings.Munidade = txtUnidade.Text
        My.Settings.Mconfronto = txtConfronto.Text
        My.Settings.Mdivisa = txtDivisa.Text
        My.Settings.Mfim = txtFim.Text
        My.Settings.Mrepeticao = chkRepeticao.Checked

        'Negritos
        My.Settings.NchkNTit = chkNTit.Checked
        My.Settings.NchkNImo = chkNImo.Checked
        My.Settings.NchkNImoV = chkNImoV.Checked
        My.Settings.NchkNMun = chkNMun.Checked
        My.Settings.NchkNMunV = chkNMunV.Checked
        My.Settings.NchkNMat = chkNMat.Checked
        My.Settings.NchkNMatV = chkNMatV.Checked
        My.Settings.NchkNCom = chkNCom.Checked
        My.Settings.NchkNComV = chkNComV.Checked
        My.Settings.NchkNCar = chkNCar.Checked
        My.Settings.NchkNCarV = chkNCarV.Checked
        My.Settings.NchkNInc = chkNInc.Checked
        My.Settings.NchkNIncV = chkNIncV.Checked
        My.Settings.NchkNAre = chkNAre.Checked
        My.Settings.NchkNAreV = chkNAreV.Checked
        My.Settings.NchkNPer = chkNPer.Checked
        My.Settings.NchkNPerV = chkNPerV.Checked
        My.Settings.NchkNPro = chkNPro.Checked
        My.Settings.NchkNProV = chkNProV.Checked
        My.Settings.NchkNPto = chkNPto.Checked
        My.Settings.NchkNCoo = chkNCoo.Checked
        My.Settings.NchkNDis = chkNDis.Checked
        My.Settings.NchkNAzi = chkNAzi.Checked
        My.Settings.NchkNCon = chkNCon.Checked
        My.Settings.NchkNDiv = chkNDiv.Checked
        My.Settings.NchkNCid = chkNCid.Checked
        My.Settings.NchkNDat = chkNDat.Checked
        My.Settings.NchkNNom = chkNNom.Checked
        My.Settings.NchkNReg = chkNReg.Checked

        'Salva na memória
        My.Settings.Save()

        'Mostra o label informando que os dados foram salvos
        LblStatus.Visible = True
        TimerLblStatus.Start()
    End Sub

    Private Sub TimerLblStatus_Tick(sender As Object, e As EventArgs) Handles TimerLblStatus.Tick
        LblStatus.Visible = False
        TimerLblStatus.Stop()
    End Sub

    'Restaurar valores padrão
    Private Sub BtnValorPadrao_Click(sender As Object, e As EventArgs) Handles BtnValorPadrao.Click
        My.Settings.Reset()

        'Memorial descritivo
        txtTitulo.Text = My.Settings.Mtitulo
        txtInicio.Text = My.Settings.Minicio
        txtCoord.Text = My.Settings.MCoord
        txtEste.Text = My.Settings.Meste
        txtNorte.Text = My.Settings.Mnorte
        txtLigacao.Text = My.Settings.Mligacao
        txtAzimute.Text = My.Settings.Mazimute
        txtDist.Text = My.Settings.Mdist
        txtUnidade.Text = My.Settings.Munidade
        txtConfronto.Text = My.Settings.Mconfronto
        txtDivisa.Text = My.Settings.Mdivisa
        txtFim.Text = My.Settings.Mfim
        chkRepeticao.Checked = My.Settings.Mrepeticao

        'Negritos
        chkNTit.Checked = My.Settings.NchkNTit
        chkNImo.Checked = My.Settings.NchkNImo
        chkNImoV.Checked = My.Settings.NchkNImoV
        chkNMun.Checked = My.Settings.NchkNMun
        chkNMunV.Checked = My.Settings.NchkNMunV
        chkNMat.Checked = My.Settings.NchkNMat
        chkNMatV.Checked = My.Settings.NchkNMatV
        chkNCom.Checked = My.Settings.NchkNCom
        chkNComV.Checked = My.Settings.NchkNComV
        chkNCar.Checked = My.Settings.NchkNCar
        chkNCarV.Checked = My.Settings.NchkNCarV
        chkNInc.Checked = My.Settings.NchkNInc
        chkNIncV.Checked = My.Settings.NchkNIncV
        chkNAre.Checked = My.Settings.NchkNAre
        chkNAreV.Checked = My.Settings.NchkNAreV
        chkNPer.Checked = My.Settings.NchkNPer
        chkNPerV.Checked = My.Settings.NchkNPerV
        chkNPro.Checked = My.Settings.NchkNPro
        chkNProV.Checked = My.Settings.NchkNProV
        chkNPto.Checked = My.Settings.NchkNPto
        chkNCoo.Checked = My.Settings.NchkNCoo
        chkNDis.Checked = My.Settings.NchkNDis
        chkNAzi.Checked = My.Settings.NchkNAzi
        chkNCon.Checked = My.Settings.NchkNCon
        chkNDiv.Checked = My.Settings.NchkNDiv
        chkNCid.Checked = My.Settings.NchkNCid
        chkNDat.Checked = My.Settings.NchkNDat
        chkNNom.Checked = My.Settings.NchkNNom
        chkNReg.Checked = My.Settings.NchkNReg
    End Sub
End Class