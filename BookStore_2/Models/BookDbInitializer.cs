using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore_2.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 220 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургеньев", Price = 180 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150 });

            db.Clients.Add(new Clients { Name = "Иванов", Age = 22, Sex = Clients.MaleFemale.Male });
            db.Clients.Add(new Clients { Name = "Петрова", Age = 25, Sex = Clients.MaleFemale.Female });
            db.Clients.Add(new Clients { Name = "Сидоров", Age = 30, Sex = Clients.MaleFemale.Male });

            base.Seed(db);
        }
    }
}