using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    [Serializable]
    public class RightOrderTask : BaseTask {
        public List<string> RightSequence { get; set; }

        public RightOrderTask() {
            this.Type = TaskType.RIGHT_ORDER;
        }
    }
}
