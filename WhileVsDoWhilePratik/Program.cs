
//İlk olarak while ile kodlama yapıyorum. 

using System;
namespace Pratik;
class program
{
    static void Main(string[] args)
    {
        int sayaç = 1;                              //Sayacı birden başlatıyorum çünkü kullanıcın girdiği sayı kadar tekrar edilemsini istiyorum
        int limit = 0;
        Console.WriteLine("Lütfen bir sayı giriniz");
        limit =Convert.ToInt32(Console.ReadLine());

        while (sayaç <= limit)
        {
            Console.WriteLine("Ben bir patikalıyım");
            sayaç++;
        }


    //Do ile aynı işlemi tekrar ediyorum

        int sayaç2 = 1; 
        int limit2 = 0;
        Console.WriteLine("Lütfen bir sayı giriniz");
        limit2 = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine("Ben bir patikalıyım");
            sayaç2++;
        }

        while (sayaç2 <= limit2);




    }
}