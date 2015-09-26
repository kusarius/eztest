using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    class RightOrderTask : BaseTask {
        public string[] RightSequence { get; set; }

        public RightOrderTask() {
            this.Type = TaskType.RIGHT_ORDER;
        }
    }
}
