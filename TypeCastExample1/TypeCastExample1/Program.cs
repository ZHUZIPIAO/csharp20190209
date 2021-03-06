﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace TypeCastExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iSize = sizeof(int);
            Console.WriteLine("int형바이트길이 : {0}", iSize);

            Type myType1 = typeof(int);
            Console.WriteLine("typeof(int) : {0}", myType1);

            int i = 10;
            Type myType2 = i.GetType();
            Console.WriteLine("i.GetType() : {0}", myType2);

            int j = 99;
            Console.WriteLine("Size of j {0}", Marshal.SizeOf(j));
        }
    }
}
