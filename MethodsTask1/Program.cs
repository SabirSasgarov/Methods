using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace MethodsTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region task1
			//Console.WriteLine("Eded daxil edin: ");
			//int number = int.Parse(Console.ReadLine());
			//Console.WriteLine(Power(number));
			#endregion

			#region task2
			//int[] numbers = { 5, 4, 7, 8, 15 };
			//Powers(numbers);
			#endregion

			#region task3
			//Console.WriteLine("String daxil edin: ");
			//string a = Console.ReadLine();
			//Console.WriteLine(Spaces(a));
			#endregion

			#region task4
			//int[] nums = [1,3,7];
			//int a = 5;
			//int[] newNums=ArrayNewElement(nums,a);
			//foreach (var num in newNums)
			//	Console.Write(num+" ");
			#endregion

			#region task5
			//Console.WriteLine("Eded daxil edin: ");
			//int n = int.Parse(Console.ReadLine());
			//BolunmeSadeMurekkeb(n);
			#endregion

			#region task6
			//int n = 5;
			//int m = 100;
			//TekEdedSayiVeCemi(n,m);
			#endregion

			#region task7
			//int[] numbers = [1,5,4,8,6,2,0,9];
			//CutEdedlerinCemi(numbers);
			#endregion

			//Previous tasks

			#region task1
			//int[] numbers = [5,4,8,7];
			//int[] newNumbers=ToPowerArr(numbers);
			//foreach (int number in newNumbers)
			//	Console.Write(number+" ");
			#endregion

			#region task2
			//int[] numbers = { 5, 4, 7, 8, 15 };
			//RemoveMin(numbers);
			#endregion

			#region task3
			//Console.WriteLine("String daxil edin: ");
			//string a = Console.ReadLine();
			//TekSimvol(a);
			#endregion

			#region task4
			//int n = 100;
			//int m = 200;
			//IsPalindrome(n,m);
			#endregion

			#region task5
			//string str = "salam sagol";
			//EnCoxTekrarlanan(str);
			#endregion

			#region task6
			//string strr = "salam adas sagol";
			//Console.WriteLine(DeleteSpaces(strr));
			#endregion

			#region task7
			//string str = "salam masin masinka";
			//Console.WriteLine("Axtardiginiz herfi daxil edin: ");
			//char axtarilan = char.Parse(Console.ReadLine());
			//Console.WriteLine(HowManyLetter(str,axtarilan));
			#endregion
			
		}
		static int Power(int a)
        {
            return a * a;
        }
		static void Powers(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] *= arr[i];
				Console.Write($"{arr[i]} ");
			}
		}
		static string Spaces(string str)
		{
			string newStr="";
			foreach (char s in str)
			{
				if (s != ' ')
					newStr += s;
			}
			return newStr;
		}
		static int[] ArrayNewElement(int[] arr, int x)
		{
			int[] newArr = new int[arr.Length + 1];
			for(int i=0; i<arr.Length; i++)
			{
				newArr[i] = arr[i];
			}
			newArr[arr.Length] = x;
			return newArr;
		}
		static void BolunmeSadeMurekkeb(int n)
		{
			//ededin bolunmesi
			if (n % 3 == 0 && n % 7 == 0)
				Console.WriteLine($"{n} ededi 3 ve 7-e tam bolunur.");
			else if (n % 3 ==0)
				Console.WriteLine($"{n} ededi tekce 3-e tam bolunur.");
			else if (n % 7 == 0)
				Console.WriteLine($"{n} ededi tekce 7-e tam bolunur.");
			else
				Console.WriteLine($"{n} ededi 3 ve 7-e bolunmur");
			//sade murekkeb yoxlamasi
			int count = default;
			for (int i=2; i <= n/2;i++)
			{
				if (n % i == 0)
					count++;
				if (count > 0)
				{
					Console.WriteLine("Eded murekkebdir.");
					break;
				}
			}
			if(count==0)
				Console.WriteLine("Eded sadedir");
		}
		static void TekEdedSayiVeCemi(int n, int m)
		{
			int count = default;
			int sum = 0;
			for (int i = n; i <= m; i++)
			{
				if (i % 2 != 0)
				{
					count++;
					sum += i;
				}
			}
			Console.WriteLine($"{n} ve {m} ededleri arasindaki ededlerin sayi=> {count}; \ncemi=>{sum}.");
		}
		static void CutEdedlerinCemi(int[] numbers)
		{
			int sum = default;
			foreach (int number in numbers)
			{
				if (number % 2 == 0)
					sum += number;
			}
			Console.WriteLine($"Cut ededlerin cemi: {sum}");
		}
		static int[] ToPowerArr(int[] arr)
		{
			int[] newArr = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
				newArr[i] = arr[i] * arr[i];
			return newArr;
		}
		static void RemoveMin(int[] arr)
		{
			int min = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{
				if (min > arr[i])
					min = arr[i];
			}
			foreach (int a in arr)
			{
				if(min!=a)
					Console.Write(a+" ");
			}
		}
		static void TekSimvol(string str)
		{
			char letter = ' ';
			int count;
			foreach (char c in str)
			{
				count = 0;
				letter = c;
				foreach (char ch in str)
				{
					if (letter == ch)
						count++;
				}
				if (count == 1)
					break;
			}
			Console.WriteLine(letter);
		}
		static void IsPalindrome(int n, int m)
		{
			for (int i = n; i <= m; i++)
			{
				int newNumber = default;
				int temp = i;
				while (temp > 0)
				{
					newNumber = newNumber * 10 + temp % 10;
					temp /= 10;
				}
				if (i == newNumber)
					Console.WriteLine($"{i} is palindrome");
			}
		}
		static void EnCoxTekrarlanan(string word)
		{
			char letter = ' ';
			int count = default;
			int newCount;
			foreach (char c in word)
			{
				newCount = 0;
				foreach (char ch in word)
				{
					if (c == ch)
						newCount++;
				}

				if (newCount > count)
				{
					letter = c;
					count = newCount;
				}
			}
			Console.WriteLine($"{letter} {count} defe tekrarlanib.");
		}
		static string DeleteSpaces(string str)
		{
			string newString = "";
			foreach(char ch in str){
				if (ch != ' ')
					newString += ch;
			}
			return newString;
		}
		static int HowManyLetter(string str,char a)
		{
			int count = default;
			foreach (char s in str)
			{
				if (s == a)
					count++;
			}
			return count;
		}






	}
}
