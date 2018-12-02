using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp1 = new Emp("", 1, 2, 1);

            Console.WriteLine("Enter your name:");
            emp1.name = Console.ReadLine();
            Console.WriteLine("Enter you id:");
            emp1.id = Convert.ToInt32(Console.ReadLine());

            if ((emp1.name != null) && (emp1.id != null))
            {

                Console.WriteLine("please select type of employment");
                Console.WriteLine("................................");


                Console.WriteLine("1.Montnly employee");
                Console.WriteLine("2.Temorary employee");
                Console.WriteLine("3.Evenning employee");

                emp1.type = Convert.ToInt32(Console.ReadLine());

                if (emp1.type == 1)
                {

                    emp1.salary(emp1.gross);

                }

                else if (emp1.type == 2)
                {

                    emp1.salary(emp1.hours, emp1.hour_salary);

                }


                else if (emp1.type == 3)
                {


                    emp1.salary(emp1.hours, emp1.hour_salary, emp1.bonus, emp1.net_before_bonus);


                }

                else Console.WriteLine(" invalid type of employment");




                Console.ReadLine();
            }

            else Console.WriteLine(" ivalid ID or name");

        }

        class Emp
        {
            public string name;
            public int id;
            public int type;
            public int gross;
            public int net;
            public int hours;
            public int hour_salary;


            public int gross1;
            public int bonus;
            public int net_before_bonus;




            public Emp(string aName, int aId, int atype, int aGross)

            {
                name = aName;
                id = aId;
                type = atype;
                gross = aGross;


            }


            public void salary(int gross)
            {






                Console.WriteLine("please inter montly salary");

                gross = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("employee name : " + name);
                Console.WriteLine("employee ID : " + id);
                Console.WriteLine("type of  employement : Montly employement");
                Console.WriteLine("gross salary: " + gross);
                Console.WriteLine("net salary " + (gross - (gross * 21) / 100));








            }


            public void salary(int hours, int hour_salary)
            {

                Console.WriteLine("Please inter your total  number of hours you work");
                hours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please inter your each hour salary");

                hour_salary = Convert.ToInt32(Console.ReadLine());


                gross = (hours * hour_salary);
                net = (gross - (gross * 18) / 100);

                Console.WriteLine("employee name : " + name);
                Console.WriteLine("employee ID : " + id);
                Console.WriteLine("type of  employement : Temporay employement");
                Console.WriteLine("total number of hours: " + hours);
                Console.WriteLine("hour salary: " + hour_salary);
                Console.WriteLine("Gross salary: " + gross);
                Console.WriteLine("net salary" + net);

            }

            public void salary(int nights, int hour_salary, double bonus, int net_before_bonus)
            {
                Console.WriteLine("please Enter  your total number of hours ");
                hours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please Enter  your one  hour salry ");

                hour_salary = Convert.ToInt32(Console.ReadLine());
                gross = (hours * hour_salary);
                bonus = ((gross * 0.15) / 100);


                net_before_bonus = (gross - ((gross * 18) / 100));
                net = Convert.ToInt32(net_before_bonus + bonus);


                Console.WriteLine("employee name : " + name);
                Console.WriteLine("employee ID : " + id);
                Console.WriteLine("type of  employement : evening employment");
                Console.WriteLine("total number of hours: " + hours);
                Console.WriteLine("hour salary: " + hour_salary);
                Console.WriteLine("Gross salary: " + gross);
                Console.WriteLine("net salary: " + net);




            }

        }
    }


}




