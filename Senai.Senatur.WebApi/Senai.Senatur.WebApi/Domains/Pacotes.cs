﻿using System;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Pacotes
    {
        public int PacoteId { get; set; }
        public string NomePacote { get; set; }
        public string Descricao { get; set; }
        public DateTime DataIda { get; set; }
        public DateTime DataVolta { get; set; }
        public decimal Valor { get; set; }
        public string Ativo { get; set; }
        public string NomeCidade { get; set; }
    }
}