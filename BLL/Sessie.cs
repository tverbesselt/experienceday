using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Sessie
    {
        public int Id { get; set; }

        public string NaamSpreker { get; set; }
        public string Titel { get; set; }
        public string BeginUur { get; set; }
        public string EindUur { get; set; }
        public string Beschrijving { get; set; }
        public string ImgUrl { get; set; }
        public string Lokaal { get; set; }
    }
}