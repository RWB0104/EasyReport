<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configure
	Inherits MetroFramework.Forms.MetroForm

	'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configure))
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.LabelPort = New MetroFramework.Controls.MetroLabel()
		Me.LabelHost = New MetroFramework.Controls.MetroLabel()
		Me.LabelSSL = New MetroFramework.Controls.MetroLabel()
		Me.LabelSend1 = New MetroFramework.Controls.MetroLabel()
		Me.LabelSend2 = New MetroFramework.Controls.MetroLabel()
		Me.LabelSend3 = New MetroFramework.Controls.MetroLabel()
		Me.LabelCC3 = New MetroFramework.Controls.MetroLabel()
		Me.LabelCC2 = New MetroFramework.Controls.MetroLabel()
		Me.LabelCC1 = New MetroFramework.Controls.MetroLabel()
		Me.LabelID = New MetroFramework.Controls.MetroLabel()
		Me.LabelPW = New MetroFramework.Controls.MetroLabel()
		Me.LabelFile = New MetroFramework.Controls.MetroLabel()
		Me.TextBoxHost = New MetroFramework.Controls.MetroTextBox()
		Me.TextBoxPort = New MetroFramework.Controls.MetroTextBox()
		Me.TextBoxID = New MetroFramework.Controls.MetroTextBox()
		Me.TextBoxPwd = New MetroFramework.Controls.MetroTextBox()
		Me.TextBoxFile = New MetroFramework.Controls.MetroTextBox()
		Me.ComboBoxSend1 = New MetroFramework.Controls.MetroComboBox()
		Me.ComboBoxSend2 = New MetroFramework.Controls.MetroComboBox()
		Me.ComboBoxSend3 = New MetroFramework.Controls.MetroComboBox()
		Me.ComboBoxCC1 = New MetroFramework.Controls.MetroComboBox()
		Me.ComboBoxCC2 = New MetroFramework.Controls.MetroComboBox()
		Me.ComboBoxCC3 = New MetroFramework.Controls.MetroComboBox()
		Me.RadioButtonTrue = New MetroFramework.Controls.MetroRadioButton()
		Me.RadioButtonFalse = New MetroFramework.Controls.MetroRadioButton()
		Me.ButtonSave = New MetroFramework.Controls.MetroButton()
		Me.ButtonPath = New MetroFramework.Controls.MetroButton()
		Me.ButtonCancel = New MetroFramework.Controls.MetroButton()
		Me.SuspendLayout()
		'
		'LabelPort
		'
		Me.LabelPort.AutoSize = True
		Me.LabelPort.Location = New System.Drawing.Point(20, 62)
		Me.LabelPort.Name = "LabelPort"
		Me.LabelPort.Size = New System.Drawing.Size(72, 19)
		Me.LabelPort.TabIndex = 28
		Me.LabelPort.Text = "SMTP Port"
		'
		'LabelHost
		'
		Me.LabelHost.AutoSize = True
		Me.LabelHost.Location = New System.Drawing.Point(19, 31)
		Me.LabelHost.Name = "LabelHost"
		Me.LabelHost.Size = New System.Drawing.Size(73, 19)
		Me.LabelHost.TabIndex = 29
		Me.LabelHost.Text = "SMTP Host"
		'
		'LabelSSL
		'
		Me.LabelSSL.AutoSize = True
		Me.LabelSSL.Location = New System.Drawing.Point(25, 92)
		Me.LabelSSL.Name = "LabelSSL"
		Me.LabelSSL.Size = New System.Drawing.Size(67, 19)
		Me.LabelSSL.TabIndex = 30
		Me.LabelSSL.Text = "SMTP SSL"
		'
		'LabelSend1
		'
		Me.LabelSend1.AutoSize = True
		Me.LabelSend1.Location = New System.Drawing.Point(36, 138)
		Me.LabelSend1.Name = "LabelSend1"
		Me.LabelSend1.Size = New System.Drawing.Size(56, 19)
		Me.LabelSend1.TabIndex = 31
		Me.LabelSend1.Text = "수신자1"
		'
		'LabelSend2
		'
		Me.LabelSend2.AutoSize = True
		Me.LabelSend2.Location = New System.Drawing.Point(36, 169)
		Me.LabelSend2.Name = "LabelSend2"
		Me.LabelSend2.Size = New System.Drawing.Size(58, 19)
		Me.LabelSend2.TabIndex = 32
		Me.LabelSend2.Text = "수신자2"
		'
		'LabelSend3
		'
		Me.LabelSend3.AutoSize = True
		Me.LabelSend3.Location = New System.Drawing.Point(36, 200)
		Me.LabelSend3.Name = "LabelSend3"
		Me.LabelSend3.Size = New System.Drawing.Size(58, 19)
		Me.LabelSend3.TabIndex = 33
		Me.LabelSend3.Text = "수신자3"
		'
		'LabelCC3
		'
		Me.LabelCC3.AutoSize = True
		Me.LabelCC3.Location = New System.Drawing.Point(203, 200)
		Me.LabelCC3.Name = "LabelCC3"
		Me.LabelCC3.Size = New System.Drawing.Size(58, 19)
		Me.LabelCC3.TabIndex = 36
		Me.LabelCC3.Text = "참조자3"
		'
		'LabelCC2
		'
		Me.LabelCC2.AutoSize = True
		Me.LabelCC2.Location = New System.Drawing.Point(204, 169)
		Me.LabelCC2.Name = "LabelCC2"
		Me.LabelCC2.Size = New System.Drawing.Size(58, 19)
		Me.LabelCC2.TabIndex = 35
		Me.LabelCC2.Text = "참조자2"
		'
		'LabelCC1
		'
		Me.LabelCC1.AutoSize = True
		Me.LabelCC1.Location = New System.Drawing.Point(204, 138)
		Me.LabelCC1.Name = "LabelCC1"
		Me.LabelCC1.Size = New System.Drawing.Size(56, 19)
		Me.LabelCC1.TabIndex = 34
		Me.LabelCC1.Text = "참조자1"
		'
		'LabelID
		'
		Me.LabelID.AutoSize = True
		Me.LabelID.Location = New System.Drawing.Point(71, 259)
		Me.LabelID.Name = "LabelID"
		Me.LabelID.Size = New System.Drawing.Size(21, 19)
		Me.LabelID.TabIndex = 37
		Me.LabelID.Text = "ID"
		'
		'LabelPW
		'
		Me.LabelPW.AutoSize = True
		Me.LabelPW.Location = New System.Drawing.Point(64, 288)
		Me.LabelPW.Name = "LabelPW"
		Me.LabelPW.Size = New System.Drawing.Size(30, 19)
		Me.LabelPW.TabIndex = 38
		Me.LabelPW.Text = "PW"
		'
		'LabelFile
		'
		Me.LabelFile.AutoSize = True
		Me.LabelFile.Location = New System.Drawing.Point(29, 336)
		Me.LabelFile.Name = "LabelFile"
		Me.LabelFile.Size = New System.Drawing.Size(65, 19)
		Me.LabelFile.TabIndex = 39
		Me.LabelFile.Text = "첨부파일"
		'
		'TextBoxHost
		'
		Me.TextBoxHost.CustomBackground = True
		Me.TextBoxHost.Location = New System.Drawing.Point(108, 27)
		Me.TextBoxHost.Name = "TextBoxHost"
		Me.TextBoxHost.Size = New System.Drawing.Size(240, 23)
		Me.TextBoxHost.TabIndex = 40
		'
		'TextBoxPort
		'
		Me.TextBoxPort.CustomBackground = True
		Me.TextBoxPort.Location = New System.Drawing.Point(108, 58)
		Me.TextBoxPort.Name = "TextBoxPort"
		Me.TextBoxPort.Size = New System.Drawing.Size(240, 23)
		Me.TextBoxPort.TabIndex = 41
		'
		'TextBoxID
		'
		Me.TextBoxID.CustomBackground = True
		Me.TextBoxID.Location = New System.Drawing.Point(108, 255)
		Me.TextBoxID.Name = "TextBoxID"
		Me.TextBoxID.Size = New System.Drawing.Size(240, 23)
		Me.TextBoxID.TabIndex = 42
		'
		'TextBoxPwd
		'
		Me.TextBoxPwd.CustomBackground = True
		Me.TextBoxPwd.Location = New System.Drawing.Point(108, 284)
		Me.TextBoxPwd.Name = "TextBoxPwd"
		Me.TextBoxPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBoxPwd.Size = New System.Drawing.Size(240, 23)
		Me.TextBoxPwd.TabIndex = 43
		'
		'TextBoxFile
		'
		Me.TextBoxFile.CustomBackground = True
		Me.TextBoxFile.Location = New System.Drawing.Point(108, 332)
		Me.TextBoxFile.Name = "TextBoxFile"
		Me.TextBoxFile.Size = New System.Drawing.Size(208, 23)
		Me.TextBoxFile.TabIndex = 44
		'
		'ComboBoxSend1
		'
		Me.ComboBoxSend1.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxSend1.FormattingEnabled = True
		Me.ComboBoxSend1.ItemHeight = 19
		Me.ComboBoxSend1.Location = New System.Drawing.Point(108, 135)
		Me.ComboBoxSend1.Name = "ComboBoxSend1"
		Me.ComboBoxSend1.Size = New System.Drawing.Size(77, 25)
		Me.ComboBoxSend1.TabIndex = 45
		'
		'ComboBoxSend2
		'
		Me.ComboBoxSend2.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxSend2.FormattingEnabled = True
		Me.ComboBoxSend2.ItemHeight = 19
		Me.ComboBoxSend2.Location = New System.Drawing.Point(108, 166)
		Me.ComboBoxSend2.Name = "ComboBoxSend2"
		Me.ComboBoxSend2.Size = New System.Drawing.Size(77, 25)
		Me.ComboBoxSend2.TabIndex = 46
		'
		'ComboBoxSend3
		'
		Me.ComboBoxSend3.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxSend3.FormattingEnabled = True
		Me.ComboBoxSend3.ItemHeight = 19
		Me.ComboBoxSend3.Location = New System.Drawing.Point(108, 197)
		Me.ComboBoxSend3.Name = "ComboBoxSend3"
		Me.ComboBoxSend3.Size = New System.Drawing.Size(77, 25)
		Me.ComboBoxSend3.TabIndex = 47
		'
		'ComboBoxCC1
		'
		Me.ComboBoxCC1.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxCC1.FormattingEnabled = True
		Me.ComboBoxCC1.ItemHeight = 19
		Me.ComboBoxCC1.Location = New System.Drawing.Point(271, 135)
		Me.ComboBoxCC1.Name = "ComboBoxCC1"
		Me.ComboBoxCC1.Size = New System.Drawing.Size(77, 25)
		Me.ComboBoxCC1.TabIndex = 48
		'
		'ComboBoxCC2
		'
		Me.ComboBoxCC2.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxCC2.FormattingEnabled = True
		Me.ComboBoxCC2.ItemHeight = 19
		Me.ComboBoxCC2.Location = New System.Drawing.Point(271, 166)
		Me.ComboBoxCC2.Name = "ComboBoxCC2"
		Me.ComboBoxCC2.Size = New System.Drawing.Size(77, 25)
		Me.ComboBoxCC2.TabIndex = 49
		'
		'ComboBoxCC3
		'
		Me.ComboBoxCC3.FontSize = MetroFramework.MetroLinkSize.Small
		Me.ComboBoxCC3.FormattingEnabled = True
		Me.ComboBoxCC3.ItemHeight = 19
		Me.ComboBoxCC3.Location = New System.Drawing.Point(271, 197)
		Me.ComboBoxCC3.Name = "ComboBoxCC3"
		Me.ComboBoxCC3.Size = New System.Drawing.Size(77, 25)
		Me.ComboBoxCC3.TabIndex = 50
		'
		'RadioButtonTrue
		'
		Me.RadioButtonTrue.AutoSize = True
		Me.RadioButtonTrue.Location = New System.Drawing.Point(138, 96)
		Me.RadioButtonTrue.Name = "RadioButtonTrue"
		Me.RadioButtonTrue.Size = New System.Drawing.Size(47, 15)
		Me.RadioButtonTrue.TabIndex = 51
		Me.RadioButtonTrue.TabStop = True
		Me.RadioButtonTrue.Text = "사용"
		Me.RadioButtonTrue.UseVisualStyleBackColor = True
		'
		'RadioButtonFalse
		'
		Me.RadioButtonFalse.AutoSize = True
		Me.RadioButtonFalse.Location = New System.Drawing.Point(257, 96)
		Me.RadioButtonFalse.Name = "RadioButtonFalse"
		Me.RadioButtonFalse.Size = New System.Drawing.Size(59, 15)
		Me.RadioButtonFalse.TabIndex = 52
		Me.RadioButtonFalse.TabStop = True
		Me.RadioButtonFalse.Text = "미사용"
		Me.RadioButtonFalse.UseVisualStyleBackColor = True
		'
		'ButtonSave
		'
		Me.ButtonSave.Location = New System.Drawing.Point(80, 381)
		Me.ButtonSave.Name = "ButtonSave"
		Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
		Me.ButtonSave.TabIndex = 54
		Me.ButtonSave.Text = "저장"
		'
		'ButtonPath
		'
		Me.ButtonPath.Location = New System.Drawing.Point(314, 332)
		Me.ButtonPath.Name = "ButtonPath"
		Me.ButtonPath.Size = New System.Drawing.Size(34, 23)
		Me.ButtonPath.TabIndex = 55
		Me.ButtonPath.Text = "선택"
		'
		'ButtonCancel
		'
		Me.ButtonCancel.Location = New System.Drawing.Point(225, 381)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
		Me.ButtonCancel.TabIndex = 56
		Me.ButtonCancel.Text = "닫기"
		'
		'Configure
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
		Me.ClientSize = New System.Drawing.Size(379, 419)
		Me.Controls.Add(Me.ButtonCancel)
		Me.Controls.Add(Me.ButtonPath)
		Me.Controls.Add(Me.ButtonSave)
		Me.Controls.Add(Me.RadioButtonFalse)
		Me.Controls.Add(Me.RadioButtonTrue)
		Me.Controls.Add(Me.ComboBoxCC3)
		Me.Controls.Add(Me.ComboBoxCC2)
		Me.Controls.Add(Me.ComboBoxCC1)
		Me.Controls.Add(Me.ComboBoxSend3)
		Me.Controls.Add(Me.ComboBoxSend2)
		Me.Controls.Add(Me.ComboBoxSend1)
		Me.Controls.Add(Me.TextBoxFile)
		Me.Controls.Add(Me.TextBoxPwd)
		Me.Controls.Add(Me.TextBoxID)
		Me.Controls.Add(Me.TextBoxPort)
		Me.Controls.Add(Me.TextBoxHost)
		Me.Controls.Add(Me.LabelFile)
		Me.Controls.Add(Me.LabelPW)
		Me.Controls.Add(Me.LabelID)
		Me.Controls.Add(Me.LabelCC3)
		Me.Controls.Add(Me.LabelCC2)
		Me.Controls.Add(Me.LabelCC1)
		Me.Controls.Add(Me.LabelSend3)
		Me.Controls.Add(Me.LabelSend2)
		Me.Controls.Add(Me.LabelSend1)
		Me.Controls.Add(Me.LabelSSL)
		Me.Controls.Add(Me.LabelHost)
		Me.Controls.Add(Me.LabelPort)
		Me.DisplayHeader = False
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Configure"
		Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
		Me.Resizable = False
		Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None
		Me.Text = "EasyReport"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents LabelPort As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelHost As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelSSL As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelSend1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelSend2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelSend3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelCC3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelCC2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelCC1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelID As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelPW As MetroFramework.Controls.MetroLabel
	Friend WithEvents LabelFile As MetroFramework.Controls.MetroLabel
	Friend WithEvents TextBoxHost As MetroFramework.Controls.MetroTextBox
	Friend WithEvents TextBoxPort As MetroFramework.Controls.MetroTextBox
	Friend WithEvents TextBoxID As MetroFramework.Controls.MetroTextBox
	Friend WithEvents TextBoxPwd As MetroFramework.Controls.MetroTextBox
	Friend WithEvents TextBoxFile As MetroFramework.Controls.MetroTextBox
	Friend WithEvents ComboBoxSend1 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents ComboBoxSend2 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents ComboBoxSend3 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents ComboBoxCC1 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents ComboBoxCC2 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents ComboBoxCC3 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents RadioButtonTrue As MetroFramework.Controls.MetroRadioButton
	Friend WithEvents RadioButtonFalse As MetroFramework.Controls.MetroRadioButton
	Friend WithEvents ButtonSave As MetroFramework.Controls.MetroButton
	Friend WithEvents ButtonPath As MetroFramework.Controls.MetroButton
	Friend WithEvents ButtonCancel As MetroFramework.Controls.MetroButton
End Class
