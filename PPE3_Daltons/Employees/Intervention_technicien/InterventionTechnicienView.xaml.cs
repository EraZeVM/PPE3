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
using Telerik.Windows.Controls;

namespace PPE3_Daltons.Employees.Intervention_technicien
{
    /// <summary>
    /// Logique d'interaction pour InterventionTechnicienView.xaml
    /// </summary>
    public partial class InterventionTechnicienView : UserControl
    {
        public InterventionTechnicienView()
        {
            InitializeComponent();
        }

        public InterventionTechnicienView(InterventionTechnicienViewModel model)
           : this()
        {
            this.DataContext = model;
        }
    }
}
