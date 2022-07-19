using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDS.model
{
    public class Produto
    {
        public int id_produto { get; set; }
        public string descricao { get; set; }
        public int qtd { get; set; }
        public double preco { get; set; }

        //Chave estrangeira da tabela fornecedor
        public int fk_fornecedor { get; set; }
    }
}
