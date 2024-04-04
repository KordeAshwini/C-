//Date difference
	using System;  
	using System.Collections.Generic;  
	using System.Text;  
	  
	namespace Console_DateTime  
	{  
	    class Program  
	    {  
	        static void Main(string[] args)  
	        {  
	            System.DateTime dtTodayNoon = new System.DateTime(2018, 9, 13, 12, 0, 0);  
	            System.DateTime dtTodayMidnight = new System.DateTime(2018, 9, 12, 0, 0, 0);  
	            System.TimeSpan diffResult = dtTodayNoon.Subtract(dtTodayMidnight);  
	            Console.WriteLine($"Yesterday Midnight - Today Noon = {diffResult.Days}");  
	            Console.WriteLine($"Yesterday Midnight - Today Noon = {diffResult.TotalDays}");  
	            Console.ReadLine();  
	        }  
	    }  
	}