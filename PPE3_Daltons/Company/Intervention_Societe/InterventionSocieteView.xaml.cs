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

namespace PPE3_Daltons.Company.Intervention_Societe
{
    /// <summary>
    /// Logique d'interaction pour InterventionSocieteView.xaml
    /// </summary>
    public partial class InterventionSocieteView : UserControl
    {
        public InterventionSocieteView()
        {
            InitializeComponent();
        }

        public InterventionSocieteView(InterventionSocieteViewModel model)
            : this()
        {
            this.DataContext = model;
        }
    }
}
