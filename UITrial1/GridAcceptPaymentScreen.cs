using System;

using Xamarin.Forms;

public class GridAcceptPaymentScreen : Grid
{
	public GridAcceptPaymentScreen ()
	{

		// Grid Attributes
		RowSpacing = 2;

		RowDefinitions = new RowDefinitionCollection {
			new RowDefinition { Height = new GridLength(60) },	// Row 0-1
			new RowDefinition { Height = new GridLength(30) },	// Row 1-2
			new RowDefinition { Height = new GridLength(30) },	// Row 2-3
			new RowDefinition { Height = new GridLength(30) },	// Row 3-4
			new RowDefinition { Height = new GridLength(30) },	// Row 4-5
			new RowDefinition { Height = new GridLength(30) },	// Row 5-6
			new RowDefinition { Height = new GridLength(30) },	// Row 6-7
			new RowDefinition { Height = new GridLength(30) },	// Row 7-8
			new RowDefinition { Height = new GridLength(30) },	// Row 8-9
			new RowDefinition { Height = new GridLength(30) },	// Row 9-10
			new RowDefinition { Height = new GridLength(10) },	// Row 10-11
			new RowDefinition { Height = new GridLength(30) },	// Row 11-12
			new RowDefinition { Height = new GridLength(30) },	// Row 12-13
			new RowDefinition { Height = new GridLength(30) },	// Row 13-14
			new RowDefinition (),	// Row 14-15
		};
		ColumnDefinitions = new ColumnDefinitionCollection {
			new ColumnDefinition { Width = new GridLength (10) },	// Column 0-1
			new ColumnDefinition (),								// Column 1-2
			new ColumnDefinition (),								// Column 2-3
			new ColumnDefinition (),								// Column 3-4
			new ColumnDefinition (),								// Column 4-5
			new ColumnDefinition (),								// Column 5-6
			new ColumnDefinition { Width = new GridLength (10) },	// Column 6-7

		};

		Picker pickerBillType = new Picker {
			
		};
		pickerBillType.Items.Add("Tax Payment");
		pickerBillType.Items.Add("Late Fees");

		var lblBillType = new Label {
			Text = "Bill Type"
		};
		var lblFirstName = new Label {
			Text = "First Name",
			VerticalOptions = LayoutOptions.End
		};
		var lblMiddleName = new Label {
			Text = "Middle",
			VerticalOptions = LayoutOptions.End
		};
		var lblLastName = new Label {
			Text = "Last Name",
			VerticalOptions = LayoutOptions.End
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
			Text = "Amount to Pay",


		};

		var entryBillType = new Entry ();
		var entryFirstName = new Entry ();
		var entryMiddleName = new Entry ();
		var entryLastName = new Entry ();
		var entryAddress = new Entry ();
		var entryCity = new Entry ();
		var entryState = new Entry ();
		var entryZip = new Entry ();
		var entryPhone = new Entry ();
		var entryEmail = new Entry ();
		var entryParcelNo = new Entry ();
		var entryTaxYear = new Entry ();
		var entryAmtToPay = new Entry {
			Placeholder = "$ US Dollars"
		};

		Button buttonMakeCreditPay = new Button {
			Text = "Make Credit Card Payment",
			TextColor = Color.Black,
			BorderColor = Color.Black,
			BorderWidth = 1
		};


		//Bill Type
		Children.Add (lblBillType, 1, 2, 1, 2);
		Children.Add (pickerBillType, 2, 6, 1, 2);
		//F Name, M Name, L Name
		Children.Add (lblFirstName, 1,3,2,3 );
		Children.Add (lblMiddleName,3,4,2,3);
		Children.Add (lblLastName,4,6,2,3);
		Children.Add (entryFirstName,1,3,3,4);
		Children.Add (entryMiddleName,3,4,3,4);
		Children.Add (entryLastName,4,6,3,4);
		// Address
		Children.Add(lblAddress,1,2,4,5);
		Children.Add(entryAddress,2,6,4,5);
		//City
		Children.Add(lblCity,1,2,5,6);
		Children.Add(entryCity,2,6,5,6);
		// State
		Children.Add(lblState,1,2,6,7);
		Children.Add(entryState,2,6,6,7);
		// Zip
		Children.Add(lblZip,1,2,7,8);
		Children.Add(entryZip,2,6,7,8);
		// Phone
		Children.Add(lblPhone,1,2,8,9);
		Children.Add(entryPhone,2,6,8,9);
		//Email
		Children.Add(lblEmail,1,2,9,10);
		Children.Add(entryEmail,2,6,9,10);
		// Parcel
		Children.Add(lblParcelNo,1,2,11,12);
		Children.Add(entryParcelNo,2,6,11,12);


		pickerBillType.SelectedIndexChanged += (sender, args) =>
		{
			string selected = pickerBillType.Items[pickerBillType.SelectedIndex];
			if (selected=="Tax Payments")
			{
				// Tax Yr
				Children.Add(lblTaxYear,1,2,12,13);
				Children.Add(entryTaxYear,2,6,12,13);
			}
		};
		
		// Amount to Pay
		Children.Add(lblAmtToPay,1,2,13,14);
		Children.Add(entryAmtToPay,2,6,13,14);








//		var entryCellBillType = new EntryCell {
//			Label = "Bill Type:",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellFirstName = new EntryCell {
//			Label = "First Name",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellMiddleName = new EntryCell {
//			Label = "Middle",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellLastName = new EntryCell {
//			Label = "Last Name",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellAddress = new EntryCell {
//			Label = "Address",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellCity = new EntryCell {
//			Label = "City",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellState = new EntryCell {
//			Label = "State",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellZip = new EntryCell {
//			Label = "Zip",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellPhone = new EntryCell {
//			Label = "Phone",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellEmail = new EntryCell {
//			Label = "Email",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellParcelNo = new EntryCell {
//			Label = "ParcelNumber",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellTaxYear = new EntryCell {
//			Label = "Tax Year",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//		var entryCellAmtToPay = new EntryCell {
//			Label = "Amount to Pay",
//			Placeholder = "default keyboard",
//			Keyboard = Keyboard.Default
//		};
//
//		TableView tv = new TableView {
//			Intent = TableIntent.Form,
//			Root = new TableRoot ("Accept Payments") {
//				new TableSection () {
//					entryCellBillType,
//					entryCellFirstName,
//					entryCellMiddleName,
//					entryCellLastName,
//					entryCellAddress,
//					entryCellCity,
//					entryCellState,
//					entryCellZip,
//					entryCellPhone,
//					entryCellEmail,
//					entryCellParcelNo,
//					entryCellTaxYear,
//					entryCellAmtToPay
//				}
//			}
//		};
//
//		Children.Add (tv,1, 6, 1, 14);

	}
}