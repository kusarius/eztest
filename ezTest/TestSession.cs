using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    [Serializable]
    public class TestSession {
        public Test PassTest { get; set; }
        public string PasserName { get; set; }
        public DateTime PassTime { get; set; }
        public int MarkBase { get; set; } // 5, 12, 100 or 200
        public int PassMark { get; set; }
    }
}
