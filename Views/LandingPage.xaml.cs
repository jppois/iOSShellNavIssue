using PMMAUIiOSShellNavIssue.Views.Folder1;
using PMMAUIiOSShellNavIssue.Views.Folder2;
using PMMAUIiOSShellNavIssue.Views.Folder3;
using PMMAUIiOSShellNavIssue.Views.Folder4;
using PMMAUIiOSShellNavIssue.Views.Folder5;
using PMMAUIiOSShellNavIssue.Views.Folder6;

namespace PMMAUIiOSShellNavIssue.Views;

public partial class LandingPage : ContentPage
{
    public LandingPage()
	{
		InitializeComponent();
        //Routing.RegisterRoute("//PageOnePage", typeof(PageOnePage));
        //Routing.RegisterRoute("//PageTwoPage", typeof(PageTwoPage));
        //Routing.RegisterRoute("//PageThreePage", typeof(PageThreePage));
        //Routing.RegisterRoute("//PageFourPage", typeof(PageFourPage));
        Routing.RegisterRoute("//PageFivePage", typeof(PageFivePage));
        Routing.RegisterRoute("//PageSixPage", typeof(PageSixPage));
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        try
        {
            Row1Btn.Text = "Button One";
            Row1Btn.Clicked += async (sender, args) => await Shell.Current.GoToAsync("//PageOnePage");
            Row2Btn.Text = "Button Two";
            Row2Btn.Clicked += async (sender, args) => await Shell.Current.GoToAsync("//PageTwoPage");
            Row3Btn.Text = "Button Three";
            Row3Btn.Clicked += async (sender, args) => await Shell.Current.GoToAsync("//PageThreePage");
            Row4Btn.Text = "Button Four";
            Row4Btn.Clicked += async (sender, args) => await Shell.Current.GoToAsync("//PageFourPage");
            Row5Btn.Text = "Button Five";
            Row5Btn.Clicked += async (sender, args) => await Shell.Current.GoToAsync("//PageFivePage");
            Row6Btn.Text = "Button Six";
            Row6Btn.Clicked += async (sender, args) => await Shell.Current.GoToAsync("//PageSixPage");
            Row7Btn.Text = "Button Seven";
            Row7Btn.Clicked += async (sender, args) => await Shell.Current.GoToAsync("//PageSevenPage");
            Row8Btn.Text = "Button Eight";
            Row8Btn.Clicked += async (sender, args) => await Shell.Current.GoToAsync("//PageEightPage");
            Row9Btn.Text = "Button Nine";
            Row9Btn.Clicked += async (sender, args) => await Shell.Current.GoToAsync("//PageNinePage");
            Row10Btn.Text = "Button Ten";
            Row10Btn.Clicked += async (sender, args) => await Shell.Current.GoToAsync("//PageTenPage");
        }
        catch (Exception ex)
        {
            string errorMessage = ex.Message.ToString();
            await DisplayAlert(errorMessage, "", "Ok");
        }
    }
}