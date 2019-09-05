Public Class EasterEgg

	' ?????
	Private Sub LabelWhoop_Click(sender As Object, e As EventArgs) Handles LabelWhoop.Click

		' 첫 번째
		If Main.JooEun = True Then

			Shell("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe https://www.google.co.kr/search?q=%EC%9D%B4%EC%A3%BC%EC%9D%80&newwindow=1&source=lnms&tbm=isch&sa=X&ved=0ahUKEwixjN7Uw5DiAhXnDaYKHUwxBFcQ_AUIDigB&biw=1920&bih=937", vbNormalFocus)
			Main.JooEun = False

			' 두 번째
		Else

			Shell("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe https://w.namu.la/s/cb0f2413f6da317be59fcdb95967cf7709f6c3eec611b6f4d04ff291711b75c9cf91e8fda1bfa90c1e0762e6d634820ec262c5c6dd7e70c420f5d266ee6362a5e2d86d460e7d3c90d8d962715f2c96ef235581702d09ef20f1924bc8c7371a9b", vbNormalFocus)

		End If

	End Sub

	' 종료 버튼
	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click

		Close()

	End Sub

End Class