using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dayEx3
{
    class EnumPropertyExam

    {

        DayOfWeek _day;

        public DayOfWeek Day

        {

            get

            {

                // 금요일인 경우 예외발생

                if (this._day == DayOfWeek.Friday )
                {

                    throw new Exception("Invalid access");

                }

                return this._day;

            }

            set

            {

                this._day = value;

            }

        }

    }



    class Program

    {

        static void Main()

        {

            EnumPropertyExam example = new EnumPropertyExam();

            example.Day = DayOfWeek.Monday;

            Console.WriteLine(example.Day == DayOfWeek.Monday);

            example.Day = DayOfWeek.Friday;

            Console.WriteLine(example.Day);

        }

    }
}
