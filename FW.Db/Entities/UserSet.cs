namespace FW.Db.Entities
{
    public class UserSet
    {
        public Guid UserId { get; set; }
        public Guid SetId { get; set; }
        public User User { get; set; }
        public Set Set { get; set; }
    }
}
