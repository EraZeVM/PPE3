using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPE3_Daltons.API_Daltons;
using PPE3_Daltons.Company.Compte_rendu_Societe;
using PPE3_Daltons.Company.Information_Societe;
using PPE3_Daltons.Company.Intervention_Societe;
using PPE3_Daltons.Company.Main_Societe;
using PPE3_Daltons.Employees.Compte_Rendu_Intervention;
using PPE3_Daltons.Employees.Intervention_technicien;
using PPE3_Daltons.Employees.Main_technicien;
using PPE3_Daltons.Assets;
using System.Windows.Input;
using PPE3_Daltons.Accueil.Main_Accueil;
using PPE3_Daltons.Accueil;
using PPE3_Daltons.Helper_Classes;
using Prism.Commands;

namespace PPE3_Daltons
{
    public class MainWindowsViewModel : ObservableObject
    {
        #region Fields

        private ICommand changePageCommand;

        private IPageViewModel currentPageViewModel;
        private List<IPageViewModel> pageViewModels;

        #endregion

        public MainWindowsViewModel()
        {

            // Add available pages
            PageViewModels.Add(new MainAccueilViewModel());
            PageViewModels.Add(new MainTechnicienViewModel());
            PageViewModels.Add(new MainSocieteViewModel());
            PageViewModels.Add(new CompteRenduSocieteViewModel());
            PageViewModels.Add(new InformationSocieteViewModel());
            PageViewModels.Add(new InterventionSocieteViewModel());
            PageViewModels.Add(new CompteRenduTechnicienViewModel());
            PageViewModels.Add(new InterventionTechnicienViewModel());

            // Set starting page
            CurrentPageViewModel = PageViewModels[0];
        }

        #region Properties / Commands

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

        #endregion

        #region Methods

        public IPageViewModel MainAccueil
        {
            get
            {
                return PageViewModels[0];
            }
        }

        public IPageViewModel MainTechnicien
        {
            get
            {
                return PageViewModels[1];
            }
        }
        
        public IPageViewModel MainSociete
        {
            get
            {
                return PageViewModels[2];
            }
        }

        public IPageViewModel CompteRenduSociete
        {
            get
            {
                return PageViewModels[3];
            }
        }

        public IPageViewModel InformationSociete
        {
            get
            {
                return PageViewModels[4];
            }
        }

        public IPageViewModel InterventionSociete
        {
            get
            {
                return PageViewModels[5];
            }
        }

        public IPageViewModel CompteRenduIntervention
        {
            get
            {
                return PageViewModels[6];
            }
        }

        public IPageViewModel InterventionTechnicien
        {
            get
            {
                return PageViewModels[7];
            }
        }

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        #endregion
    }
}
