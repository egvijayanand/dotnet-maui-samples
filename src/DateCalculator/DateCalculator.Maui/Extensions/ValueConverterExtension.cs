namespace Maui.CommunityToolkit.Extensions.Internals
{
    public abstract class ValueConverterExtension : BindableObject, IMarkupExtension<IValueConverter>
    {
        public IValueConverter ProvideValue(IServiceProvider serviceProvider)
            => (IValueConverter)this;

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
            => ((IMarkupExtension<IValueConverter>)this).ProvideValue(serviceProvider);
    }
}