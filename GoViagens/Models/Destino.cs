using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoViagens.Models
{
    public class Destino
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Cidade { get; set; }
        public string Preço { get; set; }

        public string Imagem { get; set; }

        public ICollection <Promocao> Promocao { get; set; }






    }
}
