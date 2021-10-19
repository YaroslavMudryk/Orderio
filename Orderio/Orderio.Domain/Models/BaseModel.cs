using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Orderio.Domain.Models
{
    public class BaseModel
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedFromIP { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedFromIP { get; set; }
    }

    public class BaseModel<TId> : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TId Id { get; set; }
    }
}