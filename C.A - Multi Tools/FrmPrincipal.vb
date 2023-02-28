Imports MatthiWare
Imports MatthiWare.Helpers
Imports MatthiWare.UpdateDialog

Public Class FrmPrincipal

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        End
    End Sub

    Public Sub buscarATL()
        Try
            Dim wc As New Web
            Dim urlV As String = "http://universosolucoes.com/sistemas/catools/att.txt"
            Dim urlA As String = "http://universosolucoes.com/sistemas/catools/enderecoatt.txt"
            Dim nv As String = wc.RequestDadosWeb(urlV)
            If nv = lblVA.Text Then
                btnATL.Visible = False
            Else
                btnATL.Visible = True
                btnATL.Text = "Nova Atualização Disponivel " & nv
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            End
        End Try
    End Sub
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNome.Text = System.Environment.UserName
        ' buscarATL()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAjuda.ShowDialog()
    End Sub

    Private Sub ProDescriptiveButton2_Click(sender As Object, e As EventArgs) Handles ProDescriptiveButton2.Click
        Logs.Show()
        Me.Hide()
    End Sub

    Private Sub ProDescriptiveButton3_Click(sender As Object, e As EventArgs) Handles ProDescriptiveButton3.Click
        frmDLL.Show()
        Me.Hide()
    End Sub

End Class