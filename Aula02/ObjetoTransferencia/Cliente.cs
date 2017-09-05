using System;

namespace ObjetoTransferencia
{
    public class Cliente
    {
        private int IdCliente { set; get; }
        public string Nome { get; set; }
        public DateTime DataNascimento{ get; set; }
        public Boolean Sexo { get; set; }
        public decimal LimiteCompra{ get; set; }
        
    }
}
