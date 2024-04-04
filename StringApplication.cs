using System;

namespace StringApplication {

   class Program {
   
      static void Main(string[] args) {
         //from string literal and string concatenation
         string fname, lname;
         fname = "Manjusha";
         lname = "Wadekar";
			
         char []letters= { 'H', 'e', 'l', 'l','o' };
         string [] sarray={ "Hello", "From", "BCA", "Department" };
         
         string fullname = fname + lname;
         Console.WriteLine("Full Name: {0}", fullname);
         
         //by using string constructor { 'H', 'e', 'l', 'l','o' };
         string greetings = new string(letters);
         Console.WriteLine("Greetings: {0}", greetings);
         
         //methods returning string { "Hello", "From", "BCA", "Department" };
         string message = String.Join(" ", sarray);
         Console.WriteLine("Message: {0}", message);
         
         //formatting method to convert a value y m d h m s
         DateTime waiting = new DateTime(2020, 10, 10, 17, 58, 1);
         string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
         Console.WriteLine("Message: {0}", chat);
      }
   }
}