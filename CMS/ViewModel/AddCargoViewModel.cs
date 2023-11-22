using CMS.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MahApps.Metro.Controls;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CMS.ViewModel
{
    public class AddCargoViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

        public Cargo Cargo {
            get { return cargo; }
            set
            {
                cargo = value;
                RaisePropertyChanged();
            }
        }
        private Cargo cargo = new Cargo();
        private UnitType unitType = new UnitType();
        public UnitType UnitType
        {
            get { return unitType = new UnitType(); }
            set { unitType = value; RaisePropertyChanged(); }
        }


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


        public AddCargoViewModel()
        {
            CargoTypes = new ObservableCollection<CargoType>(new CargoTypeProvider().Select());
            UnitTypes = new ObservableCollection<UnitType>(new UnitTypeProvider().Select());
        }

        public RelayCommand<MetroWindow> InsertCargoCommand { 
            get 
            {
                return new RelayCommand<MetroWindow>(arg =>
                {
                    if (string.IsNullOrEmpty(Cargo.Name)) return;
                    if (string.IsNullOrEmpty(Cargo.UnitName)) return;
                    if (string.IsNullOrEmpty(Cargo.Price.ToString())) return;
                    if (string.IsNullOrEmpty(Cargo.TypeName)) return;
                    
                    var CargoTypeModel = new CargoTypeProvider().Select().FirstOrDefault(t => t.Name == Cargo.TypeName);
                    if (CargoTypeModel == null) return;
                    else Cargo.TypeId = CargoTypeModel.Id;

                    var UnitTypeModel = new UnitTypeProvider().Select().FirstOrDefault(t => t.Name == Cargo.UnitName);
                    if(UnitTypeModel == null) return;
                    else Cargo.UnitId = UnitTypeModel.Id;

                    Cargo.InsertDate = DateTime.Now;
                    Cargo.MemberId = AppData.CurrentUser.Id;
                    Cargo.MemberName = AppData.CurrentUser.Name;

                    var count = new CargoProvider().Insert(Cargo);
                    if (count == 0) MessageBox.Show("添加失败");
                    else arg.Close();

                    Cargo = new Cargo();

                });
            } 
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
		public RelayCommand<MetroWindow> CloseCommand
        {
            get
            {
                return new RelayCommand<MetroWindow>((arg) =>
                {
                    if(arg is MetroWindow window)
                    {
                        window.Close();
                    }
                });
            }
        }


    }
}
