﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDS.model
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public int numero { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
