namespace EstDiseño
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e) //Flex
        {
            await Navigation.PushModalAsync(new NavigationPage(new FlexLayoutPage()));
        }

        private async void Button_Clicked(object sender, EventArgs e) //Absolute
        {
            await Navigation.PushModalAsync(new NavigationPage(new AbsoluteLayoutPage()));
        }

        private async void Button_Clicked_1(object sender, EventArgs e) //Grid
        {
            await Navigation.PushModalAsync(new NavigationPage(new GridPage()));
        }
    }

}
/* 
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NavigationPage(new RegisterPage()));
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new NavigationPage(new Menu()));
    }
 */