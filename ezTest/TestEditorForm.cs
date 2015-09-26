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
    public partial class TestEditorForm : Form {
        public TestEditorForm() {
            InitializeComponent();
            dataGridView1.Rows.Add("Множественный выбор", "Когда на чалась ВМВ?");
        }

        private void menuItem8_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
