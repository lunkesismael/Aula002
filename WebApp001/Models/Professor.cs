using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp001.Models
{
    public class Professor : Pessoa
    {
        public List<Sala> Salas { get; set; }
    }
}