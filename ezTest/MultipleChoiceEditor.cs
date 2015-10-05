using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezTest {
    public partial class MultipleChoiceEditor : Form {
        private MultipleChoiceTask editorResult;

        public MultipleChoiceEditor() {
            InitializeComponent();
        }

        public static MultipleChoiceTask ShowEditor(MultipleChoiceTask editTask) {
            MultipleChoiceEditor editor = new MultipleChoiceEditor();
            if (editTask != null) {
                editor.textBox1.Text = editTask.TaskText;
                for (int i = 1; i <= 8; i++) {
                    (editor.groupBox1.Controls["textBox" + (i + 1).ToString()] as TextBox).Text = editTask.VariantText[i - 1];
                    (editor.groupBox1.Controls["checkBox" + i.ToString()] as CheckBox).Checked = editTask.VariantIsRight[i - 1];
                }
            }
            editor.ShowDialog();
            return editor.getResult();
        }

        public MultipleChoiceTask getResult() {
            return editorResult;
        }

        private void button1_Click(object sender, EventArgs e) {
            editorResult = new MultipleChoiceTask();
            editorResult.TaskText = textBox1.Text;
            string[] txt = new string[8];
            bool[] ir = new bool[8];
            for (int i = 1; i <= 8; i++) {
                txt[i - 1] = (groupBox1.Controls["textBox" + (i + 1).ToString()] as TextBox).Text;
                ir[i - 1] = (groupBox1.Controls["checkBox" + i.ToString()] as CheckBox).Checked;
            }
            editorResult.VariantIsRight = ir;
            editorResult.VariantText = txt;
            Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            editorResult = null;
            Close();
        }
    }
}
