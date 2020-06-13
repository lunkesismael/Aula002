using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp001.Models.Enums;

namespace WebApp001.Models
{
    public class Cidades
    {
        public Estados Estado { get; set; }
        public string Cidade { get; set; }
    }
}