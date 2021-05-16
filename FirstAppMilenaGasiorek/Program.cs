using System;

namespace FirstAppMilenaGasiorek
{
    class Program
    {
        static void Main(string[] args)
        {
           // numberOperations();     
           // simpleCalculator();
            table();
           
            Console.ReadKey();
           
            Person person = new Person { FirstName = "Milena", LastName = "Gasiorek" };
            Console.WriteLine(person.FirstName + " " + person.LastName);

            Console.ReadKey();



        }

        private static void numberOperations()
        {

            try
            {
                Console.WriteLine("Podaj pierwsza liczbe");
                float firstNumber = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj druga liczbe");
                float secondNumber = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj działanie ktore chcesz wykonac (+/-/:/*)");
                char operation = char.Parse(Console.ReadLine());
                float result = 0;
                switch (operation)
                {
                    case '+':
                        result = firstNumber + secondNumber;
                        break;

                    case '-':

                        result = firstNumber - secondNumber;
                        break;
                    case '/':
                        if (secondNumber != 0)
                        {

                            result = firstNumber / secondNumber;
                        }

                        break;

                    case '*':
                        result = firstNumber * secondNumber;
                        break;

                    default:

                        Console.WriteLine(firstNumber + secondNumber);
                        break;

                }
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Podana wartosc nie jest prawidlowa");
            }
        }

        private static void simpleCalculator()
        {

            char finishMarker = 'n';

            do
            {
                numberOperations();

                Console.WriteLine("Czy zakończyc działanie kalkulatora [y/n]");
                finishMarker = char.Parse(Console.ReadLine());

            } while (finishMarker != 'y');

           // Console.ReadKey();
        }


        private static void table()
        {


            try
            {
                Console.WriteLine("Podaj rozmiar tablicy");
                int tableSize = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj maksymalna wartosc jaka moze byc przechowywana w komorkach tablicy");
                int tableMaxValue = int.Parse(Console.ReadLine());

                int[] myTable = new int[tableSize];
                generateRandomValueTable(tableSize, tableMaxValue, myTable); 
                printTableElements(myTable);
                Console.WriteLine("A teraz posortujemy: ");
                bubbleSort(myTable);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Podana wartosc nie jest prawidlowa");
            }

        }

        private static void generateRandomValueTable(int tableSize, int tableMaxValue, int[] myTable)
        {
            Random random = new Random();

            for (int i = 0; i < tableSize; i++)
            {

                myTable[i] = random.Next(tableMaxValue);
            }
        }

        private static void printTableElements(int[] myTable)
        {
            foreach (var item in myTable)
            {

                Console.WriteLine($"{item} ");
            }
            Console.ReadKey();
        }


        private static void bubbleSort(int [] myTable)
        {
         
            int notSorted = 0;
            do
            {

             notSorted = 0;

                for (int i = 0; i < myTable.Length - 1; i++)
                {
                    if (myTable[i] > myTable[i + 1])
                    {

                        int tmp = myTable[i];
                        myTable[i] = myTable[i + 1];
                        myTable[i + 1] = tmp;
                        notSorted = 1;
                    }


                }
            } while (notSorted==1);

            printTableElements(myTable);
            Console.ReadKey();

        }



    }
}
