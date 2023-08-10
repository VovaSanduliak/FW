namespace FW.Db.Entities
{
    public class Set : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<SetWord> Words { get; set; }
    }
}
