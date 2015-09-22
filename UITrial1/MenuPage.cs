using System;

using Xamarin.Forms;

public class MenuPage : ContentPage
{
	//		public MenuPage ()
	//		{
	//			Content = new StackLayout {
	//				Padding = new Thickness(0, Device.OnPlatform<int>(20, 0, 0), 0, 0),
	//				Children = {
	//					new MainLink("Page A"),
	//					new MainLink("Page B"),
	//					new MainLink("Page C"),
	//				}
	//			};
	//			Title = "Master";
	//			BackgroundColor = Color.Gray.WithLuminosity(0.9);
	//			Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null;
	//		}

	public ListView Menu { get; set; }

	public MenuPage ()
	{
		Icon = "settings.png";
		Title = "menu"; // The Title property must be set.
		BackgroundColor = Color.FromHex ("333333");

		Menu = new MenuListView ();

		var menuLabel = new ContentView {
			Padding = new Thickness (10, 36, 0, 5),
			Content = new Label {
				TextColor = Color.FromHex ("AAAAAA"),
				Text = "MENU", 
			}
		};

		var layout = new StackLayout { 
			Spacing = 0, 
			VerticalOptions = LayoutOptions.FillAndExpand
		};
		layout.Children.Add (menuLabel);
		layout.Children.Add (Menu);

		Content = layout;
	}
}