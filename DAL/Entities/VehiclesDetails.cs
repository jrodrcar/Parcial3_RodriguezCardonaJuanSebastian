using System.ComponentModel.DataAnnotations;

namespace Parcial3_RodriguezCardonaJuanSebastian.DAL.Entities
{
    public class VehiclesDetails : Entity
    {
        [Display(Name = "Fecha de entrega")]
        public string DeliveryDate { get; set; }
    }
}
