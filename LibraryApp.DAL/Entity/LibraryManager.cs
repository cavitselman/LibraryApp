using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.DAL.Entity
{   
    public class LibraryManager
    {
        [Key]
        public string UserName { get; set; }        
        public string Password { get; set; }        
    }
}
