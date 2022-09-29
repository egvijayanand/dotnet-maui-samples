namespace MAUIDemo.Models
{
    public class Category
    {
        public string Name { get; set; }

        public string MaterialIcon { get; set; }

        /// <summary>Not included as part of original Xaml version, 
        /// since FlexLayout is having some issues, turned it into a Grid.</summary>
        public int ColIndex { get; set; }

        /// <summary>Not included as part of original Xaml version, 
        /// since FlexLayout is having some issues, turned it into a Grid.</summary>
        public int RowIndex { get; set; }

        public Category(string name, string icon)
        {
            Name = name;
            MaterialIcon = icon;
        }
    }
}

