using PPE3_Daltons.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE3_Daltons.Company.Information_Societe
{
    public class InformationSocieteViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get { return "Information Societe"; }
        }
    }
}
