
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Labb2
{
	[Activity(Label = "NewEventActivity")]
	public class NewEventActivity : Activity
	{
        Button dateButton;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.NewEvent);
            dateButton = FindViewById<Button>(Resource.Id.dateButton);

        }
        private void DateSelect_OnClick(object sender, EventArgs eventArgs)
        {
            DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (DateTime time)
            {
                dateButton.Text = time.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ"));
            });
            frag.Show(FragmentManager, DatePickerFragment.TAG);
        }
    }
}
