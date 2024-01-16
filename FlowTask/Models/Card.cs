namespace FlowTask.Models
{
    public class Card : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid? SectionId { get; set; }
        public Section? Section { get; set; }
    }
}
