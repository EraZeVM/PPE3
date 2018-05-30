using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using PPE3_Daltons.Company.Compte_rendu_Societe;
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

        private Societe selectedSociete;

        private API_Daltons.Societe currentSociete;
         
        private string nom_societe;

        private string adresse_societe;

        private string email_societe;

        private string ville_societe;

        private string cp_societe;

        private string tel_societe;

        private int id_societe;

        public ICommand addSociete;
       
        private ICommand deleteSociete;

        private ICommand updateSociete;

        ICollectionView myDataView;

        public MainSocieteViewModel()
        {

            currentSociete = new API_Daltons.Societe();
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
                myDataView = CollectionViewSource.GetDefaultView(dataSociete);

                myDataView.CurrentChanged += delegate
                {
                    //stores the current selected person
                    SelectedSociete = (Societe)myDataView.CurrentItem;
                };
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
            societes.nom_societe = Nom_societe;
            societes.adresse_societe = Adresse_societe;
            societes.email_societe = Email_societe;
            societes.ville_societe = Ville_societe;
            societes.cp_societe = Cp_societe;
            societes.tel_societe = Tel_societe;

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

                RaisePropertyChanged("Nom_societe");
                RaisePropertyChanged("Adresse_societe");
                RaisePropertyChanged("Email_societe");
                RaisePropertyChanged("Ville_societe");
                RaisePropertyChanged("Cp_societe");
                RaisePropertyChanged("Tel_societe");
            }
            RaisePropertyChanged("DataSociete");
        }

        private void DeleteSocieteBase()
        {
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                api.DeleteSociete(SelectedSociete);
                RaisePropertyChanged("DataSociete");
            }

        }

        private void UpdateSocieteBase()
        {
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                api.UPDSociete(SelectedSociete);
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


        public Societe SelectedSociete
        {
            get
            {
                return this.selectedSociete;
            }

            set
            {
                if (this.selectedSociete == value)
                {
                    return;
                }
                this.selectedSociete = value;
                OnPropertyChanged("SelectedSociete");

            }
        }

        public int Id_societe
        {
            get
            {
                return this.id_societe;
            }

            set
            {
                if (this.id_societe == value)
                {
                    return;
                }
                this.id_societe = value;
                this.RaisePropertyChanged("Id_societe");
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
                this.RaisePropertyChanged("Nom_societe");
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
                this.RaisePropertyChanged("Email_societe");
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
                this.RaisePropertyChanged("Adresse_societe");
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
                this.RaisePropertyChanged("Ville_societe");
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
                this.RaisePropertyChanged("Cp_societe");
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
                this.RaisePropertyChanged("Tel_societe");
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
