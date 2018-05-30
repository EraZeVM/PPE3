using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using PPE3_Daltons.Login;
using System.Windows;

namespace PPE3_Daltons
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            /*
            MainWindow app = new MainWindow();
            MainWindowViewModel context = new MainWindowViewModel();
            app.DataContext = context;
            app.ShowDialog();
            */

            LoginView app = new LoginView();
            LoginViewModel context = new LoginViewModel();
            app.DataContext = context;
            app.ShowDialog();

        }
    }
}
