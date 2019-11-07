using System;
using static System.Console;

namespace SearchArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listNames = { "Charlie", "Shar", "Kodos", "Henry", "Fred", "Gates", "Abby" };
            int[] ages = { 5, 12, 24, 19, 12, 10, 13 };

            int findAge = -1;
            string inputName = ReadLine();

            for(int i = 0; i < listNames.Length; ++i)
            {
                if(inputName == listNames[i])
                {
                    findAge = ages[i];
                    i = listNames.Length;
                }
            }

            if(findAge == -1)
            {
                WriteLine("Name does not exist");
            } else
            {
                WriteLine("{0} age is: {1}", inputName, findAge);
            }
            
        }
    }
}
