using System.ComponentModel.DataAnnotations;

namespace Parcial3_RodriguezCardonaJuanSebastian.DAL.Entities
{
    public class Service : Entity
    {
        [Display(Name = "Servicio")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es oblilgatorio.")]
        public string Name { get; set; }


        [Display(Name = "Precio")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        public string? Price { get; set; }
    }
}
