using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.DTO
{
    [Table("rating", Schema = "rating")]
    public class Ratings
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("post_id")]
        public long PostId { get; set; }

        [Column("rating")]
        public int RatingValue { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("user_id")]
        public long UserId { get; set; }
    }
}
