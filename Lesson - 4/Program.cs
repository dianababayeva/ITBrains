using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

Console.WriteLine("WELCOME TO ONLINE SHOP");
while (true)
{

    Console.WriteLine("to continue please select an option");
    Console.WriteLine("to ADD ITEM enter 1");
    Console.WriteLine("to CHECK ITEM enter 2");
    Console.WriteLine("to EXIT enter 3");

    int choice = Convert.ToInt32(Console.ReadLine());
    ArrayList arrayList = new ArrayList();
    arrayList.Add(1);
    arrayList.Add(2);
    arrayList.Add("book");

    switch (choice)

    {
        case 1:

            Console.WriteLine("enter the name of item");
            string item = Console.ReadLine();
            arrayList.Add(item);
            Console.Write(item + " " + "added to cart");
            break;

        case 2:
            Console.WriteLine("axtardiginiz datani yaz");
            string data = Console.ReadLine();
            foreach (var item2 in arrayList)
            {
                if (item2.ToString() == data)
                {
                    Console.WriteLine(item2 + "checked item");
                }
            }
            break;

        default:
            Console.WriteLine("bele secim yoxdur");
            break;

    }
}


















