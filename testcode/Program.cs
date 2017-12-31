using System;
using System.Data.Entity.Design;
namespace testcode
{


    public static class  plural {
/// <summary>
/// Returns the plural form of the specified word.
/// </summary>
/// <param name="count">How many of the specified word there are. A count equal to 1 will not pluralize the specified word.</param>
/// <returns>A string that is the plural form of the input parameter.</returns>
public static string ToPlural(this string @this, int count = 0)
    {
        return count == 1 ? @this : System.Data.Entity.Design.PluralizationServices.PluralizationService.CreateService(new System.Globalization.CultureInfo("en-US")).Pluralize(@this);
    }

}
    class person {

        public person(string n)
        {
            name = n;
        }
        string name { get; set; }
     public   string talk()
        {
            Console.WriteLine( "hi my name is " + name);
            return name;
        }


    }

    class teacher: person
    {
        string author;
      public  teacher(string nam) : base(nam){
            author = nam;
        }
     public  string write()
        {
            Console.WriteLine("hi i am teacher " + author);
            return "book of ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //----Pluralize words
            for (int i = 1; i < 20; i++)
            {
                Console.Write("Please type in a word that you would like pluralized... ");
                string theWord = Console.ReadLine();

                Console.WriteLine(theWord + " in plural form is " + theWord.ToPlural());
            }
            Console.ReadLine();  //keeps console screen paused and displayed until user presses a key

            ///===================================
            return;
            Console.WriteLine("Hello World!");
            // factor();
            
            person dude = new person("dude");
            person larry = new teacher("larry");
            teacher henry = new teacher("henry");
            teacher sue = new teacher("sue");
            teacher sue2 = new teacher("sure2");
            dude.talk();
            larry = (teacher)larry;

            sue = (teacher)larry; //downcasting base to derived class - ok because base object  was defined as derived class
            sue2 = (teacher)dude;  //downcasting fails
            sue.write();
            sue2.write();

            henry.write();
          


            LongestWord();
        }

        public static void LongestWord()
        {
            Console.WriteLine("Enter a sentence...");
            string sen = Console.ReadLine();

            // code goes here  
            /* Note: In C# the return type of a function and the 
               parameter types being passed are defined, so this return 
               call must match the return type of the function.
               You are free to modify the return type. */

            int x = 0;
            int p = 0;
            int longest= 0;
            String[] ary1 = sen.Split();

            for(int i=0;i< ary1.Length ; i++)
            {
                x = ary1[i].Length;
                p = ary1[longest].Length;
                if (x > p) { longest = i; } ;

                Console.WriteLine("Word #"+i+" is "+ ary1[i].ToString() +"  (" + x + " chars) ");
               

            }
           
            Console.WriteLine("Done!  Longest word is " + ary1[longest].ToString() + "  (" + ary1[longest].Length + " chars) ");
            Array.Sort(ary1);
            Array.Sort(ary1);
            Console.WriteLine("Array sort : the longest word is " + ary1[0].ToString() + "  (" + ary1[0].Length + " chars) ");

            Console.Read();
        }


        static void factor()
        {
            Console.WriteLine("Type an integer:");
            string line = Console.ReadLine(); // Read string from console
            int value;
            if (int.TryParse(line, out value))
            {
                                
            long sum = 1;

                for (int i = 1; i <= value; i++)
                 {
                

                 sum = sum * i;
                 Console.WriteLine("i=" + i + "    sum=" + sum);
                }

                Console.WriteLine(" done!" + "  Factor sum=" + sum + "   press to exit...");
                Console.ReadKey();
            }

        }
    }
}
