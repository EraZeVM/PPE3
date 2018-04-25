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

namespace PPE3_Daltons.Company.Compte_rendu_Societe
{
    /// <summary>
    /// Logique d'interaction pour CompteRenduSocieteView.xaml
    /// </summary>
    public partial class CompteRenduSocieteView : UserControl
    {
        public CompteRenduSocieteView()
        {
            InitializeComponent();
        }

        public CompteRenduSocieteView(CompteRenduSocieteViewModel model)
            : this()
        {
            this.DataContext = model;
        }
    }
}
