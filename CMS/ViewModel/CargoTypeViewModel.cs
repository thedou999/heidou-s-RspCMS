using CMS.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using CMS.Views;
using MahApps.Metro.Controls.Dialogs;

namespace CMS.ViewModel
{
    public class CargoTypeViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

        public ObservableCollection<CargoType> CargoTypes 
        { 
            get {  return cargoTypes; } 
            set { cargoTypes = value; RaisePropertyChanged(); } 
        }   
        private ObservableCollection<CargoType> cargoTypes = new ObservableCollection<CargoType>();
        
        public CargoTypeViewModel()
        {
            cargoTypes = new ObservableCollection<CargoType>(new CargoTypeProvider().Select());
        }

        public RelayCommand OpenAddCargoTypeWindow
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var window = new AddCargoTypeWindow();
                    window.ShowDialog();

                    CargoTypes = new ObservableCollection<CargoType>(new CargoTypeProvider().Select() );
                    AppData.MainWindow.PART_Container.Content = new CargoTypeView();
                     
                });
            }
        }

        public RelayCommand<Object> DeleteCargoTypesCommand 
        {
            get
            {
                return new RelayCommand<Object>( (item) =>
                {
                    if(item==null) return;
                    if (!(item is CargoType model)) return;

                    #region 校验是否绑定
                    var CargoTypeModel = new CargoProvider().Select().FirstOrDefault<Cargo>(t =>
                    {
                        return t.TypeName == model.Name;
                    });
                    if (CargoTypeModel != null)
                    {
                        MessageBox.Show("删除失败，已有已绑定的数据源");
                        return;
                    }
                    #endregion


                    var count = new CargoTypeProvider().Delete(model);
                    if (count > 0) MessageBox.Show("操作成功");                    

                    CargoTypes = new ObservableCollection<CargoType>(new CargoTypeProvider().Select() );
                    AppData.MainWindow.PART_Container.Content = new CargoTypeView();

                });
            }
        }


    }
}
