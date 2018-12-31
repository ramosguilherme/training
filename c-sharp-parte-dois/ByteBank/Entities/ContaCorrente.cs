using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public string Titutlar { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public double Saldo { get; set; }
    }
}
