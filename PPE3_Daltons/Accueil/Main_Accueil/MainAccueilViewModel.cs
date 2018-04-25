using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPE3_Daltons.Company.Main_Societe;
using PPE3_Daltons.Employees.Main_technicien;
using PPE3_Daltons.Accueil;
using PPE3_Daltons.Accueil.Main_Accueil;
using System.Windows.Input;
using PPE3_Daltons.Helper_Classes;
using Prism.Commands;

namespace PPE3_Daltons.Accueil.Main_Accueil
{
    public class MainAccueilViewModel : ObservableObject, IPageViewModel
    {

        private MainTechnicienViewModel mainTechnicienViewModel;

        private MainSocieteViewModel mainSocieteViewModel;

        private bool isMainSocieteSelected = false;

        private bool isMainTechnicienSelected = false;


        public MainAccueilViewModel()
        {
            this.ChoixMenuCommand = new DelegateCommand<string>(this.ChoixMenuExecuteMethod, this.ChoixMenuCanExecuteMethod);

        }

        public string Name
        {
            get { return "Main Accueil"; }
        }

        /// <summary>
        /// La commande pour choisir le bon menu.
        /// </summary>
        public DelegateCommand<string> ChoixMenuCommand { get; private set; }

        public bool IsMainSocieteSelected
        {
            get
            {
                return this.isMainSocieteSelected;
            }

            set
            {
                if (this.isMainSocieteSelected == value)
                {
                    return;
                }

                this.isMainSocieteSelected = value;
            }
        }

        public bool IsMainTechnicienSelected
        {
            get
            {
                return this.isMainTechnicienSelected;
            }

            set
            {
                if (this.isMainTechnicienSelected == value)
                {
                    return;
                }

                this.isMainTechnicienSelected = value;
            }
        }

        public MainTechnicienViewModel MainTechnicienViewModel
        {
            get
            {
                return this.mainTechnicienViewModel;
            }

            set
            {
                if (this.mainTechnicienViewModel == value)
                {
                    return;
                }
                this.mainTechnicienViewModel = value;
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

        /// <summary>
        /// Méthode exécuter pour le choix du menu.
        /// </summary>
        /// <param name="name">Un nom de menu : name.</param>
        private void ChoixMenuExecuteMethod(string name)
        {
            // On vérifie qu'un paramètre a été envoyé
            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            // On met les menus "non séléctionné".
            this.DeselectLink();

            // On affiche le bon Grid.
            switch (name)
            {
                case "hlbInfo":
                    this.IsMainSocieteSelected = true;
                    break;
                case "hlbEmprunteur":
                    this.IsMainTechnicienSelected = true;
                    break;
                default:
                    return;
            }
        }

        ///// <summary>
        ///// Indique s'il est possible d'exécuter la méthode pour choix menu ou non.
        ///// </summary>
        ///// <param name="name">Le nom du lien hypertext.</param>
        ///// <returns>Vrai si l'exécution est possible.</returns>
        private bool ChoixMenuCanExecuteMethod(string name)
        {
            return true;
        }

        ///// <summary>
        ///// Deselectionne tous les menus.
        ///// </summary>
        private void DeselectLink()
        {
            this.IsMainSocieteSelected = false;
            this.IsMainTechnicienSelected = false;
        }
    }
}
