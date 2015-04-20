<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormatoCSV
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DeliEsp = New System.Windows.Forms.RadioButton()
        Me.DeliVir = New System.Windows.Forms.RadioButton()
        Me.DeliPtV = New System.Windows.Forms.RadioButton()
        Me.DeliTab = New System.Windows.Forms.RadioButton()
        Me.BtnSalvaFormato = New System.Windows.Forms.Button()
        Me.BtnCancelaFormato = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OptPonto = New System.Windows.Forms.RadioButton()
        Me.OptVirgula = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 30)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Esta tela permite que você defina os delimitadores que seus " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dados contém."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.DeliEsp)
        Me.GroupBox1.Controls.Add(Me.DeliVir)
        Me.GroupBox1.Controls.Add(Me.DeliPtV)
        Me.GroupBox1.Controls.Add(Me.DeliTab)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 73)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delimitadores"
        '
        'DeliEsp
        '
        Me.DeliEsp.AutoSize = True
        Me.DeliEsp.Location = New System.Drawing.Point(224, 21)
        Me.DeliEsp.Name = "DeliEsp"
        Me.DeliEsp.Size = New System.Drawing.Size(66, 19)
        Me.DeliEsp.TabIndex = 7
        Me.DeliEsp.Text = "Espaço"
        Me.DeliEsp.UseVisualStyleBackColor = True
        '
        'DeliVir
        '
        Me.DeliVir.AutoSize = True
        Me.DeliVir.Location = New System.Drawing.Point(224, 46)
        Me.DeliVir.Name = "DeliVir"
        Me.DeliVir.Size = New System.Drawing.Size(63, 19)
        Me.DeliVir.TabIndex = 6
        Me.DeliVir.Text = "Vírgula"
        Me.DeliVir.UseVisualStyleBackColor = True
        '
        'DeliPtV
        '
        Me.DeliPtV.AutoSize = True
        Me.DeliPtV.Checked = True
        Me.DeliPtV.Location = New System.Drawing.Point(83, 21)
        Me.DeliPtV.Name = "DeliPtV"
        Me.DeliPtV.Size = New System.Drawing.Size(106, 19)
        Me.DeliPtV.TabIndex = 5
        Me.DeliPtV.TabStop = True
        Me.DeliPtV.Text = "Ponto e vírgula"
        Me.DeliPtV.UseVisualStyleBackColor = True
        '
        'DeliTab
        '
        Me.DeliTab.AutoSize = True
        Me.DeliTab.Location = New System.Drawing.Point(83, 46)
        Me.DeliTab.Name = "DeliTab"
        Me.DeliTab.Size = New System.Drawing.Size(83, 19)
        Me.DeliTab.TabIndex = 4
        Me.DeliTab.Text = "Tabulação"
        Me.DeliTab.UseVisualStyleBackColor = True
        '
        'BtnSalvaFormato
        '
        Me.BtnSalvaFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvaFormato.Location = New System.Drawing.Point(222, 211)
        Me.BtnSalvaFormato.Name = "BtnSalvaFormato"
        Me.BtnSalvaFormato.Size = New System.Drawing.Size(75, 45)
        Me.BtnSalvaFormato.TabIndex = 7
        Me.BtnSalvaFormato.Text = "Salvar"
        Me.BtnSalvaFormato.UseVisualStyleBackColor = True
        '
        'BtnCancelaFormato
        '
        Me.BtnCancelaFormato.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelaFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelaFormato.Location = New System.Drawing.Point(305, 211)
        Me.BtnCancelaFormato.Name = "BtnCancelaFormato"
        Me.BtnCancelaFormato.Size = New System.Drawing.Size(75, 45)
        Me.BtnCancelaFormato.TabIndex = 8
        Me.BtnCancelaFormato.Text = "Cancelar"
        Me.BtnCancelaFormato.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.OptPonto)
        Me.GroupBox2.Controls.Add(Me.OptVirgula)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 84)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Separador Decimal"
        '
        'OptPonto
        '
        Me.OptPonto.AutoSize = True
        Me.OptPonto.Location = New System.Drawing.Point(103, 50)
        Me.OptPonto.Name = "OptPonto"
        Me.OptPonto.Size = New System.Drawing.Size(176, 19)
        Me.OptPonto.TabIndex = 4
        Me.OptPonto.Text = "Ponto (Formato Americano)"
        Me.OptPonto.UseVisualStyleBackColor = True
        '
        'OptVirgula
        '
        Me.OptVirgula.AutoSize = True
        Me.OptVirgula.Checked = True
        Me.OptVirgula.Location = New System.Drawing.Point(103, 25)
        Me.OptVirgula.Name = "OptVirgula"
        Me.OptVirgula.Size = New System.Drawing.Size(175, 19)
        Me.OptVirgula.TabIndex = 3
        Me.OptVirgula.TabStop = True
        Me.OptVirgula.Text = "Vírgula (Formato Brasileiro)"
        Me.OptVirgula.UseVisualStyleBackColor = True
        '
        'frmFormatoCSV
        '
        Me.AcceptButton = Me.BtnSalvaFormato
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnCancelaFormato
        Me.ClientSize = New System.Drawing.Size(384, 262)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnSalvaFormato)
        Me.Controls.Add(Me.BtnCancelaFormato)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "frmFormatoCSV"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formato para importação CSV"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalvaFormato As System.Windows.Forms.Button
    Friend WithEvents BtnCancelaFormato As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OptPonto As System.Windows.Forms.RadioButton
    Friend WithEvents OptVirgula As System.Windows.Forms.RadioButton
    Friend WithEvents DeliEsp As System.Windows.Forms.RadioButton
    Friend WithEvents DeliVir As System.Windows.Forms.RadioButton
    Friend WithEvents DeliPtV As System.Windows.Forms.RadioButton
    Friend WithEvents DeliTab As System.Windows.Forms.RadioButton
End Class
