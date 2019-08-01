<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configure
    Inherits System.Windows.Forms.Form

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
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ComboBoxSend1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSend2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSend3 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCC1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCC2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCC3 = New System.Windows.Forms.ComboBox()
        Me.LabelSend1 = New System.Windows.Forms.Label()
        Me.LabelSend2 = New System.Windows.Forms.Label()
        Me.LabelSend3 = New System.Windows.Forms.Label()
        Me.LabelCC4 = New System.Windows.Forms.Label()
        Me.LabelCC5 = New System.Windows.Forms.Label()
        Me.LabelCC6 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxPwd = New System.Windows.Forms.TextBox()
        Me.TextBoxFile = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelPwd = New System.Windows.Forms.Label()
        Me.LabelFile = New System.Windows.Forms.Label()
        Me.ButtonPath = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(84, 250)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 0
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(222, 250)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ComboBoxSend1
        '
        Me.ComboBoxSend1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSend1.FormattingEnabled = True
        Me.ComboBoxSend1.Location = New System.Drawing.Point(84, 30)
        Me.ComboBoxSend1.Name = "ComboBoxSend1"
        Me.ComboBoxSend1.Size = New System.Drawing.Size(65, 20)
        Me.ComboBoxSend1.TabIndex = 2
        '
        'ComboBoxSend2
        '
        Me.ComboBoxSend2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSend2.FormattingEnabled = True
        Me.ComboBoxSend2.Location = New System.Drawing.Point(84, 66)
        Me.ComboBoxSend2.Name = "ComboBoxSend2"
        Me.ComboBoxSend2.Size = New System.Drawing.Size(65, 20)
        Me.ComboBoxSend2.TabIndex = 3
        '
        'ComboBoxSend3
        '
        Me.ComboBoxSend3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSend3.FormattingEnabled = True
        Me.ComboBoxSend3.Location = New System.Drawing.Point(84, 103)
        Me.ComboBoxSend3.Name = "ComboBoxSend3"
        Me.ComboBoxSend3.Size = New System.Drawing.Size(65, 20)
        Me.ComboBoxSend3.TabIndex = 4
        '
        'ComboBoxCC1
        '
        Me.ComboBoxCC1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCC1.FormattingEnabled = True
        Me.ComboBoxCC1.Location = New System.Drawing.Point(283, 30)
        Me.ComboBoxCC1.Name = "ComboBoxCC1"
        Me.ComboBoxCC1.Size = New System.Drawing.Size(65, 20)
        Me.ComboBoxCC1.TabIndex = 5
        '
        'ComboBoxCC2
        '
        Me.ComboBoxCC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCC2.FormattingEnabled = True
        Me.ComboBoxCC2.Location = New System.Drawing.Point(283, 66)
        Me.ComboBoxCC2.Name = "ComboBoxCC2"
        Me.ComboBoxCC2.Size = New System.Drawing.Size(65, 20)
        Me.ComboBoxCC2.TabIndex = 6
        '
        'ComboBoxCC3
        '
        Me.ComboBoxCC3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCC3.FormattingEnabled = True
        Me.ComboBoxCC3.Location = New System.Drawing.Point(283, 103)
        Me.ComboBoxCC3.Name = "ComboBoxCC3"
        Me.ComboBoxCC3.Size = New System.Drawing.Size(65, 20)
        Me.ComboBoxCC3.TabIndex = 7
        '
        'LabelSend1
        '
        Me.LabelSend1.AutoSize = True
        Me.LabelSend1.Location = New System.Drawing.Point(23, 33)
        Me.LabelSend1.Name = "LabelSend1"
        Me.LabelSend1.Size = New System.Drawing.Size(47, 12)
        Me.LabelSend1.TabIndex = 8
        Me.LabelSend1.Text = "수신자1"
        '
        'LabelSend2
        '
        Me.LabelSend2.AutoSize = True
        Me.LabelSend2.Location = New System.Drawing.Point(23, 69)
        Me.LabelSend2.Name = "LabelSend2"
        Me.LabelSend2.Size = New System.Drawing.Size(47, 12)
        Me.LabelSend2.TabIndex = 9
        Me.LabelSend2.Text = "수신자2"
        '
        'LabelSend3
        '
        Me.LabelSend3.AutoSize = True
        Me.LabelSend3.Location = New System.Drawing.Point(23, 106)
        Me.LabelSend3.Name = "LabelSend3"
        Me.LabelSend3.Size = New System.Drawing.Size(47, 12)
        Me.LabelSend3.TabIndex = 10
        Me.LabelSend3.Text = "수신자3"
        '
        'LabelCC4
        '
        Me.LabelCC4.AutoSize = True
        Me.LabelCC4.Location = New System.Drawing.Point(220, 33)
        Me.LabelCC4.Name = "LabelCC4"
        Me.LabelCC4.Size = New System.Drawing.Size(47, 12)
        Me.LabelCC4.TabIndex = 11
        Me.LabelCC4.Text = "참조자1"
        '
        'LabelCC5
        '
        Me.LabelCC5.AutoSize = True
        Me.LabelCC5.Location = New System.Drawing.Point(220, 69)
        Me.LabelCC5.Name = "LabelCC5"
        Me.LabelCC5.Size = New System.Drawing.Size(47, 12)
        Me.LabelCC5.TabIndex = 12
        Me.LabelCC5.Text = "참조자2"
        '
        'LabelCC6
        '
        Me.LabelCC6.AutoSize = True
        Me.LabelCC6.Location = New System.Drawing.Point(220, 106)
        Me.LabelCC6.Name = "LabelCC6"
        Me.LabelCC6.Size = New System.Drawing.Size(47, 12)
        Me.LabelCC6.TabIndex = 13
        Me.LabelCC6.Text = "참조자3"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(59, 165)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxID.TabIndex = 14
        '
        'TextBoxPwd
        '
        Me.TextBoxPwd.Location = New System.Drawing.Point(248, 165)
        Me.TextBoxPwd.Name = "TextBoxPwd"
        Me.TextBoxPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPwd.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxPwd.TabIndex = 15
        '
        'TextBoxFile
        '
        Me.TextBoxFile.Location = New System.Drawing.Point(84, 208)
        Me.TextBoxFile.Name = "TextBoxFile"
        Me.TextBoxFile.Size = New System.Drawing.Size(227, 21)
        Me.TextBoxFile.TabIndex = 16
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(29, 168)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(16, 12)
        Me.LabelID.TabIndex = 17
        Me.LabelID.Text = "ID"
        '
        'LabelPwd
        '
        Me.LabelPwd.AutoSize = True
        Me.LabelPwd.Location = New System.Drawing.Point(203, 168)
        Me.LabelPwd.Name = "LabelPwd"
        Me.LabelPwd.Size = New System.Drawing.Size(31, 12)
        Me.LabelPwd.TabIndex = 18
        Me.LabelPwd.Text = "PWD"
        '
        'LabelFile
        '
        Me.LabelFile.AutoSize = True
        Me.LabelFile.Location = New System.Drawing.Point(23, 211)
        Me.LabelFile.Name = "LabelFile"
        Me.LabelFile.Size = New System.Drawing.Size(53, 12)
        Me.LabelFile.TabIndex = 19
        Me.LabelFile.Text = "첨부파일"
        '
        'ButtonPath
        '
        Me.ButtonPath.Location = New System.Drawing.Point(322, 206)
        Me.ButtonPath.Name = "ButtonPath"
        Me.ButtonPath.Size = New System.Drawing.Size(26, 23)
        Me.ButtonPath.TabIndex = 20
        Me.ButtonPath.Text = "..."
        Me.ButtonPath.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Configure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 288)
        Me.Controls.Add(Me.ButtonPath)
        Me.Controls.Add(Me.LabelFile)
        Me.Controls.Add(Me.LabelPwd)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.TextBoxFile)
        Me.Controls.Add(Me.TextBoxPwd)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.LabelCC6)
        Me.Controls.Add(Me.LabelCC5)
        Me.Controls.Add(Me.LabelCC4)
        Me.Controls.Add(Me.LabelSend3)
        Me.Controls.Add(Me.LabelSend2)
        Me.Controls.Add(Me.LabelSend1)
        Me.Controls.Add(Me.ComboBoxCC3)
        Me.Controls.Add(Me.ComboBoxCC2)
        Me.Controls.Add(Me.ComboBoxCC1)
        Me.Controls.Add(Me.ComboBoxSend3)
        Me.Controls.Add(Me.ComboBoxSend2)
        Me.Controls.Add(Me.ComboBoxSend1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Configure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ComboBoxSend1 As ComboBox
    Friend WithEvents ComboBoxSend2 As ComboBox
    Friend WithEvents ComboBoxSend3 As ComboBox
    Friend WithEvents ComboBoxCC1 As ComboBox
    Friend WithEvents ComboBoxCC2 As ComboBox
    Friend WithEvents ComboBoxCC3 As ComboBox
    Friend WithEvents LabelSend1 As Label
    Friend WithEvents LabelSend2 As Label
    Friend WithEvents LabelSend3 As Label
    Friend WithEvents LabelCC4 As Label
    Friend WithEvents LabelCC5 As Label
    Friend WithEvents LabelCC6 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxPwd As TextBox
    Friend WithEvents TextBoxFile As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelPwd As Label
    Friend WithEvents LabelFile As Label
    Friend WithEvents ButtonPath As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
