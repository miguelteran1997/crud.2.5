﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2._5.Data
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }

        public string Fname { get; set; }
        public string Lname { get; set; }
        public int DID { get; set; }

        [ForeignKey("DID")]
        public Departments Depts { get; set; }
    }
}
