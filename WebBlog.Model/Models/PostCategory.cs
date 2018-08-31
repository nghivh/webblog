using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBlog.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrd { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        [MaxLength(250)]
        public string MetaKeyword { get; set; }

        [MaxLength(250)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }

        public DateTime CreatedDate { get; set; }

        [MaxLength(250)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(250)]
        public string UpdatedBy { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}
