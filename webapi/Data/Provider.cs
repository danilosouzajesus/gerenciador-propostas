using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gerenciador_propostas.Models
{
    public class Provider
    {
        public int providerId { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string cnpj { get; set; }
        public string phone { get; set; }
        public string contactName { get; set; }
        public string address { get; set; }
        public string addressNumber { get; set; }
        public string cep { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public DateTime lastUpdate { get; set; }
    }
}
