using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF_lesson_3_7
{
    class MyContextInitializer : DropCreateDatabaseAlways<MobileContext>
    {
        protected override void Seed(MobileContext db)
        {
            Phone p1 = new Phone { Name = "Samsung Galaxy S5", Price = 14000 };
            Phone p2 = new Phone { Name = "Nokia Lumia 630", Price = 8000 };

            db.Phones.Add(p1);
            db.Phones.Add(p2);
            db.SaveChanges();
        }
    }
}
