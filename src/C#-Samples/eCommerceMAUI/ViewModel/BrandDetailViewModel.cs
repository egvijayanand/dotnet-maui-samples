using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class BrandDetailViewModel : BaseViewModel
    {
        public ICommand TapCommand { get; private set; }
        public ICommand TapCommandMenu { get; private set; }

        public ObservableCollection<TabPageModel> _TabPageList = new ObservableCollection<TabPageModel>();
        public ObservableCollection<TabPageModel> TabPageList
        {
            get
            {
                return _TabPageList;
            }
            set
            {
                _TabPageList = value;
                OnPropertyChanged("TabPageList");
            }
        }

        public ObservableCollection<ProductListModel> _AllProductDataList = new ObservableCollection<ProductListModel>();
        public ObservableCollection<ProductListModel> AllProductDataList
        {
            get
            {
                return _AllProductDataList;
            }
            set
            {
                _AllProductDataList = value;
                OnPropertyChanged("AllProductDataList");
            }
        }
        public BrandDetailViewModel()
        {
            PopulateData();
            TapCommand = new Command<ProductListModel>(SelectProduct);
            TapCommandMenu = new Command<TabPageModel>(SelectMenu);
        }
        private async void SelectProduct(ProductListModel obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new ProductDetails());
        }

        private void SelectMenu(TabPageModel obj)
        {
            foreach (var item in TabPageList)
            {
                if (item.Id == obj.Id)
                {
                    item.IsSelected = true;
                }
                else
                {
                    item.IsSelected = false;
                }
            }

        }
        void PopulateData()
        {
            AllProductDataList.Clear();
            AllProductDataList.Add(new ProductListModel() { Name = "BeoPlay Speaker", BrandName = "Bang and Olufsen", Price = "$755", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" });
            AllProductDataList.Add(new ProductListModel() { Name = "Leather Wristwatch", BrandName = "Tag Heuer", Price = "$450", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image2.png" });
            AllProductDataList.Add(new ProductListModel() { Name = "Smart Bluetooth Speaker", BrandName = "Google LLC", Price = "$900", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image3.png" });
            AllProductDataList.Add(new ProductListModel() { Name = "Smart Luggage", BrandName = "Smart Inc", Price = "$1200", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image4.png" });
            AllProductDataList.Add(new ProductListModel() { Name = "Smart Bluetooth Speaker", BrandName = "Bang and Olufsen", Price = "$90", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" });
            AllProductDataList.Add(new ProductListModel() { Name = "B&o Desk Lamp", BrandName = "Bang and Olufsen", Price = "$450", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image7.png" });
            AllProductDataList.Add(new ProductListModel() { Name = "BeoPlay Stand Speaker", BrandName = "Bang and Olufse", Price = "$3000", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image8.png" });
            AllProductDataList.Add(new ProductListModel() { Name = "Airpods", BrandName = "B&o Phone Case", Price = "$30", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image9.png" });

            TabPageList.Clear();
            TabPageList.Add(new TabPageModel("All", 0, true));
            TabPageList.Add(new TabPageModel("Smart Bluetooth Speaker", 1, false));
            TabPageList.Add(new TabPageModel("Lamp", 2, false));
            TabPageList.Add(new TabPageModel("Airpods", 3, false));
        }
    }
}
