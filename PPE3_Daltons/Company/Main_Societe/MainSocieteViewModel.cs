using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using PPE3_Daltons.Company.Compte_rendu_Societe;
using PPE3_Daltons.Company.Information_Societe;
using PPE3_Daltons.Company.Intervention_Societe;
using PPE3_Daltons.API_Daltons;
using System.Windows.Data;
using System.ComponentModel;
using PPE3_Daltons.Helper_Classes;
using System.Windows.Input;

namespace PPE3_Daltons.Company.Main_Societe
{
    public class MainSocieteViewModel : ObservableObject, IPageViewModel
    {
        private IList<Societe> societe;

        private ObservableCollection<Societe> dataSociete;

        private Societe selectedItem;

        private API_Daltons.Societe currentSociete;
         
        private string nom_societe;

        private string adresse_societe;

        private string email_societe;

        private string ville_societe;

        private string cp_societe;

        private string tel_societe;

        public ICommand addSociete;
       
        private ICommand deleteSociete;

        private ICommand updateSociete;

        public MainSocieteViewModel()
        {

            CurrentSociete = new Societe();
        }

        public string Name
        {
            get { return "Main Societe"; }
        }

        public IList<Societe> DataSociete
        {
            get
            {

                dataSociete = new ObservableCollection<Societe>(SearchSocieteBase());
                return dataSociete;

            }
        }

        private IList<Societe> SearchSocieteBase()
        {

            Societe societes = new Societe();
            societes.nom_societe = "";
            societes.adresse_societe = "";
            societes.email_societe = "";
            societes.ville_societe = "";
            societes.cp_societe = "";
            societes.tel_societe = "";

            IList<Societe> ListSociete = null;
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                {
                    ListSociete = api.SearchSociete();
                }
            }
            return ListSociete;

        }

        private void AddSocieteBase()
        {
            Societe societes = new Societe();

            int id_societe = 0;
            societes.nom_societe = nom_societe;
            societes.adresse_societe = adresse_societe;
            societes.email_societe = email_societe;
            societes.ville_societe = ville_societe;
            societes.cp_societe = cp_societe;
            societes.tel_societe = tel_societe;

            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                id_societe = api.AddSociete(societes);
            }
            if (id_societe > 0)
            {
                nom_societe = "";
                adresse_societe = "";
                email_societe = "";
                ville_societe = "";
                cp_societe = "";
                tel_societe = "";

                RaisePropertyChanged("nom_societe");
                RaisePropertyChanged("adresse_societe");
                RaisePropertyChanged("email_societe");
                RaisePropertyChanged("ville_societe");
                RaisePropertyChanged("cp_societe");
                RaisePropertyChanged("tel_societe");
            }
            RaisePropertyChanged("DataSociete");
        }

        private void DeleteSocieteBase()
        {
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                api.DeleteSociete(SelectedItem);
                RaisePropertyChanged("DataSociete");
            }

        }
        private void UpdateSocieteBase()
        {
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                api.UPDSociete(SelectedItem);
                RaisePropertyChanged("DataSociete");
            }
        }

        public IList<Societe> Societe
        {
            get
            {
                societe = SearchSocieteBase();
                return this.societe;
            }

            set
            {
                if (this.societe == value)
                {
                    return;
                }
                this.societe = value;
            }
        }
        public Societe SelectedItem
        {
            get
            {
                return this.selectedItem;
            }

            set
            {
                if (this.selectedItem == value)
                {
                    return;
                }
                this.selectedItem = value;
            }
        }


        public API_Daltons.Societe CurrentSociete
        {
            get
            {
                return this.currentSociete;
            }

            set
            {
                if (this.currentSociete == value)
                {
                    return;
                }
                this.currentSociete = value;
            }
        }

        public string Nom_societe
        {
            get
            {
                return this.nom_societe;
            }

            set
            {
                if (this.nom_societe == value)
                {
                    return;
                }
                this.nom_societe = value;
            }
        }

        public string Email_societe
        {
            get
            {
                return this.email_societe;
            }

            set
            {
                if (this.email_societe == value)
                {
                    return;
                }
                this.email_societe = value;
            }
        }

        public string Adresse_societe
        {
            get
            {
                return this.adresse_societe;
            }

            set
            {
                if (this.adresse_societe == value)
                {
                    return;
                }
                this.adresse_societe = value;
            }
        }

        public string Ville_societe
        {
            get
            {
                return this.ville_societe;
            }

            set
            {
                if (this.ville_societe == value)
                {
                    return;
                }
                this.ville_societe = value;
            }
        }

        public string Cp_societe
        {
            get
            {
                return this.cp_societe;
            }

            set
            {
                if (this.cp_societe == value)
                {
                    return;
                }
                this.cp_societe = value;
            }
        }

        public string Tel_societe
        {
            get
            {
                return this.tel_societe;
            }

            set
            {
                if (this.tel_societe == value)
                {
                    return;
                }
                this.tel_societe = value;
            }
        }

        public ICommand DeleteSociete
        {
            get
            {
                if (deleteSociete == null)
                {
                    deleteSociete = new RelayCommand(
                        p => DeleteSocieteBase());
                }

                return deleteSociete;
            }
        }
        public ICommand UpdateSociete
        {
            get
            {
                if (updateSociete == null)
                {
                    updateSociete = new RelayCommand(
                        p => UpdateSocieteBase());
                }

                return updateSociete;
            }
        }

        public ICommand AddSociete
        {
            get
            {
                if (addSociete == null)
                {
                    addSociete = new RelayCommand(
                        p => AddSocieteBase());
                }

                return addSociete;
            }
        }
    }
}
