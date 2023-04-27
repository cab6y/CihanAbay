using System.ComponentModel.DataAnnotations;

namespace CihanAbay.Models
{
    public class EntityBase
    {
        [Key]
        public Guid id { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid CreatorId {get;set;}
        public Guid? UpdaterId {get;set;}
    }
}
