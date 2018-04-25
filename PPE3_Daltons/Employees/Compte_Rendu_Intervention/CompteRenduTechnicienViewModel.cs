using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPE3_Daltons.Assets;
using PPE3_Daltons.Helper_Classes;
using PPE3_Daltons.API_Daltons;
using PPE3_Daltons.Employees.Main_technicien;
using System.Collections.ObjectModel;

namespace PPE3_Daltons.Employees.Compte_Rendu_Intervention
{
    public class CompteRenduTechnicienViewModel : ObservableObject, IPageViewModel
    {
        private IList<Compte_rendu> compte_rendu = null;

        private ObservableCollection<Compte_rendu> data;

        private API_Daltons.Compte_rendu currentCompte_rendu;

        private MainTechnicienViewModel parentModel;

        private int id_compte_rendu;

        private int id_technicien;

        private int id_societe;

        private int id_intervention;

        private string note;

        private Technicien selectedItem;

        public CompteRenduTechnicienViewModel()
        {
            CurrentCompte_rendu = new Compte_rendu();
        }

        public string Name
        {
            get { return "Compte_rendu Technicien"; }
        }

        public Technicien SelectedItem
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

        public IList<Compte_rendu> Data
        {
            get
            {

                data = new ObservableCollection<Compte_rendu>(SearchCompte_RenduBase());
                return data;

            }
        }

        public IList<Compte_rendu> Compte_rendu
        {
            get
            {
                compte_rendu = SearchCompte_RenduBase();
                return this.compte_rendu;
            }

            set
            {
                if (this.compte_rendu == value)
                {
                    return;
                }
                this.compte_rendu = value;
            }
        }

        public API_Daltons.Compte_rendu CurrentCompte_rendu
        {
            get
            {
                return this.currentCompte_rendu;
            }

            set
            {
                if (this.currentCompte_rendu == value)
                {
                    return;
                }
                this.currentCompte_rendu = value;
            }
        }

        public MainTechnicienViewModel ParentModel
        {
            get
            {
                return this.parentModel;
            }

            set
            {
                if (this.parentModel == value)
                {
                    return;
                }
                this.parentModel = value;
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

        public int Id_intervention
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

        public string Note
        {
            get
            {
                return this.note;
            }

            set
            {
                if (this.note == value)
                {
                    return;
                }
                this.note = value;
            }
        }

        private IList<Compte_rendu> SearchCompte_RenduBase()
        {

            Compte_rendu compte_rendus = new Compte_rendu();
            compte_rendus.note = "";
            if (SelectedItem != null)
            {
                compte_rendus.id_technicien = ParentModel.SelectedItem.id_technicien;
            }
            IList<Compte_rendu> ListCompte_rendu = null;
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                {
                    ListCompte_rendu = api.SearchCompte_rendu();
                }
            }
            return ListCompte_rendu;

        }
    }
}
