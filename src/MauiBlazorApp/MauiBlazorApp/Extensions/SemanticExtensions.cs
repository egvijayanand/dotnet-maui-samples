namespace MauiBlazorApp.Extensions
{
    public static class SemanticExtensions
    {
        public static TBindable SemanticDesc<TBindable>(this TBindable bindable, string description)
            where TBindable : BindableObject
        {
            SemanticProperties.SetDescription(bindable, description);
            return bindable;
        }

        public static TBindable SemanticHeading<TBindable>(this TBindable bindable, SemanticHeadingLevel headingLevel)
            where TBindable : BindableObject
        {
            SemanticProperties.SetHeadingLevel(bindable, headingLevel);
            return bindable;
        }

        public static TBindable SemanticHint<TBindable>(this TBindable bindable, string hint)
            where TBindable : BindableObject
        {
            SemanticProperties.SetHint(bindable, hint);
            return bindable;
        }
    }
}
