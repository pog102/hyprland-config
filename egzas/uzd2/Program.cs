using System.IO;
using System.Text;
namespace egazas
{
    class Program
    {
	static void Main(string[] args)
	{
		string zod="999919 ,,,, adasdgj 23 159 1987 53a13, asd 1j2 asd 100003b";
		string s = " .,\"'!?";
		apdoroti(zod,s);

	}

	static void apdoroti(string sak, string s)
	{
		 StringBuilder nauja = new StringBuilder();

		 string skaic = "";
		 char[] skyr = s.ToCharArray();
		 string[] zodziai = sak.Split(skyr, StringSplitOptions.RemoveEmptyEntries);
		 for (int i = 0; i < zodziai.Length; i++)
		 {
			 if(zodziai[i].All(char.IsDigit) && (zodziai[i].Length > skaic.Length))
			 {
			 skaic=zodziai[i];

			 }
		     
		 }
		 
		 int ind=sak.IndexOf(skaic);
		 if(ind != 0){
			nauja.Append(sak.Substring(0,ind-1)); // starting point
			nauja.Append(sak.Substring(ind+skaic.Length)); // end point
		 }
		 else
		 {
			nauja.Append(sak.Substring(skaic.Length+1)); // starting point
		 }
		 nauja.Append(" "+skaic); // add text to the end
		 Console.WriteLine(nauja);
	}
    }
}
