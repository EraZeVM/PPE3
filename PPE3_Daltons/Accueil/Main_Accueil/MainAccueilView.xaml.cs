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

namespace PPE3_Daltons.Accueil.Main_Accueil
{
    /// <summary>
    /// Logique d'interaction pour MainAccueilView.xaml
    /// </summary>
    public partial class MainAccueilView : UserControl
    {
        public MainAccueilView()
        {
            InitializeComponent();
        }

        public MainAccueilView(MainAccueilViewModel model)
        : this()
        {
            this.DataContext = model;
        }
    }
}
