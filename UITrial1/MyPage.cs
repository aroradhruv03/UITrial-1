using System;

using Xamarin.Forms;

namespace UITrial1
{
	public class MyPage : ContentPage
	{
		public MyPage()
		{
//			GridMainScreen S = new GridMainScreen ();
//			this.Content = S;
//			BackgroundColor = Color.FromRgb(75,118,209);

			createTable ();
		}

		public void createTable()
		{

			var entryCellBillType = new EntryCell {
				Label = "Bill Type:",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellFirstName = new EntryCell {
				Label = "First Name",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellMiddleName = new EntryCell {
				Label = "Middle",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellLastName = new EntryCell {
				Label = "Last Name",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellAddress = new EntryCell {
				Label = "Address",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellCity = new EntryCell {
				Label = "City",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellState = new EntryCell {
				Label = "State",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellZip = new EntryCell {
				Label = "Zip",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellPhone = new EntryCell {
				Label = "Phone",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellEmail = new EntryCell {
				Label = "Email",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellParcelNo = new EntryCell {
				Label = "ParcelNumber",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellTaxYear = new EntryCell {
				Label = "Tax Year",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};
			var entryCellAmtToPay = new EntryCell {
				Label = "Amount to Pay",
				Placeholder = "default keyboard",
				Keyboard = Keyboard.Default
			};

			Content = new TableView {
				Intent = TableIntent.Form,
				Root = new TableRoot ("Accept Payments") {
					new TableSection ("Section 1 Title") {
						entryCellBillType,
						entryCellFirstName,
						entryCellMiddleName,
						entryCellLastName,
						entryCellAddress,
						entryCellCity,
						entryCellState,
						entryCellZip,
						entryCellPhone,
						entryCellEmail,
						entryCellParcelNo,
						entryCellTaxYear,
						entryCellAmtToPay
					}
				}
			};
		}
	}
}



//	public class MyPage : ContentPage
//	{
//		public MyPage ()
//		{
//			var bolettaImage = new Image {
//				Source = "http://a4.mzstatic.com/us/r30/Purple4/v4/02/8d/e2/028de2c0-0a91-9e68-0b61-5a7f7fae4577/icon175x175.png"
//			};
//			var usernameEntry = new Entry {Placeholder = "Username"};
//			var passwordEntry = new Entry {
//				Placeholder = "Password",
//				IsPassword = true
//			};
//
//			Content = new TableView {
//				Intent = TableIntent.Form,
//				Root = new TableRoot ("Login Page") 
//					{
//					new TableSection () {
//						new TextCell {
//							Text = "Process payments from your tablet.",
//
//						},
//						new TextCell {
//							Text = "Quickly and securely."
//						}
//					},
//					new TableSection () {
//						new ImageCell {
//							ImageSource = "http://a4.mzstatic.com/us/r30/Purple4/v4/02/8d/e2/028de2c0-0a91-9e68-0b61-5a7f7fae4577/icon175x175.png"
//						}
//					},
//					new TableSection () {
//						new TextCell {
//							Text = "Please enter your Username and Password to sign in"
//						},
//						new ViewCell {
//							View = new StackLayout {
//								Orientation = StackOrientation.Vertical,
//								Children =
//								{
//									usernameEntry,
//									passwordEntry
//								}
//							}
//						}
//					},
//					new TableSection () {
//						new ViewCell {
//							View = new StackLayout {
//								Orientation = StackOrientation.Horizontal,
//								Children =
//								{
//									new Button {
//										Text = "Forgot Password",
//										BorderWidth = 1
//									},
//									new Button {
//										Text = "Sign In",
//										BorderWidth = 1
//									}
//								}
//							}
//						}
//					}
//				}
//			};
//		}
//	}