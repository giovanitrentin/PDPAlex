using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string nomeFantasia { get; set; }
        public string cNPJ{ get; set; }
        public string endereço { get; set; }
        public string cidade { get; set; }
        public string CEP { get; set; }

        public DateTime cricao { get; set; }
        public DateTime ultimaAlteracao { get; set; }
        public DateTime exclusao { get; set; }
    }
}
