Imports System.IO
Imports System.Xml

Public Class Configure

	Private Sub Configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		ComboBoxSend1.SelectedItem = Main.AutoSendList(0)
		ComboBoxSend2.SelectedItem = Main.AutoSendList(1)
		ComboBoxSend3.SelectedItem = Main.AutoSendList(2)

		ComboBoxCC1.SelectedItem = Main.AutoCCList(0)
		ComboBoxCC2.SelectedItem = Main.AutoCCList(1)
		ComboBoxCC3.SelectedItem = Main.AutoCCList(2)

		TextBoxID.Text = Main.AutoID
		TextBoxPwd.Text = Main.AutoPwd
		TextBoxFile.Text = Main.AutoAttachStr

	End Sub

	Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

		Close()

	End Sub

	Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

		Try

			Dim Conf As New XmlDocument()

			If File.Exists(Main.Config) Then

				Conf.Load(Main.Config)

				Dim nodeSend1 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/send/name1[.='" + Main.AutoSendList(0) + "']")
				Dim nodeSend2 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/send/name2[.='" + Main.AutoSendList(1) + "']")
				Dim nodeSend3 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/send/name3[.='" + Main.AutoSendList(2) + "']")

				Dim nodeCC1 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/cc/name1[.='" + Main.AutoCCList(0) + "']")
				Dim nodeCC2 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/cc/name2[.='" + Main.AutoCCList(1) + "']")
				Dim nodeCC3 As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/cc/name3[.='" + Main.AutoCCList(2) + "']")

				Dim nodeFile As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/attach/path[.='" + Main.AutoAttachStr + "']")
				Dim nodeID As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/account/id[.='" + Main.AutoID + "']")
				Dim nodePwd As XmlNode = Conf.SelectSingleNode("/descendant::data/autoset/account/password[.='" + Main.AutoPwd + "']")

				nodeSend1.InnerText = ComboBoxSend1.SelectedItem
				nodeSend2.InnerText = ComboBoxSend2.SelectedItem
				nodeSend3.InnerText = ComboBoxSend3.SelectedItem

				nodeCC1.InnerText = ComboBoxCC1.SelectedItem
				nodeCC2.InnerText = ComboBoxCC2.SelectedItem
				nodeCC3.InnerText = ComboBoxCC3.SelectedItem

				nodeID.InnerText = TextBoxID.Text
				nodePwd.InnerText = TextBoxPwd.Text
				nodeFile.InnerText = TextBoxFile.Text

				Conf.Save(Main.Config)

			Else

				MsgBox("설정파일이 존재하지 않습니다.")

			End If

			Main.AutoSendList(0) = ComboBoxSend1.SelectedItem
			Main.AutoSendList(1) = ComboBoxSend2.SelectedItem
			Main.AutoSendList(2) = ComboBoxSend3.SelectedItem

			Main.AutoCCList(0) = ComboBoxCC1.SelectedItem
			Main.AutoCCList(1) = ComboBoxCC2.SelectedItem
			Main.AutoCCList(2) = ComboBoxCC3.SelectedItem

			Main.AutoID = TextBoxID.Text
			Main.AutoPwd = TextBoxPwd.Text
			Main.AutoAttachStr = TextBoxFile.Text

			MsgBox("적용 완료")

			Close()

		Catch ex As Exception

			MsgBox("오류 발생\n" + ex.Message)

		End Try


	End Sub

	Private Sub ButtonPath_Click(sender As Object, e As EventArgs) Handles ButtonPath.Click

		OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"

		If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then

			TextBoxFile.Text = OpenFileDialog1.FileName

		End If

	End Sub

End Class