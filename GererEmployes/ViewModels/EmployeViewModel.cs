using GererEmployes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GererEmployes.ViewModels
{
    public class EmployeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le Nom est obligatoire")]
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }
        public string Tel { get; set; }
        public string Adresse { get; set; }
        public string fonction { get; set; }
        public List<Employe> Employes { get; set; }
    }
}
