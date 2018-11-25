using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.DTO
{
    [Table("comments", Schema = "comments")]
    public class Comments
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("body")]
        public string Body { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("post_id")]
        public long PostId { get; set; }

        [Column("user_id")]
        public long UserId { get; set; }
    }
}
