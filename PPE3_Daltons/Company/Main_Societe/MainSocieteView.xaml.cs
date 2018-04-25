using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PPE3_Daltons.Company.Main_Societe
{
    /// <summary>
    /// Logique d'interaction pour MainSocieteView.xaml
    /// </summary>
    public partial class MainSocieteView : UserControl
    {
        public MainSocieteView()
        {
            InitializeComponent();
        }

        public MainSocieteView(MainSocieteViewModel model)
            : this()
        {
            this.DataContext = model;
        }
    }
}
