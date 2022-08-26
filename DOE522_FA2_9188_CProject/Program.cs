using System;

namespace DOE522_FA2_9188_CProject
{
    class SearchReplace
    {
        //Method 1
        public int searchSubstring(string normalS, string searchS)
        {
            //search for the correct string
            int search = normalS.IndexOf(searchS);
            return search;
        }
        //Method 2
        public void ReplaceSubString(string normalS, string replacer, string f)
        {
            //replace the old string
            string newStr = normalS.Replace(f, replacer);

            Console.WriteLine("Your new string is: " + newStr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SearchReplace sr = new SearchReplace();

            //Ask for input string
            Console.Write("Please enter a string: ");
            string inputString = Console.ReadLine();

            //Ask for input to search for certain string
            Console.Write("Please enter the substring you wish to find: ");
            string inputSub = Console.ReadLine();

            //Search for the string
            int found = sr.searchSubstring(inputString, inputSub);

            //Input for the character replacement
            Console.Write("Please enter a character to replace the given substring: ");
            string inputChar = Console.ReadLine();

            //Replace string with character
            sr.ReplaceSubString(inputString, inputChar, inputSub);
            Console.ReadKey();
        }
    }
}
