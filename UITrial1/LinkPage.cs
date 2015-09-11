using System;

using Xamarin.Forms;

public class LinkPage : ContentPage
	{
		
			public LinkPage(string name)
			{
				Title = name;
		Content = new StackLayout {
			Children = {
				new SubLink(name + ".1"),
				new SubLink(name + ".2"),
				new SubLink(name + ".3"),
			},
		};
		}
	}

public class SubLink: Button
{
	public SubLink(string name)
	{
		Text = name;
		Command = new Command(o => App.MasterDetailPage.Detail.Navigation.PushAsync(new LinkPage(name)));
	}
}