using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS;
using CMS.Models;
using Models;
using GalaSoft.MvvmLight.Command;
using CMS.Views;
using CMS.Windows;
using System.Windows;

namespace CMS.ViewModel
{
    public class MemberViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;
        public ObservableCollection<Member> Members 
        { 
            get {  return members; } 
            set { members = value; RaisePropertyChanged(); } 
        }   
        private ObservableCollection<Member> members = new ObservableCollection<Member>();
        public MemberViewModel()
        {
            Members = new ObservableCollection<Member>(new MemberProvider().Select());
        }


        public RelayCommand<Member> DeleteMembersCommand
        {
            get 
            {
                return new RelayCommand<Member>(item =>
                {
                    if (!(item is Member)) return;
                    if (AppData.CurrentUser.Role != 0 || item.Role==0 || AppData.CurrentUser.Name == item.Name)
                    {
                        MessageBox.Show("您的权限不足。");
                        return;
                    }

                    if (MessageBox.Show("确定删除该项吗", "确定", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel) return;


                    if (!(item is Member member)) return;
                    var count = new MemberProvider().Delete(member);
                    if (count == 0) { MessageBox.Show("删除失败"); return; }
                    else
                    {
                        MessageBox.Show("删除成功");

                        Members = new ObservableCollection<Member>(new MemberProvider().Select());
                        AppData.MainWindow.PART_Container.Content = new MemberView();
                    }



                });
            }
        }
        public RelayCommand<Member> EditMembersCommand
        {
            get
            {
                return new RelayCommand<Member>(item =>
                {
                    if (AppData.CurrentUser.Role != 0) return;
                    if (!(item is Member member)) return;
                    if (string.IsNullOrEmpty(member.Name)) return;
                    var count = new MemberProvider().Update(member);
                    if (count == 0) MessageBox.Show("修改失败");
                    else
                    {
                        MessageBox.Show("修改成功");

                        Members = new ObservableCollection<Member>(new MemberProvider().Select());
                        AppData.MainWindow.PART_Container.Content = new MemberView();
                    }



                });
            }
        }

        public RelayCommand  OpenAddMemberWindow
        {
            get
            {
                return new RelayCommand( () =>
                {
                    AddMemberWindow addMemberWindow = new AddMemberWindow();
                    addMemberWindow.ShowDialog();

                    Members = new ObservableCollection<Member>(new MemberProvider().Select());
                    AppData.MainWindow.PART_Container.Content = new MemberView();


                });
            }
        }


    }
}
