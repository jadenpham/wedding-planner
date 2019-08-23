using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class Response
    {
        [Key]
        [Column("resp_id")]
        public int RespId{get; set;}
        
        [Column("user_id")]
        public int UserId{get; set;}

        [Column("wedding_id")]
        public int WeddingId{get; set;}

        public UserReg Guest {get; set;}

        public Wedding Wedding {get; set;}
    }
}