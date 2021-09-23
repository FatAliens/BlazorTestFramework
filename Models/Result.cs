using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperTest.Models
{
    [Serializable]
    public class Result
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }

        public override string ToString()
        {
            return $"{Id}:{Title}:{Content}:{ImageURL}";
        }
    }
}
