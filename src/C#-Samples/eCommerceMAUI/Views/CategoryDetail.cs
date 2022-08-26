using EcommerceMAUI.Model;
using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class CategoryDetail : ContentPage
{
    public CategoryDetail(CategoriesModel data)
    {
        InitializeComponent();
        BindingContext = new CategoryDetailViewModel(data);
    }
}