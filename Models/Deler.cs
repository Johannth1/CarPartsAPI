using System.ComponentModel.DataAnnotations;

namespace CarPartsAPI.Models {
    public class Deler {

        [Key]


        public string Name { get; set;}
        
        public int DelerNummer { get; set;}

        public char Hylle { get; set;}

        public int Rad { get; set;}  

        public int Antall { get; set;}      


    }
}

    
