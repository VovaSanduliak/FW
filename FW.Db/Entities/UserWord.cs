namespace FW.Db.Entities
{
    public class UserWord
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid WordId { get; set; }
        public Word Word { get; set; }
    }
}
