using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperTest.Models
{
    public class Variant
    {
        public string Content { get; set; }
        public string Id { get; set; }

        public override string ToString()
        {
            return $"{Content}:{Id}";
        }
    }
}
