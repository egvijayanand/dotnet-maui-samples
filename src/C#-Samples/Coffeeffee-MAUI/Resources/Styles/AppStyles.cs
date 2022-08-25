namespace Coffeeffee_MAUI
{
    public partial class AppStyles : ResourceDictionary
    {
        public AppStyles()
        {
            Add("product_title", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.LineBreakModeProperty, Value = LineBreakMode.TailTruncation },
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("green") },
                    new() { Property = Label.VerticalTextAlignmentProperty, Value = TextAlignment.Center },
                    new() { Property = Label.FontFamilyProperty, Value = "JosefinSansBold" },
                    new() { Property = Label.FontSizeProperty, Value = 28 },
                },
            });
            Add("product_title_large", new Style(typeof(Label))
            {
                BasedOn = (Style)this["product_title"],
                Setters =
                {
                    new() { Property = Label.FontSizeProperty, Value = 36 },
                },
            });
            Add("product_subtitle", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Orange },
                    new() { Property = Label.FontFamilyProperty, Value = "JosefinSansRegular" },
                    new() { Property = Label.FontSizeProperty, Value = 16 },
                },
            });
            
            #region Additional Styles
            Add("quantity", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("green") },
                    new() { Property = Label.FontFamilyProperty, Value = "JosefinSansBold" },
                    new() { Property = Label.FontSizeProperty, Value = 20 },
                    new() { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.VerticalTextAlignmentProperty, Value = TextAlignment.Center },
                },
            });
            Add("counter", new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = AppResource<Color>("green") },
                    new() { Property = Label.FontSizeProperty, Value = 18 },
                    new() { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new() { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                },
            });
            #endregion
        }
    }
}

