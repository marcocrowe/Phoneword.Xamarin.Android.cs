namespace Phoneword
{
	using Android.App;
	using Android.OS;
	using Android.Widget;
	using Core;
	using System;
	[Activity(Label = "Phone Word", MainLauncher = true, Icon = "@drawable/icon")]
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
			EditText phoneNumberTextEditText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
			String translatedNumber = PhonewordTranslator.ToNumber(phoneNumberTextEditText.Text);

			TextView translatedPhoneWordTextView = FindViewById<TextView>(Resource.Id.TranslatedPhoneWord);
			translatedPhoneWordTextView.Text = String.IsNullOrWhiteSpace(translatedNumber) ? String.Empty : translatedNumber;
		}
	}
}