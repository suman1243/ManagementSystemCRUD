using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystemCRUD.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column(TypeName ="nvarchar(200)")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(200)")]
        
        public string Course { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Stream { get; set; }
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Mobile No")]
        public string MobileNo { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Address { get; set; }
    }
}
