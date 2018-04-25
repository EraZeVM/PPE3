using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using PPE3_Daltons.API_Daltons;
using PPE3_Daltons.Helper_Classes;
using PPE3_Daltons.Company.Main_Societe;

namespace PPE3_Daltons.Company.Intervention_Societe
{
    public class InterventionSocieteViewModel : ObservableObject, IPageViewModel
    {

        private MainSocieteViewModel mainSocieteViewModel;

        private IList<Intervention> intervention = null;

        private ObservableCollection<Intervention> data;

        private API_Daltons.Intervention currentIntervention;

        private Societe selectedItem;

        private int id_compte_rendu;

        private int id_technicien;

        private int id_societe;

        private int id_motif;

        private int id_etat;

        private DateTime date_intervention;

        public InterventionSocieteViewModel()
        {
            CurrentIntervention = new Intervention();
        }

        public string Name
        {
            get { return "Intervention Societe"; }
        }

        public Societe SelectedItem
        {
            get
            {
                return selectedItem;
            }

            private set
            {
                selectedItem = value;
                OnPropertyChanged("selectedItem");
            }
        }

        public IList<Intervention> Data
        {
            get
            {

                data = new ObservableCollection<Intervention>(SearchInterventionBase());
                return data;

            }
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

        public API_Daltons.Intervention CurrentIntervention
        {
            get
            {
                return this.currentIntervention;
            }

            set
            {
                if (this.currentIntervention == value)
                {
                    return;
                }
                this.currentIntervention = value;
            }
        }

        public MainSocieteViewModel MainSocieteViewModel
        {
            get
            {
                return this.mainSocieteViewModel;
            }

            set
            {
                if (this.mainSocieteViewModel == value)
                {
                    return;
                }
                this.mainSocieteViewModel = value;
            }
        }

        public int Id_compte_rendu
        {
            get
            {
                return this.id_compte_rendu;
            }

            set
            {
                if (this.id_compte_rendu == value)
                {
                    return;
                }
                this.id_compte_rendu = value;
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

            Intervention interventions = new Intervention();
            interventions.date_intervention = DateTime.Now;

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
