using System;

using Xamarin.Forms;

namespace UITrial1
{
	public class GridMainScreen : Grid
	{
		public GridMainScreen ()
		{
			var label1 = new Label {
				Text = "Process payments from your tablet.",
				HorizontalOptions = LayoutOptions.Center
			};
			var label2 = new Label {
				Text = "Quickly and securely.",
				HorizontalOptions = LayoutOptions.Center
			};
			var label3 = new Label {
				Text = "Bolletta",
				VerticalOptions = LayoutOptions.Center
			};
			var label4 = new Label {
				Text = "Mobile Cashier",
				VerticalOptions = LayoutOptions.Center
			};
			var label5 = new Label {
				Text = "Please enter your Username and Password to sign in"
			};
			var label6 = new Label {
				Text = "Forgot"
			};
			var label7 = new Label {
				Text = "Sign"
			};
			var usernameEntry = new Entry {
				Placeholder = "Username"
			};
			var passwordEntry = new Entry {
				Placeholder = "Password",
				IsPassword = true
			};

			var bolettaImage = new Image {
								Source = "http://a4.mzstatic.com/us/r30/Purple4/v4/02/8d/e2/028de2c0-0a91-9e68-0b61-5a7f7fae4577/icon175x175.png"
			};

			Button button1 = new Button {
				Text = "Forgot Password",
				TextColor = Color.Black,
				BorderColor = Color.Black,
				BorderWidth = 1
			};

			Button button2 = new Button {
				Text = "Sign In",
				TextColor = Color.Black,
				BorderColor = Color.Black,
				BorderWidth = 1
			};

			var bg = Color.White;

			StackLayout st = new StackLayout { BackgroundColor = Color.White,
			};


			// Grid Attributes
			RowSpacing = 2;

			RowDefinitions = new RowDefinitionCollection {
				new RowDefinition (),	// Row 0-1
				new RowDefinition (),	// Row 1-2
				new RowDefinition (),	// Row 2-3
				new RowDefinition (),	// Row 3-4
				new RowDefinition (),	// Row 4-5
				new RowDefinition (),	// Row 5-6
				new RowDefinition (),	// Row 6-7
				new RowDefinition (),	// Row 7-8
				new RowDefinition (),	// Row 8-9
				new RowDefinition (),	// Row 9-10
				new RowDefinition (),	// Row 10-11
				new RowDefinition (),	// Row 11-12
				new RowDefinition (),	// Row 12-13
			};
			ColumnDefinitions = new ColumnDefinitionCollection {
				new ColumnDefinition { Width = new GridLength(5) },	// Column 0-1
				new ColumnDefinition { Width = new GridLength(10)},	// Column 1-2
				new ColumnDefinition (),							// Column 2-3
				new ColumnDefinition (),							// Column 3-4
				new ColumnDefinition (),							// Column 4-5
				new ColumnDefinition { Width = new GridLength(10)},	// Column 5-6
				new ColumnDefinition { Width = new GridLength(5) },	// Column 6-7
			};
			// Specify in format (column start, column end, row start, row end);
			Children.Add (st,1,6,4,12);
			Children.Add (label1,2,6,1,2);
			Children.Add (label2,2,6,2,3);
			Children.Add (bolettaImage,2,3,5,7);
			Children.Add (label3,3,6,5,6);
			Children.Add (label4,3,6,6,7);
			Children.Add (label5,2,6,7,8);
			Children.Add (usernameEntry,2,5,8,9);
			Children.Add (passwordEntry,2,5,9,10);
			Children.Add (button1,3,4,10,11);
			Children.Add (button2,4,5,10,11);



		}
	}
}


