namespace CihanAbay.Models
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public float NetAmount { get; set; }
        public float Tax { get; set; }
        
    }
}
