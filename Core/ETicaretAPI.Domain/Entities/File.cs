using ETicaretAPI.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretAPI.Domain.Entities
{
    public class File : BaseEntity
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Storage { get; set; }

        [NotMapped]
        public override DateTime UpdatedDateTime { get => base.UpdatedDateTime; set => base.UpdatedDateTime = value; }
    }
}
