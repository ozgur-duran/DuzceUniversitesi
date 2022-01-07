using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzceUniversitesi_Model.Models
{
    public class AkademikPersonel
    {
        public int AkademikPersonelId { get; set; }
        public string AkademikPersonelAdSoyad { get; set; }
        public DateTime AkademikPersonelDogumTarihi { get; set; }
        public string AkademikPersonelDersler { get; set; }
        public string AkademikPersonelMail { get; set; }
        public string AkademikPersonelGorsel { get; set; }
    }
}
