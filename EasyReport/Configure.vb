Imports System.IO
Imports System.Xml

Public Class Configure

	Private Sub Configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		TextBoxHost.Text = Main.SmtpHost
		TextBoxPort.Text = Main.SmtpPort

		If Main.SmtpSSL Then

			RadioButtonTrue.Checked = True

		Else

			RadioButtonFalse.Checked = True

		End If

		ComboBoxSend1.SelectedItem = Main.AutoSendList(0)
		ComboBoxSend2.SelectedItem = Main.AutoSendList(1)
		ComboBoxSend3.SelectedItem = Main.AutoSendList(2)

		ComboBoxCC1.SelectedItem = Main.AutoCCList(0)
		ComboBoxCC2.SelectedItem = Main.AutoCCList(1)
		ComboBoxCC3.SelectedItem = Main.AutoCCList(2)

		TextBoxID.Text = Main.AutoID
		
		If String.IsNullOrEmpty(Main.AutoPwd) Then

			TextBoxPwd.Text = ""

		Else

			TextBoxPwd.Text = Main.encrypt.DecryptData(Main.AutoPwd)

		End If

		TextBoxFile.Text = Main.AutoAttachStr

		If Main.AutoSimpler Then

			RadioSimpleTrue.Checked = True

		Else

			RadioSimpleFalse.Checked = True

		End If

	End Sub

	Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

		Close()

	End Sub

	Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

		Try

			Dim Conf As New XmlDocument()

			If File.Exists(Main.Config) Then

				Conf.Load(Main.Config)

				Dim nodeHost As XmlNode = Conf.SelectSingleNode("/descendant::data/mail/host[.='" + Main.SmtpHost + "']")
				Dim nodePort As XmlNode = Conf.SelectSingleNode("/descendant::data/mail/port[.='" + Main.SmtpPort.ToString + "']")
				Dim nodeSSL As XmlNode = Conf.SelectSingleNode("/descendant::data/mail/ssl[.='" + Main.SmtpSSL.ToString + "']")

				Dim nodeSend1 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/send/name1[.='" + Main.AutoSendList(0) + "']")
				Dim nodeSend2 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/send/name2[.='" + Main.AutoSendList(1) + "']")
				Dim nodeSend3 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/send/name3[.='" + Main.AutoSendList(2) + "']")

				Dim nodeCC1 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/cc/name1[.='" + Main.AutoCCList(0) + "']")
				Dim nodeCC2 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/cc/name2[.='" + Main.AutoCCList(1) + "']")
				Dim nodeCC3 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/cc/name3[.='" + Main.AutoCCList(2) + "']")

				Dim nodeFile As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/attach/path[.='" + Main.AutoAttachStr + "']")
				Dim nodeSimple As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/attach/simple[.='" + Main.AutoSimpler.ToString + "']")
				Dim nodeID As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/account/id[.='" + Main.AutoID + "']")
				Dim nodePwd As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/account/password[.='" + Main.AutoPwd + "']")

				nodeHost.InnerText = TextBoxHost.Text
				nodePort.InnerText = TextBoxPort.Text

				If RadioButtonTrue.Checked Then

					nodeSSL.InnerText = "True"

				Else

					nodeSSL.InnerText = "False"

				End If

				nodeSend1.InnerText = ComboBoxSend1.SelectedItem
				nodeSend2.InnerText = ComboBoxSend2.SelectedItem
				nodeSend3.InnerText = ComboBoxSend3.SelectedItem

				nodeCC1.InnerText = ComboBoxCC1.SelectedItem
				nodeCC2.InnerText = ComboBoxCC2.SelectedItem
				nodeCC3.InnerText = ComboBoxCC3.SelectedItem

				nodeID.InnerText = TextBoxID.Text

				If String.IsNullOrEmpty(TextBoxPwd.Text) Then

					nodePwd.InnerText = ""

				Else

					nodePwd.InnerText = Main.encrypt.EncryptData(TextBoxPwd.Text)

				End If

				nodeFile.InnerText = TextBoxFile.Text

				Conf.Save(Main.Config)

			Else

				MsgBox("설정파일이 존재하지 않습니다.")

			End If

			Main.SmtpHost = TextBoxHost.Text
			Main.SmtpPort = Integer.Parse(TextBoxPort.Text)

			If RadioButtonTrue.Checked Then

				Main.SmtpSSL = True

			Else

				Main.SmtpSSL = False

			End If

			Main.AutoSendList(0) = ComboBoxSend1.SelectedItem
			Main.AutoSendList(1) = ComboBoxSend2.SelectedItem
			Main.AutoSendList(2) = ComboBoxSend3.SelectedItem

			Main.AutoCCList(0) = ComboBoxCC1.SelectedItem
			Main.AutoCCList(1) = ComboBoxCC2.SelectedItem
			Main.AutoCCList(2) = ComboBoxCC3.SelectedItem

			If RadioSimpleTrue.Checked Then

				Main.AutoSimpler = True

			Else

				Main.AutoSimpler = False

			End If

			Main.AutoID = TextBoxID.Text

			If String.IsNullOrEmpty(TextBoxPwd.Text) Then

				Main.AutoPwd = ""

			Else

				Main.AutoPwd = Main.encrypt.EncryptData(TextBoxPwd.Text)

			End If

			Main.AutoAttachStr = TextBoxFile.Text

			MsgBox("적용 완료")

			Close()

		Catch ex As Exception

			MsgBox("오류 발생 : " + ex.StackTrace)

		End Try


	End Sub

	Private Sub ButtonPath_Click(sender As Object, e As EventArgs) Handles ButtonPath.Click

		OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"

		If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then

			TextBoxFile.Text = OpenFileDialog1.FileName

		End If

	End Sub

	Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPort.KeyPress

		If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then

			e.Handled = True

		End If

	End Sub

End Class