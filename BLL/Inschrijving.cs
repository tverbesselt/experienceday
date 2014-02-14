using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Inschrijving
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string SessieId { get; set; }
        public string Email { get; set; }
        public bool BringsOwnDevice { get; set; }

    }
}
