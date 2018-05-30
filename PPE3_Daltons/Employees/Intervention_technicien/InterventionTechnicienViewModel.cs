using PPE3_Daltons.Employees.Main_technicien;
using PPE3_Daltons.Helper_Classes;
using PPE3_Daltons.API_Daltons;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using System;

namespace PPE3_Daltons.Employees.Intervention_technicien
{
    public class InterventionTechnicienViewModel : ObservableObject, IPageViewModel
    {
        private IList<Intervention> intervention;

        private ObservableCollection<Intervention> dataIntervention;

        private Intervention selectedItem;

        ICollectionView myDataView;

        private int id_intervention;

        private int id_societe;

        private int id_technicien;

        private int id_motif;

        private int id_etat;

        private string libelle;

        private string nom_societe;

        private string adresse_societe;

        private string email_societe;

        private string ville_societe;

        private string cp_societe;

        private string tel_societe;

        private string nom;

        private string prenom;

        private string tel;

        private DateTime date_intervention;

        public InterventionTechnicienViewModel()
        {
            SelectedItem = new API_Daltons.Intervention();
        }

        public ObservableCollection<Intervention> DataIntervention
        {
            get
            {
                dataIntervention = new ObservableCollection<Intervention>(SearchInterventionBase());
                myDataView = CollectionViewSource.GetDefaultView(dataIntervention);

                myDataView.CurrentChanged += delegate
                {
                    //stores the current selected person
                    SelectedItem = (Intervention)myDataView.CurrentItem;
                };
                return dataIntervention;
            }
        }

        public string Name
        {
            get { return "Intervention Technicien"; }
        }

        public IList<Intervention> Intervention
        {
            get
            {
                intervention = SearchInterventionBase();
                return this.intervention;
            }

            set
            {
                if (this.intervention == value)
                {
                    return;
                }
                this.intervention = value;
            }
        }

        public Intervention SelectedItem
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
                OnPropertyChanged("SelectedItem");
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
            }
        }

        public int Id_Intervention
        {
            get
            {
                return this.id_intervention;
            }

            set
            {
                if (this.id_intervention == value)
                {
                    return;
                }
                this.id_intervention = value;
            }
        }

        public int Id_technicien
        {
            get
            {
                return this.id_technicien;
            }

            set
            {
                if (this.id_technicien == value)
                {
                    return;
                }
                this.id_technicien = value;
            }
        }

        public int Id_motif
        {
            get
            {
                return this.id_motif;
            }

            set
            {
                if (this.id_motif == value)
                {
                    return;
                }
                this.id_motif = value;
            }
        }

        public int Id_etat
        {
            get
            {
                return this.id_etat;
            }

            set
            {
                if (this.id_etat == value)
                {
                    return;
                }
                this.id_etat = value;
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

        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                if (this.nom == value)
                {
                    return;
                }
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }

            set
            {
                if (this.prenom == value)
                {
                    return;
                }
                this.prenom = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }

            set
            {
                if (this.tel == value)
                {
                    return;
                }
                this.tel = value;
            }
        }

        public string Libelle
        {
            get
            {
                return this.libelle;
            }

            set
            {
                if (this.libelle == value)
                {
                    return;
                }
                this.libelle = value;
                this.RaisePropertyChanged("Libelle");
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

        public DateTime Date_intervention
        {
            get
            {
                return this.date_intervention;
            }

            set
            {
                if (this.date_intervention == value)
                {
                    return;
                }
                this.date_intervention = value;
            }
        }

        private IList<Intervention> SearchInterventionBase()
        {

            Intervention item = new Intervention();
            item.Societe = new Societe();
            item.Motif_intervention = new Motif_intervention();
            item.Technicien = new Technicien();
            item.Societe.nom_societe = "";
            item.Societe.adresse_societe = "";
            item.Societe.email_societe = "";
            item.Societe.ville_societe = "";
            item.Societe.cp_societe = "";
            item.Societe.tel_societe = "";
            item.Motif_intervention.libelle = "";
            item.Technicien.nom = "";
            item.Technicien.prenom = "";

            IList<Intervention> ListIntervention = null;
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                {
                    ListIntervention = api.SearchIntervention();
                }
            }
            return ListIntervention;
        }
    }
}
