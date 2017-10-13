using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMgmt.WebApi.Models
{
    public class EmployeeModelCreate
    {
        [Required(ErrorMessage ="Informe o Nome.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o Cargo.")]
        public string Occupation { get; set; }

        [Required(ErrorMessage = "Informe o E-mail.")]
        [EmailAddress(ErrorMessage = "Informe um Email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Informe a data de naacimento.")]
        public DateTime Birth { get; set; }
    }

    public class EmployeeModelGet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Email { get; set; }
        public DateTime Birth { get; set; }

    }

    public class EmployeeModelEdit
    {
        [Required(ErrorMessage = "Informe o Id.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o Cargo.")]
        public string Occupation { get; set; }

        [Required(ErrorMessage = "Informe o E-mail.")]
        [EmailAddress(ErrorMessage = "Informe um Email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a data de naacimento.")]
        public DateTime Birth { get; set; }
    }
}