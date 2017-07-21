
using System;
using System.Text;

namespace Chractor
{

    class  Program
    {
        static void Main(string[] args)
        {
            bool quit = false;

            while (!quit)
            {
                DisplayMenu(); //UI 
                quit = Task();  //start
            }
        }
        public static bool Task()
        {
            bool quit = false;
            int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(Insert_Tab(4)); 
                        Console.WriteLine("Type first ascii value: then return key");
                        int start = int.Parse(Console.ReadLine());
                        Console.WriteLine("Type second ascii value: then return key");
                        int end = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        GenerateCharacters(start, end);
                        break;
                    case 2:
                        Console.WriteLine(Insert_Tab(4));
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Print_Ascii_Table();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red; Console.Clear();
                        Console.WriteLine("Quitting Application!");
                        quit = true;
                        break;
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine(Repeat(' ',6)+"Invalid Input, Try again!");
            }
   
            return quit;
        }

        public static void GenerateCharacters(int min, int max)
        {
         
            for (int i = min; i <= max; i++)
            {
                // Get ASCII character.
                char c = (char)i;
                Console.WriteLine("Unicode value of"+Repeat(' ',1)+i+ Repeat(' ', 1) +"is"+Repeat(' ',1)+c);
               
            }
           
        }
        public static void Print_Ascii_Table()
        {
            Console.Write("Decimal".PadRight(10));
            Console.Write("ASCII".PadRight(10));
            Console.Write("Hex".PadRight(10));
            Console.WriteLine();
            int start = 0;
            int end = 150;
            for (int i = start; i < end; i++)
            {
                // Get ASCII character.
                char c = (char)i;

                // Get display string.
                string display = string.Empty;
                if (char.IsWhiteSpace(c))
                {
                    display = c.ToString();
                    switch (c)
                    {
                        case '\t':
                            display = "\\t";
                            break;
                        case ' ':
                            display = "space";
                            break;
                        case '\n':
                            display = "\\n";
                            break;
                        case '\r':
                            display = "\\r";
                            break;
                        case '\v':
                            display = "\\v";
                            break;
                        case '\f':
                            display = "\\f";
                            break;
                    }
                }
                else if (char.IsControl(c))
                {
                    display = "control";
                }
                else
                {
                    display = c.ToString();
                }
                // Write table row.
                Console.Write(i.ToString().PadRight(10));
                Console.Write(display.PadRight(10));
                Console.Write(i.ToString("X2"));
                Console.WriteLine();

            }
        }


        public static void DisplayMenu()
        {
            Console.SetWindowSize(
    Math.Min(90, Console.LargestWindowWidth),
    Math.Min(60, Console.LargestWindowHeight));
            Console.WriteLine(Insert_Tab(5));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Insert_Tab(3) + "WELCOME TO Charactor" + Insert_Tab(2));
            Console.WriteLine();
            Console.WriteLine(Insert_Tab(1) + "ASCII equivalent Character Generator In C#");
            Console.WriteLine(Repeat(' ', 10));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press 1 to Find Unicode Equivalent");
            Console.WriteLine(Insert_Tab(4));
            Console.WriteLine("Press 2 to Print Unicode Chracter Table For First 128 characters");
            Console.WriteLine(Insert_Tab(4));
            Console.WriteLine(Insert_Tab(4));
            Console.WriteLine("Press 3 to Quit");

        }
        public static string Repeat(char c, int count)
        {
            return new string(c, count);
        }
        public static string Insert_Tab(int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append("\t");

            }
            return sb.ToString();
        }
        public static string Insert_NewLine(int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
