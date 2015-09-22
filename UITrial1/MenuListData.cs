using System;
using Xamarin.Forms;
using System.Collections.Generic;

public class MenuListData : List<MenuItem>
{
	public MenuListData ()
	{
		this.Add (new MenuItem () { 
			Title = "Accept Payment", 
			IconSource = "pay.png", 
			TargetType = typeof(AcceptPayPage)
		});

		this.Add (new MenuItem () { 
			Title = "Transaction History", 
			IconSource = "history.png", 
			TargetType = typeof(ContractsPage)
		});

		this.Add (new MenuItem () { 
			Title = "Settings", 
			IconSource = "settings.png", 
			TargetType = typeof(ContractsPage)
		});

		this.Add (new MenuItem () {
			Title = "Support",
			IconSource = "support.png",
			TargetType = typeof(ContractsPage)
		});
	}
}