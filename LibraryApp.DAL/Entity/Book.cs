using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DAL.Entity
{
    public class Book
    {
        [Key]
        public int ID { get; set; }        
        public string BookName { get; set; }        
        public string AuthorName { get; set; }        
        public string AuthorSurname { get; set; }        
        public string ISBN { get; set; }
        public byte Status { get; set; }
        public int Deptor { get; set; }
        public DateTime DeptorDate { get; set; }
        public byte BookTypeCode { get; set; }        
    }
}
