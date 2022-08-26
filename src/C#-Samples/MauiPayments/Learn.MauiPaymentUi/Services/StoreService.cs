namespace Learn.MauiPaymentUi.Services
{
    public enum StoreItem
    {
        Hat,
        Shoes,
        Shirt,
    };

    public class StoreService : IStoreService
    {
        private Dictionary<StoreItem, int> _cartItems = new();

        public StoreService()
        {
        }

        public Dictionary<StoreItem, int> CartItems => _cartItems;

        public int TotalCost => _cartItems.Count * 10;

        public void AddItem(StoreItem storeItem, int quantity)
        {
            if (_cartItems is null)
                _cartItems = new();

            // _cartItems.Add(itemCode, price);
            _cartItems[storeItem] = quantity;
        }

        public void Clear()
        {
            _cartItems.Clear();
        }
    }
}
