using System;

namespace MUKAYUHI
{
    class program
    {
       public static void Main(string[] args)
        
        {
            double first_number,second_number,sum,operation;

         Console.WriteLine("enter first number");
       first_number = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("enter second number");
       second_number = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("enetr your operation");
       operation = Convert.ToInt32(Console.Read());
        
        
  if (operation == '-'){
    Console.WriteLine("the subtraction of {0} and {1} equal {2}", first_number - second_number);
    Console.ReadKey();
}
else if (operation == '*'){
    Console.WriteLine("the sum of {0} and {1} equal {2}", first_number * second_number);
    Console.ReadKey();
}
else if (operation == '/'){
    Console.WriteLine("the sum of {0} and {1} equal {2}", first_number / second_number);
    Console.ReadKey();
}

else if (operation == '+'){
    Console.WriteLine("the subtraction of {0} and {1} equal {2}", first_number + second_number);
    Console.ReadKey();
}
else {
    Console.WriteLine("invald choice");
    Console.ReadKey();
}
        }
    }}


