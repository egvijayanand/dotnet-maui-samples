namespace MauiBlazorApp.Extensions
{
    public static class GenericExtensions
    {
        public static Dictionary<TKey, TValue> CreateDictionary<TKey, TValue>(params (TKey key, TValue value)[] keyValues)
            where TKey : notnull
        {
            var dict = new Dictionary<TKey, TValue>();

            foreach (var (key, value) in keyValues)
            {
                dict[key] = value;
            }

            return dict;
        }
    }
}
