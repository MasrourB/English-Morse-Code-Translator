using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace MorseCode
{
	public class Translator
	{
		Dictionary<char, string> translator;
		
		
		public Translator ()
		{
			//A dictionary of every alphanumeric symbol and it's equivalent in Morse Code
			translator = new Dictionary<char, string>();
			//Add every alphanumeric symbol with it's Morse Code equivalent to the dictionary
			translator.Add('A', "·-");
			translator.Add('B', "-···");
			translator.Add('C', "-·-·");
			translator.Add('D', "-··");
			translator.Add('E', "·");
			translator.Add('F', "··-.");
			translator.Add('G', "--·");
			translator.Add('H', "····");
			translator.Add('I', "··");
			translator.Add('J', "·---");
			translator.Add('K', "-·-");
			translator.Add('L', "·-··");
			translator.Add('M', "--");
			translator.Add('N', "-·");
			translator.Add('O', "---");
			translator.Add('P', "·--·");
			translator.Add('Q', "--·-");
			translator.Add('R', "·-·");
			translator.Add('S', "···");
			translator.Add('T', "-");
			translator.Add('U', "··-");
			translator.Add('V', "···-");
			translator.Add('W', "·--");
			translator.Add('X', "-··-");
			translator.Add('Y', "-·--");
			translator.Add('Z', "--··");
			translator.Add('1', "·----");
			translator.Add('2', "··---");
			translator.Add('3', "···--");
			translator.Add('4', "····-");
			translator.Add('5', "·····");
			translator.Add('6', "-····");
			translator.Add('7', "--···");
			translator.Add('8', "---··");
			translator.Add('9', "----·");
			translator.Add('0', "-----");
		}
		//Character to Morse Code Method
		private string ConvertCharacter(char ch)
		{
			
			if (translator.Keys.Contains (ch)) 
				return translator [ch];
			else
				return string.Empty;
		}
		
		//Word to Morse Code Method (This program builds off of ConvertCharacter)
		private string ConvertWord(string word)
		{
			StringBuilder phrase = new StringBuilder (); //We use StringBuilder here because we will need to keep changing the string
			
			foreach (char character in word) {

				//Add the converted chracter to the phrase
				phrase.Append(ConvertCharacter(character));
			}//Code repeats until the entire word is converted

			return phrase.ToString();//Return the converted word
		}
		
		//Text to Morse Code Method (This program builds off of ConvertWord)
		public string ConvertText(string text)
		{
			string[] words = text.ToUpper ().Split (' '); //Change the text to all capitals and split by spaces for each word
			StringBuilder phrase = new StringBuilder();

			foreach (String s in words) {
				//if (phrase.Length != 0) 
					//phrase.Append ("/");
				phrase.Append (ConvertWord (s));
			}
			return phrase.ToString ();
		}
		
	}
}

