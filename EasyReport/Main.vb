Imports Microsoft.Office.Interop
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class Main

    Public JooEun = True
    Public Person(18) As String
    Public Address(18) As String
    Public WorkDeny = False

    Public xls As New Excel.Application
    Public xworkbook As Excel.Workbook
    Public xworksheet As Excel.Worksheet

    Public BF = 9
    Public BE = 25

    Private Sub ButtonGetDate_Click(sender As Object, e As EventArgs) Handles ButtonGetDate.Click

        TextBoxDate.Text = Format(Now, "yyyy-MM-dd")

    End Sub

    Private Sub TextBoxDate_LostFocus(sender As Object, e As EventArgs) Handles TextBoxDate.LostFocus

        If Not IsDate(TextBoxDate.Text) And Not TextBoxDate.Text = "" Then

            MsgBox("올바른 날짜가 아닙니다.", vbOKOnly, "Error")
            TextBoxDate.Text = ""

        End If

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load

        If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then

            MsgBox("굳이 두 개나 킬 필요가..?", vbOKOnly, "Why?")
            Application.Exit()

        End If

        Person(0) = ""
        Person(1) = "김인현"
        Person(2) = "박종택"
        Person(3) = "김영미"
        Person(4) = "한동훈"
        Person(5) = "신규선"
        Person(6) = "전홍규"
        Person(7) = "방대현"
        Person(8) = "신영준"
        Person(9) = "정언락"
        Person(10) = "박성진"
        Person(11) = "김이호"
        Person(12) = "김정배"
        Person(13) = "KSIC 전체"
        Person(14) = "연구소"
        Person(15) = "사업본부"
        Person(16) = "경영"
        Person(17) = "영업"
        Person(18) = "기술지원"

        Address(0) = ""
        Address(1) = "ihkim@ksic.net"
        Address(2) = "jongtaikp@ksic.net"
        Address(3) = "ymkim@ksic.net"
        Address(4) = "dhhan@ksic.net"
        Address(5) = "gsshin@ksic.net"
        Address(6) = "hkjeon82@ksic.net"
        Address(7) = "dhbang@ksic.net"
        Address(8) = "syj0928@ksic.net"
        Address(9) = "carakmon@ksic.net"
        Address(10) = "psj1789@ksic.net"
        Address(11) = "vahnchris79@ksic.net"
        Address(12) = "tdcgman@ksic.net"
        Address(13) = "all@ksic.net"
        Address(14) = "lab@ksic.net"
        Address(15) = "business@ksic.net"
        Address(16) = "mts@ksic.net"
        Address(17) = "sales@ksic.net"
        Address(18) = "techsupport@ksic.net"

        Dim i As Integer

        For i = 0 To Person.Length - 1

            ComboBoxSend1.Items.Add(Person(i))
            ComboBoxSend2.Items.Add(Person(i))
            ComboBoxSend3.Items.Add(Person(i))

            ComboBoxCC1.Items.Add(Person(i))
            ComboBoxCC2.Items.Add(Person(i))
            ComboBoxCC3.Items.Add(Person(i))

        Next

        ProgressBar1.Style = ProgressBarStyle.Blocks
        ProgressBar1.Maximum = 9
        ProgressBar1.Step = 1

    End Sub

    Private Sub ComboBoxSend1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSend1.SelectedIndexChanged

        Select Case ComboBoxSend1.Text

            Case Person(0)
                LabelSend1.Text = Address(0)
            Case Person(1)
                LabelSend1.Text = Address(1)
            Case Person(2)
                LabelSend1.Text = Address(2)
            Case Person(3)
                LabelSend1.Text = Address(3)
            Case Person(4)
                LabelSend1.Text = Address(4)
            Case Person(5)
                LabelSend1.Text = Address(5)
            Case Person(6)
                LabelSend1.Text = Address(6)
            Case Person(7)
                LabelSend1.Text = Address(7)
            Case Person(8)
                LabelSend1.Text = Address(8)
            Case Person(9)
                LabelSend1.Text = Address(9)
            Case Person(10)
                LabelSend1.Text = Address(10)
            Case Person(11)
                LabelSend1.Text = Address(11)
            Case Person(12)
                LabelSend1.Text = Address(12)
            Case Person(13)
                LabelSend1.Text = Address(13)
            Case Person(14)
                LabelSend1.Text = Address(14)
            Case Person(15)
                LabelSend1.Text = Address(15)
            Case Person(16)
                LabelSend1.Text = Address(16)
            Case Person(17)
                LabelSend1.Text = Address(17)
            Case Person(18)
                LabelSend1.Text = Address(18)
            Case Else
                LabelSend1.Text = ""

        End Select

    End Sub

    Private Sub ComboBoxSend2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSend2.SelectedIndexChanged

        Select Case ComboBoxSend2.Text

            Case Person(0)
                LabelSend2.Text = Address(0)
            Case Person(1)
                LabelSend2.Text = Address(1)
            Case Person(2)
                LabelSend2.Text = Address(2)
            Case Person(3)
                LabelSend2.Text = Address(3)
            Case Person(4)
                LabelSend2.Text = Address(4)
            Case Person(5)
                LabelSend2.Text = Address(5)
            Case Person(6)
                LabelSend2.Text = Address(6)
            Case Person(7)
                LabelSend2.Text = Address(7)
            Case Person(8)
                LabelSend2.Text = Address(8)
            Case Person(9)
                LabelSend2.Text = Address(9)
            Case Person(10)
                LabelSend2.Text = Address(10)
            Case Person(11)
                LabelSend2.Text = Address(11)
            Case Person(12)
                LabelSend2.Text = Address(12)
            Case Person(13)
                LabelSend2.Text = Address(13)
            Case Person(14)
                LabelSend2.Text = Address(14)
            Case Person(15)
                LabelSend2.Text = Address(15)
            Case Person(16)
                LabelSend2.Text = Address(16)
            Case Person(17)
                LabelSend2.Text = Address(17)
            Case Person(18)
                LabelSend2.Text = Address(18)
            Case Else
                LabelSend2.Text = ""

        End Select

    End Sub

    Private Sub ComboBoxSend3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSend3.SelectedIndexChanged

        Select Case ComboBoxSend3.Text

            Case Person(0)
                LabelSend3.Text = Address(0)
            Case Person(1)
                LabelSend3.Text = Address(1)
            Case Person(2)
                LabelSend3.Text = Address(2)
            Case Person(3)
                LabelSend3.Text = Address(3)
            Case Person(4)
                LabelSend3.Text = Address(4)
            Case Person(5)
                LabelSend3.Text = Address(5)
            Case Person(6)
                LabelSend3.Text = Address(6)
            Case Person(7)
                LabelSend3.Text = Address(7)
            Case Person(8)
                LabelSend3.Text = Address(8)
            Case Person(9)
                LabelSend3.Text = Address(9)
            Case Person(10)
                LabelSend3.Text = Address(10)
            Case Person(11)
                LabelSend3.Text = Address(11)
            Case Person(12)
                LabelSend3.Text = Address(12)
            Case Person(13)
                LabelSend3.Text = Address(13)
            Case Person(14)
                LabelSend3.Text = Address(14)
            Case Person(15)
                LabelSend3.Text = Address(15)
            Case Person(16)
                LabelSend3.Text = Address(16)
            Case Person(17)
                LabelSend3.Text = Address(17)
            Case Person(18)
                LabelSend3.Text = Address(18)
            Case Else
                LabelSend3.Text = ""

        End Select

    End Sub

    Private Sub ComboBoxCC1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCC1.SelectedIndexChanged

        Select Case ComboBoxCC1.Text

            Case Person(0)
                LabelCC1.Text = Address(0)
            Case Person(1)
                LabelCC1.Text = Address(1)
            Case Person(2)
                LabelCC1.Text = Address(2)
            Case Person(3)
                LabelCC1.Text = Address(3)
            Case Person(4)
                LabelCC1.Text = Address(4)
            Case Person(5)
                LabelCC1.Text = Address(5)
            Case Person(6)
                LabelCC1.Text = Address(6)
            Case Person(7)
                LabelCC1.Text = Address(7)
            Case Person(8)
                LabelCC1.Text = Address(8)
            Case Person(9)
                LabelCC1.Text = Address(9)
            Case Person(10)
                LabelCC1.Text = Address(10)
            Case Person(11)
                LabelCC1.Text = Address(11)
            Case Person(12)
                LabelCC1.Text = Address(12)
            Case Person(13)
                LabelCC1.Text = Address(13)
            Case Person(14)
                LabelCC1.Text = Address(14)
            Case Person(15)
                LabelCC1.Text = Address(15)
            Case Person(16)
                LabelCC1.Text = Address(16)
            Case Person(17)
                LabelCC1.Text = Address(17)
            Case Person(18)
                LabelCC1.Text = Address(18)
            Case Else
                LabelCC1.Text = ""

        End Select

    End Sub

    Private Sub ComboBoxCC2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCC2.SelectedIndexChanged

        Select Case ComboBoxCC2.Text

            Case Person(0)
                LabelCC2.Text = Address(0)
            Case Person(1)
                LabelCC2.Text = Address(1)
            Case Person(2)
                LabelCC2.Text = Address(2)
            Case Person(3)
                LabelCC2.Text = Address(3)
            Case Person(4)
                LabelCC2.Text = Address(4)
            Case Person(5)
                LabelCC2.Text = Address(5)
            Case Person(6)
                LabelCC2.Text = Address(6)
            Case Person(7)
                LabelCC2.Text = Address(7)
            Case Person(8)
                LabelCC2.Text = Address(8)
            Case Person(9)
                LabelCC2.Text = Address(9)
            Case Person(10)
                LabelCC2.Text = Address(10)
            Case Person(11)
                LabelCC2.Text = Address(11)
            Case Person(12)
                LabelCC2.Text = Address(12)
            Case Person(13)
                LabelCC2.Text = Address(13)
            Case Person(14)
                LabelCC2.Text = Address(14)
            Case Person(15)
                LabelCC2.Text = Address(15)
            Case Person(16)
                LabelCC2.Text = Address(16)
            Case Person(17)
                LabelCC2.Text = Address(17)
            Case Person(18)
                LabelCC2.Text = Address(18)
            Case Else
                LabelCC2.Text = ""

        End Select

    End Sub

    Private Sub ComboBoxCC3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCC3.SelectedIndexChanged

        Select Case ComboBoxCC3.Text

            Case Person(0)
                LabelCC3.Text = Address(0)
            Case Person(1)
                LabelCC3.Text = Address(1)
            Case Person(2)
                LabelCC3.Text = Address(2)
            Case Person(3)
                LabelCC3.Text = Address(3)
            Case Person(4)
                LabelCC3.Text = Address(4)
            Case Person(5)
                LabelCC3.Text = Address(5)
            Case Person(6)
                LabelCC3.Text = Address(6)
            Case Person(7)
                LabelCC3.Text = Address(7)
            Case Person(8)
                LabelCC3.Text = Address(8)
            Case Person(9)
                LabelCC3.Text = Address(9)
            Case Person(10)
                LabelCC3.Text = Address(10)
            Case Person(11)
                LabelCC3.Text = Address(11)
            Case Person(12)
                LabelCC3.Text = Address(12)
            Case Person(13)
                LabelCC3.Text = Address(13)
            Case Person(14)
                LabelCC3.Text = Address(14)
            Case Person(15)
                LabelCC3.Text = Address(15)
            Case Person(16)
                LabelCC3.Text = Address(16)
            Case Person(17)
                LabelCC3.Text = Address(17)
            Case Person(18)
                LabelCC3.Text = Address(18)
            Case Else
                LabelCC3.Text = ""

        End Select

    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click

        If LabelSend1.Text = "" And LabelSend2.Text = "" And LabelSend3.Text = "" Then

            MsgBox("수신자가 없습니다.", vbOKOnly, "Error")

        ElseIf Not IsDate(TextBoxDate.Text) Then

            MsgBox("날짜가 올바르지 않습니다.", vbOKOnly, "Error")

        ElseIf TextBoxPath.Text = "" Then

            MsgBox("보고서가 없습니다.", vbOKOnly, "Error")

        ElseIf TextBoxID.Text = "" Or TextBoxPW.Text = "" Then

            MsgBox("이메일 혹은 비밀번호가 없습니다.", vbOKOnly, "Error")

        ElseIf Not LabelSend1.Text = "" Or Not LabelSend2.Text = "" Or Not LabelSend3.Text = "" And IsDate(TextBoxDate) And Not TextBoxPath.Text = "" And Not TextBoxID.Text = "" And Not TextBoxPW.Text = "" Then

            If MsgBox("보고서를 발송합니다.", vbOKCancel, "Send") = 1 Then

                BackgroundWorker1.RunWorkerAsync()

            End If

        End If

    End Sub

    Private Sub ButtonCls_Click(sender As Object, e As EventArgs) Handles ButtonCls.Click

        ComboBoxSend1.SelectedIndex = 0
        ComboBoxSend2.SelectedIndex = 0
        ComboBoxSend3.SelectedIndex = 0
        ComboBoxCC1.SelectedIndex = 0
        ComboBoxCC2.SelectedIndex = 0
        ComboBoxCC3.SelectedIndex = 0
        TextBoxPath.Clear()
        TextBoxTxt.Clear()

    End Sub

    Private Sub ButtonFile_Click(sender As Object, e As EventArgs) Handles ButtonFile.Click

        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"

        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then

            TextBoxPath.Text = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim xlotno = ""
        Dim sheetname = Format(DatePart("m", TextBoxDate.Text), "00") & Format(DatePart("d", TextBoxDate.Text), "00")
        Dim i = 0
        Dim workerName As String
        Dim workerPart As String
        Dim charArr() As Char

        WorkDeny = False
        BackgroundWorker1.ReportProgress(1)

        Try

            xls.Visible = True
            xworkbook = xls.Workbooks.Open(TextBoxPath.Text)
            xworksheet = xworkbook.Sheets(sheetname)
            workerName = xworksheet.Cells(6, 3).Value
            workerPart = xworksheet.Cells(5, 3).Value

            While (True)

                If Not xworksheet.Cells(BF + i, 3).Value = "" Then

                    charArr = xworksheet.Cells(BF + i, 3).Value.ToCharArray

                End If

                If charArr.Length >= 3 And charArr(0) = "=" And charArr(1) = "=" And charArr(2) = "=" Then

                    Exit While

                End If


                If Not xworksheet.Cells(BF + i, 3).Value = "" Then

                    If charArr(1) = "." And charArr(2) = " " Then

                        xlotno += vbCrLf & xworksheet.Cells(BF + i, 3).Value & vbCrLf

                    ElseIf Not charArr(1) = "." And Not charArr(2) = " " Then

                        xlotno += xworksheet.Cells(BF + i, 3).Value & vbCrLf

                    End If

                End If

                i += 1

            End While

        Catch ex As Exception

            MsgBox(ex.Message)
            WorkDeny = True
            Exit Sub

        End Try

        BackgroundWorker1.ReportProgress(2)

        Try

            xworkbook.Close()
            xls.Quit()

            Marshal.ReleaseComObject(xworksheet)
            Marshal.ReleaseComObject(xworkbook)
            Marshal.ReleaseComObject(xls)

        Catch ex As Exception

            MsgBox(ex.Message)
            WorkDeny = True
            Exit Sub

        End Try

        BackgroundWorker1.ReportProgress(3)

        Dim smtpServer As New SmtpClient()
        Dim mail As New MailMessage()

        Try

            smtpServer.Credentials = New Net.NetworkCredential(TextBoxID.Text, TextBoxPW.Text)
            smtpServer.Port = 587
            smtpServer.Host = "smtp.gmail.com"
            smtpServer.EnableSsl = True

            mail = New MailMessage()
            mail.From = New MailAddress(TextBoxID.Text)

        Catch ex As Exception

            MsgBox(ex.Message)
            WorkDeny = True

            xworkbook.Close()
            xls.Quit()

            Marshal.ReleaseComObject(xworksheet)
            Marshal.ReleaseComObject(xworkbook)
            Marshal.ReleaseComObject(xls)

            Exit Sub

        End Try

        BackgroundWorker1.ReportProgress(4)

        Try

            If Not LabelSend1.Text = "" Then

                mail.To.Add(LabelSend1.Text)

            End If

            If Not LabelSend2.Text = "" Then

                mail.To.Add(LabelSend2.Text)

            End If

            If Not LabelSend3.Text = "" Then

                mail.To.Add(LabelSend3.Text)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            WorkDeny = True

            xworkbook.Close()
            xls.Quit()

            Marshal.ReleaseComObject(xworksheet)
            Marshal.ReleaseComObject(xworkbook)
            Marshal.ReleaseComObject(xls)

            Exit Sub

        End Try

        BackgroundWorker1.ReportProgress(5)

        Try

            If Not LabelCC1.Text = "" Then

                mail.CC.Add(LabelCC1.Text)

            End If

            If Not LabelCC2.Text = "" Then

                mail.CC.Add(LabelCC2.Text)

            End If

            If Not LabelCC3.Text = "" Then

                mail.CC.Add(LabelCC3.Text)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            WorkDeny = True

            xworkbook.Close()
            xls.Quit()

            Marshal.ReleaseComObject(xworksheet)
            Marshal.ReleaseComObject(xworkbook)
            Marshal.ReleaseComObject(xls)

            Exit Sub

        End Try

        BackgroundWorker1.ReportProgress(6)

        Try

            mail.Subject = TextBoxDate.Text & " " & WeekdayName(Weekday(TextBoxDate.Text)) & " 일일업무 보고입니다."
            mail.Body = "안녕하십니까." & vbCrLf &
                        workerPart & " " & workerName & "입니다." & vbCrLf & vbCrLf &
                        TextBoxDate.Text & " " & WeekdayName(Weekday(TextBoxDate.Text)) & " 일일업무 보고입니다." & vbCrLf &
                        xlotno & vbCrLf &
                        TextBoxTxt.Text & vbCrLf & vbCrLf &
                        "이상입니다." & vbCrLf & vbCrLf & vbCrLf &
                        workerName & " 드림"

        Catch ex As Exception

            MsgBox(ex.Message)
            WorkDeny = True

            xworkbook.Close()
            xls.Quit()

            Marshal.ReleaseComObject(xlotno)
            Marshal.ReleaseComObject(workerPart)
            Marshal.ReleaseComObject(workerName)
            Marshal.ReleaseComObject(xworksheet)
            Marshal.ReleaseComObject(xworkbook)
            Marshal.ReleaseComObject(xls)

            Exit Sub

        End Try

        BackgroundWorker1.ReportProgress(7)

        Try

            mail.Attachments.Add(New Attachment(TextBoxPath.Text))

        Catch ex As Exception

            MsgBox(ex.Message)
            WorkDeny = True

            xworkbook.Close()
            xls.Quit()

            Marshal.ReleaseComObject(xlotno)
            Marshal.ReleaseComObject(workerPart)
            Marshal.ReleaseComObject(workerName)
            Marshal.ReleaseComObject(xworksheet)
            Marshal.ReleaseComObject(xworkbook)
            Marshal.ReleaseComObject(xls)

            Exit Sub

        End Try

        BackgroundWorker1.ReportProgress(8)

        Try

            smtpServer.Send(mail)

        Catch ex As Exception

            MsgBox(ex.Message)
            WorkDeny = True

            xworkbook.Close()
            xls.Quit()

            Marshal.ReleaseComObject(xlotno)
            Marshal.ReleaseComObject(workerPart)
            Marshal.ReleaseComObject(workerName)
            Marshal.ReleaseComObject(xworksheet)
            Marshal.ReleaseComObject(xworkbook)
            Marshal.ReleaseComObject(xls)

            Exit Sub

        End Try

        BackgroundWorker1.ReportProgress(9)

        Try

            xworkbook.Close()
            xls.Quit()

            Marshal.ReleaseComObject(xlotno)
            Marshal.ReleaseComObject(workerPart)
            Marshal.ReleaseComObject(workerName)
            Marshal.ReleaseComObject(xworksheet)
            Marshal.ReleaseComObject(xworkbook)
            Marshal.ReleaseComObject(xls)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If WorkDeny = False Then

            MsgBox("발송 완료", vbOKOnly, "Send")
            ProgressBar1.Value = 0

        ElseIf WorkDeny = True Then

            MsgBox("발송 실패", vbOKOnly, "Send")
            ProgressBar1.Value = 0

        End If

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub ButtonShoot_Click(sender As Object, e As EventArgs) Handles ButtonShoot.Click

        TextBoxDate.Text = Format(Now, "yyyy-MM-dd")
        ComboBoxSend1.SelectedIndex = 1
        ComboBoxCC1.SelectedIndex = 7
        TextBoxID.Text = "psj1789@ksic.net"
        TextBoxPath.Text = "\\30.30.30.150\Storage_Hub\999.NAS_PORTAL\사업본부_37번_백업\개인자료\박성진\사업본부 2019 일일업무보고서 박성진.xlsm"

    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Try

            xworkbook.Close()
            xls.Quit()

            Marshal.ReleaseComObject(xworksheet)
            Marshal.ReleaseComObject(xworkbook)
            Marshal.ReleaseComObject(xls)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick

        EasterEgg.ShowDialog()

    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click

        Dim workbook As New Excel.Application

        workbook.Visible = True
        workbook.Workbooks.Open(TextBoxPath.Text)

    End Sub

End Class
