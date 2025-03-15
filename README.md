ده تعديل ع الكود باستخدام int بدل من ال void ف الكود 
مم تقيمني ع ده برضه ولو فيه غلطات مستني ردك عليها ان شاء الله عشان استفيد اكتر 
شكرا :)
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task
{
    internal class Program
    {
        static void ChooseMenu()
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("C - Clear the list");
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("G -Sort the number ASC");
            Console.WriteLine("J-Sort the number DESC");
            Console.WriteLine("Q - Quit");
            Console.Write("Enter your choice: ");
        }
        static void MethodsOfSelection(ref List<int> list, char selection)
        {
            switch (selection)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Enter the number : ");
                    int number = AddNumber(list);
                    Console.Write($"The number {number} was added successfully.");

                    break;
                case 'C':
                case 'c':
                    ConditionalStatement(list);
                    ClearList(ref list);
                    Console.WriteLine("The list is cleared successfully.");
                    break;
                case 'P':
                case 'p':
                    ConditionalStatement(list);
                    PrintNumbers(list);
                    break;
                case 'M':
                case 'm':
                    ConditionalStatement(list);
                    int mean = DisplayMean(list);
                    Console.WriteLine($"The mean of numbers is : {mean}");
                    break;
                case 'S':
                case 's':
                    ConditionalStatement(list);
                    int min = SmallestNumber(list);
                    Console.WriteLine($"The Smallest number is : {min}");
                    break;
                case 'L':
                case 'l':
                    ConditionalStatement(list);
                    int max = LargestNumber(list);
                    Console.WriteLine($"The Largest number is : {max}");
                    break;
                case 'G':
                case 'g':
                    ConditionalStatement(list);
                    list = SortNumberASC(list);
                    PrintNumbers(list);
                    break;
                case 'j':
                case 'J':
                    ConditionalStatement(list);
                    list = SortNumberDESC(list);
                    PrintNumbers(list);
                    break;
                case 'q':
                case 'Q':
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
        }
        static int AddNumber(List<int> List)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            bool duplicate = false;
            for (int i = 0; i < List.Count; i++)
                if (List[i] == number)
                {
                    duplicate = true;
                    break;
                }
            if (!duplicate)
                List.Add(number);
            return number;
        }
        static List<int> ClearList(ref List<int> list)
        {
            if (list.Count > 0)
                list = new List<int>();
            return list;
        }
        static void PrintNumbers(List<int> list)
        {
            Console.Write("[ ");
            for (int k = 0; k < list.Count; k++)
                Console.Write($" {list[k]} ");
            Console.Write(" ]");
        }
        static int DisplayMean(List<int> list)
        {
            int sum = 0;
            int mean;
            if (list.Count > 0)
                for (int j = 0; j < list.Count; j++)
                    sum += list[j];
            mean = sum / list.Count;
            return mean;
        }
        static int SmallestNumber(List<int> list)
        {
            int min = 0;
            if (list.Count > 0)
                min = list[0]; int max = list[0];
            for (int j = 1; j < list.Count; j++)
                if (list[j] < min)
                    min = list[j];
            return min;
        }
        static int LargestNumber(List<int> list)
        {
            int max = 0;
            if (list.Count > 0)
            {
                max = list[0];
                for (int j = 1; j < list.Count; j++)
                    if (list[j] > max)
                        max = list[j];
            }
            return max;
        }
        static List<int> SortNumberASC(List<int> list)
        {
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                    for (int j = i + 1; j < list.Count; j++)
                        if (list[i] > list[j])
                        {
                            int swap = list[i];
                            list[i] = list[j];
                            list[j] = swap;
                        }
            }
            return list;
        }
        static List<int> SortNumberDESC(List<int> list)
        {
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                    for (int j = i + 1; j < list.Count; j++)
                        if (list[i] < list[j])
                        {
                            int swap = list[i];
                            list[i] = list[j];
                            list[j] = swap;
                        }
            }
            return list;
        }
        static void ConditionalStatement(List<int> list)
        {
            if (list.Count <= 0)
                Console.WriteLine("The list is empty.");

        }
        static void Main(string[] args)
        {
            List<int> listOfNumber = new List<int>();
            char selection;
            do
            {
                ChooseMenu();
                selection = Convert.ToChar(Console.ReadLine());
                MethodsOfSelection(ref listOfNumber, selection);
            } while (selection != 'Q' && selection != 'q');
            Console.WriteLine("Good Bye");
            Console.ReadLine();
        }
    }
}
