namespace CihanAbay.Models
{
    public class Basket : EntityBase
    {
        public Guid ProductId { get; set; } 
        public Guid UserId { get; set; }
    }
}
