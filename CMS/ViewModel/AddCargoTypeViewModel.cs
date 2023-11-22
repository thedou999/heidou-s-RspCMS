using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MahApps.Metro.Controls;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CMS.ViewModel
{
    public class AddCargoTypeViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

		private CargoType cargoType = new CargoType();
		public CargoType CargoType
		{
			get { return cargoType; }
			set { cargoType = value; RaisePropertyChanged(); }
		}


        public RelayCommand<MetroWindow> InsertCargoTypeCommand { 
            get 
            {
                return new RelayCommand<MetroWindow>(arg =>
                {
                    if (string.IsNullOrEmpty(CargoType.Name)) return;
                    CargoType.InsertDate = DateTime.Now;
                    CargoType.MemberId = AppData.CurrentUser.Id;
                    CargoType.MemberName = AppData.CurrentUser.Name;

                    var count = new CargoTypeProvider().Insert(CargoType);
                    if (count == 0) MessageBox.Show("添加失败");
                    else arg.Close();

                    CargoType = new CargoType();


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
