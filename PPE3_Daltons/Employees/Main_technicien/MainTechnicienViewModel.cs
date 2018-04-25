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

namespace PPE3_Daltons.Employees.Main_technicien
{
    public class MainTechnicienViewModel : ObservableObject, IPageViewModel
    {
        private CompteRenduTechnicienViewModel compteRenduTechnicienViewModel;

        private InterventionTechnicienViewModel interventionTechnicienViewModel;

        private IList<Technicien> technicien;

        private ObservableCollection<Technicien> dataTechnicien;

        private API_Daltons.Technicien currentTechnicien;

        private Technicien selectedItem;

        private ICommand changePageCommand;

        private IPageViewModel currentPageViewModel;

        private List<IPageViewModel> pageViewModels;

        private string nom;

        private string prenom;

        private string tel;

        private int id_Materiel;

        public MainTechnicienViewModel()
        {
            CurrentTechnicien = new Technicien();

            PageViewModels.Add(new CompteRenduTechnicienViewModel());
            PageViewModels.Add(new InterventionTechnicienViewModel());

            // Set starting page
            CurrentPageViewModel = PageViewModels[0];

        }

        public IList<Technicien> DataTechnicien
        {
            get
            {

                dataTechnicien = new ObservableCollection<Technicien>(SearchTechnicienBase());
                return dataTechnicien;

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

        public ICommand ChangePageCommand
        {
            get
            {
                if (changePageCommand == null)
                {
                    changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return changePageCommand;
            }
        }

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (pageViewModels == null)
                    pageViewModels = new List<IPageViewModel>();

                return pageViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return currentPageViewModel;
            }
            set
            {
                if (currentPageViewModel != value)
                {
                    currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }

        public IPageViewModel CompteRenduIntervention
        {
            get
            {
                return PageViewModels[0];
            }
        }

        public IPageViewModel InterventionTechnicien
        {
            get
            {
                return PageViewModels[1];
            }
        }

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }
    }
}
