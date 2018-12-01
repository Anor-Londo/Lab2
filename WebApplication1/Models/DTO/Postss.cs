using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.DTO
{
    [Table("post", Schema = "posts")]
    public class Postss
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("body")]
        public string Body { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }
    }
}
