using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MahApps.Metro.Controls;
using CMS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Windows;
using Models;
using CMS.Views;
using System.Windows;
using CMS.Models;

namespace CMS.ViewModel
{
    public class CargoViewModel : ViewModelBase
    {
        #region Property
        public AppData AppData { get; set; } = AppData.Instance;
        public ObservableCollection<Cargo> Cargos 
        { 
            get {  return cargos; } 
            set { cargos = value; RaisePropertyChanged(); } 
        }   
        private ObservableCollection<Cargo> cargos = new ObservableCollection<Cargo>();

        private ObservableCollection<CargoType> cargoTypes;
        public ObservableCollection<CargoType> CargoTypes
        {
            get { return cargoTypes; }
            set { cargoTypes = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<UnitType> unitTypes;
        public ObservableCollection<UnitType> UnitTypes
        {
            get { return unitTypes; }
            set { unitTypes = value; RaisePropertyChanged(); }
        }



        public CargoViewModel() 
        {
            Cargos = new ObservableCollection<Cargo>(new CargoProvider().Select());
            UnitTypes = new ObservableCollection<UnitType>( new UnitTypeProvider().Select());
            CargoTypes = new ObservableCollection<CargoType>( new CargoTypeProvider().Select());

        }
        #endregion

        public RelayCommand OpenAddCargoWindow
        {
            get
            {
                return new RelayCommand( () =>
                {
                    AddCargoWindow addCargoWindow  = new AddCargoWindow();
                    addCargoWindow.ShowDialog();
                    

                    cargos = new ObservableCollection<Cargo>(new CargoProvider().Select());
                    AppData.Instance.MainWindow.PART_Container.Content = new CargoView();

                });
            }
        }
        public RelayCommand<Cargo> DeleteCargoCommand
        { 
            get
            {
                return new RelayCommand<Cargo>(arg =>
                {
                    if (MessageBox.Show("确认删除该项?", "确认", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                    {
                        if (arg == null) return;
                        if (!(arg is Cargo model)) return;

                        var count = new CargoProvider().Delete(model);
                        if (count == 0) return;
                        else MessageBox.Show("操作成功");

                        cargos = new ObservableCollection<Cargo>(new CargoProvider().Select());
                        AppData.Instance.MainWindow.PART_Container.Content = new CargoView();
                    }

                });
            } 
        }
        public RelayCommand<Cargo> EditCargoCommand
        { 
            get
            {
                return new RelayCommand<Cargo>(arg =>
                {
                    if (arg == null) return;
                    if (!(arg is Cargo cargoModel)) return;

                    var count = new CargoProvider().Update(cargoModel);
                    if (count != 0) MessageBox.Show("操作成功");
                    else
                    {
                        MessageBox.Show("操作失败");
                        return;
                    }

                    cargos = new ObservableCollection<Cargo>(new CargoProvider().Select());
                    AppData.Instance.MainWindow.PART_Container.Content = new CargoView();

                });
            } 
        }
        public RelayCommand<Cargo> OpenInputCargoWindowCommand
        {
            get
            {
                return new RelayCommand<Cargo>(cargo => 
                {
                    new ViewModelLocator().InputOrOutputCargo.Cargo = cargo;
                    InputCargoWindow inputCargoWindow = new InputCargoWindow();
                    inputCargoWindow.ShowDialog();

                    Cargos = new ObservableCollection<Cargo>(new CargoProvider().Select());
                    new ViewModelLocator().Record.Records = new ObservableCollection<Record>(new RecordProvider().Select());
                    AppData.MainWindow.PART_Container.Content = new CargoView();

                });
            }
        }
        public RelayCommand<Cargo> OpenOutputCargoWindowCommand
        {
            get
            {
                return new RelayCommand<Cargo>(cargo => 
                {
                    new ViewModelLocator().InputOrOutputCargo.Cargo = cargo;
                    OutputCargoWindow outputCargoWindow = new OutputCargoWindow();
                    outputCargoWindow.ShowDialog();

                    Cargos = new ObservableCollection<Cargo>(new CargoProvider().Select());
                    new ViewModelLocator().Record.Records = new ObservableCollection<Record>(new RecordProvider().Select());
                    AppData.MainWindow.PART_Container.Content = new CargoView();
                    
                });
            }
        }


    }

    

}
