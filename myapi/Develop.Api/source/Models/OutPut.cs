using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace source.Models
{
    public class Output
    {
        public string Status { get; set; }

        public string Message { get; set; }

        public List<Erro> Erro { get; set; }

    }
}