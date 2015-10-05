using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    [Serializable]
    public class MatchingTask : BaseTask {
        public List<string> LeftPart { get; set; }
        public List<string> RightPart { get; set; }

        public List<int> RightMatch { get; set; }

        public MatchingTask() {
            Type = TaskType.MATCHING;
        }
    }
}
