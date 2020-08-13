namespace Core
{
	using System;
	using System.Text;
	public static class PhonewordTranslator
	{
		public static String ToNumber(String text)
		{
			if (String.IsNullOrWhiteSpace(text))
				return String.Empty;

			var newNumber = new StringBuilder();
			foreach (Char character in text.ToUpperInvariant())
			{
				if (numericCharacters.Contains(character))
				{
					newNumber.Append(character);
				}
				else
				{
					var result = TranslateToNumber(character);
					if (result != null)
						newNumber.Append(result);
				}
				// otherwise we've skipped a non-numeric char
			}
			return newNumber.ToString();
		}
		static Int32? TranslateToNumber(Char character)
		{
			for (Int32 index = 0; index < letters.Length; index++)
			{
				if (letters[index].Contains(character))
					return numbers[index];
			}
			return null;
		}
		#region Fields
		#endregion
		static readonly String[] letters = { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
		static readonly String numericCharacters = " -0123456789";
		static readonly Int32[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9 };
	}
}