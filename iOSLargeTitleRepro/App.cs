using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace iOSLargeTitleRepro
{
    public class App : Xamarin.Forms.Application
    {
        public App()
        {
            var contentPage = new ContentPage
            {
                Title = "Wrong Toolbar Background Color",
                Content = new Xamarin.Forms.ScrollView
                {
                    Content = new Label
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        Text = "Main Page"
                    }
                }
            };

            var navigationPage = new Xamarin.Forms.NavigationPage(contentPage)
            {                
                BarBackgroundColor = Color.Green,
                BarTextColor = Color.Red
            };

            navigationPage.On<iOS>().SetPrefersLargeTitles(true);

            MainPage = navigationPage;
        }
    }
}
