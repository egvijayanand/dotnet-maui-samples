using BeautyShopApp.Models;

namespace BeautyShopApp.Views.Templates
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ResultsTemplate { get; set; }
        public DataTemplate ProductTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = (Product)item;

            if(product.IsEmpty())
                return ResultsTemplate;

            return ProductTemplate;
        }
    }
}
