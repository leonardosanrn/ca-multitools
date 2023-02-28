﻿Imports System.Net
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Data
Public Class Web
    Public Function RequestDadosWeb(ByVal pstrURL As String) As String
        Dim oWebRequest As WebRequest
        Dim oWebResponse As WebResponse = Nothing
        Dim strBuffer As String = ""
        Dim objSR As StreamReader = Nothing
        'conecta com o website
        Try
            oWebRequest = HttpWebRequest.Create(pstrURL)
            oWebResponse = oWebRequest.GetResponse()
            'Le a resposta do web site e armazena em uma stream
            objSR = New StreamReader(oWebResponse.GetResponseStream)
            strBuffer = objSR.ReadToEnd
        Catch ex As Exception
            Throw ex
        Finally
            objSR.Close()
            oWebResponse.Close()
        End Try
        Return strBuffer
    End Function
End Class
