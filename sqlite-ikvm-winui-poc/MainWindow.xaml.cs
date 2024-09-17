using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using com.asukiasyan.poc.service;
using System.Reflection;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace sqlite_ikvm_winui_poc
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("sqlite.jdbc"));
            ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.flywaydb.core"));
            ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.mybatis"));
            SQliteService sQliteService = new SQliteService();
            sQliteService.init();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
        }
    }
}
