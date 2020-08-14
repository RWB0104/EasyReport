<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
	Inherits MetroFramework.Forms.MetroForm

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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
		Me.GroupBoxSend = New System.Windows.Forms.GroupBox()
		Me.LabelSend3 = New MetroFramework.Controls.MetroLabel()
		Me.LabelSend2 = New MetroFramework.Controls.MetroLabel()
		Me.LabelSend1 = New MetroFramework.Controls.MetroLabel()
		Me.ComboBoxSend3 = New MetroFramework.Controls.MetroComboBox()
		Me.ComboBoxSend2 = New MetroFramework.Controls.MetroComboBox()
		Me.ComboBoxSend1 = New MetroFramework.Controls.MetroComboBox()
		Me.GroupBoxText = New System.Windows.Forms.GroupBox()
		Me.TextBoxTxt = New MetroFramework.Controls.MetroTextBox()
		Me.GroupBoxGmail = New System.Windows.Forms.GroupBox()
		Me.ButtonSend = New MetroFramework.Controls.MetroButton()
		Me.TextBoxPW = New MetroFramework.Controls.MetroTextBox()
		Me.TextBoxID = New MetroFramework.Controls.MetroTextBox()
		Me.LabelPW = New System.Windows.Forms.Label()
		Me.LabelID = New System.Windows.Forms.Label()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.LabelWork = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.LabelDev = New System.Windows.Forms.Label()
		Me.ButtonGetDate = New MetroFramework.Controls.MetroButton()
		Me.TextBoxDate = New MetroFramework.Controls.MetroTextBox()
		Me.GroupBoxCC = New System.Windows.Forms.GroupBox()
		Me.LabelCC3 = New MetroFramework.Controls.MetroLabel()
		Me.LabelCC2 = New MetroFramework.Controls.MetroLabel()
		Me.LabelCC1 = New MetroFramework.Controls.MetroLabel()
		Me.ComboBoxCC3 = New MetroFramework.Controls.MetroComboBox()
		Me.ComboBoxCC2 = New MetroFramework.Controls.MetroComboBox()
		Me.ComboBoxCC1 = New MetroFramework.Controls.MetroComboBox()
		Me.LabelFile = New MetroFramework.Controls.MetroLabel()
		Me.TextBoxPath = New MetroFramework.Controls.MetroTextBox()
		Me.ButtonFile = New MetroFramework.Controls.MetroButton()
		Me.ButtonOpen = New MetroFramework.Controls.MetroButton()
		Me.ButtonConf = New MetroFramework.Controls.MetroButton()
		Me.ButtonShoot = New MetroFramework.Controls.MetroButton()
		Me.ButtonCls = New MetroFramework.Controls.MetroButton()
		Me.ProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
		Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
		Me.ButtonDownload = New MetroFramework.Controls.MetroButton()
		Me.GroupBoxSend.SuspendLayout()
		Me.GroupBoxText.SuspendLayout()
		Me.GroupBoxGmail.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxCC.SuspendLayout()
		CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBoxSend
		'
		Me.GroupBoxSend.Controls.Add(Me.LabelSend3)
		Me.GroupBoxSend.Controls.Add(Me.LabelSend2)
		Me.GroupBoxSend.Controls.Add(Me.LabelSend1)
		Me.GroupBoxSend.Controls.Add(Me.ComboBoxSend3)
		Me.GroupBoxSend.Controls.Add(Me.ComboBoxSend2)
		Me.GroupBoxSend.Controls.Add(Me.ComboBoxSend1)
		Me.GroupBoxSend.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.GroupBoxSend.Location = New System.Drawing.Point(19, 115)
		Me.GroupBoxSend.Name = "GroupBoxSend"
		Me.GroupBoxSend.Size = New System.Drawing.Size(294, 126)
		Me.GroupBoxSend.TabIndex = 15
		Me.GroupBoxSend.TabStop = False
		Me.GroupBoxSend.Text = "수신자"
		'
		'LabelSend3
		'
		Me.LabelSend3.Location = New System.Drawing.Point(129, 85)
		Me.LabelSend3.Name = "LabelSend3"
		Me.LabelSend3.Size = New System.Drawing.Size(154, 29)
		Me.LabelSend3.TabIndex = 46
		Me.LabelSend3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LabelSend2
		'
		Me.LabelSend2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
		Me.LabelSend2.Location = New System.Drawing.Point(129, 50)
		Me.LabelSend2.Name = "LabelSend2"
		Me.LabelSend2.Size = New System.Drawing.Size(154, 29)
		Me.LabelSend2.TabIndex = 45
		Me.LabelSend2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LabelSend1
		'
		Me.LabelSend1.Location = New System.Drawing.Point(129, 15)
		Me.LabelSend1.Name = "LabelSend1"
		Me.LabelSend1.Size = New System.Drawing.Size(154, 29)
		Me.LabelSend1.TabIndex = 44
		Me.LabelSend1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ComboBoxSend3
		'
		Me.ComboBoxSend3.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxSend3.FormattingEnabled = True
		Me.ComboBoxSend3.ItemHeight = 19
		Me.ComboBoxSend3.Location = New System.Drawing.Point(15, 89)
		Me.ComboBoxSend3.Name = "ComboBoxSend3"
		Me.ComboBoxSend3.Size = New System.Drawing.Size(103, 25)
		Me.ComboBoxSend3.TabIndex = 43
		'
		'ComboBoxSend2
		'
		Me.ComboBoxSend2.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxSend2.FormattingEnabled = True
		Me.ComboBoxSend2.ItemHeight = 19
		Me.ComboBoxSend2.Location = New System.Drawing.Point(15, 54)
		Me.ComboBoxSend2.Name = "ComboBoxSend2"
		Me.ComboBoxSend2.Size = New System.Drawing.Size(103, 25)
		Me.ComboBoxSend2.TabIndex = 42
		'
		'ComboBoxSend1
		'
		Me.ComboBoxSend1.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxSend1.ItemHeight = 19
		Me.ComboBoxSend1.Location = New System.Drawing.Point(15, 19)
		Me.ComboBoxSend1.Name = "ComboBoxSend1"
		Me.ComboBoxSend1.Size = New System.Drawing.Size(103, 25)
		Me.ComboBoxSend1.TabIndex = 41
		'
		'GroupBoxText
		'
		Me.GroupBoxText.Controls.Add(Me.TextBoxTxt)
		Me.GroupBoxText.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.GroupBoxText.Location = New System.Drawing.Point(332, 115)
		Me.GroupBoxText.Name = "GroupBoxText"
		Me.GroupBoxText.Size = New System.Drawing.Size(230, 274)
		Me.GroupBoxText.TabIndex = 18
		Me.GroupBoxText.TabStop = False
		Me.GroupBoxText.Text = "추가 내용"
		'
		'TextBoxTxt
		'
		Me.TextBoxTxt.BackColor = System.Drawing.Color.White
		Me.TextBoxTxt.CustomBackground = True
		Me.TextBoxTxt.Location = New System.Drawing.Point(14, 22)
		Me.TextBoxTxt.Multiline = True
		Me.TextBoxTxt.Name = "TextBoxTxt"
		Me.TextBoxTxt.Size = New System.Drawing.Size(203, 238)
		Me.TextBoxTxt.TabIndex = 42
		'
		'GroupBoxGmail
		'
		Me.GroupBoxGmail.Controls.Add(Me.ButtonSend)
		Me.GroupBoxGmail.Controls.Add(Me.TextBoxPW)
		Me.GroupBoxGmail.Controls.Add(Me.TextBoxID)
		Me.GroupBoxGmail.Controls.Add(Me.LabelPW)
		Me.GroupBoxGmail.Controls.Add(Me.LabelID)
		Me.GroupBoxGmail.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.GroupBoxGmail.Location = New System.Drawing.Point(19, 447)
		Me.GroupBoxGmail.Name = "GroupBoxGmail"
		Me.GroupBoxGmail.Size = New System.Drawing.Size(359, 81)
		Me.GroupBoxGmail.TabIndex = 19
		Me.GroupBoxGmail.TabStop = False
		Me.GroupBoxGmail.Text = "G-Mail"
		'
		'ButtonSend
		'
		Me.ButtonSend.Highlight = True
		Me.ButtonSend.Location = New System.Drawing.Point(272, 19)
		Me.ButtonSend.Name = "ButtonSend"
		Me.ButtonSend.Size = New System.Drawing.Size(75, 52)
		Me.ButtonSend.TabIndex = 49
		Me.ButtonSend.Text = "전송"
		'
		'TextBoxPW
		'
		Me.TextBoxPW.CustomBackground = True
		Me.TextBoxPW.Location = New System.Drawing.Point(34, 48)
		Me.TextBoxPW.Name = "TextBoxPW"
		Me.TextBoxPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBoxPW.Size = New System.Drawing.Size(232, 23)
		Me.TextBoxPW.Style = MetroFramework.MetroColorStyle.Silver
		Me.TextBoxPW.TabIndex = 50
		'
		'TextBoxID
		'
		Me.TextBoxID.CustomBackground = True
		Me.TextBoxID.Location = New System.Drawing.Point(34, 19)
		Me.TextBoxID.Name = "TextBoxID"
		Me.TextBoxID.Size = New System.Drawing.Size(232, 23)
		Me.TextBoxID.Style = MetroFramework.MetroColorStyle.Silver
		Me.TextBoxID.TabIndex = 49
		'
		'LabelPW
		'
		Me.LabelPW.AutoSize = True
		Me.LabelPW.Location = New System.Drawing.Point(6, 52)
		Me.LabelPW.Name = "LabelPW"
		Me.LabelPW.Size = New System.Drawing.Size(25, 15)
		Me.LabelPW.TabIndex = 3
		Me.LabelPW.Text = "PW"
		'
		'LabelID
		'
		Me.LabelID.AutoSize = True
		Me.LabelID.Location = New System.Drawing.Point(11, 24)
		Me.LabelID.Name = "LabelID"
		Me.LabelID.Size = New System.Drawing.Size(19, 15)
		Me.LabelID.TabIndex = 2
		Me.LabelID.Text = "ID"
		'
		'BackgroundWorker1
		'
		Me.BackgroundWorker1.WorkerReportsProgress = True
		Me.BackgroundWorker1.WorkerSupportsCancellation = True
		'
		'LabelWork
		'
		Me.LabelWork.AutoSize = True
		Me.LabelWork.Location = New System.Drawing.Point(302, 466)
		Me.LabelWork.Name = "LabelWork"
		Me.LabelWork.Size = New System.Drawing.Size(0, 12)
		Me.LabelWork.TabIndex = 26
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.EasyReport.My.Resources.Resources.Form_Logo
		Me.PictureBox1.Location = New System.Drawing.Point(441, 25)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(121, 36)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 28
		Me.PictureBox1.TabStop = False
		'
		'LabelDev
		'
		Me.LabelDev.AutoSize = True
		Me.LabelDev.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.LabelDev.Location = New System.Drawing.Point(234, 540)
		Me.LabelDev.Name = "LabelDev"
		Me.LabelDev.Size = New System.Drawing.Size(110, 15)
		Me.LabelDev.TabIndex = 37
		Me.LabelDev.Text = "Developed by RWB"
		'
		'ButtonGetDate
		'
		Me.ButtonGetDate.Location = New System.Drawing.Point(19, 68)
		Me.ButtonGetDate.Name = "ButtonGetDate"
		Me.ButtonGetDate.Size = New System.Drawing.Size(75, 24)
		Me.ButtonGetDate.Style = MetroFramework.MetroColorStyle.Teal
		Me.ButtonGetDate.TabIndex = 39
		Me.ButtonGetDate.Text = "Date"
		'
		'TextBoxDate
		'
		Me.TextBoxDate.BackColor = System.Drawing.Color.White
		Me.TextBoxDate.CustomBackground = True
		Me.TextBoxDate.Location = New System.Drawing.Point(104, 69)
		Me.TextBoxDate.Name = "TextBoxDate"
		Me.TextBoxDate.Size = New System.Drawing.Size(86, 23)
		Me.TextBoxDate.TabIndex = 40
		Me.TextBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'GroupBoxCC
		'
		Me.GroupBoxCC.Controls.Add(Me.LabelCC3)
		Me.GroupBoxCC.Controls.Add(Me.LabelCC2)
		Me.GroupBoxCC.Controls.Add(Me.LabelCC1)
		Me.GroupBoxCC.Controls.Add(Me.ComboBoxCC3)
		Me.GroupBoxCC.Controls.Add(Me.ComboBoxCC2)
		Me.GroupBoxCC.Controls.Add(Me.ComboBoxCC1)
		Me.GroupBoxCC.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
		Me.GroupBoxCC.Location = New System.Drawing.Point(19, 258)
		Me.GroupBoxCC.Name = "GroupBoxCC"
		Me.GroupBoxCC.Size = New System.Drawing.Size(294, 131)
		Me.GroupBoxCC.TabIndex = 41
		Me.GroupBoxCC.TabStop = False
		Me.GroupBoxCC.Text = "참조"
		'
		'LabelCC3
		'
		Me.LabelCC3.Location = New System.Drawing.Point(129, 88)
		Me.LabelCC3.Name = "LabelCC3"
		Me.LabelCC3.Size = New System.Drawing.Size(154, 29)
		Me.LabelCC3.TabIndex = 46
		Me.LabelCC3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LabelCC2
		'
		Me.LabelCC2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
		Me.LabelCC2.Location = New System.Drawing.Point(129, 53)
		Me.LabelCC2.Name = "LabelCC2"
		Me.LabelCC2.Size = New System.Drawing.Size(154, 29)
		Me.LabelCC2.TabIndex = 45
		Me.LabelCC2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LabelCC1
		'
		Me.LabelCC1.Location = New System.Drawing.Point(129, 18)
		Me.LabelCC1.Name = "LabelCC1"
		Me.LabelCC1.Size = New System.Drawing.Size(154, 29)
		Me.LabelCC1.TabIndex = 44
		Me.LabelCC1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ComboBoxCC3
		'
		Me.ComboBoxCC3.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxCC3.FormattingEnabled = True
		Me.ComboBoxCC3.ItemHeight = 19
		Me.ComboBoxCC3.Location = New System.Drawing.Point(15, 92)
		Me.ComboBoxCC3.Name = "ComboBoxCC3"
		Me.ComboBoxCC3.Size = New System.Drawing.Size(103, 25)
		Me.ComboBoxCC3.TabIndex = 43
		'
		'ComboBoxCC2
		'
		Me.ComboBoxCC2.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxCC2.FormattingEnabled = True
		Me.ComboBoxCC2.ItemHeight = 19
		Me.ComboBoxCC2.Location = New System.Drawing.Point(15, 57)
		Me.ComboBoxCC2.Name = "ComboBoxCC2"
		Me.ComboBoxCC2.Size = New System.Drawing.Size(103, 25)
		Me.ComboBoxCC2.TabIndex = 42
		'
		'ComboBoxCC1
		'
		Me.ComboBoxCC1.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxCC1.FormattingEnabled = True
		Me.ComboBoxCC1.ItemHeight = 19
		Me.ComboBoxCC1.Location = New System.Drawing.Point(15, 22)
		Me.ComboBoxCC1.Name = "ComboBoxCC1"
		Me.ComboBoxCC1.Size = New System.Drawing.Size(103, 25)
		Me.ComboBoxCC1.TabIndex = 41
		'
		'LabelFile
		'
		Me.LabelFile.AutoSize = True
		Me.LabelFile.Location = New System.Drawing.Point(19, 407)
		Me.LabelFile.Name = "LabelFile"
		Me.LabelFile.Size = New System.Drawing.Size(65, 19)
		Me.LabelFile.TabIndex = 42
		Me.LabelFile.Text = "첨부파일"
		'
		'TextBoxPath
		'
		Me.TextBoxPath.CustomBackground = True
		Me.TextBoxPath.Location = New System.Drawing.Point(104, 407)
		Me.TextBoxPath.Name = "TextBoxPath"
		Me.TextBoxPath.Size = New System.Drawing.Size(367, 23)
		Me.TextBoxPath.TabIndex = 43
		'
		'ButtonFile
		'
		Me.ButtonFile.Location = New System.Drawing.Point(470, 407)
		Me.ButtonFile.Name = "ButtonFile"
		Me.ButtonFile.Size = New System.Drawing.Size(36, 23)
		Me.ButtonFile.TabIndex = 44
		Me.ButtonFile.Text = "..."
		'
		'ButtonOpen
		'
		Me.ButtonOpen.Location = New System.Drawing.Point(526, 407)
		Me.ButtonOpen.Name = "ButtonOpen"
		Me.ButtonOpen.Size = New System.Drawing.Size(36, 23)
		Me.ButtonOpen.TabIndex = 45
		Me.ButtonOpen.Text = "열기"
		'
		'ButtonConf
		'
		Me.ButtonConf.Location = New System.Drawing.Point(487, 499)
		Me.ButtonConf.Name = "ButtonConf"
		Me.ButtonConf.Size = New System.Drawing.Size(75, 29)
		Me.ButtonConf.TabIndex = 46
		Me.ButtonConf.Text = "설정"
		'
		'ButtonShoot
		'
		Me.ButtonShoot.Location = New System.Drawing.Point(396, 499)
		Me.ButtonShoot.Name = "ButtonShoot"
		Me.ButtonShoot.Size = New System.Drawing.Size(75, 29)
		Me.ButtonShoot.TabIndex = 47
		Me.ButtonShoot.Text = "자동"
		'
		'ButtonCls
		'
		Me.ButtonCls.Location = New System.Drawing.Point(396, 455)
		Me.ButtonCls.Name = "ButtonCls"
		Me.ButtonCls.Size = New System.Drawing.Size(75, 31)
		Me.ButtonCls.TabIndex = 48
		Me.ButtonCls.Text = "초기화"
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(199, 69)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(363, 23)
		Me.ProgressBar1.TabIndex = 53
		'
		'MetroStyleManager1
		'
		Me.MetroStyleManager1.Owner = Me
		Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue
		Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light
		'
		'ButtonDownload
		'
		Me.ButtonDownload.Location = New System.Drawing.Point(487, 455)
		Me.ButtonDownload.Name = "ButtonDownload"
		Me.ButtonDownload.Size = New System.Drawing.Size(75, 31)
		Me.ButtonDownload.TabIndex = 55
		Me.ButtonDownload.Text = "보고서 양식"
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ClientSize = New System.Drawing.Size(581, 569)
		Me.Controls.Add(Me.ButtonDownload)
		Me.Controls.Add(Me.ProgressBar1)
		Me.Controls.Add(Me.ButtonCls)
		Me.Controls.Add(Me.ButtonShoot)
		Me.Controls.Add(Me.ButtonConf)
		Me.Controls.Add(Me.ButtonOpen)
		Me.Controls.Add(Me.ButtonFile)
		Me.Controls.Add(Me.TextBoxPath)
		Me.Controls.Add(Me.LabelFile)
		Me.Controls.Add(Me.GroupBoxCC)
		Me.Controls.Add(Me.TextBoxDate)
		Me.Controls.Add(Me.ButtonGetDate)
		Me.Controls.Add(Me.LabelDev)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.LabelWork)
		Me.Controls.Add(Me.GroupBoxGmail)
		Me.Controls.Add(Me.GroupBoxText)
		Me.Controls.Add(Me.GroupBoxSend)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Main"
		Me.Resizable = False
		Me.Text = "EasyReport"
		Me.GroupBoxSend.ResumeLayout(False)
		Me.GroupBoxText.ResumeLayout(False)
		Me.GroupBoxGmail.ResumeLayout(False)
		Me.GroupBoxGmail.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxCC.ResumeLayout(False)
		CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents GroupBoxSend As GroupBox
	Friend WithEvents GroupBoxText As GroupBox
	Friend WithEvents GroupBoxGmail As GroupBox
	Friend WithEvents LabelPW As Label
	Friend WithEvents LabelID As Label
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents LabelWork As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents LabelDev As Label
	Friend WithEvents ButtonGetDate As MetroFramework.Controls.MetroButton
	Friend WithEvents TextBoxDate As MetroFramework.Controls.MetroTextBox
	Friend WithEvents ComboBoxSend1 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents ComboBoxSend2 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents ComboBoxSend3 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents LabelSend2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelSend1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelSend3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents GroupBoxCC As GroupBox
	Friend WithEvents LabelCC3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelCC2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelCC1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents ComboBoxCC3 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents ComboBoxCC2 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents ComboBoxCC1 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents TextBoxTxt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents LabelFile As MetroFramework.Controls.MetroLabel
	Friend WithEvents TextBoxPath As MetroFramework.Controls.MetroTextBox
	Friend WithEvents ButtonFile As MetroFramework.Controls.MetroButton
	Friend WithEvents ButtonOpen As MetroFramework.Controls.MetroButton
	Friend WithEvents ButtonShoot As MetroFramework.Controls.MetroButton
	Friend WithEvents ButtonCls As MetroFramework.Controls.MetroButton
	Friend WithEvents ButtonSend As MetroFramework.Controls.MetroButton
	Friend WithEvents TextBoxPW As MetroFramework.Controls.MetroTextBox
	Friend WithEvents TextBoxID As MetroFramework.Controls.MetroTextBox
	Friend WithEvents ButtonConf As MetroFramework.Controls.MetroButton
	Friend WithEvents ProgressBar1 As MetroFramework.Controls.MetroProgressBar
	Public WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
	Friend WithEvents ButtonDownload As MetroFramework.Controls.MetroButton
End Class
