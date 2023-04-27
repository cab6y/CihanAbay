namespace CihanAbay.Models
{
    public class Roles : EntityBase
    {
        public Guid UserId { get; set; }
        public roles RoleEnum { get; set; }
    }
    public enum roles
    {
        admin,
        Customer,
        Shop
    }
}
