<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logs
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
        Me.btnSair = New System.Windows.Forms.Button()
        Me.cbLOG = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxLocal = New System.Windows.Forms.TextBox()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbDMP = New System.Windows.Forms.CheckBox()
        Me.cbAVI = New System.Windows.Forms.CheckBox()
        Me.cbBIN = New System.Windows.Forms.CheckBox()
        Me.cbV3D = New System.Windows.Forms.CheckBox()
        Me.cbJSON = New System.Windows.Forms.CheckBox()
        Me.cbDUMP = New System.Windows.Forms.CheckBox()
        Me.cbJPG = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbCAV = New System.Windows.Forms.CheckBox()
        Me.cbEnding = New System.Windows.Forms.CheckBox()
        Me.cbCAERROR = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbNMDATA = New System.Windows.Forms.CheckBox()
        Me.cbPLogs = New System.Windows.Forms.CheckBox()
        Me.cbETC = New System.Windows.Forms.CheckBox()
        Me.cbALL = New System.Windows.Forms.CheckBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fbdLocalizar = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSair.FlatAppearance.BorderSize = 0
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSair.Location = New System.Drawing.Point(536, 0)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(30, 30)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "X"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'cbLOG
        '
        Me.cbLOG.AutoSize = True
        Me.cbLOG.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLOG.Location = New System.Drawing.Point(12, 34)
        Me.cbLOG.Name = "cbLOG"
        Me.cbLOG.Size = New System.Drawing.Size(57, 22)
        Me.cbLOG.TabIndex = 2
        Me.cbLOG.Text = "*.log"
        Me.cbLOG.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbxLocal)
        Me.GroupBox1.Controls.Add(Me.btnProcurar)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 75)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Diretorio Combat Arms"
        '
        'tbxLocal
        '
        Me.tbxLocal.Enabled = False
        Me.tbxLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLocal.Location = New System.Drawing.Point(15, 30)
        Me.tbxLocal.Multiline = True
        Me.tbxLocal.Name = "tbxLocal"
        Me.tbxLocal.Size = New System.Drawing.Size(407, 27)
        Me.tbxLocal.TabIndex = 1
        '
        'btnProcurar
        '
        Me.btnProcurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnProcurar.Location = New System.Drawing.Point(428, 30)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(109, 27)
        Me.btnProcurar.TabIndex = 0
        Me.btnProcurar.Text = "......"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbDMP)
        Me.GroupBox2.Controls.Add(Me.cbAVI)
        Me.GroupBox2.Controls.Add(Me.cbBIN)
        Me.GroupBox2.Controls.Add(Me.cbV3D)
        Me.GroupBox2.Controls.Add(Me.cbJSON)
        Me.GroupBox2.Controls.Add(Me.cbDUMP)
        Me.GroupBox2.Controls.Add(Me.cbJPG)
        Me.GroupBox2.Controls.Add(Me.cbLOG)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(543, 82)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Arquivos da pasta raiz"
        '
        'cbDMP
        '
        Me.cbDMP.AutoSize = True
        Me.cbDMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDMP.Location = New System.Drawing.Point(470, 34)
        Me.cbDMP.Name = "cbDMP"
        Me.cbDMP.Size = New System.Drawing.Size(66, 22)
        Me.cbDMP.TabIndex = 9
        Me.cbDMP.Text = "*.dmp"
        Me.cbDMP.UseVisualStyleBackColor = True
        '
        'cbAVI
        '
        Me.cbAVI.AutoSize = True
        Me.cbAVI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAVI.Location = New System.Drawing.Point(410, 34)
        Me.cbAVI.Name = "cbAVI"
        Me.cbAVI.Size = New System.Drawing.Size(55, 22)
        Me.cbAVI.TabIndex = 8
        Me.cbAVI.Text = "*.avi"
        Me.cbAVI.UseVisualStyleBackColor = True
        '
        'cbBIN
        '
        Me.cbBIN.AutoSize = True
        Me.cbBIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBIN.Location = New System.Drawing.Point(349, 34)
        Me.cbBIN.Name = "cbBIN"
        Me.cbBIN.Size = New System.Drawing.Size(56, 22)
        Me.cbBIN.TabIndex = 7
        Me.cbBIN.Text = "*.bin"
        Me.cbBIN.UseVisualStyleBackColor = True
        '
        'cbV3D
        '
        Me.cbV3D.AutoSize = True
        Me.cbV3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbV3D.Location = New System.Drawing.Point(284, 34)
        Me.cbV3D.Name = "cbV3D"
        Me.cbV3D.Size = New System.Drawing.Size(60, 22)
        Me.cbV3D.TabIndex = 6
        Me.cbV3D.Text = "*.v3d"
        Me.cbV3D.UseVisualStyleBackColor = True
        '
        'cbJSON
        '
        Me.cbJSON.AutoSize = True
        Me.cbJSON.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJSON.Location = New System.Drawing.Point(214, 34)
        Me.cbJSON.Name = "cbJSON"
        Me.cbJSON.Size = New System.Drawing.Size(65, 22)
        Me.cbJSON.TabIndex = 5
        Me.cbJSON.Text = "*.json"
        Me.cbJSON.UseVisualStyleBackColor = True
        '
        'cbDUMP
        '
        Me.cbDUMP.AutoSize = True
        Me.cbDUMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDUMP.Location = New System.Drawing.Point(135, 34)
        Me.cbDUMP.Name = "cbDUMP"
        Me.cbDUMP.Size = New System.Drawing.Size(74, 22)
        Me.cbDUMP.TabIndex = 4
        Me.cbDUMP.Text = "*.dump"
        Me.cbDUMP.UseVisualStyleBackColor = True
        '
        'cbJPG
        '
        Me.cbJPG.AutoSize = True
        Me.cbJPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJPG.Location = New System.Drawing.Point(74, 34)
        Me.cbJPG.Name = "cbJPG"
        Me.cbJPG.Size = New System.Drawing.Size(56, 22)
        Me.cbJPG.TabIndex = 3
        Me.cbJPG.Text = "*.jpg"
        Me.cbJPG.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbCAV)
        Me.GroupBox3.Controls.Add(Me.cbEnding)
        Me.GroupBox3.Controls.Add(Me.cbCAERROR)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 110)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Inuteis"
        '
        'cbCAV
        '
        Me.cbCAV.AutoSize = True
        Me.cbCAV.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCAV.Location = New System.Drawing.Point(10, 74)
        Me.cbCAV.Name = "cbCAV"
        Me.cbCAV.Size = New System.Drawing.Size(83, 22)
        Me.cbCAV.TabIndex = 5
        Me.cbCAV.Text = "CAV.exe"
        Me.cbCAV.UseVisualStyleBackColor = True
        '
        'cbEnding
        '
        Me.cbEnding.AutoSize = True
        Me.cbEnding.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEnding.Location = New System.Drawing.Point(10, 46)
        Me.cbEnding.Name = "cbEnding"
        Me.cbEnding.Size = New System.Drawing.Size(146, 22)
        Me.cbEnding.TabIndex = 4
        Me.cbEnding.Text = "EndingBanner.exe"
        Me.cbEnding.UseVisualStyleBackColor = True
        '
        'cbCAERROR
        '
        Me.cbCAERROR.AutoSize = True
        Me.cbCAERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCAERROR.Location = New System.Drawing.Point(10, 18)
        Me.cbCAERROR.Name = "cbCAERROR"
        Me.cbCAERROR.Size = New System.Drawing.Size(166, 22)
        Me.cbCAERROR.TabIndex = 3
        Me.cbCAERROR.Text = "CAErrorReporter.exe"
        Me.cbCAERROR.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbNMDATA)
        Me.GroupBox4.Controls.Add(Me.cbPLogs)
        Me.GroupBox4.Controls.Add(Me.cbETC)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(276, 201)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(279, 110)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Logs"
        '
        'cbNMDATA
        '
        Me.cbNMDATA.AutoSize = True
        Me.cbNMDATA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNMDATA.Location = New System.Drawing.Point(9, 74)
        Me.cbNMDATA.Name = "cbNMDATA"
        Me.cbNMDATA.Size = New System.Drawing.Size(163, 22)
        Me.cbNMDATA.TabIndex = 2
        Me.cbNMDATA.Text = "Pasta: NMDATA.900"
        Me.cbNMDATA.UseVisualStyleBackColor = True
        '
        'cbPLogs
        '
        Me.cbPLogs.AutoSize = True
        Me.cbPLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPLogs.Location = New System.Drawing.Point(9, 46)
        Me.cbPLogs.Name = "cbPLogs"
        Me.cbPLogs.Size = New System.Drawing.Size(106, 22)
        Me.cbPLogs.TabIndex = 1
        Me.cbPLogs.Text = "Pasta: Logs"
        Me.cbPLogs.UseVisualStyleBackColor = True
        '
        'cbETC
        '
        Me.cbETC.AutoSize = True
        Me.cbETC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbETC.Location = New System.Drawing.Point(9, 18)
        Me.cbETC.Name = "cbETC"
        Me.cbETC.Size = New System.Drawing.Size(103, 22)
        Me.cbETC.TabIndex = 0
        Me.cbETC.Text = "Pasta: ETC"
        Me.cbETC.UseVisualStyleBackColor = True
        '
        'cbALL
        '
        Me.cbALL.AutoSize = True
        Me.cbALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbALL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbALL.Location = New System.Drawing.Point(436, 319)
        Me.cbALL.Name = "cbALL"
        Me.cbALL.Size = New System.Drawing.Size(119, 22)
        Me.cbALL.TabIndex = 6
        Me.cbALL.Text = "Limpar Todos"
        Me.cbALL.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Enabled = False
        Me.btnLimpar.Location = New System.Drawing.Point(12, 317)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(418, 27)
        Me.btnLimpar.TabIndex = 7
        Me.btnLimpar.Text = "LIMPAR LOGS"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Limpador de Logs"
        '
        'Logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(566, 355)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.cbALL)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSair)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Logs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logs"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents cbLOG As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbxLocal As System.Windows.Forms.TextBox
    Friend WithEvents btnProcurar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbDMP As System.Windows.Forms.CheckBox
    Friend WithEvents cbAVI As System.Windows.Forms.CheckBox
    Friend WithEvents cbBIN As System.Windows.Forms.CheckBox
    Friend WithEvents cbV3D As System.Windows.Forms.CheckBox
    Friend WithEvents cbJSON As System.Windows.Forms.CheckBox
    Friend WithEvents cbDUMP As System.Windows.Forms.CheckBox
    Friend WithEvents cbJPG As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCAV As System.Windows.Forms.CheckBox
    Friend WithEvents cbEnding As System.Windows.Forms.CheckBox
    Friend WithEvents cbCAERROR As System.Windows.Forms.CheckBox
    Friend WithEvents cbNMDATA As System.Windows.Forms.CheckBox
    Friend WithEvents cbPLogs As System.Windows.Forms.CheckBox
    Friend WithEvents cbETC As System.Windows.Forms.CheckBox
    Friend WithEvents cbALL As System.Windows.Forms.CheckBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fbdLocalizar As System.Windows.Forms.FolderBrowserDialog
End Class
