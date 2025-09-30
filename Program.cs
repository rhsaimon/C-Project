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

}*/


using System;
namespace gentle
{
	class Program
	{
		static void Main(string[] args)
		{
			// string concatenation:

			// string firstName = "Robiul Hasan";
			// string lastName = "Saimon";
			// string fullName = firstName + " " +lastName;
			// Console.WriteLine(fullName);


			// string firstName = "Robiul Hasan";
			// string lastName = "Saimon";
			// string fullName = string.Concat(firstName, " " ,lastName);
			// Console.WriteLine(fullName);

			// string interpolation:

			// string firstName = "Robiul Hasan";
			// string lastName = "Saimon";
			// string fullName = $"The full name is: {firstName}{" "}{lastName}";
			// Console.WriteLine(fullName);

			// access strings: for index no,

			// string myString = "Robiul Hasan Saimon";
			// Console.WriteLine(myString[13]);
			// Console.WriteLine(myString.IndexOf("H"));

			string myString = "Robiul Hasan Saimon";
			int charPos = myString.IndexOf("S");
			string lastName = myString.Substring(charPos);
			Console.WriteLine(lastName);



		}
	}

}