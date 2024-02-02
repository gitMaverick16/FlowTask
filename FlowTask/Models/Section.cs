namespace FlowTask.Models
{
    public class Section : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid BoardId { get; set; }
        public Board Board { get; set; } = null!;
        public ICollection<Card> Cards { get; set; }
    }
}
