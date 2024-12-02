namespace assignment_5._1._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number, remainder, reverseNumber = 0, temp;

			Console.Write("Enter a number : ");
			number = int.Parse(Console.ReadLine());
			temp = number;
			bool isPalindrome = true;
			bool isNotPalindrome = false;


			while (number > 0)
			{
				remainder = number % 10; //Process to get the remainder of the number  
				reverseNumber = (reverseNumber * 10) + remainder; //Create the reverse number  
				number = number / 10;  //Reduce the number for the next iteration  
			}

			if (temp == reverseNumber)
			{
				Console.WriteLine(isPalindrome);
			}
			else if (number.ToString().Contains("-"))
			{
				Console.WriteLine(isNotPalindrome);
				Console.WriteLine("A negative number will never be a palindrome.");
			}
			else
			{
				Console.Write(isNotPalindrome);
			}








			//	Console.WriteLine("Enter a number:"); 
			//	string input = Console.ReadLine(); 
			//	if (IsPalindrome(input)) 
			//	{
			//		Console.WriteLine("The number is a palindrome."); 
			//	}
			//	else if (IsPalindrome(input.ToString.Contains("-"))
			//	else 
			//	{ 
			//		Console.WriteLine("The number is not a palindrome."); 
			//	}
			//}
			//static bool IsPalindrome(string number)
			//{
			//	char[] charArray = number.ToCharArray(); 
			//	Array.Reverse(charArray); 
			//	string reversedNumber = new string(charArray); 
			//	return number == reversedNumber;
		}
		
	}
}

