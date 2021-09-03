using System;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace reminder
{
    public partial class FormAddTask : Form
    {
        public FormAddTask()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)  
        {

            if (textBoxTaskText.Text != "")
            {
                AddTask();
                Close();
            }
            else
            {
                MessageBox.Show("Описание задачи не заполнено");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)  
        {
            if (textBoxTaskText.Text != "")
            {
                AddTask();
            }
            else
            {
                MessageBox.Show("Описание задачи не заполнено");
            }

        }

        private void buttonCansel_Click(object sender, EventArgs e)    
        {
            Close();
        }


        private void FormAddTask_FormClosed(object sender, FormClosedEventArgs e) 
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void AddTask ()
        {
            string task = dateTimePickerTask.Value.ToString() + " " + textBoxTaskText.Text + ":;1:;0:;0:;";
            FileStream fs = new FileStream("tasks.txt", FileMode.Append, FileAccess.Write);
            StreamWriter TasksFile = new StreamWriter(fs, Encoding.GetEncoding(1251));
            TasksFile.WriteLine(task);
            TasksFile.Close();
        }
    }
}
