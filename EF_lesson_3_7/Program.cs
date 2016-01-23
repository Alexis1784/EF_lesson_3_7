using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MobileContext db = new MobileContext())
            {
                foreach (Phone phone in db.Phones)
                {
                    Console.WriteLine("Name - {0}, Price - {1}", phone.Name, phone.Price);
                }
                Console.ReadLine();
            }
        }
    }
}
