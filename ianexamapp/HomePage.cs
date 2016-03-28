using System;

using Xamarin.Forms;

namespace ianexamapp
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			var abs = new AbsoluteLayout ();
			var button = new Button{Text = "Start eXam!", TextColor = Color.Navy, BackgroundColor = Color.Silver };

			abs.Children.Add (button, new Rectangle (0.5, 0.5, 150, 60), AbsoluteLayoutFlags.PositionProportional);

			Content = abs;
		}
	}
}


