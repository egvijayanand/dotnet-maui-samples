using System.Collections;

namespace ClassFlyXaml
{
    public class AlternateRowDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EvenTemplate { get; set; }
        public DataTemplate OddTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            int index;
            var itemSource = ((CollectionView)container).ItemsSource;
            if (itemSource is IList list)
            {
                index = list.IndexOf(item);
            }
            else
            {
                index = ((IEnumerable<object>)itemSource).ToList().IndexOf(item);
            }

            return index % 2 == 0 ? EvenTemplate : OddTemplate;
        }
    }
}
