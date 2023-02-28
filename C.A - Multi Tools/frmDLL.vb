Public Class frmDLL

    Private Sub btnSAIR_Click(sender As Object, e As EventArgs) Handles btnSAIR.Click
        FrmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As Net.DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Label7.Text = ComboBox1.Text + "  Baixada com sucesso! Reinincie o PC !"
        Label7.ForeColor = Color.Red
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label7.Text = Label7.Text + "Baixando."
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        Dim client As Net.WebClient = New Net.WebClient
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        client.DownloadFileAsync(New Uri( _
        "http://www.# YouForum #.com.br/forum/DllsDeInstalação - Anti-Erro/" & ComboBox1.Text), ComboBox2.Text & ComboBox1.Text)
    End Sub

    Private Sub frmDLL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class