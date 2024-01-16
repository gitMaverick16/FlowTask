namespace FlowTask.Models
{
    public class Board : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Section> Sections { get; set; }
    }
}
