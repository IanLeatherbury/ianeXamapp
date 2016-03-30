using System;

using Xamarin.Forms;

namespace ianexamapp
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            //remove navigation bar
            NavigationPage.SetHasNavigationBar(this, false);

            //Set background image
            var backgroundImage = new Image { Source = ImageSource.FromResource("ianexamapp.Images.background.jpg") };
            backgroundImage.Aspect = Aspect.AspectFill;

            var abs = new AbsoluteLayout();
            var button = new Button { Text = "Start eXam!", TextColor = Color.Navy, BackgroundColor = Color.Silver };
            button.Clicked += Button_Clicked;

            //add background image first, so it's first in the z order
            abs.Children.Add(backgroundImage, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.SizeProportional);
            abs.Children.Add(button, new Rectangle(0.5, 0.5, 150, 60), AbsoluteLayoutFlags.PositionProportional);           

            Content = abs;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuestionPage());
        }
    }
}