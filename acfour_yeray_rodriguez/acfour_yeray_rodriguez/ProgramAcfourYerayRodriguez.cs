namespace Acfour
{
    public class ProgramAcfourYerayRodriguez
    {
        const string AskArrayLength = "Introdueix quants numeros vols introduir";
        const string NatNumErr = "El numero a de ser natural";
        const string InvalidErr = "Valor no valid, ha de ser un numero natural";
        const string LargeErr = "El numero es massa llarg";
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
                    if (userNum > 0 && userNum % 2 == 0)
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
    }
}