//Bitwise operators
using System;

namespace OperatorsAppl {

   class Program {
   
      static void Main(string[] args) {
         int a = 60;            /* 60 = 0011 1100 */ 
         int b = 13;            /* 13 = 0000 1101 */
         int c = 0; 
         
         c = a & b;             /* 12 = 0000 1100 */ 
         Console.WriteLine("Line 1 - Value of c is {0}", c );
         
         c = a | b;             /* 61 = 0011 1101 */
         Console.WriteLine("Line 2 - Value of c is {0}", c);
         
         c = a ^ b;             /* 49 = 0011 0001 */
         Console.WriteLine("Line 3 - Value of c is {0}", c);
         
         c = ~a;                /*-61 = 1100 0011 */
         Console.WriteLine("Line 4 - Value of c is {0}", c);
         
         c = a << 2;      /* 240 = 1111 0000 */
         Console.WriteLine("Line 5 - Value of c is {0}", c);
         
         c = a >> 2;      /* 15 = 0000 1111 */
         Console.WriteLine("Line 6 - Value of c is {0}", c);
         Console.ReadLine();
      }
   }
}