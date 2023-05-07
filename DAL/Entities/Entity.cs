﻿using System.ComponentModel.DataAnnotations;

namespace Parcial3_RodriguezCardonaJuanSebastian.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de creación")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Fecha de modificación")]
        public DateTime? ModifiedDate { get; set; }
    }
}