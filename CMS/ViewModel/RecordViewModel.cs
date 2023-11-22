using CMS.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using CMS.Models;
using CMS.Views;
using System.Windows;

namespace CMS.ViewModel
{
    public class RecordViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;
        public ObservableCollection<Record> Records 
        { 
            get {  return records; } 
            set { records = value; RaisePropertyChanged(); } 
        }   
        private ObservableCollection<Record> records = new ObservableCollection<Record>(new RecordProvider().Select());

        private ObservableCollection<Cargo> cargos;
        public ObservableCollection<Cargo> Cargos
        {
            get { return cargos; }
            set { cargos = value; RaisePropertyChanged(); }
        }
        public RecordViewModel()
        {
            Records = new ObservableCollection<Record>( new RecordProvider().Select());
            Cargos = new ObservableCollection<Cargo>( new CargoProvider().Select());
        }

        public RelayCommand<Record> DeleteRecordCommand
        {
            get
            {
                return new RelayCommand<Record>(record =>
                {
                    if (record == null) return;

                    if (MessageBox.Show("确定要删除该项吗?", "确定", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                    {
                        if (!(record is Record)) return;
                        if (string.IsNullOrEmpty(record.CargoName)) return;
                        var count = new RecordProvider().Delete(record);
                        if (count == 0) MessageBox.Show("删除失败");
                        else MessageBox.Show("删除成功");
                    }

                    Records = new ObservableCollection<Record>( new RecordProvider().Select());
                    AppData.Instance.MainWindow.PART_Container.Content = new RecordView();
                });
            }
        }



    }
}
