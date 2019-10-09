using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2._5.Data
{
    public class Departments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }

        [Display(Name ="Department Name")]
        public string Dname { get; set; }

        [Display(Name ="Dept Head")]
        public string Dhead { get; set; }
    }
}
