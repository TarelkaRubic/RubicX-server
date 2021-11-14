using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubicX_server.DataAccess.Core.Models
{
    [Table("UserRole")]
    public class UserRoleRto
    
    {
       [Key] public int Id {get; set; }
        public string Name { get; set; }


    }
}
