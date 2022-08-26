

using EcommerceMAUI.Model;
using System.Windows.Input;
using static EcommerceMAUI.Model.TrackOrderModel;

namespace EcommerceMAUI.ViewModel
{
    public class TrackOrderViewModel : BaseViewModel
    {

        public List<DeliveryStepsModel> TrackStatusData { get; private set; } = new List<DeliveryStepsModel>();

        public ICommand TapBackCommand { get; set; }

        Track TrackOrderData { get; set; }
        public string PageTitle
        {
            get
            {
                return TrackOrderData.OrderId;
            }
        }
        public TrackOrderViewModel(Track data, bool emptyGroups = false)
        {
            TrackOrderData = data;
            TapBackCommand = new Command<object>(GoBack);
            CreateCollection();
        }

        void CreateCollection()
        {
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 1, DateMonth = "20/18", IsComplete = true, Time = "12:00", Name = "Order Signed", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 2, DateMonth = "20/18", IsComplete = true, Time = "12:00", Name = "Order Signed", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 3, DateMonth = "20/18", IsComplete = true, Time = "12:00", Name = "Order Signed", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 4, DateMonth = "20/18", IsComplete = false, Time = "12:00", Name = "Order Signed", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 5, DateMonth = "20/18", IsComplete = false, Time = "12:00", Name = "Order Signed", Location = "Lagos State, Nigeria" });
        }


        private async void GoBack(object obj)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

    }
}
