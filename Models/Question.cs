using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SuperTest.Models
{
    [Serializable]
    public class Question
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public string Content { get; set; }
        public List<Variant> Variants { get; set; }
        [XmlIgnore] public string SelectedVariant { get; set; } = "";

        public override string ToString()
        {
            string debug = "";
            foreach(var variant in Variants)
            {
                debug += "\n"+variant;
            }
            return $"{Title}:{Id}:{Content}"+debug;
        }
    }
}
