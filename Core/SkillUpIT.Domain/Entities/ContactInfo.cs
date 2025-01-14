using SkillUpIT.Domain.Entities.Comman;

namespace SkillUpIT.Domain.Entities
{
    public class ContactInfo : BaseEntity<Guid>
    {
        public string Icon { get; set; }        
        public string Title { get; set; }       
        public string Description { get; set; } 
        public string Value { get; set; }
    }
}
