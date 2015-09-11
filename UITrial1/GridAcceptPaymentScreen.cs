using System;

using Xamarin.Forms;

public class GridAcceptPaymentScreen : Grid
	{
		public GridAcceptPaymentScreen ()
		{

			var lblBillType = new Label {
				Text = "Bill Type"
			};
			var lblFirstName = new Label {
				Text = "First Name"
			};
			var lblMiddleName = new Label {
				Text = "Middle"
			};
			var lblLastName = new Label {
				Text = "Last Name"
			};
			var lblAddress = new Label {
				Text = "Address"
			};
			var lblCity = new Label {
				Text = "City"
			};
			var lblState = new Label {
				Text = "State"
			};
			var lblZip = new Label {
				Text = "Zip"
			};
			var lblPhone = new Label {
				Text = "Phone"
			};
			var lblEmail = new Label {
				Text = "Email"
			};
			var lblParcelNo = new Label {
				Text = "Parcel Number"
			};
			var lblTaxYear = new Label {
				Text = "Tax Year"
			};
			var lblAmtToPay = new Label {
				Text = "Amount to Pay"
			};

			Button buttonMakeCreditPay = new Button {
				Text = "Make Credit Card Payment",
				TextColor = Color.Black,
				BorderColor = Color.Black,
				BorderWidth = 1
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
				new RowDefinition (),	// Row 13-14
				new RowDefinition (),	// Row 14-15
			};
			ColumnDefinitions = new ColumnDefinitionCollection {
				new ColumnDefinition { Width = new GridLength (5) },	// Column 0-1
				new ColumnDefinition (),								// Column 1-2
				new ColumnDefinition (),								// Column 2-3
				new ColumnDefinition (),								// Column 3-4
				new ColumnDefinition (),								// Column 4-5
				new ColumnDefinition (),								// Column 5-6
				new ColumnDefinition { Width = new GridLength (5) },	// Column 6-7

			};
//				Children.Add (lblBillType ,1,2,1,2);


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

		TableView tv = new TableView {
			Intent = TableIntent.Form,
			Root = new TableRoot ("Accept Payments") {
				new TableSection () {
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

		Children.Add (tv,1, 6, 1, 14);

		}
	}