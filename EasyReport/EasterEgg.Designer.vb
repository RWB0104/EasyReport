<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EasterEgg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EasterEgg))
        Me.LabelTitie = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelBirth = New System.Windows.Forms.Label()
        Me.LabelWhoop = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelTitle2 = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitie
        '
        Me.LabelTitie.AutoSize = True
        Me.LabelTitie.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelTitie.Location = New System.Drawing.Point(135, 26)
        Me.LabelTitie.Name = "LabelTitie"
        Me.LabelTitie.Size = New System.Drawing.Size(138, 15)
        Me.LabelTitie.TabIndex = 1
        Me.LabelTitie.Text = "일일업무 보고서 귀찮다."
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelName.Location = New System.Drawing.Point(135, 66)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(106, 15)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "만든 환자 : 박성진"
        '
        'LabelBirth
        '
        Me.LabelBirth.AutoSize = True
        Me.LabelBirth.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelBirth.Location = New System.Drawing.Point(134, 87)
        Me.LabelBirth.Name = "LabelBirth"
        Me.LabelBirth.Size = New System.Drawing.Size(132, 15)
        Me.LabelBirth.TabIndex = 3
        Me.LabelBirth.Text = "제작일자 : 2019-05-10"
        '
        'LabelWhoop
        '
        Me.LabelWhoop.AutoSize = True
        Me.LabelWhoop.Cursor = System.Windows.Forms.Cursors.No
        Me.LabelWhoop.Font = New System.Drawing.Font("맑은 고딕", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelWhoop.ForeColor = System.Drawing.Color.Blue
        Me.LabelWhoop.Location = New System.Drawing.Point(134, 116)
        Me.LabelWhoop.Name = "LabelWhoop"
        Me.LabelWhoop.Size = New System.Drawing.Size(87, 15)
        Me.LabelWhoop.TabIndex = 4
        Me.LabelWhoop.Text = "갓주은 찬양해!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.EasyReport.My.Resources.Resources.계정
        Me.PictureBox1.Location = New System.Drawing.Point(12, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LabelTitle2
        '
        Me.LabelTitle2.AutoSize = True
        Me.LabelTitle2.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelTitle2.Location = New System.Drawing.Point(134, 46)
        Me.LabelTitle2.Name = "LabelTitle2"
        Me.LabelTitle2.Size = New System.Drawing.Size(98, 15)
        Me.LabelTitle2.TabIndex = 5
        Me.LabelTitle2.Text = "그래서 만들었다."
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(29, 132)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(63, 26)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "찬양해!"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'EasterEgg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.LabelTitle2)
        Me.Controls.Add(Me.LabelWhoop)
        Me.Controls.Add(Me.LabelBirth)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.LabelTitie)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EasterEgg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasterEgg"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelTitie As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelBirth As Label
    Friend WithEvents LabelWhoop As Label
    Friend WithEvents LabelTitle2 As Label
    Friend WithEvents ButtonExit As Button
End Class
