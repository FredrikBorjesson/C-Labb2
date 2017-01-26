﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace Labb2
{
	public class DatePickerFragment : DialogFragment, DatePickerDialog.IOnDateSetListener
	{
		// TAG can be any string of your choice.
		public static readonly string TAG = "X:" + typeof(DatePickerFragment).Name.ToUpper();

		// Initialize this value to prevent NullReferenceExceptions.
		Action<DateTime> _dateSelectedHandler = delegate { };

		public IntPtr Handle
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public static DatePickerFragment NewInstance(Action<DateTime> onDateSelected)
		{
			DatePickerFragment frag = new DatePickerFragment();
			frag._dateSelectedHandler = onDateSelected;
			return frag;
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public override Dialog OnCreateDialog(Bundle savedInstanceState)
		{
			DateTime currently = DateTime.Now;
			DatePickerDialog dialog = new DatePickerDialog(Activity,
														   this,
														   currently.Year,
														   currently.Month,
														   currently.Day);
			return dialog;
		}


		public void OnDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth)
		{
			// Note: monthOfYear is a value between 0 and 11, not 1 and 12!
			DateTime selectedDate = new DateTime(year, monthOfYear + 1, dayOfMonth);
			Log.Debug(TAG, selectedDate.ToLongDateString());
			_dateSelectedHandler(selectedDate);
		}
	}
	//the NewInstance method is invoked to instantiate a new DatePickerFragment.This method takes an Action<DateTime>
}
