using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoViagens.Models
{
    public class Promocao
    {

        [Key]
        public int Id { get; set; }

        public string NomePromocao { get; set; }
        public double ValorDesconto { get; set; }








        public int DestinoId { get; set; }
        [ForeignKey("DestinoId")]
        public virtual Destino Destino{ get; set; }





    }
}
