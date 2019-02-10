using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex92P
{

    class OnjOutTest
    {
        static void FillArray1(out int[] arr)
        {
            arr = new int[3] { 5919,4790,4791};
        }


        static void FillArray2(ref int[] arr)
        {
            if (arr == null)
            {
                arr = new int[3];
            }
            arr[0] = 1111; arr[1] = 2222;
        }



        static void Main(string[] args)
        {
            int[] onjArray;
            FillArray1(out onjArray);

            Console.WriteLine("배열(out parameter):");

            for(int i=0; i<onjArray.Length; i++)
            {
                Console.WriteLine(onjArray[i] + " ");
            }
            Console.WriteLine("Press Any Key to Next"); Console.ReadKey();
            FillArray2(ref onjArray);
            //배열출력
            Console.WriteLine("배열(ref parameter) : ");
            for (int i = 0; i < onjArray.Length; i++) { Console.Write(onjArray[i] + " "); }
            Console.WriteLine("Press Any Key to Next"); Console.ReadKey();
            FillArray2(ref onjArray);

        }
    }
}
