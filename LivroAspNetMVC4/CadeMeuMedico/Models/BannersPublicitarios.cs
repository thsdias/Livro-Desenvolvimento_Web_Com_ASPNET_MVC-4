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

    public partial class BannersPublicitarios
    {
        [Display(Name = "C�digo")]
        public long IDBanner { get; set; }

        [Display(Name = "T�tulo da Campanha")]
        [Required(ErrorMessage = "* Obrigat�rio informar o t�tulo da campanha")]
        [StringLength(60, ErrorMessage = "O t�tulo deve possuir no m�ximo 60 caracteres")]
        public string TituloCampanha { get; set; }

        [Display(Name = "Nome do Banner")]
        [Required(ErrorMessage = "* Obrigat�rio informar o nome do banner")]
        [StringLength(200, ErrorMessage = "O Nome do banner deve possuir no m�ximo 200 caracteres")]
        public string BannerCampanha { get; set; }

        [Display(Name = "Endere�o URL")]
        [StringLength(200, ErrorMessage = "O endere�o do link deve possuir no m�ximo 200 caracteres")]
        public string LinkBanner { get; set; }
    }
}
