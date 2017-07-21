
using System;
using System.Text;

namespace Charactor
{

   sealed class  Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
           
            SetWindowSize();
            Startup_Animate();
            SetDesignElements();
            while (!quit)
            {
                ShowMenu(); //UI 
                quit = Task();  //start
            }
        }
        public static bool Task()
        {
         private  bool quit = false;
         private  int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(Insert_Tab(4)); 
                        Console.WriteLine("Type start ascii value: then return key");
                        int start = int.Parse(Console.ReadLine());
                        Console.WriteLine("Type end ascii value: then return key");
                        int end = int.Parse(Console.ReadLine());
                        GenerateCharacters(start, end);
                        break;
                    case 2:
                        Console.WriteLine(Insert_Tab(4));
                        Print_Ascii_Table();
                        break;

                    case 3:
                        Warning("Quitting Application!");
                        Console.WriteLine();
                        quit = true;
                        break;
                }
            }
            catch
            {
                
               Warning("Invalid Input, Try again!");
            }
   
            return quit;
        }

        public static void GenerateCharacters(int min, int max)
        {
            string display = string.Empty;
            for (int i = min; i <= max; i++)
            {
                // Get ASCII character.
                char c = (char)i;
                Console.WriteLine("Unicode value of"+Repeat(' ',1)+i+ Repeat(' ', 1) +"is"+Repeat(' ',1)+c);
                display += c;
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


        public static void ShowMenu()
        {
            Console.WriteLine(Insert_Tab(5));
            Console.WriteLine(Insert_Tab(3) + "WELCOME TO Charactor" + Insert_Tab(2));
            Console.WriteLine();
            Console.WriteLine(Insert_Tab(1) + "ASCII equivalent Character Generator In C#");
            Console.WriteLine(Repeat(' ', 10));
            Console.WriteLine("Press 1 to Find Unicode Equivalent");
            Console.WriteLine(Insert_Tab(4));
            Console.WriteLine("Press 2 to Print Unicode Chracter Table For First 128 characters");
            Console.WriteLine(Insert_Tab(4));
            Console.WriteLine(Insert_Tab(4));
            Console.WriteLine("Press 3 to Quit");

        }
       public static SetWindowSize()
       {
        for (int i = 1; i <60; i++)
            {
                Console.SetWindowSize(i, i);
                System.Threading.Thread.Sleep(50);
            }
       }
       public static Startup_Animate()
       {
         string LoadingText = "Loading...";
            string TitleBarText = "";
            bool Loading = true;

            Console.Title = TitleBarText;

            while (Loading)
            {
                for (int i = 0; i < LoadingText.Length; i++)
                {
                    TitleBarText = TitleBarText + LoadingText[i];
                    Console.Title = TitleBarText;
                    Thread.Sleep(240);
                }
                TitleBarText = "";
            }
            Console.Read();
         
       }
      public static void SetDesignElements()
      {
        Console.BackgroundColor = ConsoleColor.White;
           Console.ForegroundColor=ConsoleColor.Magenta;
            Console.Clear();
             string TitleText = "";
         TitleText=@"
  ______  __    __       ___      .______          ___       ______ .___________.  ______   .______      
 /      ||  |  |  |     /   \     |   _  \        /   \     /      ||           | /  __  \  |   _  \     
|  ,----'|  |__|  |    /  ^  \    |  |_)  |      /  ^  \   |  ,----'`---|  |----`|  |  |  | |  |_)  |    
|  |     |   __   |   /  /_\  \   |      /      /  /_\  \  |  |         |  |     |  |  |  | |      /     
|  `----.|  |  |  |  /  _____  \  |  |\  \----./  _____  \ |  `----.    |  |     |  `--'  | |  |\  \----.
 \______||__|  |__| /__/     \__\ | _| `._____/__/     \__\ \______|    |__|      \______/  | _| `._____|";
         
      }
        public static string Repeat(char c, int count)
        {
            return new String(c, count);
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
      static void Warning(string message)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(message);
    Console.ResetColor();
}
    }
}
