﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.Registro.Models
{
    public class RegistroModel
    {
        [Required]
        [Display(Name = "Nombre de usuario")]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmPassword { get; set; }
    }
}