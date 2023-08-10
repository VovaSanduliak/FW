namespace FW.Db.Entities
{
    public class SetWord
    {
        public Guid SetId { get; set; }
        public Guid WordId { get; set; }
        public Set Set { get; set; }
        public Word Word { get; set; }
    }
}
