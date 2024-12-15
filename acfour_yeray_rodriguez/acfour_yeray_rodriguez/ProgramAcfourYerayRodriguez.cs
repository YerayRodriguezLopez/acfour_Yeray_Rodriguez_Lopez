using System.Runtime.CompilerServices;

namespace Acfour
{
    public class ProgramAcfourYerayRodriguez
    {
        const string AskArrayLength = "Introdueix quants numeros vols introduir";
        const string NatNumErr = "El numero a de ser natural";
        const string InvalidErr = "Valor no valid, ha de ser un numero natural";
        const string LargeErr = "El numero es massa llarg";
        const string Result = "Aquest son els teus numeros";
        const string Ordered = " ordenats";
        const int Zero = 0;
        const int One = 1;
        public static void Main()
        {
            Console.WriteLine(AskArrayLength);
            int[] myArray = new int[GetNatNum()];
            FillArray(myArray);
            Console.WriteLine(Result);
            PrintArray(myArray);
            QuickSortDescending(myArray, Zero, myArray.Length - 1);
            Console.WriteLine(Result + Ordered);
            PrintArray(myArray);
        }
        public static int GetNatNum()
        {
            int userNum = 0;
            bool flag = false;
            while (flag)
            {
                try
                {
                    userNum = int.Parse(Console.ReadLine());
                    if (IsNatNum(userNum))
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine(NatNumErr);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(InvalidErr);
                }
                catch (OverflowException)
                {
                    Console.WriteLine(LargeErr);
                }
            }
            return userNum;
        }
        public static bool IsNatNum(int userNum) { return userNum > Zero && userNum % One == Zero; }
        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = GetNatNum();
            }
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (!(i == array.Length)) { Console.Write(","); }
            }
        }
        public static void QuickSortDescending(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);

                QuickSortDescending(array, low, pivotIndex - One);  // Sort the left part
                QuickSortDescending(array, pivotIndex + One, high); // Sort the right part
            }
        }
        public static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - One;

            for (int j = low; j < high; j++)
            {
                if (array[j] > pivot) // Change condition to ">" for descending order
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + One, high);
            return i + One; // Return the pivot index
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}