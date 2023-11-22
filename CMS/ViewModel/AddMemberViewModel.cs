using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MahApps.Metro.Controls;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CMS.ViewModel
{
    public class AddMemberViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

		private Member member = new Member();

		public Member Member
		{
			get { return member; }
			set { member = value; RaisePropertyChanged(); }
		}

        public RelayCommand<MetroWindow> InsertMemberCommand
        {
            get 
            {
                return new RelayCommand<MetroWindow>(window => 
                {
                    if (!(window is MetroWindow)) return;
                    if (string.IsNullOrEmpty(member.Name) || string.IsNullOrEmpty(member.Password)) return;
                    member.InsertDate = DateTime.Now;

                    var count = new MemberProvider().Insert(Member);
                    if(count==0) return;
                    else window.Close();
                    Member = new Member();
                });
            }
        }

        public RelayCommand<MetroWindow> CloseCommand
        {
            get 
            {
                return new RelayCommand<MetroWindow>(window =>
                {
                    if (!(window is MetroWindow)) return;
                    window.Close();

                });
            }
        }



    }
}
