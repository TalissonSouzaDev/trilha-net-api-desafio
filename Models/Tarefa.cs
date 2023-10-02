using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
       
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Error"),StringLength(255,ErrorMessage ="limite de caracteres é 255")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Error"),StringLength(500,ErrorMessage ="limite de caracteres é 500")]
        public string Descricao { get; set; }

        [Required]
        public DateTime Data { get; set; } = DateTime.Now;

        [Required]
        public EnumStatusTarefa Status { get; set; }
    }
}