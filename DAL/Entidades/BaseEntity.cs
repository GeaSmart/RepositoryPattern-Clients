using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entidades
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
