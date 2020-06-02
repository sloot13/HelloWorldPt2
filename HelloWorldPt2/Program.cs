using System;

namespace HelloWorldPt2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("What is your name?");
             string name = Console.ReadLine();
             Console.WriteLine("Hello " + name);

             Console.WriteLine("What is the length");
             int length = int.Parse(Console.ReadLine());
             Console.WriteLine("What is the width");
             int width = int.Parse(Console.ReadLine());
             Console.WriteLine("Rectangle area is " + length * width);

             Console.WriteLine("How many miles did you drive?");
             int miles = int.Parse(Console.ReadLine());
             Console.WriteLine("How much gas in gallons did you use?");
             int gas = int.Parse(Console.ReadLine());
             Console.WriteLine("Your MPG is " + miles/gas + "mpg");
             

            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            alice = alice.ToLower();
           Console.WriteLine("What are you looking for?");
            string search = Console.ReadLine();
            search = search.ToLower();
            int index = alice.IndexOf(search);
            bool foundIt = false;
            string found = "Not Found";

            if (index >= 0) 
            {
                foundIt = true;
                found = alice.Substring(index, search.Length);
            }
            
            Console.WriteLine(foundIt);
            Console.WriteLine(found);
            if (foundIt)
            {
                Console.WriteLine(alice.Substring(0, index) + alice.Substring(index + search.Length, alice.Length - index - search.Length));
            }


        }
    }
}
