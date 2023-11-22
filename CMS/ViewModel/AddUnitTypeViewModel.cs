using CMS.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CMS.ViewModel
{
    public class AddUnitTypeViewModel : ViewModelBase
    {
        AppData AppData { get; set; } = AppData.Instance;

		private UnitType unitType = new UnitType();

		public UnitType UnitType
		{
			get { return unitType; }
			set { unitType = value; RaisePropertyChanged(); }
		}

        public RelayCommand<MetroWindow> InsertUnitTypeCommand
        {
            get
            {
                return new RelayCommand<MetroWindow>(item =>
                {
                    if (!(item is MetroWindow window)) return;
                    if (string.IsNullOrEmpty(UnitType.Name)) return;
                    UnitType.InsertDate = DateTime.Now;
                    UnitType.MemberName = AppData.CurrentUser.Name;
                    UnitType.MemberId = AppData.CurrentUser.Id;
                    
                    var count = new UnitTypeProvider().Insert(UnitType);
                    if (count == 0) MessageBox.Show("插入失败，请重试");
                    else
                    {
                        window.Close();
                        UnitType = new UnitType();
                    }

                });
            }
        }


        public RelayCommand<MetroWindow> CloseCommand
        {
            get
            {
                return new RelayCommand<MetroWindow>(item =>
                {
                    if (!(item is MetroWindow window)) return;
                    
                    window.Close();
                    UnitType = new UnitType();
                });
            }
        }

    }
}
