﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Input;
using Medical_tp.Model;
using Medical_tp.DataAccess;

namespace Medical_tp.ViewModel
{
    class GestPatientsViewModel : DockPanelViewModel
    {
        #region variables
        private Model.Patient _selectedPatient;
        private DataAccess.Patients patients;
        private ObservableCollection<Model.Patient> _listPatient = null;
        private string _searchPattern;

        private string _displayBtns;
        private string _readOnlyFields;
        #endregion

        private ICommand _addCommand;
        private ICommand _modifyCommand;
        private ICommand _deleteCommand;
        private ICommand _observeCommand;


        #region getter / setter

        /// <summary>
        /// command pour ajouter une personne
        /// </summary>
        public ICommand AddCommand
        {
            get { return _addCommand; }
            set { _addCommand = value; }
        }
        public ICommand ObserveCommand
        {
            get { return _observeCommand; }
            set { _observeCommand = value; }
        }

        public ICommand ModifyCommand
        {
            get { return _modifyCommand; }
            set { _modifyCommand = value; }
        }

        public ICommand DeleteCommand
        {
            get { return _deleteCommand; }
            set { _deleteCommand = value; }
        }

        public string DisplayBtns
        {
            get { return _displayBtns; }

            set
            {
                if (_displayBtns != value)
                {
                    _displayBtns = value;
                    OnPropertyChanged("DisplayBtns");
                }
            }
        }

        public string ReadOnlyFields
        {
            get { return _readOnlyFields; }

            set
            {
                if (_readOnlyFields != value)
                {
                    _readOnlyFields = value;
                    OnPropertyChanged("ReadOnlyFields");
                }
            }
        }

        public string IsEnableDatePicker
        {
            get {
                if (_readOnlyFields.Equals("True"))
                    return "False";
                else
                    return "True";
            }
        }

        public string SearchPattern
        {
            get { return _searchPattern; }
            set
            {
                if (_searchPattern != value)
                {
                    _searchPattern = value;
                    //utilisation des propriétés de vue d'une collection 
                    //pour faire des filtres dessus
                    System.ComponentModel.ICollectionView myView = CollectionViewSource.GetDefaultView(ListPatient);
                    myView.Filter = (item) =>
                    {
                        if (item as Model.Patient == null)
                            return false;

                        Model.Patient personView = (Model.Patient)item;
                        if (personView.Firstname.ToLower().Contains(value.ToLower()) ||
                            personView.Name.ToLower().Contains(value.ToLower()))
                            return true;

                        return false;
                    };
                    //indique à l'interface de se rafraichir
                    OnPropertyChanged("SearchPattern");
                }
            }
        }

        /// <summary>
        /// contient la liste des utilisateurs
        /// </summary>
        public ObservableCollection<Model.Patient> ListPatient
        {
            get { return _listPatient; }
            set
            {
                if (_listPatient != value)
                {
                    _listPatient = value;
                    OnPropertyChanged("ListPatient");
                }
            }
        }

        /// <summary>
        /// personne sélectionnée dans la liste
        /// </summary>
        public Model.Patient SelectedPatient
        {
            get { return _selectedPatient; }
            set
            {
                if (_selectedPatient != value)
                {
                    _selectedPatient = value;
                    OnPropertyChanged("SelectedPatient");
                   
                }
            }
        }
        #endregion

        /// <summary>
        /// constructeur
        /// </summary>
        public GestPatientsViewModel()
        {
            DisplayName = "Display Patients";

            loadPatients();

             _displayBtns = Data.Session.Instance.VisibilityButtons();
            _readOnlyFields = Data.Session.Instance.ReadOnlyFields();

            //configuration de la commande
            AddCommand = new RelayCommand(param => AddPerson());
            ModifyCommand = new RelayCommand(param => ModifyPerson());
            DeleteCommand = new RelayCommand(param => DeletePerson());
            ObserveCommand = new RelayCommand(param => Observe());
            if (ListPatient.Count > 0)
            {
                SelectedPatient = ListPatient[0];
                OnPropertyChanged("SelectedPatient");
            }
        }

        private void loadPatients()
        {
            patients = new DataAccess.Patients();

            //transformation en Observable collection pour l'interface
            ListPatient = new ObservableCollection<Medical_tp.Model.Patient>(patients.getPatients());
        }

        public void Observe()
        {
            if (_selectedPatient == null)
                return;

            View.PrincipalWindow window = Medical_tp.Data.Session.Instance.GetPrincipalWindow();
            ViewModel.ObservationViewModel vm = new ObservationViewModel(_selectedPatient);
            window.DataContext = vm;
            window.Content = new Medical_tp.View.Observation();
        }

        /// <summary>
        /// action permettant d'ajouter une personne à la liste
        /// </summary>
        private void AddPerson()
        {
            try { 
                _listPatient.Add(patients.addNewPatient());
                loadPatients();
            }
            catch { }
        }

        private void ModifyPerson()
        {
            try
            {
                patients.updatePatient(SelectedPatient);
            }
            catch { }
                Patient p = SelectedPatient;
                loadPatients();
                p.Id = ListPatient[ListPatient.Count - 1].Id;
                foreach (var e in p.Observations)
                {
                    try
                    {
                        DataAccess.Observation.AddObservation(p, e);
                    }
                    catch {

                    }
                }
                loadPatients();  
        }

        public void DeletePerson()
        {
            try
            {
                patients.removePatient(SelectedPatient);

                _listPatient.Remove(SelectedPatient);
            }
            catch { }
        }
    }
}
