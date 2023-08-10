namespace FW.Db.Entities
{
    public class Word : BaseEntity
    {
        public string Name { get; set; }
        public string Translate { get; set; }
        public Guid SetId { get; set; }
        public SetWord Set { get; set; }
    }
}
