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

	Public SmtpHost As String
	Public SmtpPort As Integer
	Public SmtpSSL As Boolean

	Public PersonName(1) As String
	Public PersonMail(1) As String

	Public AutoSendCount As Integer
	Public AutoCCCount As Integer
	Public AutoSendList(2) As String
	Public AutoCCList(2) As String
	Public AutoAttachStr As String
	Public AutoSimpler As Boolean
	Public AutoID As String
	Public AutoPwd As String

	Public xls
	Public xworkbook As Excel.Workbook
	Public xworksheet As Excel.Worksheet

	Public Config As String = Application.StartupPath + "\EasyReportConf.xml"

	Public ConfForm As New Configure()

	Public BF = 9
	Dim i As Integer

	Public encrypt As New EncryptManager(Environ("COMPUTERNAME"))

	' 현재날짜 계산
	Private Sub ButtonGetDate_Click(sender As Object, e As EventArgs) Handles ButtonGetDate.Click

		TextBoxDate.Text = Format(Now, "yyyy-MM-dd")

	End Sub

	' 날짜 검증
	Private Sub TextBoxDate_LostFocus(sender As Object, e As EventArgs)

		' 날짜 형식이 아니거나 빈 칸일 경우
		If Not IsDate(TextBoxDate.Text) And Not String.IsNullOrEmpty(TextBoxDate.Text) Then

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

		' 설정파일이 없을 경우
		If Not File.Exists(Config) Then

			ConfigMake()
			MsgBox("기본 설정파일이 생성되었습니다.")

		End If

		Conf.Load(Config)

		Dim nodes As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/list/address")

		Dim mail As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/mail")

		Dim autoSend As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/autoset/send")
		Dim autoCC As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/autoset/cc")
		Dim autoAttach As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/autoset/attach")
		Dim autoAccount As XmlNodeList = Conf.DocumentElement.SelectNodes("/data/autoset/account")

		' Smtp 호스트
		SmtpHost = mail(0).SelectSingleNode("host").InnerText

		' Smtp 포트
		SmtpPort = Integer.Parse(mail(0).SelectSingleNode("port").InnerText)

		Dim TempSSL = mail(0).SelectSingleNode("ssl").InnerText

		If TempSSL.ToLower = "true" Then

			SmtpSSL = True

		Else

			SmtpSSL = False

		End If

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

		' 데이터 간단 표시
		Dim tempSimple = autoAttach(0).SelectSingleNode("simple").InnerText

		If tempSimple.ToLower() = "true" Then

			AutoSimpler = True

		Else

			AutoSimpler = False

		End If

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

		ProgressBar1.Maximum = 9
		ProgressBar1.Step = 1

	End Sub

	' 수신자1 메일주소 표시
	Private Sub ComboBoxSend1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSend1.SelectedIndexChanged, ComboBoxSend1.SelectedIndexChanged

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

			xls = New Excel.Application
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

						If AutoSimpler Then

							If charArr(1) = "." And charArr(2) = " " Then

								xlotno += vbCrLf & "<p style=""font-family: 맑은 고딕; font-size:  14px;""><b>" & xworksheet.Cells(BF + i, 3).Value & "</b></p>" & vbCrLf

							End If

						Else

							If charArr(1) = "." And charArr(2) = " " Then

								xlotno += vbCrLf & "<br /><p style=""font-family: 맑은 고딕; font-size:  14px;""><b>" & xworksheet.Cells(BF + i, 3).Value & "</b></p>" & vbCrLf

							Else

								xlotno += vbCrLf & "<p style=""font-family: 맑은 고딕; font-size:  14px;"">" & xworksheet.Cells(BF + i, 3).Value & "</p>" & vbCrLf

							End If

						End If

					Else

						xlotno += "<p style=""font-family: 맑은 고딕; font-size:  14px;"">" & xworksheet.Cells(BF + i, 3).Value & "</p>" & vbCrLf

					End If

				End If

				i += 1

			End While

		Catch ex As Exception

			MsgBox(ex.StackTrace)
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
			smtpServer.Port = SmtpPort
			smtpServer.Host = SmtpHost
			smtpServer.EnableSsl = SmtpSSL

			mail = New MailMessage()
			mail.From = New MailAddress(TextBoxID.Text)

		Catch ex As Exception

			MsgBox(ex.Message)
			WorkDeny = True

			xworkbook.Close()
			xls.Quit()

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

			Exit Sub

		End Try

		BackgroundWorker1.ReportProgress(6)

		Try

			mail.Subject = TextBoxDate.Text & " " & WeekdayName(Weekday(TextBoxDate.Text)) & " 일일업무 보고입니다."
			mail.IsBodyHtml = True
			mail.Body = "<p style=""font-family: 맑은 고딕; font-size:  14px;"">안녕하십니까.</p><br />" &
							"<p style=""font-family: 맑은 고딕; font-size:  14px;"">" & workerPart & " " & workerName & "입니다.</p><br /><br />" &
							"<p style=""font-family: 맑은 고딕; font-size:  14px;"">" & TextBoxDate.Text & " " & WeekdayName(Weekday(TextBoxDate.Text)) & " 일일업무 보고입니다.</p><br />" &
							xlotno & "<br />" &
							"<p style=""font-family: 맑은 고딕; font-size:  14px;"">" & TextBoxTxt.Text & "</p><br /><br />" &
							"<p style=""font-family: 맑은 고딕; font-size:  14px;"">이상입니다.</p><br /><br /><br />" &
							"<p style=""font-family: 맑은 고딕; font-size:  14px;"">" & workerName & " 드림</p>"

		Catch ex As Exception

			MsgBox(ex.Message)
			WorkDeny = True

			xworkbook.Close()
			xls.Quit()

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

			Exit Sub

		End Try

		BackgroundWorker1.ReportProgress(9)

		Try

			xworkbook.Close()
			xls.Quit()

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

		If String.IsNullOrEmpty(AutoPwd) Then

			TextBoxPW.Text = ""

		Else

			TextBoxPW.Text = encrypt.DecryptData(AutoPwd)

		End If

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

	Private Sub ConfigMake()

		Dim xml As New Text.StringBuilder
		xml.Append("<?xml version=""1.0"" encoding=""UTF-8""?>" + vbCr)
		xml.Append("<data>" + vbCr)
		xml.Append("	<mail>" + vbCr)
		xml.Append("		<host>gwm.bizmeka.com</host>" + vbCr)
		xml.Append("		<port>587</port>" + vbCr)
		xml.Append("		<ssl>False</ssl>" + vbCr)
		xml.Append("	</mail>" + vbCr)
		xml.Append("	<autoset>" + vbCr)
		xml.Append("		<send>" + vbCr)
		xml.Append("			<!-- 수신자 최대 3명까지 지원 -->" + vbCr)
		xml.Append("			<name1>김인현</name1>" + vbCr)
		xml.Append("			<name2></name2>" + vbCr)
		xml.Append("			<name3></name3>" + vbCr)
		xml.Append("		</send>" + vbCr)
		xml.Append("		<cc>" + vbCr)
		xml.Append("			<!-- 참조 최대 3명까지 지원 -->" + vbCr)
		xml.Append("			<name1></name1>" + vbCr)
		xml.Append("			<name2></name2>" + vbCr)
		xml.Append("			<name3></name3>" + vbCr)
		xml.Append("		</cc>" + vbCr)
		xml.Append("		<attach>" + vbCr)
		xml.Append("			<path>\\30.30.30.150\Storage_Hub\999.NAS_PORTAL\사업본부_37번_백업\개인자료\박성진\사업본부 2020 일일업무보고서 박성진.xlsm</path>" + vbCr)
		xml.Append("			<simple>True</simple>" + vbCr)
		xml.Append("		</attach>" + vbCr)
		xml.Append("		<account>" + vbCr)
		xml.Append("			<id></id>" + vbCr)
		xml.Append("			<password></password>" + vbCr)
		xml.Append("		</account>" + vbCr)
		xml.Append("	</autoset>" + vbCr)
		xml.Append("	<list>" + vbCr)
		xml.Append("		<!-- 인원을 변경할 경우, 아래의 양식을 추가하고 요소에 맞는 값을 입력 -->" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<!-- 초기화를 위한 공백값 -->" + vbCr)
		xml.Append("			<name>" + vbCr)
		xml.Append("				<!-- 이름 -->" + vbCr)
		xml.Append("			</name>" + vbCr)
		xml.Append("			<email>" + vbCr)
		xml.Append("				<!-- 이메일 -->" + vbCr)
		xml.Append("			</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>김인현</name>" + vbCr)
		xml.Append("			<email>ihkim@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>김영미</name>" + vbCr)
		xml.Append("			<email>ymkim@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>한동훈</name>" + vbCr)
		xml.Append("			<email>dhhan@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>신규선</name>" + vbCr)
		xml.Append("			<email>gsshin@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>전홍규</name>" + vbCr)
		xml.Append("			<email>hkjeon82@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>박성진</name>" + vbCr)
		xml.Append("			<email>psj1789@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>김호영</name>" + vbCr)
		xml.Append("			<email>khy7206@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>KSIC 전체</name>" + vbCr)
		xml.Append("			<email>all@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>연구소</name>" + vbCr)
		xml.Append("			<email>lab@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>사업본부</name>" + vbCr)
		xml.Append("			<email>business@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>경영</name>" + vbCr)
		xml.Append("			<email>mts@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>영업</name>" + vbCr)
		xml.Append("			<email>sales@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("		<address>" + vbCr)
		xml.Append("			<name>기술지원</name>" + vbCr)
		xml.Append("			<email>techsupport@ksic.net</email>" + vbCr)
		xml.Append("		</address>" + vbCr)
		xml.Append("	</list>" + vbCr)
		xml.Append("</data>")

		Dim file As IO.StreamWriter
		file = My.Computer.FileSystem.OpenTextFileWriter(Config, True)
		file.WriteLine(xml)
		file.Close()

	End Sub

	Private Sub Send_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPW.KeyDown, TextBoxID.KeyDown

		' 엔터키를 누를 경우
		If e.KeyCode = Keys.Return Then

			ButtonSend_Click(sender, New EventArgs())

		End If

	End Sub

	Private Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click

		Process.Start("https://github.com/RWB0104/EasyReport/raw/master/Documents/%EC%9D%BC%EC%9D%BC%EC%97%85%EB%AC%B4%EB%B3%B4%EA%B3%A0%EC%84%9C.xlsm")

	End Sub

	Private Sub LabelDev_Click(sender As Object, e As EventArgs) Handles LabelDev.Click

		Process.Start("https://github.com/RWB0104/EasyReport")

	End Sub

End Class