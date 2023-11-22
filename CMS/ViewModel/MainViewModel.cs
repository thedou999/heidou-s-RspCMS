using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MahApps.Metro.Controls;
using System.Windows.Controls;
using CMS.Windows;
using CMS.Views;

namespace CMS.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;
        public string Number { get; set; }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {

            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        public RelayCommand<RadioButton> SelectViewCommand
        {
            get
            {
                return new RelayCommand<RadioButton>(arg =>
                {

                    if (!(arg is RadioButton button)) return;
                    if (string.IsNullOrEmpty(button.Content.ToString())) return;

                    switch (button.Content.ToString())
                    {
                        case "��ҳ": AppData.MainWindow.PART_Container.Content = new IndexView(); break;
                        case "�����": AppData.MainWindow.PART_Container.Content = new RecordView(); break;
                        case "���ʹ���": AppData.MainWindow.PART_Container.Content = new CargoView(); break;
                        case "�û�����": AppData.MainWindow.PART_Container.Content  = new MemberView(); break;
                        case "��������": AppData.MainWindow.PART_Container.Content = new CargoTypeView(); break;
                        case "��λ����": AppData.MainWindow.PART_Container.Content = new UnitTypeView(); break;
                        default: break;

                    }

                });
            }
        }

    }
}