using System;

using Xamarin.Forms;

public class LoginPage : ContentPage
{
	public LoginPage ()
	{
		LoginGridView S = new LoginGridView ();
		this.Content = S;
		BackgroundColor = Color.FromHex ("1976D2");
	}
}