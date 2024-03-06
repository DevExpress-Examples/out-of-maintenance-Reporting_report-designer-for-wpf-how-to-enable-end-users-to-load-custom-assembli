using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.Xpf.DataAccess.DataSourceWizard;
using DevExpress.Xpf.Reports.UserDesigner.ReportWizard;
using System.Windows.Controls;

namespace EnableEFBrowseButton {
    /// <summary>
    /// Interaction logic for UseEFOptionsAndCustomization.xaml
    /// </summary>
    public partial class UseEFOptionsAndCustomization : UserControl {
        public UseEFOptionsAndCustomization() {
            InitializeComponent();
        }
    }

    public class WizardCustomizationService : IWizardCustomizationService {
        public void CustomizeDataSourceWizard(DataSourceWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) {
            var options = container.Resolve<EFWizardOptions>() | EFWizardOptions.ShowBrowseButton;
            container.RegisterInstance(options);
        }
        public void CustomizeReportWizard(ReportWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) {
            var options = container.Resolve<EFWizardOptions>() | EFWizardOptions.ShowBrowseButton;
            container.RegisterInstance(options);
        }
        bool IDataSourceWizardCustomizationService.TryCreateDataSource(IDataSourceModel model, out object dataSource, out string dataMember) {
            dataSource = null;
            dataMember = null;
            return false;
        }
        bool IWizardCustomizationService.TryCreateReport(DevExpress.XtraReports.Wizards.XtraReportModel model, out DevExpress.XtraReports.UI.XtraReport report) {
            report = null;
            return false;
        }
    }
}
