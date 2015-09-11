using System;

using Xamarin.Forms;

public class App : Application
	{
		public static MasterDetailPage MasterDetailPage;

		public App ()
		{
			// The root page of your application
		MainPage = new GridLoginPage();
//			MainPage = new NavigationPage(new AcceptPaymentView());

//			MasterDetailPage = new MasterDetailPage {
//				Master = new MenuPage(),
//			Detail = new NavigationPage(new MyPage()),
//			};
//			MainPage = MasterDetailPage;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}