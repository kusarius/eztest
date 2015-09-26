using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    class MultipleChoiceTask : BaseTask {
        public Dictionary<string, bool> AnswerVariants { get; set; }

        public MultipleChoiceTask() {
            this.Type = BaseTask.TaskType.MULTIPLE_CHOICE;
        }
    }
}
