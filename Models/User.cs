namespace CihanAbay.Models
{
    public class User : EntityBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool IsActive { get; set; }
        
    }
}
