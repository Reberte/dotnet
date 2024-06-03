using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{

   public class Venda
    {

    // Deserializando um Objeto - Transformar um Json em Objeto

        public int Id {get; set;}

        [JsonProperty("Nome_Produto")]
        public string Produto  {get; set;}
        
        public decimal Preco  {get; set;}
        public DateTime DataVenda {get; set;}

/*
          // Serializando Gerar um JSON referente ao Objeto Venda

        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public int Id {get; set;}
        public string Produto  {get; set;}
        public decimal Preco  {get; set;}
        public DateTime DataVenda {get; set;}
*/


    }
    
}