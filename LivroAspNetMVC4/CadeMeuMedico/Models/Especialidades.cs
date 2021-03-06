//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadeMeuMedico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Especialidades
    {
        public Especialidades()
        {
            this.Medicos = new HashSet<Medicos>();
        }

        [Display(Name = "C�digo")]
        public int IDEspecialidade { get; set; }

        [Required(ErrorMessage = "* Obrigat�rio informar a Especialidade")]
        [StringLength(80, ErrorMessage = "O Nome deve possuir no m�ximo 80 caracteres")]
        public string Nome { get; set; }

        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}
