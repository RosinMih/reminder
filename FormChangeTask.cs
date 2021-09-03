using System;
using System.Windows.Forms;

namespace reminder
{ 

    public partial class FormChangeTask : Form
    {

        int NumString = MainForm.NumStringTask;
        ReadWriteFileTasksToDB RWDB = new ReadWriteFileTasksToDB();
        string DatteTime, Task, Activity, extendHour, extendDay;
        public FormChangeTask()
        {
            InitializeComponent();
            string task = ReadWriteFileTasksToDB.DBTask[NumString];
            RWDB.parseString(task, out string DatteTimeIn, out string TaskIn, out string ActivityIn, out extendHour, out extendDay);
            dateTimePickerChangeTask.Value = DateTime.Parse(DatteTimeIn);
            textBoxTaskChangeTask.Text = TaskIn;
            if (ActivityIn == "1")  
                checkBoxActivity.Checked = true;
            else checkBoxActivity.Checked = false;
        }




        private void buttonOK_Click(object sender, EventArgs e)
        {
            string str = CollectString();
            ReadWriteFileTasksToDB.DBTask.RemoveAt(NumString);
            ReadWriteFileTasksToDB.DBTask.Insert(NumString, str);
            RWDB.WriteToFileDB();
            Close();
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormChangeTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form ifrm = Application.OpenForms[0]; 
            ifrm.Show();
        }


        private string CollectString()
        {
            if (checkBoxActivity.Checked == true)
                 Activity = "1";
            else Activity = "0";
            DatteTime = dateTimePickerChangeTask.Value.ToString();
            Task = textBoxTaskChangeTask.Text;
            return DatteTime + " " + Task + ":;" + Activity + ":;" + extendHour + ":;" + extendDay + ":;";
        }

    }
}
