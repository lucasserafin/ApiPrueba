using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPrueba.WebApi.Data.Entities
{
    public class Pais
    {
        public int Id { get; set; }
        [Required]
        public string CodPais { get; set; }
        [Required]
        public string NomPais { get; set; }
    }
}
