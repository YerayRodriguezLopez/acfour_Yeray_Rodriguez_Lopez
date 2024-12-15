﻿using System.Runtime.CompilerServices;

namespace Acfour
{
    public class ProgramAcfourYerayRodriguez
    {
        const string AskArrayLength = "Introdueix quants numeros vols introduir";
        const string NatNumErr = "El numero a de ser natural";
        const string InvalidErr = "Valor no valid, ha de ser un numero natural";
        const string LargeErr = "El numero es massa llarg";
        const string Result = "Aquest son els teus numeros";
        const int Zero = 0;
        const int Two = 2;
        public static void Main()
        {
            Console.WriteLine(AskArrayLength);
            int[] myArray = new int[GetNatNum()];
            FillArray(myArray);
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
        public static bool IsNatNum(int userNum) { return userNum > Zero && userNum % Two == Zero; }
        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = GetNatNum();
            }
        }
        public static void PrintArray(int[] array)
        {
            Console.WriteLine(Result);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (!(i == array.Length)) { Console.Write(","); }
            }
        }
        static void QuickSortDescending(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);

                QuickSortDescending(array, low, pivotIndex - 1);  // Sort the left part
                QuickSortDescending(array, pivotIndex + 1, high); // Sort the right part
            }
        }
    }
}