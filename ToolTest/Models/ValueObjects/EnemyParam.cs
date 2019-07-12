using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolTest.Models.ValueObjects
{
    public class EnemyParam
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Hp { get; set; }

        public int Mp { get; set; }

        public bool IsBoss { get; set; }

        public EnemyParam()
        {
        }
    }
}
