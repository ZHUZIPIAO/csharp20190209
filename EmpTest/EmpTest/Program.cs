﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Emp
{
    public int id; public string name;
}

namespace EmpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp e; e.id = 1; e.name = "1길동";
            Console.WriteLine("사번 : {0}", e.id);
            Console.WriteLine("이름 : {0}", e.name);

            Emp e1 = new Emp(); // new 하더라도 스택에저장된다.
            e1.id = 2; e1.name = "2길동";
            Console.WriteLine("사번: {0}", e1.id);
            Console.WriteLine("이름 : {0}",e1.name);

        }
    }
}
