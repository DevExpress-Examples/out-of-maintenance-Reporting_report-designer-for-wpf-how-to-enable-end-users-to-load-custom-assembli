Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.Xpf.DataAccess.DataSourceWizard
Imports DevExpress.Xpf.Reports.UserDesigner.ReportWizard
Imports System.Windows.Controls

Namespace EnableEFBrowseButton
    ''' <summary>
    ''' Interaction logic for UseEFOptionsAndCustomization.xaml
    ''' </summary>
    Partial Public Class UseEFOptionsAndCustomization
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class WizardCustomizationService
        Implements IWizardCustomizationService

        Public Sub CustomizeDataSourceWizard(ByVal customization As DataSourceWizardCustomizationModel, ByVal container As ViewModelSourceIntegrityContainer) Implements IWizardCustomizationService.CustomizeDataSourceWizard
            Dim options = container.Resolve(Of EFWizardOptions)() Or EFWizardOptions.ShowBrowseButton
            container.RegisterInstance(options)
        End Sub
        Public Sub CustomizeReportWizard(ByVal customization As ReportWizardCustomizationModel, ByVal container As ViewModelSourceIntegrityContainer) Implements IWizardCustomizationService.CustomizeReportWizard
            Dim options = container.Resolve(Of EFWizardOptions)() Or EFWizardOptions.ShowBrowseButton
            container.RegisterInstance(options)
        End Sub
        Private Function IDataSourceWizardCustomizationService_TryCreateDataSource(ByVal model As IDataSourceModel, ByRef dataSource As Object, ByRef dataMember As String) As Boolean Implements IDataSourceWizardCustomizationService.TryCreateDataSource
            dataSource = Nothing
            dataMember = Nothing
            Return False
        End Function
        Private Function IWizardCustomizationService_TryCreateReport(ByVal model As DevExpress.XtraReports.Wizards.XtraReportModel, ByRef report As DevExpress.XtraReports.UI.XtraReport) As Boolean Implements IWizardCustomizationService.TryCreateReport
            report = Nothing
            Return False
        End Function
    End Class
End Namespace
