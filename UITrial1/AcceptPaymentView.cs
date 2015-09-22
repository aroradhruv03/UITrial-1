//using System;
//using Xamarin.Forms;
//
//class AcceptPaymentView :  ContentPage
//{
//	
//	public AcceptPaymentView ()
//	{
//		Content = new StackLayout {
//			Children = {
//				new Button {
//					Text = "PushAsync",
//					Command = new Command(() => Navigation.PushAsync(new AcceptPaymentView())),
//				},
//				new Button {
//					Text = "PopAsync",
//					Command = new Command(() => Navigation.PopAsync()),
//				},
//				new Button {
//					Text = "PushModalAsync",
//					Command = new Command(() => Navigation.PushModalAsync(new AcceptPaymentView())),
//				},
//				new Button {
//					Text = "PopModalAsync",
//					Command = new Command(() => Navigation.PopModalAsync()),
//				},
//				new Button {
//					Text = "PopToRootAsync",
//					Command = new Command(() => Navigation.PopToRootAsync()),
//				},
//			},
//		};
//	}
//}
