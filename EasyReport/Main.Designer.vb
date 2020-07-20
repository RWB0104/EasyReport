<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
		Me.ButtonGetDate = New System.Windows.Forms.Button()
		Me.TextBoxDate = New System.Windows.Forms.TextBox()
		Me.LabelSend1 = New System.Windows.Forms.Label()
		Me.ComboBoxSend1 = New System.Windows.Forms.ComboBox()
		Me.ComboBoxSend3 = New System.Windows.Forms.ComboBox()
		Me.ComboBoxSend2 = New System.Windows.Forms.ComboBox()
		Me.ComboBoxCC1 = New System.Windows.Forms.ComboBox()
		Me.ComboBoxCC2 = New System.Windows.Forms.ComboBox()
		Me.ComboBoxCC3 = New System.Windows.Forms.ComboBox()
		Me.LabelCC2 = New System.Windows.Forms.Label()
		Me.LabelCC3 = New System.Windows.Forms.Label()
		Me.LabelCC1 = New System.Windows.Forms.Label()
		Me.LabelSend3 = New System.Windows.Forms.Label()
		Me.LabelSend2 = New System.Windows.Forms.Label()
		Me.GroupBoxSend = New System.Windows.Forms.GroupBox()
		Me.GroupBoxCC = New System.Windows.Forms.GroupBox()
		Me.TextBoxTxt = New System.Windows.Forms.TextBox()
		Me.GroupBoxText = New System.Windows.Forms.GroupBox()
		Me.GroupBoxGmail = New System.Windows.Forms.GroupBox()
		Me.ButtonSend = New System.Windows.Forms.Button()
		Me.LabelPW = New System.Windows.Forms.Label()
		Me.LabelID = New System.Windows.Forms.Label()
		Me.TextBoxPW = New System.Windows.Forms.TextBox()
		Me.TextBoxID = New System.Windows.Forms.TextBox()
		Me.ButtonCls = New System.Windows.Forms.Button()
		Me.TextBoxPath = New System.Windows.Forms.TextBox()
		Me.LabelFile = New System.Windows.Forms.Label()
		Me.ButtonFile = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.LabelWork = New System.Windows.Forms.Label()
		Me.ButtonShoot = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.ButtonOpen = New System.Windows.Forms.Button()
		Me.LabelDev = New System.Windows.Forms.Label()
		Me.ButtonConf = New System.Windows.Forms.Button()
		Me.GroupBoxSend.SuspendLayout()
		Me.GroupBoxCC.SuspendLayout()
		Me.GroupBoxText.SuspendLayout()
		Me.GroupBoxGmail.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ButtonGetDate
		'
		Me.ButtonGetDate.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ButtonGetDate.Location = New System.Drawing.Point(12, 14)
		Me.ButtonGetDate.Name = "ButtonGetDate"
		Me.ButtonGetDate.Size = New System.Drawing.Size(75, 23)
		Me.ButtonGetDate.TabIndex = 0
		Me.ButtonGetDate.Text = "Date"
		Me.ButtonGetDate.UseVisualStyleBackColor = True
		'
		'TextBoxDate
		'
		Me.TextBoxDate.Location = New System.Drawing.Point(100, 15)
		Me.TextBoxDate.Name = "TextBoxDate"
		Me.TextBoxDate.Size = New System.Drawing.Size(74, 21)
		Me.TextBoxDate.TabIndex = 1
		Me.TextBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'LabelSend1
		'
		Me.LabelSend1.BackColor = System.Drawing.Color.White
		Me.LabelSend1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LabelSend1.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.LabelSend1.Location = New System.Drawing.Point(101, 20)
		Me.LabelSend1.Name = "LabelSend1"
		Me.LabelSend1.Size = New System.Drawing.Size(150, 20)
		Me.LabelSend1.TabIndex = 3
		'
		'ComboBoxSend1
		'
		Me.ComboBoxSend1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ComboBoxSend1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBoxSend1.FormattingEnabled = True
		Me.ComboBoxSend1.Location = New System.Drawing.Point(15, 20)
		Me.ComboBoxSend1.Name = "ComboBoxSend1"
		Me.ComboBoxSend1.Size = New System.Drawing.Size(80, 20)
		Me.ComboBoxSend1.TabIndex = 4
		'
		'ComboBoxSend3
		'
		Me.ComboBoxSend3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ComboBoxSend3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBoxSend3.FormattingEnabled = True
		Me.ComboBoxSend3.Location = New System.Drawing.Point(15, 72)
		Me.ComboBoxSend3.Name = "ComboBoxSend3"
		Me.ComboBoxSend3.Size = New System.Drawing.Size(80, 20)
		Me.ComboBoxSend3.TabIndex = 5
		'
		'ComboBoxSend2
		'
		Me.ComboBoxSend2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ComboBoxSend2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBoxSend2.FormattingEnabled = True
		Me.ComboBoxSend2.Location = New System.Drawing.Point(15, 46)
		Me.ComboBoxSend2.Name = "ComboBoxSend2"
		Me.ComboBoxSend2.Size = New System.Drawing.Size(80, 20)
		Me.ComboBoxSend2.TabIndex = 6
		'
		'ComboBoxCC1
		'
		Me.ComboBoxCC1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ComboBoxCC1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBoxCC1.FormattingEnabled = True
		Me.ComboBoxCC1.Location = New System.Drawing.Point(15, 20)
		Me.ComboBoxCC1.Name = "ComboBoxCC1"
		Me.ComboBoxCC1.Size = New System.Drawing.Size(80, 20)
		Me.ComboBoxCC1.TabIndex = 7
		'
		'ComboBoxCC2
		'
		Me.ComboBoxCC2.BackColor = System.Drawing.SystemColors.Window
		Me.ComboBoxCC2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ComboBoxCC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBoxCC2.FormattingEnabled = True
		Me.ComboBoxCC2.Location = New System.Drawing.Point(15, 46)
		Me.ComboBoxCC2.Name = "ComboBoxCC2"
		Me.ComboBoxCC2.Size = New System.Drawing.Size(80, 20)
		Me.ComboBoxCC2.TabIndex = 8
		'
		'ComboBoxCC3
		'
		Me.ComboBoxCC3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ComboBoxCC3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBoxCC3.FormattingEnabled = True
		Me.ComboBoxCC3.Location = New System.Drawing.Point(15, 72)
		Me.ComboBoxCC3.Name = "ComboBoxCC3"
		Me.ComboBoxCC3.Size = New System.Drawing.Size(80, 20)
		Me.ComboBoxCC3.TabIndex = 9
		'
		'LabelCC2
		'
		Me.LabelCC2.BackColor = System.Drawing.Color.White
		Me.LabelCC2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LabelCC2.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.LabelCC2.Location = New System.Drawing.Point(101, 46)
		Me.LabelCC2.Name = "LabelCC2"
		Me.LabelCC2.Size = New System.Drawing.Size(150, 20)
		Me.LabelCC2.TabIndex = 10
		'
		'LabelCC3
		'
		Me.LabelCC3.BackColor = System.Drawing.Color.White
		Me.LabelCC3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LabelCC3.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.LabelCC3.Location = New System.Drawing.Point(101, 72)
		Me.LabelCC3.Name = "LabelCC3"
		Me.LabelCC3.Size = New System.Drawing.Size(150, 20)
		Me.LabelCC3.TabIndex = 11
		'
		'LabelCC1
		'
		Me.LabelCC1.BackColor = System.Drawing.Color.White
		Me.LabelCC1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LabelCC1.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.LabelCC1.Location = New System.Drawing.Point(101, 20)
		Me.LabelCC1.Name = "LabelCC1"
		Me.LabelCC1.Size = New System.Drawing.Size(150, 20)
		Me.LabelCC1.TabIndex = 12
		'
		'LabelSend3
		'
		Me.LabelSend3.BackColor = System.Drawing.Color.White
		Me.LabelSend3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LabelSend3.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.LabelSend3.Location = New System.Drawing.Point(101, 72)
		Me.LabelSend3.Name = "LabelSend3"
		Me.LabelSend3.Size = New System.Drawing.Size(150, 20)
		Me.LabelSend3.TabIndex = 13
		'
		'LabelSend2
		'
		Me.LabelSend2.BackColor = System.Drawing.Color.White
		Me.LabelSend2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LabelSend2.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.LabelSend2.Location = New System.Drawing.Point(101, 46)
		Me.LabelSend2.Name = "LabelSend2"
		Me.LabelSend2.Size = New System.Drawing.Size(150, 20)
		Me.LabelSend2.TabIndex = 14
		'
		'GroupBoxSend
		'
		Me.GroupBoxSend.Controls.Add(Me.LabelSend1)
		Me.GroupBoxSend.Controls.Add(Me.LabelSend2)
		Me.GroupBoxSend.Controls.Add(Me.ComboBoxSend2)
		Me.GroupBoxSend.Controls.Add(Me.LabelSend3)
		Me.GroupBoxSend.Controls.Add(Me.ComboBoxSend1)
		Me.GroupBoxSend.Controls.Add(Me.ComboBoxSend3)
		Me.GroupBoxSend.Location = New System.Drawing.Point(19, 61)
		Me.GroupBoxSend.Name = "GroupBoxSend"
		Me.GroupBoxSend.Size = New System.Drawing.Size(266, 109)
		Me.GroupBoxSend.TabIndex = 15
		Me.GroupBoxSend.TabStop = False
		Me.GroupBoxSend.Text = "수신자"
		'
		'GroupBoxCC
		'
		Me.GroupBoxCC.Controls.Add(Me.ComboBoxCC1)
		Me.GroupBoxCC.Controls.Add(Me.ComboBoxCC2)
		Me.GroupBoxCC.Controls.Add(Me.LabelCC3)
		Me.GroupBoxCC.Controls.Add(Me.LabelCC1)
		Me.GroupBoxCC.Controls.Add(Me.LabelCC2)
		Me.GroupBoxCC.Controls.Add(Me.ComboBoxCC3)
		Me.GroupBoxCC.Location = New System.Drawing.Point(19, 184)
		Me.GroupBoxCC.Name = "GroupBoxCC"
		Me.GroupBoxCC.Size = New System.Drawing.Size(266, 109)
		Me.GroupBoxCC.TabIndex = 16
		Me.GroupBoxCC.TabStop = False
		Me.GroupBoxCC.Text = "참조"
		'
		'TextBoxTxt
		'
		Me.TextBoxTxt.Location = New System.Drawing.Point(14, 20)
		Me.TextBoxTxt.Multiline = True
		Me.TextBoxTxt.Name = "TextBoxTxt"
		Me.TextBoxTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.TextBoxTxt.Size = New System.Drawing.Size(138, 194)
		Me.TextBoxTxt.TabIndex = 17
		Me.TextBoxTxt.WordWrap = False
		'
		'GroupBoxText
		'
		Me.GroupBoxText.Controls.Add(Me.TextBoxTxt)
		Me.GroupBoxText.Location = New System.Drawing.Point(304, 60)
		Me.GroupBoxText.Name = "GroupBoxText"
		Me.GroupBoxText.Size = New System.Drawing.Size(167, 233)
		Me.GroupBoxText.TabIndex = 18
		Me.GroupBoxText.TabStop = False
		Me.GroupBoxText.Text = "추가 내용"
		'
		'GroupBoxGmail
		'
		Me.GroupBoxGmail.Controls.Add(Me.ButtonSend)
		Me.GroupBoxGmail.Controls.Add(Me.LabelPW)
		Me.GroupBoxGmail.Controls.Add(Me.LabelID)
		Me.GroupBoxGmail.Controls.Add(Me.TextBoxPW)
		Me.GroupBoxGmail.Controls.Add(Me.TextBoxID)
		Me.GroupBoxGmail.Location = New System.Drawing.Point(19, 351)
		Me.GroupBoxGmail.Name = "GroupBoxGmail"
		Me.GroupBoxGmail.Size = New System.Drawing.Size(266, 81)
		Me.GroupBoxGmail.TabIndex = 19
		Me.GroupBoxGmail.TabStop = False
		Me.GroupBoxGmail.Text = "G-Mail"
		'
		'ButtonSend
		'
		Me.ButtonSend.BackgroundImage = CType(resources.GetObject("ButtonSend.BackgroundImage"), System.Drawing.Image)
		Me.ButtonSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ButtonSend.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ButtonSend.Location = New System.Drawing.Point(180, 20)
		Me.ButtonSend.Name = "ButtonSend"
		Me.ButtonSend.Size = New System.Drawing.Size(75, 49)
		Me.ButtonSend.TabIndex = 4
		Me.ButtonSend.UseVisualStyleBackColor = True
		'
		'LabelPW
		'
		Me.LabelPW.AutoSize = True
		Me.LabelPW.Location = New System.Drawing.Point(6, 52)
		Me.LabelPW.Name = "LabelPW"
		Me.LabelPW.Size = New System.Drawing.Size(23, 12)
		Me.LabelPW.TabIndex = 3
		Me.LabelPW.Text = "PW"
		'
		'LabelID
		'
		Me.LabelID.AutoSize = True
		Me.LabelID.Location = New System.Drawing.Point(11, 24)
		Me.LabelID.Name = "LabelID"
		Me.LabelID.Size = New System.Drawing.Size(16, 12)
		Me.LabelID.TabIndex = 2
		Me.LabelID.Text = "ID"
		'
		'TextBoxPW
		'
		Me.TextBoxPW.Location = New System.Drawing.Point(34, 48)
		Me.TextBoxPW.Name = "TextBoxPW"
		Me.TextBoxPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBoxPW.Size = New System.Drawing.Size(137, 21)
		Me.TextBoxPW.TabIndex = 1
		'
		'TextBoxID
		'
		Me.TextBoxID.Location = New System.Drawing.Point(34, 20)
		Me.TextBoxID.Name = "TextBoxID"
		Me.TextBoxID.Size = New System.Drawing.Size(137, 21)
		Me.TextBoxID.TabIndex = 0
		'
		'ButtonCls
		'
		Me.ButtonCls.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ButtonCls.Location = New System.Drawing.Point(397, 409)
		Me.ButtonCls.Name = "ButtonCls"
		Me.ButtonCls.Size = New System.Drawing.Size(75, 23)
		Me.ButtonCls.TabIndex = 20
		Me.ButtonCls.Text = "Clear"
		Me.ButtonCls.UseVisualStyleBackColor = True
		'
		'TextBoxPath
		'
		Me.TextBoxPath.Location = New System.Drawing.Point(76, 311)
		Me.TextBoxPath.Name = "TextBoxPath"
		Me.TextBoxPath.Size = New System.Drawing.Size(331, 21)
		Me.TextBoxPath.TabIndex = 21
		'
		'LabelFile
		'
		Me.LabelFile.AutoSize = True
		Me.LabelFile.Location = New System.Drawing.Point(17, 315)
		Me.LabelFile.Name = "LabelFile"
		Me.LabelFile.Size = New System.Drawing.Size(53, 12)
		Me.LabelFile.TabIndex = 22
		Me.LabelFile.Text = "첨부파일"
		'
		'ButtonFile
		'
		Me.ButtonFile.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ButtonFile.Location = New System.Drawing.Point(413, 310)
		Me.ButtonFile.Name = "ButtonFile"
		Me.ButtonFile.Size = New System.Drawing.Size(26, 23)
		Me.ButtonFile.TabIndex = 23
		Me.ButtonFile.Text = "..."
		Me.ButtonFile.UseVisualStyleBackColor = True
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(189, 14)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(167, 23)
		Me.ProgressBar1.TabIndex = 25
		'
		'BackgroundWorker1
		'
		Me.BackgroundWorker1.WorkerReportsProgress = True
		Me.BackgroundWorker1.WorkerSupportsCancellation = True
		'
		'LabelWork
		'
		Me.LabelWork.AutoSize = True
		Me.LabelWork.Location = New System.Drawing.Point(302, 370)
		Me.LabelWork.Name = "LabelWork"
		Me.LabelWork.Size = New System.Drawing.Size(0, 12)
		Me.LabelWork.TabIndex = 26
		'
		'ButtonShoot
		'
		Me.ButtonShoot.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ButtonShoot.Location = New System.Drawing.Point(304, 409)
		Me.ButtonShoot.Name = "ButtonShoot"
		Me.ButtonShoot.Size = New System.Drawing.Size(75, 23)
		Me.ButtonShoot.TabIndex = 27
		Me.ButtonShoot.Text = "Auto"
		Me.ButtonShoot.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.EasyReport.My.Resources.Resources.Form_Logo
		Me.PictureBox1.Location = New System.Drawing.Point(362, 8)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(121, 36)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 28
		Me.PictureBox1.TabStop = False
		'
		'ButtonOpen
		'
		Me.ButtonOpen.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ButtonOpen.Location = New System.Drawing.Point(445, 310)
		Me.ButtonOpen.Name = "ButtonOpen"
		Me.ButtonOpen.Size = New System.Drawing.Size(26, 23)
		Me.ButtonOpen.TabIndex = 36
		Me.ButtonOpen.Text = "O"
		Me.ButtonOpen.UseVisualStyleBackColor = True
		'
		'LabelDev
		'
		Me.LabelDev.AutoSize = True
		Me.LabelDev.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.LabelDev.Location = New System.Drawing.Point(188, 443)
		Me.LabelDev.Name = "LabelDev"
		Me.LabelDev.Size = New System.Drawing.Size(110, 15)
		Me.LabelDev.TabIndex = 37
		Me.LabelDev.Text = "Developed by RWB"
		'
		'ButtonConf
		'
		Me.ButtonConf.Location = New System.Drawing.Point(397, 371)
		Me.ButtonConf.Name = "ButtonConf"
		Me.ButtonConf.Size = New System.Drawing.Size(75, 23)
		Me.ButtonConf.TabIndex = 38
		Me.ButtonConf.Text = "Config"
		Me.ButtonConf.UseVisualStyleBackColor = True
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(484, 461)
		Me.Controls.Add(Me.ButtonConf)
		Me.Controls.Add(Me.LabelDev)
		Me.Controls.Add(Me.ButtonOpen)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.ButtonShoot)
		Me.Controls.Add(Me.LabelWork)
		Me.Controls.Add(Me.ProgressBar1)
		Me.Controls.Add(Me.ButtonFile)
		Me.Controls.Add(Me.LabelFile)
		Me.Controls.Add(Me.TextBoxPath)
		Me.Controls.Add(Me.ButtonCls)
		Me.Controls.Add(Me.GroupBoxGmail)
		Me.Controls.Add(Me.GroupBoxText)
		Me.Controls.Add(Me.TextBoxDate)
		Me.Controls.Add(Me.ButtonGetDate)
		Me.Controls.Add(Me.GroupBoxSend)
		Me.Controls.Add(Me.GroupBoxCC)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Main"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "EasyReport"
		Me.GroupBoxSend.ResumeLayout(False)
		Me.GroupBoxCC.ResumeLayout(False)
		Me.GroupBoxText.ResumeLayout(False)
		Me.GroupBoxText.PerformLayout()
		Me.GroupBoxGmail.ResumeLayout(False)
		Me.GroupBoxGmail.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ButtonGetDate As Button
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents LabelSend1 As Label
    Friend WithEvents ComboBoxSend1 As ComboBox
    Friend WithEvents ComboBoxSend3 As ComboBox
    Friend WithEvents ComboBoxSend2 As ComboBox
    Friend WithEvents ComboBoxCC1 As ComboBox
    Friend WithEvents ComboBoxCC2 As ComboBox
    Friend WithEvents ComboBoxCC3 As ComboBox
    Friend WithEvents LabelCC2 As Label
    Friend WithEvents LabelCC3 As Label
    Friend WithEvents LabelCC1 As Label
    Friend WithEvents LabelSend3 As Label
    Friend WithEvents LabelSend2 As Label
    Friend WithEvents GroupBoxSend As GroupBox
    Friend WithEvents GroupBoxCC As GroupBox
    Friend WithEvents TextBoxTxt As TextBox
    Friend WithEvents GroupBoxText As GroupBox
    Friend WithEvents GroupBoxGmail As GroupBox
    Friend WithEvents TextBoxPW As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents ButtonSend As Button
    Friend WithEvents LabelPW As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents ButtonCls As Button
    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents LabelFile As Label
    Friend WithEvents ButtonFile As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelWork As Label
    Friend WithEvents ButtonShoot As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonOpen As Button
    Friend WithEvents LabelDev As Label
    Friend WithEvents ButtonConf As Button
End Class
