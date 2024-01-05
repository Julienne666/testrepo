using System.Reflection;

namespace HomeWork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

            int[] userArray = program.GetArrayWithUserInputLenght();

            program.FillArrayRandomNumbers(userArray, 1, 27);

            foreach (int number in userArray)
            {
                Console.Write(number);
                Console.Write(" ");
            }

            (int[] oddArray, int[] evenArray) = program.SplitIntoOddAndEven(userArray);

           var oddLettersArray = program.ReplaceNumbersWithLetters(oddArray);

           var evenLettersArray = program.ReplaceNumbersWithLetters(evenArray);

           program.UppercaseSpecificLetters(oddLettersArray);

           program.UppercaseSpecificLetters(evenLettersArray);

           program.DisplayArrayWithMoreUppercaseLetters(oddLettersArray, evenLettersArray);

            Console.WriteLine();
            foreach (char number in oddLettersArray)
            {
                Console.Write(number);
                Console.Write(" ");
            }

            Console.WriteLine();
            foreach (char number in evenLettersArray)
            {
                Console.Write(number);
                Console.Write(" ");
            }
        }

        private void DisplayArrayWithMoreUppercaseLetters(char[] oddLettersArray, char[] evenLettersArray)
        {
            var uppercaseOddLetterCounter = 0;
            foreach (char letter in oddLettersArray)
                if (char.IsUpper(letter))
                {
                    uppercaseOddLetterCounter++;
                }

            var uppercaseEvenLetterCounter = 0;
            foreach (char letter in evenLettersArray)
                if (char.IsUpper(letter))
                {
                    uppercaseEvenLetterCounter++;
                }

            if (uppercaseOddLetterCounter > uppercaseEvenLetterCounter)
            {
                Console.WriteLine("\nOdd is the best");
            }
            else if (uppercaseOddLetterCounter < uppercaseEvenLetterCounter)
            {
                Console.WriteLine("\nEven is the best");
            }
            else 
            {
                Console.WriteLine("\nNo Winner yet");
            }
        }

        private void UppercaseSpecificLetters(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 'a' || array[i] == 'e' || array[i] == 'i' || array[i] == 'd' || array[i] == 'h' || array[i] == 'j')
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
        }

        private char[] ReplaceNumbersWithLetters(int[] array)
        {
            char[] result = new char[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i] + 96;
                char letter = (char) number;
                result[i] = letter;
            } 
            
            return result;
        }

        private ValueTuple<int[], int[]> SplitIntoOddAndEven(int[] userArray)
        {
            var oddNumberCounter = 0;
            foreach (int number in userArray)
            {
                if (number % 2 != 0) 
                {
                oddNumberCounter++;
                }
            }

            int[] oddArray = new int[oddNumberCounter];
            int[] evenArray = new int[userArray.Length - oddNumberCounter];

            int oddIndex = 0;
            int evenIndex = -1;
            foreach (int number in userArray)
            {
                if ((number % 2) != 0)
                {
                    oddArray[oddIndex++] = number;
                } 
                else
                {
                    evenArray[++evenIndex] = number;
                }
            }

            return new ValueTuple<int[], int[]>(oddArray, evenArray);
        }

        private int[] GetArrayWithUserInputLenght()
        {
            Console.WriteLine("Hello! Enter a number ");
            var input = Console.ReadLine();
            int arrayLenght = int.Parse(input);
            return new int[arrayLenght];
        }

        private void FillArrayRandomNumbers(int[] array, int minValue, int maxValue) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(minValue, maxValue);
            }
        }
    }
}
