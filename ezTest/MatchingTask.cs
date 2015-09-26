using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    class MatchingTask : BaseTask {
        public string[] LeftPart { get; set; }
        public string[] RightPart { get; set; }

        public int[] RightMatch { get; set; }

        public MatchingTask() {
            Type = TaskType.MATCHING;
        }
    }
}
