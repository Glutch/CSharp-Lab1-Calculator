using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            int memoryValue = 0;

            Console.WriteLine("Welcome to Calculator");
            Console.WriteLine("Please select an option from 1-7");

            void PrintMenuOptions() {
                Console.WriteLine("");
			    Console.WriteLine("---- MENU ----");
                Console.WriteLine("1. Sum numbers");
                Console.WriteLine("2. Multiply numbers");
                Console.WriteLine("3. Sum all values");
                Console.WriteLine("4. Save value to memory");
                Console.WriteLine("5. Clear memory");
                Console.WriteLine("6. Print memory");
                Console.WriteLine("7. Exit program");
            }

            int GetUserInput()
            {
                bool valid = false;
                int userValue = 0;

                while (!valid) {
                    if (Int32.TryParse(Console.ReadLine(), out userValue))
                    {
                        valid = true;
                        return userValue;
                    } else {
                        Console.WriteLine("You did not enter a number");
                    }
                }

                return userValue;
            }

            void SumNumbers() {
                Console.WriteLine("[Sum numbers]");
                Console.WriteLine("Insert first number: ");
                int firstNumber = GetUserInput();
                Console.WriteLine("Insert second number: ");
                int secondNumber = GetUserInput();
                int sum = firstNumber + secondNumber;
                Console.WriteLine("The sum is: " + sum);
            }

            void MultiplyNumbers() {
                Console.WriteLine("[Multiply numbers]");
                Console.WriteLine("Insert first number: ");
                int firstNumber = GetUserInput();
                Console.WriteLine("Insert second number: ");
                int secondNumber = GetUserInput();
                int sum = firstNumber * secondNumber;
                Console.WriteLine("The sum is: " + sum);
            }

            void SumAllValues() {
                Console.WriteLine("[Sum all values from first to last]");
                Console.WriteLine("Insert first number: ");
                int firstNumber = GetUserInput();
                Console.WriteLine("Insert second number: ");
                int secondNumber = GetUserInput();
                int sum = 0;
                for (int i = firstNumber; i <= secondNumber; i++) {
                    sum += i;
                }
                Console.WriteLine("The sum is: " + sum);
            }

            void SaveValueToMemory() {
                Console.WriteLine("Insert number to save to memory");
                memoryValue = GetUserInput();
            }

            void ClearMemory() {
                Console.WriteLine("Memory is cleared");
                memoryValue = 0;
            }

            void PrintMemory() {
                Console.WriteLine("Memory: " + memoryValue);
            }

            while (active) {
                PrintMenuOptions();
                int menuOption = GetUserInput();

                switch (menuOption) {
                    case 1:
                        SumNumbers();
                        break;
                    case 2:
                        MultiplyNumbers();
                        break;
                    case 3:
                        SumAllValues();
                        break;
                    case 4:
                        SaveValueToMemory();
                        break;
                    case 5:
                        ClearMemory();
                        break;
                    case 6:
                        PrintMemory();
                        break;
                    case 7:
                        Console.WriteLine("Program will exit");
                        active = false;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}
