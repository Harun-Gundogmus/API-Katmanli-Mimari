using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Ogrenci
    {
        [Key]
        public int ogrenci_id{ get; set; }
        public string ogrenci_ad { get; set; }
        public string ogrenci_soyad { get; set; }
    }
}
