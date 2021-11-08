using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //Property. alttakilern her biri bir property. özelikleri yani.
        public int Id { get; set; }// bir ürünü diğerlerinden ayırmak için kullandık
        public string Adı { get; set; }
        public double Fiyatı { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }

    }
}
