using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity  bu tür classlarda sadece özellik olur
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //foreign key referans alanları
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
