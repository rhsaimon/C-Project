/*
using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int x, y, z, a;
			x = y = z = a = 55;
			Console.WriteLine(x + y + z + a);
		}
	}
}

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 55, y = 55, z = 55, a = 55;
			Console.WriteLine(x + y + z + a);
;
			
		}
	}
}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{

			int number = 55;
			double decimalNumber = 55.55;
			string text = "saimon";
			char character = 's';
			bool boolean = true;
			Console.WriteLine(number + " " + decimalNumber + " " + text + " " + character + " " + boolean)
;

		}
	}
}




using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = 234234;
			long longNumber = 2342343234545565666;
			Console.WriteLine(number);
			Console.WriteLine(longNumber)
			float myNum = 5.75F;
			Console.WriteLine(myNum);
			double mynum = 19.99D;
			Console.WriteLine(mynum);


		}
	}
}
*/


/*
using System;
using System.CodeDom.Compiler;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 5;
			int b = 10;
			int sum = a + b;
			Console.WriteLine("The sum of " + a + " and " + b + " is: " + sum);
			

			
		}
	}
}


		}
	}
}

type casting:


implicit casting:
using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 4;
			double b = a;
			Console.WriteLine(b);

		}
	}
}

explicit casting:

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			double a = 4.55;
			int b = (int)a;
			Console.WriteLine(b);
			
		}
	}
}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int myInt = 22;
			double myDouble = 22.66;
			bool myBool = false;
			char myChar = 's';
			string myString = "saimon";
			Console.WriteLine(Convert.ToDouble(myInt));
			Console.WriteLine(Convert.ToInt32(myDouble));
			Console.WriteLine(Convert.ToString(myBool));
			Console.WriteLine(Convert.ToString(myChar));
			Console.WriteLine(Convert.ToChar(myString));	
		}
	}
}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your name:");
			string name = Console.ReadLine();
			Console.WriteLine("Hello " + name);
			

			
		}
	}
}



using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your number:");
			int number = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Your number is: " + number);
			

			
		}
	}
}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 5;
			int b = 10;
			int sum = a + b;
			Console.WriteLine("The sum of " + a + " and " + b + " is: " + sum);
			

			
		}
	}
}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			if (50 > 10)
			{
				Console.WriteLine("50 is greater than 10");
			}
			else
			{
				Console.WriteLine("50 is not greater than 10");
			}
			
		}
	}

}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			if (50 > 10)
			{
				Console.WriteLine("50 is greater than 10");
			}
			else
			{
				Console.WriteLine("50 is not greater than");

			}
		}
	}
}



using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{


			Console.WriteLine(Math.Min(33, 55));
			Console.WriteLine(Math.Max(33, 55));
			
			
			
		}
	}

}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine(Math.Sqrt(64));
		
		}
	}

}



using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine(Math.Abs(-54545));

		}
	}

}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine(Math.Round(5.55));

		}
	}

}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			string keyword = "Hello Mother Fucker";
			Console.WriteLine(keyword);
		}
	}

}



using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{

			string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			Console.WriteLine("the length of the text is:"+" "+txt.Length);

			string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			Console.WriteLine($"length of the text is: {txt.Length}"); *string interpolation

			string txt = "fjsklfjjkSNSSDJkjkkjGHGYU";
			Console.WriteLine(txt.ToUpper());
			Console.WriteLine(txt.ToLower());
		

		}
	}

}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			// string concatenation:.....................

			// string firstName = "Robiul Hasan";
			// string lastName = "Saimon";
			// string fullName = firstName + " " +lastName;
			// Console.WriteLine(fullName);


			// string firstName = "Robiul Hasan";
			// string lastName = "Saimon";
			// string fullName = string.Concat(firstName, " " ,lastName);
			// Console.WriteLine(fullName);

			// string interpolation:.......................

			// string firstName = "Robiul Hasan";
			// string lastName = "Saimon";
			// string fullName = $"The full name is: {firstName}{" "}{lastName}";
			// Console.WriteLine(fullName);

			// access strings: for index no,......................

			// string myString = "Robiul Hasan Saimon";
			// Console.WriteLine(myString[13]);
			// Console.WriteLine(myString.IndexOf("H"));

			// string myString = "Robiul Hasan Saimon";
			// int charPos = myString.IndexOf("S");
			// string lastName = myString.Substring(charPos);
			// Console.WriteLine(lastName);

			//string spesial characters:.............

			// string txt = "\\'Vikings\\' ";
			// Console.WriteLine(txt);

			// string txt = "It\'s \nalright.";
			// Console.WriteLine(txt);

			// string txt1 = "i\'m \tSaimon";
			// Console.WriteLine(txt1);
			
			// string txt1 = "i\'m \bSaimon";
			// Console.WriteLine(txt1);
			

		}
	}

}

// Boolean:

using System;
using System.Drawing;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			// int a = 44;
			// int b = 55;
			// Console.WriteLine(a != b);

			// int myAge = 25;
			// int votingAge = 18;
			// Console.WriteLine(myAge >= votingAge);

			// if else statement:.......................

			// int myAge = 25;
			// int votingAge = 18;
			// if (myAge >= votingAge)
			// {
			// 	Console.WriteLine("Old enough to vote!");

			// }
			// else
			// {
			// 	Console.WriteLine("Not old enough to vote.");


			// if (44 >= 55)
			// {
			// 	Console.WriteLine("44 is less than or equal to 55");
			// }
			// else
			// {
			// 	Console.WriteLine("44 is not less than or equal to 55");
			// }

			if (44 <= 55)
			{
				Console.WriteLine("44 is less than or equal to 55");
			}
			else if(44==55)
			{
				Console.WriteLine("44 is equal to 55");
			}
			else
			{
				Console.WriteLine("44 is not less than or equal to 55");
			}
		}
	}

}

// Switch statement:....................

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int month = 7;
			switch (month)
			{
				case 1:
					Console.WriteLine("January");
					break;
				case 2:
					Console.WriteLine("February");
					break;
				case 3:
					Console.WriteLine("March");
					break;
				case 4:
					Console.WriteLine("April");
					break;
				case 5:
					Console.WriteLine("May");
					break;
				case 6:
					Console.WriteLine("June");

					break;
				case 7:
					Console.WriteLine("July");
					break;
				case 8:
					Console.WriteLine("August");
					break;
				default:
					Console.WriteLine("Not a valid month");
					break;

				
			}

		}
	}

}


// while loop:..............
using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0;
			while (i < 7)
			{
				Console.WriteLine(i);
				i++;
			}

			
		}
	}
}

// do while loop:..............

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0;
			do
			{
				Console.WriteLine(i);
				i++;
			}
			while (i < 5);
			
		}
	}
}


// for loop:..............

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			// for (int i = 0; i < 5; i++)
			// {
			// 	Console.WriteLine(i);

			// }

			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine(i);
			}
			
		}
	}
}

// nested for loop:..............
using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 2; i++)
			{
				Console.WriteLine("Outer loop: " + i); 

				for (int j = 1; j <= 3; j++)
				{

					Console.WriteLine("inner loop:" + j);
				}

			}
		}
	}
}

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 2; i++)
			{
		
				for (int j = 1; j <= 3; j++)
				{
					Console.WriteLine($"i = {i}, j = {j}");
				}
			}
		}
	}
}

//foreach loop:..............
using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] names = { "Robiul", "Hasan", "Sainmon" };
			foreach (string name in names)
			{
				Console.WriteLine(name);
				}
			
		}
	}
}

// break statement:..............
					
using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
			{
				if (i == 4)
				{
					break;
				}
				Console.WriteLine(i);
			}
		}
	}
}

// continue statement:..............
using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
			{
				if (i == 4)
				{
					continue;
				}
				Console.WriteLine(i);
			}
		}
	}
}

// break and continue statement in while loop:..............
using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0;
			while (i <= 10)
			{

				if (i == 5)
				{
					i++;
					continue;

				}
				Console.WriteLine(i);
				i++;
			}

			// int i = 0;
			// while (i <= 10)
			// {
			// 	Console.WriteLine(i);
			// 	i++;


			// 	if (i == 5)
			// 	{
			// 		break;

			// 	}

			// }
		}
	}
}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			string Name = "12345";

			int sum = 0;
			for (int i = 0; i < Name.Length; i++)
			{
				sum = sum + Name[i] - '0';	
			}
			 Console.WriteLine(sum);
		
			
		}
	}
}

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 3;
			for (int i = 1; i <= 10; i++)
			{
				int a = n * i;
				Console.WriteLine(a);
			}
		
		}
	}
}

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 5;
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= n - i; j++)
				{
					Console.Write(" ");					
				}
				for (int s = 1; s <= i; s++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

		}
	}
}

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			string word = "Programming";
			int cnt = 0;
			for (int i = 0; i < word.Length; i++)
			{
				if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
				{
					cnt += 1;
				}

			}
			Console.WriteLine(cnt);
		}
		
				
	}
}


// using System;
// namespace gentle
// {
// 	class Program
// 	{
// 		static void Main(string[] args)
// 		{
// 			int i = 1;
// 			int n = 20;
// 			while (i <= n)
// 			{
// 				if (i % 2 == 0)
// 				{
// 					Console.WriteLine(i);

// 				}
// 				i++;


// 			}

// 		} 
		
				
// 	}
// }

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 10;
			int i = 1;
			while (i <= n)
			{
				Console.WriteLine("5 * "+ i+ " = " + i*5);
				i++;
			}
		
		} 
		
				
	}
}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			string Num = "1234";
			int cnt = 0;
			int i = 1;
			while (i <= Num.Length)
			{
				cnt = i;
				i++;
			}
			Console.WriteLine(cnt);
		
		} 
		
				
	}
}

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			int Num = 123;
			int i = 0;
			int reverse = 0;
			while (i < Num)
			{
				int digit = Num % 10;
				reverse = (reverse * 10) + digit;
				Num = Num / 10;
				

			}
			Console.WriteLine(reverse);
		} 
		
				
	}
}


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			string n = "868";
			int sum = 1;
			int i = 0;
			while (i < n.Length)
			{
				sum  *= n[i] - '0';
				i++;
			}
			Console.WriteLine(sum);
		} 
		
				
	}
}*/

using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			string n = "1221";
			int i = 0;
			int p = n.Length;
			bool flag = false;
			while (i <= p)
			{
				if (n[i] == n[p - 1] && n[i + 1] == n[p - 2])
				{
					flag = true;
					i++;
				}
			}
			if (flag) {
				Console.WriteLine("palindrome");
			}
			else {
				Console.WriteLine("not Palindrome");
			}
		
		} 
		
				
	}
}

