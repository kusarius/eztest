using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    class BaseTask {
        public enum TaskType {
            MULTIPLE_CHOICE, RIGHT_ORDER,
            MATCHING, WRITING
        }

        public string TaskText { get; set; }
        public TaskType Type { get; set; }
    }
}
