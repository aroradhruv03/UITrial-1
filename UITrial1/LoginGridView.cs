﻿using System;
using Xamarin.Forms;



public class LoginGridView : Grid
{
	public LoginGridView ()
	{
		var label1 = new Label {
			Text = "Process payments from your tablet.",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.End,
			TextColor = Color.White,
			Font = Font.SystemFontOfSize (NamedSize.Large),
			FontAttributes = FontAttributes.Bold
		};
		var label2 = new Label {
			Text = "Quickly and securely.",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Start,
			TextColor = Color.White,
			Font = Font.SystemFontOfSize (NamedSize.Medium),
		};
		var label3 = new Label {
			Text = "Bolletta",
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Start,
			TextColor = Color.FromHex ("FF9800"),
			Font = Font.SystemFontOfSize (NamedSize.Medium),

		};
		var label4 = new Label {
			Text = "MOBILE CASHIER",
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Start,
			TextColor = Color.Gray,
			Font = Font.SystemFontOfSize (NamedSize.Micro),
		};
		var label5 = new Label {
			Text = "Please enter your Username and Password to sign in",
			TextColor = Color.Gray,
			VerticalOptions = LayoutOptions.End,
		};

//		var label6 = new Label {
//			Text = "Forgot"
//		};
//		var label7 = new Label {
//			Text = "Sign"
//		};

		var usernameEntry = new Entry {
			Placeholder = "Username"
		};
		var passwordEntry = new Entry {
			Placeholder = "Password",
			IsPassword = true
		};

		var bolettaImage = new Image {
			Source = "http://a4.mzstatic.com/us/r30/Purple4/v4/02/8d/e2/028de2c0-0a91-9e68-0b61-5a7f7fae4577/icon175x175.png",
			HeightRequest = 10,
			WidthRequest = 10,
		};

		Button buttonForgotPass = new Button {
			Text = "Forgot Password",
			TextColor = Color.White,
			BorderColor = Color.Black,
			BackgroundColor = Color.FromHex ("2196F3"),
			BorderWidth = 1
		};
		buttonForgotPass.Clicked += OnForgotPassClicked;
//		buttonForgotPass.Clicked += async (sender, e) => {
//			var action = await Page.DisplayActionSheet ("ActionSheet: Save Photo?", "Cancel", "Delete", "Photo Roll", "Email");
//			Debug.WriteLine("Action: " + action); // writes true or false to the console
//		};

		Button buttonSignIn = new Button {
			Text = "Sign In",
			TextColor = Color.White,
			BorderColor = Color.Black,
			BackgroundColor = Color.FromHex ("2196F3"),
			BorderWidth = 1,
			Command = new Command (() => Navigation.PushModalAsync (new RootPage ()))
		};
//		buttonSignIn.Clicked += OnSignInClicked;
//			var bg = Color.White;

		StackLayout loginSquare = new StackLayout { BackgroundColor = Color.FromHex ("E3F2FD"),
		};


		// Grid Attributes
		RowSpacing = 2;

		RowDefinitions = new RowDefinitionCollection {
			new RowDefinition (),	// Row 0-1
			new RowDefinition (),	// Row 1-2
			new RowDefinition (),	// Row 2-3
			new RowDefinition (),	// Row 3-4
			new RowDefinition { Height = new GridLength (30) },	// Row 4-5
			new RowDefinition { Height = new GridLength (30) },	// Row 5-6
			new RowDefinition { Height = new GridLength (30) },	// Row 6-7
			new RowDefinition { Height = new GridLength (30) },	// Row 7-8
			new RowDefinition { Height = new GridLength (30) },	// Row 8-9
			new RowDefinition { Height = new GridLength (30) },	// Row 9-10
			new RowDefinition { Height = new GridLength (30) },	// Row 10-11
			new RowDefinition (),	// Row 11-12
			new RowDefinition (),	// Row 12-13
		};
		ColumnDefinitions = new ColumnDefinitionCollection {
			new ColumnDefinition { Width = new GridLength (5) },	// Column 0-1
			new ColumnDefinition { Width = new GridLength (10) },	// Column 1-2
			new ColumnDefinition (),							// Column 2-3
			new ColumnDefinition (),							// Column 3-4
			new ColumnDefinition (),							// Column 4-5
			new ColumnDefinition { Width = new GridLength (10) },	// Column 5-6
			new ColumnDefinition { Width = new GridLength (5) },	// Column 6-7
		};
		// Specify in format (column start, column end, row start, row end);
		Children.Add (loginSquare, 1, 6, 4, 12);
		Children.Add (label1, 2, 6, 1, 2);
		Children.Add (label2, 2, 6, 2, 3);
		Children.Add (bolettaImage, 2, 3, 5, 7);
		Children.Add (label3, 3, 6, 5, 6);
		Children.Add (label4, 3, 6, 6, 7);
		Children.Add (label5, 2, 6, 7, 8);
		Children.Add (usernameEntry, 2, 5, 8, 9);
		Children.Add (passwordEntry, 2, 5, 9, 10);
		Children.Add (buttonForgotPass, 3, 4, 10, 11);
		Children.Add (buttonSignIn, 4, 5, 10, 11);
	}


	async void OnForgotPassClicked (object sender, EventArgs e)
	{
//				var action = await Page.DisplayActionSheet ("ActionSheet: Save Photo?", "Cancel", "Delete", "Photo Roll", "Email");
//		Debug.Print("Answer: " ); // writes true or false to the console
			
	}

	//	void OnSignInClicked(object sender, EventArgs e)
	//	{
	//		Command = new Command (() => Navigation.PushAsync (new MyPage ()));
	//	}
}