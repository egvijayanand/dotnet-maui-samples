

using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class HomePageViewModel : BaseViewModel
    {
        public ICommand TapCommand { get; private set; }
        public ICommand BrandTapCommand { get; private set; }
        public Command<object> RecommendedTapCommand { get; private set; }
        public ICommand CategoryTapCommand { get; private set; }

        public ObservableCollection<CategoriesModel> _CategoriesDataList = new ObservableCollection<CategoriesModel>();
        public ObservableCollection<CategoriesModel> CategoriesDataList
        {
            get
            {
                return _CategoriesDataList;
            }
            set
            {
                _CategoriesDataList = value;
                OnPropertyChanged("CategoriesDataList");
            }
        }

        public ObservableCollection<ProductListModel> _BestSellingDataList = new ObservableCollection<ProductListModel>();
        public ObservableCollection<ProductListModel> BestSellingDataList
        {
            get
            {
                return _BestSellingDataList;
            }
            set
            {
                _BestSellingDataList = value;
                OnPropertyChanged("BestSellingDataList");
            }
        }

        public ObservableCollection<ProductListModel> _FeaturedBrandsDataList = new ObservableCollection<ProductListModel>();
        public ObservableCollection<ProductListModel> FeaturedBrandsDataList
        {
            get
            {
                return _FeaturedBrandsDataList;
            }
            set
            {
                _FeaturedBrandsDataList = value;
                OnPropertyChanged("FeaturedBrandsDataList");
            }
        }

        public HomePageViewModel()
        {
            PopulateData();
            TapCommand = new Command<ProductListModel>(SelectProduct);
            RecommendedTapCommand = new Command<object>(SelectRecommend);
            CategoryTapCommand = new Command<CategoriesModel>(SelectCategory);
            BrandTapCommand = new Command<ProductListModel>(SelectBrand);
        }
        void PopulateData()
        {
            CategoriesDataList.Clear();
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 1, CategoryName = "Men", Icon = "\ufb22" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Women", Icon = "\ufb23" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Devices", Icon = "\uf322" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Gadgets", Icon = "\uf2cb" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Games", Icon = "\uf5ba" });

            BestSellingDataList.Clear();
            BestSellingDataList.Add(new ProductListModel() { Name = "BeoPlay Speaker", BrandName = "Bang and Olufsen", Price = "$755", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" });
            BestSellingDataList.Add(new ProductListModel() { Name = "Leather Wristwatch", BrandName = "Tag Heuer", Price = "$450", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image2.png" });
            BestSellingDataList.Add(new ProductListModel() { Name = "Smart Bluetooth Speaker", BrandName = "Google LLC", Price = "$900", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image3.png" });
            BestSellingDataList.Add(new ProductListModel() { Name = "Smart Luggage", BrandName = "Smart Inc", Price = "$1200", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image4.png" });

            FeaturedBrandsDataList.Clear();
            FeaturedBrandsDataList.Add(new ProductListModel() { BrandName = "B&O", Details = "5693 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png" });
            FeaturedBrandsDataList.Add(new ProductListModel() { BrandName = "Beats", Details = "1124 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/beats.png" });
            FeaturedBrandsDataList.Add(new ProductListModel() { BrandName = "Apple, Inc", Details = "5693 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Apple.png" });

        }

        private async void SelectBrand(ProductListModel obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new BrandDetail());
        }
        private async void SelectProduct(ProductListModel obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new ProductDetails());
        }

        private async void SelectCategory(CategoriesModel obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CategoryDetail(obj));
        }
        private async void SelectRecommend(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AllProduct());
        }
    }
}
