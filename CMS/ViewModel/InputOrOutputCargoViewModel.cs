using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using CMS.Models;
using GalaSoft.MvvmLight.Command;
using MahApps.Metro.Controls;
using System.Windows;

namespace CMS.ViewModel
{
    public class InputOrOutputCargoViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

		public InputOrOutputCargoViewModel() 
		{

		}

		private Cargo cargo = new Cargo();
		public Cargo Cargo
		{
			get { return cargo; }
			set { cargo = value; RaisePropertyChanged(); }
		}


		public RelayCommand<MetroWindow> InputCargoCommand
		{
			get
			{
				return new RelayCommand<MetroWindow>(window =>
				{
					if (!(window is MetroWindow)) return;
					if (string.IsNullOrEmpty(Cargo.Name)) return;
					record.CargoName = Cargo.Name;
					Record.CargoId = new CargoProvider().Select().FirstOrDefault<Cargo>(item => item.Name == Record.CargoName).Id;
					Record.InsertDate = DateTime.Now;
					Record.MemberName = AppData.CurrentUser.Name;
					Record.MemberId = AppData.CurrentUser.Id;
					Record.InOrOutBit = true;

					var count = new RecordProvider().Insert(Record);
					if(count == 0) { MessageBox.Show("插入失败"); }
					else
					{
						window.Close();
						Record = new Record();
					}
				});
			}
		}
		public RelayCommand<MetroWindow> OutputCargoCommand
		{
			get
			{
				return new RelayCommand<MetroWindow>(window =>
				{
					if (!(window is MetroWindow)) return;
					if (string.IsNullOrEmpty(Cargo.Name)) return;
					if(record.Number > cargo.Number)
					{
						MessageBox.Show("出库数量大于产品数量，请重试");
						return;
					}

					record.CargoName = Cargo.Name;
					Record.CargoId = new CargoProvider().Select().FirstOrDefault<Cargo>(item => item.Name == Record.CargoName).Id;
					Record.InsertDate = DateTime.Now;
					Record.MemberName = AppData.CurrentUser.Name;
					Record.MemberId = AppData.CurrentUser.Id;
					Record.InOrOutBit = false;

					var count = new RecordProvider().Insert(Record);
					if(count == 0) { MessageBox.Show("插入失败"); }
					else
					{
						window.Close();
						Record = new Record();
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
					if (!(item is MetroWindow)) return;
					item.Close();
				});
			}
		}


		private Record record = new Record();
		public Record Record
		{
			get { return record; }
			set { record = value; RaisePropertyChanged(); }
		}

		}


	}


