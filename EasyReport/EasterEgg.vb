Public Class EasterEgg

	' ?????
	Private Sub LabelWhoop_Click(sender As Object, e As EventArgs) Handles LabelWhoop.Click

		' 첫 번째
		If Main.JooEun = True Then

			Process.Start("https://www.google.co.kr/search?q=%EC%9D%B4%EC%A3%BC%EC%9D%80&newwindow=1&source=lnms&tbm=isch&sa=X&ved=0ahUKEwixjN7Uw5DiAhXnDaYKHUwxBFcQ_AUIDigB&biw=1920&bih=937", vbNormalFocus)
			Main.JooEun = False

			' 두 번째
		Else

			Process.Start("https://user-images.githubusercontent.com/50317129/90104659-9e9e9700-dd7f-11ea-8f81-654c67464b7c.png", vbNormalFocus)

		End If

	End Sub

	' 종료 버튼
	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click

		Close()

	End Sub

End Class