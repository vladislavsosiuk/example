using System;
using Android.App;
using Android.Views;
using StartAJob;
using StartAJob.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomCustomEntryRenderer))]

namespace StartAJob.Droid
{
	public class CustomCustomEntryRenderer:EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if (this.Control == null) return;

			this.Control.SetPadding(10, 30, PaddingRight, PaddingBottom);
			this.Control.Background = this.Resources.GetDrawable(Resource.Drawable.EntryWithColorBorderAndRadius);
		}
	}

	
}
