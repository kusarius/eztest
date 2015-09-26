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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void menuItem4_Click(object sender, EventArgs e) {
            TestEditorForm editor = new TestEditorForm();
            editor.Show();
        }

        private void menuItem6_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
