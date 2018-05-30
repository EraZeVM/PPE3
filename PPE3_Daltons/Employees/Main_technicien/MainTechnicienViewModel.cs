using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPE3_Daltons.Employees.Compte_Rendu_Intervention;
using PPE3_Daltons.Employees.Intervention_technicien;
using PPE3_Daltons.Helper_Classes;
using PPE3_Daltons.API_Daltons;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows.Data;

namespace PPE3_Daltons.Employees.Main_technicien
{
    public class MainTechnicienViewModel : ObservableObject, IPageViewModel
    {
        private CompteRenduTechnicienViewModel compteRenduTechnicienViewModel;

        private InterventionTechnicienViewModel interventionTechnicienViewModel;

        private IList<Technicien> technicien;

        private ObservableCollection<Materiel> dataMateriel;        
        
        private ObservableCollection<Technicien> dataTechnicien;

        private API_Daltons.Technicien currentTechnicien;

        private Technicien selectedItem;

        public ICommand addTechnicien;

        private ICommand deleteTechnicien;

        private ICommand updateTechnicien;

        ICollectionView myDataView;

        private string nom;

        private string prenom;

        private string tel;

        private string modele;

        private string num_serie;

        private int id_Materiel;

        private int id_technicien;

        public MainTechnicienViewModel()
        {
            CurrentTechnicien = new Technicien();

        }

        public IList<Technicien> DataTechnicien
        {
            get
            {

                dataTechnicien = new ObservableCollection<Technicien>(SearchTechnicienBase());
                myDataView = CollectionViewSource.GetDefaultView(dataTechnicien);

                myDataView.CurrentChanged += delegate
                {
                    //stores the current selected person
                    SelectedItem = (Technicien)myDataView.CurrentItem;
                };
                
                return dataTechnicien;
            }
        }

        public IList<Materiel> DataMateriel
        {
            get
            {

                dataMateriel = new ObservableCollection<Materiel>(SearchMaterielBase());

                return dataMateriel;

            }
        }

        private IList<Technicien> SearchTechnicienBase()
        {

            Technicien techniciens = new Technicien();
            techniciens.nom = "";
            techniciens.prenom = "";
            techniciens.tel = "";

            IList<Technicien> ListTechnicien = null;
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                {
                    ListTechnicien = api.SearchTechnicien();
                }
            }
            return ListTechnicien;

        }

        private IList<Materiel> SearchMaterielBase()
        {

            Materiel matos = new Materiel();
            matos.modele = "";
            matos.num_serie = "";

            IList<Materiel> ListeMatos = null;
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                {
                    ListeMatos = api.SearchMateriel();
                }
            }
            return ListeMatos;

        }

        private void AddTechnicienBase()
        {
            Technicien Techniciens = new Technicien();

            int id_Technicien = 0;
            Techniciens.nom = nom;
            Techniciens.prenom = prenom;
            Techniciens.tel = tel;
            Techniciens.id_materiel = id_Materiel;

            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                id_Technicien = api.AddTechnicien(Techniciens);
            }
            if (id_Technicien > 0)
            {
                nom = "";
                prenom = "";
                tel = "";
              //  id_materiel;


                RaisePropertyChanged("Nom");
                RaisePropertyChanged("Prenom");
                RaisePropertyChanged("Tel");
                RaisePropertyChanged("Id_materiel");
                
            }
            RaisePropertyChanged("DataTechnicien");
        }

        private void DeleteTechnicienBase()
        {
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                api.DeleteTechnicien(SelectedItem);
                RaisePropertyChanged("DataTechnicien");
            }

        }

        private void UpdateTechnicienBase()
        {
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                api.UPDTechnicien(SelectedItem);
                RaisePropertyChanged("DataTechnicien");
            }
        }



        public IList<Technicien> Technicien
        {
            get
            {
                technicien = SearchTechnicienBase();
                return this.technicien;
            }

            set
            {
                if (this.technicien == value)
                {
                    return;
                }
                this.technicien = value;
            }
        }

        public API_Daltons.Technicien CurrentTechnicien
        {
            get
            {
                return this.currentTechnicien;
            }

            set
            {
                if (this.currentTechnicien == value)
                {
                    return;
                }
                this.currentTechnicien = value;
            }
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
                OnPropertyChanged("SelectedItem");
            }
        }

        public string Name
        {
            get { return "Main Technicien"; }
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

        public string Modele
        {
            get
            {
                return this.modele;
            }

            set
            {
                if (this.modele == value)
                {
                    return;
                }
                this.modele = value;
            }
        }

        public string Num_Serie
        {
            get
            {
                return this.num_serie;
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

        public int Id_Materiel
        {
            get
            {
                return this.id_Materiel;
            }

            set
            {
                if (this.id_Materiel == value)
                {
                    return;
                }
                this.id_Materiel = value;
            }
        }

        public int Id_Technicien
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

        public CompteRenduTechnicienViewModel CompteRenduTechnicienViewModel
        {
            get
            {
                return this.compteRenduTechnicienViewModel;
            }

            set
            {
                if (this.compteRenduTechnicienViewModel == value)
                {
                    return;
                }
                this.compteRenduTechnicienViewModel = value;
            }
        }

        public InterventionTechnicienViewModel InterventionTechnicienViewModel
        {
            get
            {
                return this.interventionTechnicienViewModel;
            }

            set
            {
                if (this.interventionTechnicienViewModel == value)
                {
                    return;
                }
                this.interventionTechnicienViewModel = value;
            }
        }
        public ICommand DeleteTechnicien
        {
            get
            {
                if (deleteTechnicien == null)
                {
                    deleteTechnicien = new RelayCommand(
                        p => DeleteTechnicienBase());
                }

                return deleteTechnicien;
            }
        }
        public ICommand UpdateTechnicien
        {
            get
            {
                if (updateTechnicien == null)
                {
                    updateTechnicien = new RelayCommand(
                        p => UpdateTechnicienBase());
                }

                return updateTechnicien;
            }
        }

        public ICommand AddTechnicien
        {
            get
            {
                if (addTechnicien == null)
                {
                    addTechnicien = new RelayCommand(
                        p => AddTechnicienBase());
                }

                return addTechnicien;
            }
        }
    }
}
