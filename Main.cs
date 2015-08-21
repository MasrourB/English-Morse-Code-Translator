using System;

namespace MorseCode
{
	class MainClass
	{
		static void Main(string[] args){
			Translator translator = new Translator(); //Initiate a Translator object
			string phrase; //The phrase string that will contain our converted Morse Code string
			
			
			Console.WriteLine ("Enter a phrase to convert to Morse Code");
			phrase = Console.ReadLine ();
			
			if (phrase.Length != 0) { //If the string is of a valid length convert it to Morse Code
				string morsePhrase = translator.ConvertText (phrase);
				Console.WriteLine (morsePhrase); //Print out the converted morse code
			} else
				Console.WriteLine ("Invalid Phrase!"); //Deals with the case if the user inputted an empty string
		}
	}
}
