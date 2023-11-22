using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MahApps.Metro.Controls;
using Models;

namespace CMS.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

        /// <summary>
        /// 登录命令
        /// </summary>
        //public RelayCommand LoginCommand
        //{
        //    get
        //    {
        //        return new RelayCommand(() =>
        //        {
        //            MemberProvider memberProvider = new MemberProvider();
        //            var user = memberProvider.Select().FirstOrDefault(item =>
        //            {
        //                return item.Name == Member.Name && item.Password == Member.Password;
        //            });

        //            if (user != null)
        //            {
        //                MainWindow mainWindow = new MainWindow();
        //                MessageBox.Show("登录成功");
        //                mainWindow.Show();
        //                App.Current.Shutdown();
        //            }
        //            else MessageBox.Show("登录失败");

        //        });
        //    }
        //}
        public RelayCommand<MetroWindow> LoginCommand
        {
            get 
            {
                return new RelayCommand<MetroWindow>((arg) =>
                {
                    MemberProvider memberProvider = new MemberProvider();

                    var user = memberProvider.Select().FirstOrDefault(item =>
                    {
                        return item.Name == AppData.CurrentUser.Name && item.Password == AppData.CurrentUser.Password;
                    });

                    if (user != null)
                    {
                        AppData.CurrentUser = user;
                        MainWindow mainWindow = new MainWindow();

                        mainWindow.Show();
                        arg.Close();
                        
                    }
                    else MessageBox.Show("登录失败");

                });
            }
        }


        /// <summary>
        /// 关闭命令
        /// </summary>
        public RelayCommand CloseCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    App.Current.Shutdown();
                });
            }
        }


        public LoginViewModel() 
        {
            this.AppData.CurrentUser.Name = "admin"; 
            this.AppData.CurrentUser.Password = "0"; 
        }


    }
}
