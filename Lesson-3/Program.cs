using System;
using System.Globalization;


//namespace Assignment2
//{
//    internal class Program
//{
//        static void Main(string[] args)
{
    Console.WriteLine("please enter your score");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 89 && num <= 100)
    {
        Console.WriteLine("your grade is A");

    }

    else if (num > 79 || num == 89)
    {
        Console.WriteLine("your grade is B");

    }
    else if (num > 69 || num == 79)
    {
        Console.WriteLine("your grade is C");

    }
    else if (num > 59 || num == 69)
    {
        Console.WriteLine("your grade is D");

    }
    else if (num >= 0 || num == 59)
    {
        Console.WriteLine("your grade is E");

    }

    else
    {

        Console.WriteLine("wrong information");
    }
}








//Console.WriteLine("zehmet olmasa 1ci ededi daxil et");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("zehmet olmasa 2ci ededi daxil et");
//int num2=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("zehmet olmasa simvol  daxil et");
//string symbol =Console.ReadLine();

    //    if (symbol == "+")
    //    {
    //        int result = num1+ num2;
    //        Console.WriteLine(num1 + "+" + num2 + "="+ result);
    //    }
    //    else if (symbol == "-")
    //    {

    //        Console.WriteLine(num1 - num2);
    //    }
    //    else if (symbol == "/")
    //    {
    //        Console.WriteLine(num1 / num2);
    //    }

    //    else if (symbol == "*") 
    //    {
    //        Console.WriteLine(num1 * num2);
    //    }
    //    else
    //    {
    //        Console.WriteLine("daxil etdiyiniz yalnishdir");
    //    }
    //}

    //    }
    //}



namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };

            #region
            //int maxNum = numbers[0];
            //foreach (var item in numbers)
            //{
            //    if (item > maxNum)
            //    {
            //        maxNum = item;
            //    }


            //}  Console.WriteLine(maxNum);

            //int minNum = numbers[0];
            //foreach (var item in numbers)
            //{
            //    if (item < minNum)
            //    {
            //        minNum = item;

            //    }
            //}
            //Console.WriteLine(minNum);
            #endregion

            //int sum = 0;

            ////foreach (var item in num)
            ////{
            ////    sum += item;
            ////}

            ////Console.WriteLine(sum); 
            ///
           







            #region 

            //int count = 0;
            //foreach (var item in num)

            //{
            //    if(item==9)
            //    {
            //        count++;


            //    }
            //} Console.WriteLine(count+"times");
            #endregion



            int sum = 0;
            for (int i = 10; i <= 30; i++) 

            {
                sum += i;
            }
            Console.WriteLine(sum);


            Console.WriteLine("add number" ); 
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("add second number" ); 
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("add symbol");
            string symb=Console.ReadLine();
            

            int result = 0;

            switch(symb)
                 { case "+":
                    result = (num1 + num2);
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = (num1 - num2);
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = (num1 - num2);
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = (num1 - num2); 
                    Console.WriteLine(result);
                    break;

                }

             



        }


        
        
        
    
    }

}