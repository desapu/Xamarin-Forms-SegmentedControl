using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SegmentedControl
{	
	public partial class SamplePage : ContentPage
	{	
		public SamplePage ()
		{
			InitializeComponent ();

			sgControl.SelectedSegmentIndex = 1;  // Index start from 0, so 1 menas 2nd segment of the SegmentedControl
			sgControl.ValueChanged+= (object sender, EventArgs e) => System.Diagnostics.Debug.WriteLine("I pressed "+sgControl.SelectedValue.ToString());
		}
	}
}

