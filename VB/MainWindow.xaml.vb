Imports DevExpress.DataAccess.EntityFramework
Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace EnableEFBrowseButton
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            AddHandler EFDataSource.BeforeLoadCustomAssemblyGlobal, AddressOf OnBeforeCustomAssemblyLoad
        End Sub

        Private Sub OnBeforeCustomAssemblyLoad(ByVal sender As Object, ByVal args As BeforeLoadCustomAssemblyEventArgs)
            args.AllowLoading = True
        End Sub

        Private Sub UseCustomization(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CType(New DXTabbedWindow() With {.Content = New UseEFOptionsAndCustomization()}, DXTabbedWindow).ShowDialog()
        End Sub

        Private Sub UseDataSourceWizardSettings(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CType(New DXTabbedWindow() With {.Content = New UseDataSourceWizardSettings()}, DXTabbedWindow).ShowDialog()
        End Sub
    End Class
End Namespace
