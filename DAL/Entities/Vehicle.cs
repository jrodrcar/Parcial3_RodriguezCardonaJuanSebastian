using System.ComponentModel.DataAnnotations;

namespace Parcial3_RodriguezCardonaJuanSebastian.DAL.Entities
{
    public class Vehicle : Entity 
    {
        [Display(Name = "Servicios")]
        public ICollection<Service> Services { get; set; }

        [Display(Name = "Dueño")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        public string? Fullname { get; set; }

        [Display(Name = "Placa")]
        [Required(ErrorMessage = "El campo {0} es oblilgatorio.")]
        public string NumberPlace { get; set; }
    }
}
