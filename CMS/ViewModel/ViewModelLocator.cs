/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:CMS"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace CMS.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<IndexViewModel>();
            SimpleIoc.Default.Register<CargoViewModel>();
            SimpleIoc.Default.Register<CargoTypeViewModel>();
            SimpleIoc.Default.Register<MemberViewModel>();
            SimpleIoc.Default.Register<RecordViewModel>();
            SimpleIoc.Default.Register<AddCargoTypeViewModel>();
            SimpleIoc.Default.Register<AddCargoViewModel>();
            SimpleIoc.Default.Register<UnitTypeViewModel>();
            SimpleIoc.Default.Register<AddUnitTypeViewModel>();
            SimpleIoc.Default.Register<AddMemberViewModel>();
            SimpleIoc.Default.Register<InputOrOutputCargoViewModel>();

           


        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public LoginViewModel Login
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }
        public IndexViewModel Index
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IndexViewModel>();
            }
        }
        public CargoViewModel Cargo
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CargoViewModel>();
            }
        }
        public CargoTypeViewModel CargoType
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CargoTypeViewModel>();
            }
        }
        public MemberViewModel Member
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MemberViewModel>();
            }
        }
        public RecordViewModel Record
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RecordViewModel>();
            }
        }
        public AddCargoTypeViewModel AddCargoType
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddCargoTypeViewModel>();
            }
        }
        public AddCargoViewModel AddCargo
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddCargoViewModel>();
            }
        }
        public UnitTypeViewModel UnitType
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UnitTypeViewModel>();
            }
        }
        public AddUnitTypeViewModel AddUnitType
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddUnitTypeViewModel>();
            }
        }

        public AddMemberViewModel AddMember
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddMemberViewModel>();
            }
        }
        public InputOrOutputCargoViewModel InputOrOutputCargo
        {
            get
            {
                return ServiceLocator.Current.GetInstance<InputOrOutputCargoViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}