using BeautyShopApp.Models;
using BeautyShopApp.Services;
using System.Collections.ObjectModel;

namespace BeautyShopApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        ObservableCollection<Product> _products;

        public HomeViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        private void LoadData()
        {
            Products = new ObservableCollection<Product>();

            // Add first fake item
            Products.Add(new Product());

            foreach (var product in ProductService.Instance.GetProducts())
                Products.Add(product);
        }
    }
}