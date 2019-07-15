using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolTest.Models.Entity
{
    public class EnemyParam
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Hp { get; set; }

        public int Mp { get; set; }

        public bool IsBoss { get; set; }

        public int Atk { get; set; }
        public int Def { get; set; }
        public int Int { get; set; }
        public int Mnd { get; set; }
        public int Spd { get; set; }
        public int Lvl { get; set; }
        public int Exp { get; set; }

        public EnemyParam()
        {
        }
    }
}
