using System.ComponentModel.DataAnnotations.Schema;

namespace ghostproject.Models
{
    public class Transaksjoner
    {
        
        
        public int Id { get; set; }
        public int Pris { get; set; }  
        public int Volum { get; set; }  
        public string Dato { get; set; }
        public bool Kjop { get; set; }
        public virtual Bruker Bruker { get; set; }
        public virtual Aksje Aksje { get; set; } 
       
    }
}
