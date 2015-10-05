using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    [Serializable]
    public class MultipleChoiceTask : BaseTask {
        public string[] VariantText { get; set; }
        public bool[] VariantIsRight { get; set; }

        public MultipleChoiceTask() {
            this.Type = BaseTask.TaskType.MULTIPLE_CHOICE;
        }
    }
}
