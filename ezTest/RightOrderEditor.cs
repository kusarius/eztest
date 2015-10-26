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
    public partial class RightOrderEditor : Form {
        private RightOrderTask editorResult;

        public RightOrderEditor() {
            InitializeComponent();
        }

        public static RightOrderTask ShowEditor(RightOrderTask editTask) {
            RightOrderEditor editor = new RightOrderEditor();
            if (editTask != null) {
                editor.textBox1.Text = editTask.TaskText;
                for (int i = 1; i <= 8; i++) 
                    (editor.groupBox1.Controls["textBox" + (i + 1).ToString()] as TextBox).Text = editTask.RightSequence[i - 1];
            }
            editor.ShowDialog();
            return editor.getResult();
        }

        public RightOrderTask getResult() {
            return editorResult;
        }

        private void button2_Click(object sender, EventArgs e) {
            editorResult = null;
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            editorResult = new RightOrderTask();
            editorResult.TaskText = textBox1.Text;
            List<string> rs = new List<string>();
            for (int i = 1; i <= 8; i++)
                rs.Add((groupBox1.Controls["textBox" + (i + 1).ToString()] as TextBox).Text);
            editorResult.RightSequence = rs;
            Close();
        }
    }
}
