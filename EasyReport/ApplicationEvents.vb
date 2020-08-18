﻿Imports System.Reflection

Namespace My
	' MyApplication에 대해 다음 이벤트를 사용할 수 있습니다.
	' Startup: 애플리케이션이 시작되고 시작 폼이 만들어지기 전에 발생합니다.
	' Shutdown: 모든 애플리케이션 폼이 닫힌 후에 발생합니다.  이 이벤트는 애플리케이션이 비정상적으로 종료되는 경우에는 발생하지 않습니다.
	' UnhandledException: 애플리케이션에서 처리되지 않은 예외가 발생하는 경우 이 이벤트가 발생합니다.
	' StartupNextInstance: 단일 인스턴스 애플리케이션을 시작할 때 해당 애플리케이션이 이미 활성 상태인 경우 발생합니다.
	' NetworkAvailabilityChanged: 네트워크가 연결되거나 연결이 끊어질 때 발생합니다.
	Partial Friend Class MyApplication
		Private Sub AppStart(ByVal sender As Object,
		  ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
			AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveAssemblies
		End Sub

		Private Function ResolveAssemblies(sender As Object, e As System.ResolveEventArgs) As Reflection.Assembly
			Dim desiredAssembly = New Reflection.AssemblyName(e.Name)

			If desiredAssembly.Name = "MetroFramework" Then

				Return Reflection.Assembly.Load(Resources.MetroFramework) 'replace with your assembly's resource name
			Else

				Return Nothing

			End If

		End Function

	End Class

End Namespace
