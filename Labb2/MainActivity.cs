
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Labb2
{
	[Activity(Label = "Labb2", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button newEventButton = FindViewById<Button>(Resource.Id.newEventButton);
			Button showAllEventsButton = FindViewById<Button>(Resource.Id.showAllEventsButton);
			Button createRapportsButton = FindViewById<Button>(Resource.Id.createReportsButton);

			newEventButton.Click += delegate
			{
				ClickToNewEvent();
			};


		}

		private void ClickToNewEvent()
		{
			Intent i = new Intent(this, typeof(NewEventActivity));
			StartActivity(i);
		}
	}
}

