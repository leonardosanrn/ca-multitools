Public Class Logs
    Dim Diretorio As String
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        FrmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles cbALL.CheckedChanged
        If cbALL.Checked = True Then
            cbAVI.Checked = True
            cbBIN.Checked = True
            cbCAERROR.Checked = True
            cbCAV.Checked = True
            cbDMP.Checked = True
            cbDUMP.Checked = True
            cbEnding.Checked = True
            cbETC.Checked = True
            cbJPG.Checked = True
            cbJSON.Checked = True
            cbLOG.Checked = True
            cbNMDATA.Checked = True
            cbPLogs.Checked = True
            cbV3D.Checked = True
        Else
            cbAVI.Checked = False
            cbBIN.Checked = False
            cbCAERROR.Checked = False
            cbCAV.Checked = False
            cbDMP.Checked = False
            cbDUMP.Checked = False
            cbEnding.Checked = False
            cbETC.Checked = False
            cbJPG.Checked = False
            cbJSON.Checked = False
            cbLOG.Checked = False
            cbNMDATA.Checked = False
            cbPLogs.Checked = False
            cbV3D.Checked = False
        End If
    End Sub

    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        fbdLocalizar.ShowDialog()
        If fbdLocalizar.SelectedPath <> "" Then
            btnLimpar.Enabled = True
            tbxLocal.Text = fbdLocalizar.SelectedPath
            Diretorio = fbdLocalizar.SelectedPath
            fbdLocalizar.SelectedPath = Nothing
            fbdLocalizar.Dispose()
        End If
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Try
            If cbETC.Checked = True Then
                If My.Computer.FileSystem.DirectoryExists(Diretorio & "\Game\ETC") = True Then
                    My.Computer.FileSystem.DeleteDirectory(Diretorio & "\Game\ETC", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            End If

            If cbPLogs.Checked = True Then
                If My.Computer.FileSystem.DirectoryExists(Diretorio & "\Log") = True Then
                    My.Computer.FileSystem.DeleteDirectory(Diretorio & "\Log", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            End If

            If cbNMDATA.Checked = True Then
                If My.Computer.FileSystem.DirectoryExists(Diretorio & "\NMDATA.900") = True Then
                    My.Computer.FileSystem.DeleteDirectory(Diretorio & "\NMDATA.900", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            End If

            If cbLOG.Checked = True Then
                Try
                    Kill(Diretorio & "\BlackCipher\*.log")
                Catch ex As Exception
                End Try
            End If
            If cbJPG.Checked = True Then
                Try
                    Kill(Diretorio & "\*.jpg")
                Catch ex As Exception
                End Try
            End If
            If cbDUMP.Checked = True Then
                Try
                    Kill(Diretorio & "\*.dump")
                Catch ex As Exception
                End Try
            End If
            If cbJSON.Checked = True Then
                Try
                    Kill(Diretorio & "\*.json")
                Catch ex As Exception
                End Try
            End If
            If cbV3D.Checked = True Then
                Try
                    Kill(Diretorio & "\*.v3d")
                Catch ex As Exception
                End Try
            End If
            If cbBIN.Checked = True Then
                Try
                    Kill(Diretorio & "\*.bin")
                Catch ex As Exception
                End Try
            End If
            If cbAVI.Checked = True Then
                Try
                    Kill(Diretorio & "\*.avi")
                Catch ex As Exception
                End Try
            End If
            If cbDMP.Checked = True Then
                Try
                    Kill(Diretorio & "\*.dmp")
                Catch ex As Exception
                End Try
            End If
            If cbCAV.Checked = True Then
                If My.Computer.FileSystem.FileExists(Diretorio & "\CAV.exe") = True Then
                    My.Computer.FileSystem.DeleteFile(Diretorio & "\CAV.exe")
                End If
            End If
            If cbEnding.Checked = True Then
                If My.Computer.FileSystem.FileExists(Diretorio & "\EndingBanner.exe") = True Then
                    My.Computer.FileSystem.DeleteFile(Diretorio & "\EndingBanner.exe")
                End If
            End If
            If cbCAERROR.Checked = True Then
                If My.Computer.FileSystem.FileExists(Diretorio & "\CAErrorReporter.exe") = True Then
                    My.Computer.FileSystem.DeleteFile(Diretorio & "\CAErrorReporter.exe")
                End If
            End If
            MsgBox("Logs Apagados com Sucesso!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists("C:\Level Up\Combat Arms") = True Then
            tbxLocal.Text = "C:\Level Up\Combat Arms"
            btnLimpar.Enabled = True
        End If
    End Sub
End Class