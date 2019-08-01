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
        Me.SuspendLayout()
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(51, 415)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 0
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(181, 415)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ComboBoxSend1
        '
        Me.ComboBoxSend1.FormattingEnabled = True
        Me.ComboBoxSend1.Location = New System.Drawing.Point(97, 51)
        Me.ComboBoxSend1.Name = "ComboBoxSend1"
        Me.ComboBoxSend1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBoxSend1.TabIndex = 2
        '
        'ComboBoxSend2
        '
        Me.ComboBoxSend2.FormattingEnabled = True
        Me.ComboBoxSend2.Location = New System.Drawing.Point(97, 97)
        Me.ComboBoxSend2.Name = "ComboBoxSend2"
        Me.ComboBoxSend2.Size = New System.Drawing.Size(121, 20)
        Me.ComboBoxSend2.TabIndex = 3
        '
        'ComboBoxSend3
        '
        Me.ComboBoxSend3.FormattingEnabled = True
        Me.ComboBoxSend3.Location = New System.Drawing.Point(111, 123)
        Me.ComboBoxSend3.Name = "ComboBoxSend3"
        Me.ComboBoxSend3.Size = New System.Drawing.Size(121, 20)
        Me.ComboBoxSend3.TabIndex = 4
        '
        'ComboBoxCC1
        '
        Me.ComboBoxCC1.FormattingEnabled = True
        Me.ComboBoxCC1.Location = New System.Drawing.Point(93, 215)
        Me.ComboBoxCC1.Name = "ComboBoxCC1"
        Me.ComboBoxCC1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBoxCC1.TabIndex = 5
        '
        'ComboBoxCC2
        '
        Me.ComboBoxCC2.FormattingEnabled = True
        Me.ComboBoxCC2.Location = New System.Drawing.Point(135, 258)
        Me.ComboBoxCC2.Name = "ComboBoxCC2"
        Me.ComboBoxCC2.Size = New System.Drawing.Size(121, 20)
        Me.ComboBoxCC2.TabIndex = 6
        '
        'ComboBoxCC3
        '
        Me.ComboBoxCC3.FormattingEnabled = True
        Me.ComboBoxCC3.Location = New System.Drawing.Point(135, 284)
        Me.ComboBoxCC3.Name = "ComboBoxCC3"
        Me.ComboBoxCC3.Size = New System.Drawing.Size(121, 20)
        Me.ComboBoxCC3.TabIndex = 7
        '
        'Configure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 450)
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

    End Sub

    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ComboBoxSend1 As ComboBox
    Friend WithEvents ComboBoxSend2 As ComboBox
    Friend WithEvents ComboBoxSend3 As ComboBox
    Friend WithEvents ComboBoxCC1 As ComboBox
    Friend WithEvents ComboBoxCC2 As ComboBox
    Friend WithEvents ComboBoxCC3 As ComboBox
End Class
