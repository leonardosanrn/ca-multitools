Imports System.Net

Public Class Dlls
    Public Shared verefic As New WebClient

    Public Shared LocalDaDllPC As String = "C:\Windows\Temp" 'Local da baixada Dll no PC



    '==========================================Link De Download das Dlls=========================================
    Public Shared DllLink0 As String = verefic.DownloadString("http://www.# YouForum #.com.br/forum/LinkDasDlls/DllLink0.txt")
    Public Shared DllLink1 As String = verefic.DownloadString("http://www.# YouForum #.com.br/forum/LinkDasDlls/DllLink1.txt")
    Public Shared DllLink2 As String = verefic.DownloadString("http://www.# YouForum #.com.br/forum/LinkDasDlls/DllLink2.txt")
    Public Shared DllLink3 As String = verefic.DownloadString("http://www.# YouForum #.com.br/forum/LinkDasDlls/DllLink3.txt")
    Public Shared DllLink4 As String = verefic.DownloadString("http://www.# YouForum #.com.br/forum/LinkDasDlls/DllLink4.txt")
    Public Shared DllLink5 As String = verefic.DownloadString("http://www.# YouForum #.com.br/forum/LinkDasDlls/DllLink5.txt")
    Public Shared MuLink As String = verefic.DownloadString("http://www.# YouForum #.com.br/forum/LinkDasDlls/MuLink.txt")

    '##############################################################################################

    Public Shared Function DllDownload(ByVal linkDaDll_ As String)
        If IO.File.Exists(LocalDaDllPC) Then
            IO.File.Delete(LocalDaDllPC)
        End If
        Dim url As New System.Uri(linkDaDll_)
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(url)
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            My.Computer.Network.DownloadFile(linkDaDll_, LocalDaDllPC)
        Catch ex As Exception
            req = Nothing
        End Try

    End Function
End Class
