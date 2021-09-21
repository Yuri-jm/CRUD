using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projeto
{

    public class Produto
    {
        
        public int Id { get; set; }

        [Display (Name ="Descrição")]
        
       
        public string Descricao { get; set; }

       
        public int Quantidade { get; set; }

        [Display(Name= "Categoria")]
        public int CategoriaID { get; set;  }
        
        
        public Categoria Categoria { get; set;  }
    }
    
    

}
