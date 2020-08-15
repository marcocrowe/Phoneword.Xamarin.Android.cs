namespace Phoneword
{
	using Android.App;
	using Android.OS;
	using Android.Widget;
	using Core;
	using System;
	[Activity(Label = "Phoneword", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceStateBundle)
		{
			base.OnCreate(savedInstanceStateBundle);

			SetContentView(Resource.Layout.Main);

			Button translateButton = FindViewById<Button>(Resource.Id.TranslateButton);
			translateButton.Click += new EventHandler(this.TranslateButton_Click);
		}
		private void TranslateButton_Click(Object sender, EventArgs eventArgs)
		{
			EditText phoneNumberInputEditText = FindViewById<EditText>(Resource.Id.PhoneNumberInputEditText);
			String translatedNumber = PhonewordTranslator.ToNumber(phoneNumberInputEditText.Text);

			TextView translatedPhoneWordTextView = FindViewById<TextView>(Resource.Id.TranslatedPhoneWordTextView);
			translatedPhoneWordTextView.Text = String.IsNullOrWhiteSpace(translatedNumber) ? String.Empty : translatedNumber;
		}
	}
}