using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    [Serializable]
    public class Test {
        public string TestName { get; set; }
        public string Author { get; set; }
        public int TryCount { get; set; }
        public List<BaseTask> Tasks { get; set; }

        public Test() {
            Tasks = new List<BaseTask>();
        }
    }
}
