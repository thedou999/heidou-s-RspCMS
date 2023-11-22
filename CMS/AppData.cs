using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using MahApps.Metro.Controls;
using Models;

namespace CMS
{
    public class AppData : ObservableObject
    {
		private Member member = new Member();

		private string systemName = "仓库物资管理系统";
		public string SystemName
		{
			get { return systemName; }
			set { systemName = value;RaisePropertyChanged(); }
		}  
		public Member CurrentUser
		{
			get { return member;}
			set { member = value;RaisePropertyChanged();}
		}
		public MainWindow MainWindow { get; set; } = null;
		public void ShowMarkLayer(bool isMark)
		{
			if (MainWindow == null) return;
			MainWindow.MarkLayer.Visibility = isMark ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
		}
		public ObservableCollection<Role> Roles { get; set; } = new ObservableCollection<Role>();
		public AppData() 
		{
			Roles.Add(new Role() {Name="操作员",RoleNumber=1 });
			Roles.Add(new Role() {Name="管理员",RoleNumber=0 });
		}

		public static AppData Instance = new Lazy<AppData>(() => new AppData()).Value;




	}

	public class Role
	{
		public String Name { get; set; }
		public int RoleNumber {  get; set; }
	}
}
