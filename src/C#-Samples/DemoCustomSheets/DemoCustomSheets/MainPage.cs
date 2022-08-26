using System.Collections.ObjectModel;
using System.Text.Json;
using static DemoCustomSheets.MonekyApi;

namespace DemoCustomSheets;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void LoadData()
    {
        try
        {
            incdicate.IsVisible = true;
            MonkeyButton.IsVisible = Listbutton.IsVisible = false;
            HttpClient httpClient = new HttpClient();
            string RestUrl = @"https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/MonkeysApp/monkeydata.json";
            var response = await httpClient.GetAsync(RestUrl);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var Items = JsonSerializer.Deserialize<ObservableCollection<MonkeyApi>>(content);
                var rnd = new Random();
                var randomMonkey = Items.OrderBy(item => rnd.Next());
                ApiListViewName.ItemsSource = randomMonkey.Take(5).ToList();
                incdicate.IsVisible = false;
                MonkeyButton.IsVisible = Listbutton.IsVisible = true;
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Ok");
        }

    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DefaultSheet.OpenSheet();
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        CommonSheet.SheetHeight = 150;
        CommonSheet.SheetWidth = 300;
        await CommonSheet.OpenSheet();
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await CloseRemoved.OpenSheet();
        LoadData();
    }

    private async void SheetClose(object sender, EventArgs e)
    {
        if (CloseRemoved.SheetVisible)
            await CloseRemoved.CloseSheet();
        if (sheetview.SheetVisible)
            await sheetview.CloseSheet();
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        CommonSheet.SheetHeight = 150;
        CommonSheet.SheetWidth = 300;
        await CommonSheet.OpenSheet();
    }
    protected override bool OnBackButtonPressed()
    {
        if (CommonSheet.SheetVisible)
        {
            CommonSheet.CloseSheet();
            return true;
        }
        else
            return base.OnBackButtonPressed();
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        CommonSheet.SheetHeight = 150;
        CommonSheet.SheetWidth = 300;
        CommonSheet.BackClickClose = true;
        CommonSheet.IsRoundRectangleVisible = false;
        CommonSheet.SheetBackgroundColor = Colors.White;
        await CommonSheet.OpenSheet();
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        CommonSheet.SheetHeight = 150;
        CommonSheet.SheetWidth = 300;
        CommonSheet.IsRoundRectangleVisible = false;
        CommonSheet.SheetBackgroundColor = Colors.White;
        await CommonSheet.OpenSheet();
    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
        await sheetview.OpenSheet();
    }

    private async void Button_Clicked_7(object sender, EventArgs e)
    {
        CommonSheet.SheetHeight = 150;
        CommonSheet.SheetWidth = 300;
        CommonSheet.SheetBackgroundColor = Colors.Pink;
        await CommonSheet.OpenSheet();
    }

    private async void Button_Clicked_8(object sender, EventArgs e)
    {
        await RadioButtons.CloseSheet();
    }

    private async void Button_Clicked_9(object sender, EventArgs e)
    {
        await RadioButtons.OpenSheet();
    }
}

