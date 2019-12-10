using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace users.Models
{
    public class User
    {
        [Key]
        [DisplayName("Id")]
        public int u_Id { get; set; }
        [Required]
        [DisplayName("Typ")]
        public byte u_Type { get; set; }
        [DisplayName("Czy jest aktywny?")]
        public bool u_Active { get; set; }
        [Column(TypeName ="varchar(60)")]
        [Required]
        [DisplayName("Login")]
        public string u_Code { get; set; }
        [DisplayName("Id z systemu ERP")]
        public int? u_ForeignId { get; set; }
        [Column(TypeName = "varchar(60)")]
        [DisplayName("Nazwa z systemu ERP")]
        public string u_ForeignCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Imię i nazwisko")]
        public string u_Name { get; set; }
        [Column(TypeName = "varchar(60)")]
        [Required]
        [DisplayName("Hasło")]
        public string u_Pwd { get; set; }
        [DisplayName("Identyfikator maszyny")]
        public int? u_MachineID { get; set; }
        [DisplayName("Język")]
        public byte u_DefaultLanguage { get; set; }
    }
}
