using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_3_7
{
    public class MobileContext : DbContext
    {
        static MobileContext()
        {
            Database.SetInitializer<MobileContext>(new MyContextInitializer());
        }

        public MobileContext()
            : base("DefaultConnection")
        { }
        public DbSet<Phone> Phones { get; set; }
    }
}
