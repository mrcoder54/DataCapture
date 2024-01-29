using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiographicCapture.Shared
{
    public class Section
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "Section Name";
        public string Description { get; set; } = string.Empty;
        //public List<FieldGroup> FieldGroups { get; set; } = new();
        public List<Field> Fields { get; set; } = new();
    }
}
