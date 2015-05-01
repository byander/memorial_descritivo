Public NotInheritable Class frmSobre

    Private Sub frmSobre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Sobre o aplicativo {0}", ApplicationTitle)

        LabelVersion.Text = "Versão" & My.Application.Info.Version.ToString

        LabelVersion.Text = "Versão " & My.Application.Info.Version.ToString
        LabelCopyright.Text = My.Application.Info.Copyright.ToString
        LabelCompanyName.Text = My.Application.Info.CompanyName.ToString & My.Application.Info.Trademark.ToString
        TextBoxDescription.Text = "Gerador automático de Memorial Descritivo de uma área, com base nas coordenadas cartesianas de seus vértices, confrontantes e tipos de divisas, calculando as distâncias e azimutes." _
            & vbNewLine & vbNewLine & "O software Gerar Memorial Descritivo é um software livre; você pode redistribuí-lo e/ou modificá-lo " _
            & "sob os termos da Licença Pública Geral GNU (GNU General Public License), conforme publicada pela Free Software Foundation; " _
            & "quer a versão 3 da Licença, ou (a seu critério) qualquer versão posterior." & vbNewLine & vbNewLine &
            "O software Gerar Memorial Descritivo é distribuído na expectativa de que seja útil, porém SEM NENHUMA GARANTIA; sem mesmo implicar garantias de COMERCIALIZAÇÃO ou ADEQUAÇÃO A UM FIM ESPECÍFICO. Veja a Licença Pública Geral GNU para maiores detalhes." _
            & vbNewLine & vbNewLine & "A cópia da Licença Pública Geral GNU pode ser visualizado no link http://www.gnu.org/licenses/."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
