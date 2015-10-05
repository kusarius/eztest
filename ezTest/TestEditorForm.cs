using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezTest {
    public partial class TestEditorForm : Form {
        string fileNameToSave = "";
        private Test editTest = new Test();

        public TestEditorForm() {
            InitializeComponent();
        }

        private void menuItem8_Click(object sender, EventArgs e) {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            BaseTask taskToAdd = null;
            if (radioButton1.Checked) taskToAdd = MultipleChoiceEditor.ShowEditor(null);
            if (taskToAdd != null) {
                editTest.Tasks.Add(taskToAdd);
                dataGridView1.Rows.Add(taskToAdd.TypeToText(), taskToAdd.TaskText);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count != 0) {
                int selIndex = dataGridView1.SelectedRows[0].Index;
                BaseTask taskToEdit = editTest.Tasks[selIndex];
                if (taskToEdit.Type == BaseTask.TaskType.MULTIPLE_CHOICE) 
                    taskToEdit = MultipleChoiceEditor.ShowEditor((MultipleChoiceTask)taskToEdit);
                if (taskToEdit != null) {
                    editTest.Tasks[selIndex] = taskToEdit;
                    dataGridView1.Rows[selIndex].Cells[1].Value = taskToEdit.TaskText;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count != 0) {
                int selIndex = dataGridView1.SelectedRows[0].Index; ;
                editTest.Tasks.RemoveAt(selIndex);
                dataGridView1.Rows.RemoveAt(selIndex);
            }
        }

        private void menuItem5_Click(object sender, EventArgs e) {
            if (fileNameToSave == "") {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Файлы тестов|*.ezt";
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    SaveTest(saveDialog.FileName);
                    fileNameToSave = saveDialog.FileName;
                }
            }
            else SaveTest(fileNameToSave);
        }

        private void SaveTest(string fileName) {
            editTest.TestName = textBox1.Text;
            editTest.Author = textBox2.Text;
            editTest.TryCount = (int)numericUpDown1.Value;
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(new FileStream(fileName, FileMode.Create), editTest);
        }

        private void menuItem6_Click(object sender, EventArgs e) {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Файлы тестов|*.ezt";
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                SaveTest(saveDialog.FileName);
        }

        private void menuItem2_Click(object sender, EventArgs e) {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Файлы тестов|*.ezt";
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                BinaryFormatter bf = new BinaryFormatter();
                Test openTest = (Test)bf.Deserialize(new FileStream(openDialog.FileName, FileMode.Open));
                editTest = openTest;
                textBox1.Text = editTest.TestName;
                textBox2.Text = editTest.Author;
                numericUpDown1.Value = editTest.TryCount;
                dataGridView1.Rows.Clear();
                foreach (BaseTask task in editTest.Tasks)
                    dataGridView1.Rows.Add(task.TypeToText(), task.TaskText);
                fileNameToSave = openDialog.FileName;
            }
        }
    }
}
