using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.DTO
{
    [Table("post", Schema = "mybd")]
    public class Postss
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("body")]
        public string Body { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("category_id")]
        public long CategoryId { get; set; }

        [Column("data")]
        public DateTime Date { get; set; }

        [Column("user_id")]
        public long UserId { get; set; }
    }
}
