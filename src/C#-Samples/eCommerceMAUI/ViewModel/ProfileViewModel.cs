

using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class ProfileViewModel : BaseViewModel
    {
        public ICommand TapCommand { get; private set; }

        public string Name { get; set; } = "David Spade";
        public string Email { get; set; } = "iamdavid@gmail.com";
        public string ImageUrl { get; set; } = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Avatar.png";

        public List<MenuItems> _MenuItems = new List<MenuItems>();
        public List<MenuItems> MenuItems
        {
            get { return _MenuItems; }
            set { _MenuItems = value; }
        }

        public ProfileViewModel()
        {
            PopulateData();
            CommandInit();
        }

        void PopulateData()
        {
            MenuItems.Clear();
            MenuItems.Add(new Model.MenuItems() { Title = "Edit Profile", Body = "\uf3eb", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Shipping Address", Body = "\uf34e", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Wishlist", Body = "\uf2d5", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Order History", Body = "\uf150", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Track Order", Body = "\uf787", TargetType = typeof(OrderDetails) });
            MenuItems.Add(new Model.MenuItems() { Title = "Cards", Body = "\uf19b", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Notifications", Body = "\uf09c", TargetType = typeof(HomePage) });
        }

        private void CommandInit()
        {
            TapCommand = new Command<MenuItems>(item =>
            {
                Application.Current.MainPage.Navigation.PushModalAsync(((Page)Activator.CreateInstance(item.TargetType)));
            });

        }
    }
}
