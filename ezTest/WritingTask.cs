using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    [Serializable]
    public class WritingTask : BaseTask {
        public string RightAnswer { get; set; }

        public WritingTask() {
            Type = TaskType.WRITING;
        }
    }
}
