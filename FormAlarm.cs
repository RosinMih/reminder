using System;
using System.Windows.Forms;

namespace reminder
{

    public partial class FormAlarm : Form
    {
        int NumString = MainForm.NumStringTask;
        ReadWriteFileTasksToDB RWDB = new ReadWriteFileTasksToDB();
        string DatteTime, Task, Activity, extendHour, extendDay;
        public FormAlarm()
        {
            InitializeComponent();
            string task = ReadWriteFileTasksToDB.DBTask[NumString];
            RWDB.parseString(task, out DatteTime, out Task, out Activity, out extendHour, out extendDay);
            labelTaskText.Text = Task;
        }

        private void FormAlarm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];   
            ifrm.Show();

        }

        private void Complete_Click(object sender, EventArgs e)
        {
            ReadWriteFileTasksToDB.DBTask.RemoveAt(NumString);
            string StringToDB = CollectString(DatteTime, Task, "0", "0", "0");
            ReadWriteFileTasksToDB.DBTask.Insert(NumString, StringToDB);
            Close();
        }

        private void RepeatAfterAnHour_Click(object sender, EventArgs e)
        {
            ReadWriteFileTasksToDB.DBTask.RemoveAt(NumString);
            extendHour = (int.Parse(extendHour) + 1).ToString();
            string StringToDB = CollectString(DatteTime, Task, "1", extendHour, extendDay);
            ReadWriteFileTasksToDB.DBTask.Insert(NumString, StringToDB);
            Close();
        }

        private void RepeatAfterAnDay_Click(object sender, EventArgs e)
        {
            ReadWriteFileTasksToDB.DBTask.RemoveAt(NumString);
            extendDay = (int.Parse(extendDay) + 1).ToString();
            string StringToDB = CollectString(DatteTime, Task, "1", extendHour, extendDay);
            ReadWriteFileTasksToDB.DBTask.Insert(NumString, StringToDB);
            Close();

        }


        private string CollectString(string DatteTime, string Task, string Activity, string extendHour, string extendDay)
        {
            return DatteTime + " " + Task + ":;" + Activity + ":;" + extendHour + ":;" + extendDay + ":;";
        }
    }
}
