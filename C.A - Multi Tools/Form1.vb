Public Class frmADS

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub frmADS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox1.Text = WebBrowser1.Url.Host
        If TextBox1.Text = ("megavibefm.com.br") Then
            FrmPrincipal.Show()
            Me.Hide()
        End If
    End Sub
End Class
