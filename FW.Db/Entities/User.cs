namespace FW.Db.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<UserSet> Sets { get; set; }
        public ICollection<UserWord> Words { get; set; }
    }
}
