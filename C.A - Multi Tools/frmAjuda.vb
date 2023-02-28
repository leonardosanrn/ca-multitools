Public Class frmAjuda

    Private Sub btnSAIR_Click(sender As Object, e As EventArgs) Handles btnSAIR.Click
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        NavigateWebURL("http://www.google.com", "default")
    End Sub

    Private Sub NavigateWebURL(v1 As String, v2 As String)
        Throw New NotImplementedException()
    End Sub
End Class