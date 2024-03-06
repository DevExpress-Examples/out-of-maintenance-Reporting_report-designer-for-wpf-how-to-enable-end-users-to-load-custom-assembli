<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604500/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T503673)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [UseDataSourceWizardSettings.xaml](./CS/UseDataSourceWizardSettings.xaml) (VB: [UseDataSourceWizardSettings.xaml](./VB/UseDataSourceWizardSettings.xaml))
* [UseDataSourceWizardSettings.xaml.cs](./CS/UseDataSourceWizardSettings.xaml.cs) (VB: [UseDataSourceWizardSettings.xaml.vb](./VB/UseDataSourceWizardSettings.xaml.vb))
* [UseEFOptionsAndCustomization.xaml](./CS/UseEFOptionsAndCustomization.xaml) (VB: [UseEFOptionsAndCustomization.xaml](./VB/UseEFOptionsAndCustomization.xaml))
* [UseEFOptionsAndCustomization.xaml.cs](./CS/UseEFOptionsAndCustomization.xaml.cs) (VB: [UseEFOptionsAndCustomization.xaml.vb](./VB/UseEFOptionsAndCustomization.xaml.vb))
<!-- default file list end -->
# Report Designer for WPF - How to enable end-users to load custom assemblies to the Entity Framework context


In the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument114851">Entity Framework Data Source wizard</a>, it is possible to load custom assemblies by using the Browse button on the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument114856">Select the Data Context</a> page.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/report-designer-for-wpf-how-to-enable-end-users-to-load-custom-assemblies-to-the-entity-fr-t503673/17.1.3+/media/4b00efec-2108-11e7-80bf-00155d62480c.png"><br>In the End-User Designer, this button is hidden by default, so that end-users are allowed only to select the data context from assemblies referenced by the project.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/report-designer-for-wpf-how-to-enable-end-users-to-load-custom-assemblies-to-the-entity-fr-t503673/17.1.3+/media/5cb8b6d5-2108-11e7-80bf-00155d62480c.png"><br>This example illustrates how to enable this functionality in the End-User Report Designer for WPF.<br>To learn more, see <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument117318">Security Considerations</a>.

<br/>