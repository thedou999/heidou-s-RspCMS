using CMS.Models;
using CMS.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Views;
using System.Windows;

namespace CMS.ViewModel
{
    public class UnitTypeViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

        public ObservableCollection<UnitType> UnitTypes 
        {
            get { return unitTypes; }
            set
            {
                unitTypes = value;
                RaisePropertyChanged();
            }
        }
        private ObservableCollection<UnitType> unitTypes;
        public UnitTypeViewModel()
        {
            unitTypes = new ObservableCollection<UnitType>(new UnitTypeProvider().Select()); 
        }


        public RelayCommand OpenAddUnitTypeWindow
        {
            get
            {
                return new RelayCommand(() =>
                {
                    AddUnitTypeWindow addUnitTypeWindow = new AddUnitTypeWindow();
                    addUnitTypeWindow.ShowDialog();

                    UnitTypes = new ObservableCollection<UnitType>(new UnitTypeProvider().Select());
                    AppData.MainWindow.PART_Container.Content = new UnitTypeView();
                });
            }
        }
        public RelayCommand<UnitType> DeleteUnitTypesCommand
        {
            get
            {
                return new RelayCommand<UnitType>(item =>
                {
                    if (item == null) return;
                    if (!(item is UnitType unit)) return;
                    if (!(string.IsNullOrWhiteSpace(unit.Name) || !(string.IsNullOrEmpty(unit.MemberName)))) return;
                    if (unit.InsertDate == null) return;

                    var count = new UnitTypeProvider().Delete(unit);
                    if (count == 0) MessageBox.Show("删除失败");
                    else
                    {
                        UnitTypes = new ObservableCollection<UnitType>(new UnitTypeProvider().Select());
                        AppData.MainWindow.PART_Container.Content = new UnitTypeView();
                    }

                });
            }
        }


    }
}
