namespace Learn.MauiPaymentUi.Services
{
    public interface IStoreService
    {
        Dictionary<StoreItem, int> CartItems { get; }

        int TotalCost { get; }

        /// <summary>Select item for purchase</summary>
        /// <param name="storeItem">Item from the store.</param>
        /// <param name="quantity">Quantity of item.</param>
        void AddItem(StoreItem storeItem, int quantity);

        /// <summary>Clear cart.</summary>
        void Clear();
    }
}
