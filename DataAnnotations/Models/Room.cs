using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; } 

        public int Capacity { get; set; }
        
        public Sections Section { get; set; }
        
        public enum Sections
        {
            First,
            Second,
            Third
        }



    }
}
