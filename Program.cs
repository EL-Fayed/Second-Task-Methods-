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
                    AddNumber(list);
                    break;
                case 'C':
                case 'c':
                    ClearList(ref list);
                    break;
                case 'P':
                case 'p':
                    PrintNumbers(list);
                    break;
                case 'M':
                case 'm':
                    DisplayMean(list);
                    break;
                case 'S':
                case 's':
                    SmallestNumber(list);
                    break;
                case 'L':
                case 'l':
                    LargestNumber(list);
                    break;
                case 'G':
                case 'g':
                    SortNumberASC(list);
                    break;
                case 'j':
                case 'J':
                    SortNumberDESC(list);
                    break;
                case 'q':
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
        }
        static void AddNumber(List<int> List)
        {
            if (true)
            {

                Console.Write("Enter the number : ");
                int number = Convert.ToInt32(Console.ReadLine());
                bool duplicate = false;
                for (int i = 0; i < List.Count; i++)
                {
                    if (List[i] == number)
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    List.Add(number);
                    Console.Write($"The number {number} was added successfully.");
                }
                else
                    Console.WriteLine("The number is already exist in the list.");
            }
            else
                Console.WriteLine("Please Enter a valid number");

        }
        static void ClearList(ref List<int> list)
        {
            if (list.Count > 0)
            {
                list = new List<int>();
                Console.WriteLine("The list is cleared successfully.");
            }
            else
                Console.WriteLine("The List is Empty");
        }
        static void PrintNumbers(List<int> list)
        {
            if (list.Count > 0)
            {
                Console.Write("[ ");
                for (int j = 0; j < list.Count; j++)
                    Console.Write($" {list[j]} ");
                Console.Write(" ]");
            }
            else
                Console.WriteLine("The list is empty.");
        }
        static void DisplayMean(List<int> list)
        {
            if (list.Count > 0)
            {
                int sum = 0;
                for (int j = 0; j < list.Count; j++)
                    sum += list[j];
                Console.WriteLine($"The mean of numbers is : {sum / list.Count}");
            }
            else
                Console.WriteLine("The List is empty");
        }
        static void SmallestNumber(List<int> list)
        {
            if (list.Count > 0)
            {
                int min = list[0]; int max = list[0];
                for (int j = 1; j < list.Count; j++)
                    if (list[j] < min)
                        min = list[j];
                Console.WriteLine($"The Smallest number is : {min}");
            }
            else
                Console.WriteLine("The List is Empty");
        }
        static void LargestNumber(List<int> list)
        {
            if (list.Count > 0)
            {
                int max = list[0];
                for (int j = 1; j < list.Count; j++)
                    if (list[j] > max)
                        max = list[j];
                Console.WriteLine($"The Largest number is : {max}");
            }
            else
                Console.WriteLine("The List is Empty");
        }
        static void SortNumberASC(List<int> list)
        {
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i] > list[j])
                        {
                            int swap = list[i];
                            list[i] = list[j];
                            list[j] = swap;
                        }
                    }
                }
                Console.Write("[ ");
                for (int k = 0; k < list.Count; k++)
                    Console.Write($" {list[k]} ");
                Console.Write(" ]");
            }
            else
                Console.WriteLine("The List is Empty");
        }
        static void SortNumberDESC(List<int> list)
        {
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                        if (list[i] < list[j])
                        {
                            int swap = list[i];
                            list[i] = list[j];
                            list[j] = swap;
                        }
                }
                Console.Write("[ ");
                for (int k = 0; k < list.Count; k++)
                    Console.Write($" {list[k]} ");
                Console.Write(" ]");
            }
            else
                Console.WriteLine("The List is Empty");
        }
            static void Main(string[] args)
            {
                List<int> listOfNumber = new List<int>();
                char selection;
                do
                {
                    ChooseMenu();
                    selection = Convert.ToChar(Console.ReadLine());
                    MethodsOfSelection( ref listOfNumber, selection);
                } while (selection != 'Q' && selection != 'q');


                Console.ReadLine();
            }
        }
    }