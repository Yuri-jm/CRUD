using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projeto
{
    public class Categoria 
    {

        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="O campo 'Descrição' é obrigatório")]
        [Range(1, 10, ErrorMessage = "Valor fora da faixa")]
        public string Descricao { get; set; }
        
        


    }
}
