using System;

namespace API.Models
{
    public class Produto
    {
        //Construtor
        public Produto() => CriadoEm = DateTime.Now;
        //Atributos
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }


    }
}