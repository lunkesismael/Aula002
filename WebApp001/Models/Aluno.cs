using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp001.Models
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public Sala Sala { get; set; }
    }
}