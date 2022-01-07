using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzceUniversitesi_Model.Models
{
    public class Duyuru
    {

        public Duyuru()
        {
            DuyuruOlusturulmaTarihi = DateTime.Today;
        }
        public int DuyuruId { get; set; }
        public string DuyuruKonu { get; set; }
        public string DuyuruAçıklama { get; set; }
        
        public DateTime DuyuruOlusturulmaTarihi { get; set; }

    }
}
