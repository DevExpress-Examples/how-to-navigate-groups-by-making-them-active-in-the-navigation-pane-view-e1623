Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.NavBar

Namespace ActiveGroupNavigation
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		#Region "#CodeBehind"
		Public Sub New()
			InitializeComponent()
			CheckButtonAvailability()
		End Sub

		Private Sub button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim activegroupIndex As Integer = navBarControl1.Groups.IndexOf(navBarControl1.ActiveGroup)
			If sender Is btnNext Then
				navBarControl1.ActiveGroup = navBarControl1.Groups(activegroupIndex + 1)
			End If
			If sender Is btnPrev Then
				navBarControl1.ActiveGroup = navBarControl1.Groups(activegroupIndex - 1)
			End If
		End Sub

		Private Sub CheckButtonAvailability()
			btnNext.IsEnabled = Not(navBarControl1.Groups.IndexOf(navBarControl1.ActiveGroup) = navBarControl1.Groups.Count - 1)
			btnPrev.IsEnabled = Not(navBarControl1.Groups.IndexOf(navBarControl1.ActiveGroup) = 0)
		End Sub

		Private Sub NavigationPaneView_ActiveGroupChanged(ByVal sender As Object, ByVal e As NavBarActiveGroupChangedEventArgs)
			CheckButtonAvailability()
		End Sub
		#End Region ' #CodeBehind
	End Class
End Namespace
