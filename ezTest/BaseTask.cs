using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezTest {
    [Serializable]
    public class BaseTask {
        public enum TaskType {
            MULTIPLE_CHOICE, RIGHT_ORDER,
            MATCHING, WRITING
        }

        public string TypeToText() {
            if (Type == TaskType.MATCHING) return "Сопоставление";
            else if (Type == TaskType.MULTIPLE_CHOICE) return "Множественный выбор";
            else if (Type == TaskType.RIGHT_ORDER) return "Выбор правильного порядка";
            else return "Письменный ответ";
        }

        public string TaskText { get; set; }
        public TaskType Type { get; set; }
    }
}
