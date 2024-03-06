using DevExpress.DataAccess.EntityFramework;
using DevExpress.Xpf.Core;
using System.Windows;

namespace EnableEFBrowseButton {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            EFDataSource.BeforeLoadCustomAssemblyGlobal += OnBeforeCustomAssemblyLoad;
        }

        void OnBeforeCustomAssemblyLoad(object sender, BeforeLoadCustomAssemblyEventArgs args) {
            args.AllowLoading = true;
        }

        void UseCustomization(object sender, RoutedEventArgs e) {
            new DXTabbedWindow() { Content = new UseEFOptionsAndCustomization() }.ShowDialog();
        }

        void UseDataSourceWizardSettings(object sender, RoutedEventArgs e) {
            new DXTabbedWindow() { Content = new UseDataSourceWizardSettings() }.ShowDialog();
        }
    }
}
