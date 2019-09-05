Imports Microsoft.Office.Interop
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Xml
Imports System.IO

Public Class Main

	Public JooEun = True
	Public Person(18) As String
	Public Address(18) As String
	Public WorkDeny = False

	Public PersonName(1) As String
	Public PersonMail(1) As String

	Public AutoSendCount As Integer
	Public AutoCCCount As Integer
	Public AutoSendList(2) As String
	Public AutoCCList(2) As String
	Public AutoAttachStr As String
	Public AutoID As String
	Public AutoPwd As String

	Public xls As New Excel.Application
	Public xworkbook As Excel.Workbook
	Public xworksheet As Excel.Worksheet

	Public Config As String = Application.StartupPath + "\EasyReportConf.xml"

	Public ConfForm As New Configure()

	Public BF = 9
	Dim i As Integer

	' 현재날짜 계산
	Private Sub ButtonGetDate_Click(sender As Object, e As EventArgs) Handles ButtonGetDate.Click

		TextBoxDate.Text = Format(Now, "yyyy-MM-dd")

	End Sub

	' 날짜 검증
	Private Sub TextBoxDate_LostFocus(sender As Object, e As EventArgs) Handles TextBoxDate.LostFocus

		' 날짜 형식이 아니거나 빈 칸일 경우
		If Not IsDate(TextBoxDate.Text) And Not TextBoxDate.Text = "" Then

			MsgBox("올바른 날짜가 아닙니다.", vbOKOnly, "Error")
			TextBoxDate.Text = Format(Now, "yyyy-MM-dd")

		End If

	End Sub

	Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load

		' 중복 구동 방지
		If UBound(Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName)) > 0 Then

			MsgBox("굳이 두 개나 킬 필요가..?", vbOKOnly, "Why?")
			Application.Exit()

		End If

		Dim Conf As New XmlDocument()

		' 설정파일이 있을 경우
		If File.Exists(Config) Then

			Conf.Load(Config)

			Dim nodes As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/list/address")

			Dim autoSend As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/autoset/send")
			Dim autoCC As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/autoset/cc")
			Dim autoAttach As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/autoset/attach")
			Dim autoAccount As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/autoset/account")

			' 수신자
			AutoSendList(0) = autoSend(0).SelectSingleNode("name1").InnerText
			AutoSendList(1) = autoSend(0).SelectSingleNode("name2").InnerText
			AutoSendList(2) = autoSend(0).SelectSingleNode("name3").InnerText

			' 참조자
			AutoCCList(0) = autoCC(0).SelectSingleNode("name1").InnerText
			AutoCCList(1) = autoCC(0).SelectSingleNode("name2").InnerText
			AutoCCList(2) = autoCC(0).SelectSingleNode("name3").InnerText

			' 첨부파일 경로
			AutoAttachStr = autoAttach(0).SelectSingleNode("path").InnerText

			' 계정
			AutoID = autoAccount(0).SelectSingleNode("id").InnerText
			AutoPwd = autoAccount(0).SelectSingleNode("password").InnerText

			ReDim PersonName(nodes.Count - 1)
			ReDim PersonMail(nodes.Count - 1)

			' 주소록
			For i = 0 To nodes.Count - 1

				PersonName(i) = nodes(i).SelectSingleNode("name").InnerText
				PersonMail(i) = nodes(i).SelectSingleNode("email").InnerText

				' 수신자
				ComboBoxSend1.Items.Add(PersonName(i))
				ComboBoxSend2.Items.Add(PersonName(i))
				ComboBoxSend3.Items.Add(PersonName(i))

				' 참조자
				ComboBoxCC1.Items.Add(PersonName(i))
				ComboBoxCC2.Items.Add(PersonName(i))
				ComboBoxCC3.Items.Add(PersonName(i))

				' 설정창의 수신자
				ConfForm.ComboBoxSend1.Items.Add(PersonName(i))
				ConfForm.ComboBoxSend2.Items.Add(PersonName(i))
				ConfForm.ComboBoxSend3.Items.Add(PersonName(i))

				' 설정창의 참조자
				ConfForm.ComboBoxCC1.Items.Add(PersonName(i))
				ConfForm.ComboBoxCC2.Items.Add(PersonName(i))
				ConfForm.ComboBoxCC3.Items.Add(PersonName(i))

			Next

			' 설정파일이 없을 경우
		Else

			MsgBox("설정파일이 존재하지 않습니다.")

		End If

		ProgressBar1.Style = ProgressBarStyle.Blocks
		ProgressBar1.Maximum = 9
		ProgressBar1.Step = 1

	End Sub

	' 수신자1 메일주소 표시
	Private Sub ComboBoxSend1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSend1.SelectedIndexChanged

		LabelSend1.Text = PersonMail(ComboBoxSend1.SelectedIndex)

	End Sub

	' 수신자2 메일주소 표시
	Private Sub ComboBoxSend2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSend2.SelectedIndexChanged

		LabelSend2.Text = PersonMail(ComboBoxSend2.SelectedIndex)

	End Sub

	' 수신자3 메일주소 표시
	Private Sub ComboBoxSend3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSend3.SelectedIndexChanged

		LabelSend3.Text = PersonMail(ComboBoxSend3.SelectedIndex)

	End Sub

	' 참조자1 메일주소 표시
	Private Sub ComboBoxCC1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCC1.SelectedIndexChanged

		LabelCC1.Text = PersonMail(ComboBoxCC1.SelectedIndex)

	End Sub

	' 참조자2 메일주소 표시
	Private Sub ComboBoxCC2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCC2.SelectedIndexChanged

		LabelCC2.Text = PersonMail(ComboBoxCC2.SelectedIndex)

	End Sub

	' 참조자3 메일주소 표시
	Private Sub ComboBoxCC3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCC3.SelectedIndexChanged

		LabelCC3.Text = PersonMail(ComboBoxCC3.SelectedIndex)

	End Sub

	' 전송버튼 클릭 시 데이터 검증
	Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click

		' 수신자가 전부 비었을 경우
		If LabelSend1.Text = "" And LabelSend2.Text = "" And LabelSend3.Text = "" Then

			MsgBox("수신자가 없습니다.", vbOKOnly, "Error")

			' 날짜 형식이 올바르지 않을 경우
		ElseIf Not IsDate(TextBoxDate.Text) Then

			MsgBox("날짜가 올바르지 않습니다.", vbOKOnly, "Error")

			' 경로 형식이 올바르지 않을 경우
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

					If charArr.Length >= 3 Then

						If charArr.Length >= 3 And charArr(0) = "=" And charArr(1) = "=" And charArr(2) = "=" Then

							Exit While

						End If

						If charArr(1) = "." And charArr(2) = " " Then

							xlotno += vbCrLf & xworksheet.Cells(BF + i, 3).Value & vbCrLf

						End If

					Else

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

		ComboBoxSend1.SelectedItem = AutoSendList(0)
		ComboBoxSend2.SelectedItem = AutoSendList(1)
		ComboBoxSend3.SelectedItem = AutoSendList(2)

		ComboBoxCC1.SelectedItem = AutoCCList(0)
		ComboBoxCC2.SelectedItem = AutoCCList(1)
		ComboBoxCC3.SelectedItem = AutoCCList(2)

		TextBoxID.Text = AutoID
		TextBoxPW.Text = AutoPwd
		TextBoxPath.Text = AutoAttachStr

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

		If Not TextBoxPath.Text = "" Then

			Dim workbook As New Excel.Application
			workbook.Visible = True
			workbook.Workbooks.Open(TextBoxPath.Text)

		Else

			MsgBox("올바른 보고서 경로를 입력하세요!", vbOKOnly, "Error")

		End If

	End Sub

	Private Sub ButtonConf_Click(sender As Object, e As EventArgs) Handles ButtonConf.Click

		ConfForm.ShowDialog()

	End Sub

End Class