using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolTest.Models.ValueObjects
{
    [Serializable]

    public class PlayerParam
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public bool Job { get; set; }

        public bool isMale { get; set; }

        public bool IsBraver { get; set; }

        public string ParameterType { get; set; }

        public int HP { get; set; }
    }
}
