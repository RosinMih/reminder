using System;
using System.Windows.Forms;


namespace reminder
{
    public partial class MainForm : Form
    {
        public static int NumStringTask;
        ReadWriteFileTasksToDB RWDB= new ReadWriteFileTasksToDB();
        public MainForm()
        {
            InitializeComponent();
            RWDB.readFileToDB();
            DisplayFromDB();
        }
        void MainForm_Load(object sender, EventArgs e)
        {
        }


            void buttonAdd_Click(object sender, EventArgs e) 
            {
                NumStringTask = listBoxTasks.Items.Count;
                FormAddTask FormAdd = new FormAddTask();       
                FormAdd.Owner = this;
                FormAdd.FormClosed += FormAddTask_FormClosed;
                FormAdd.Show();
                this.Hide();
            }

            void buttonChange_Click(object sender, EventArgs e)    
            {
                if (listBoxTasks.SelectedIndex >= 0)    
                {   
                    NumStringTask = listBoxTasks.SelectedIndex;
                    FormChangeTask FormChange = new FormChangeTask();  
                    FormChange.Owner = this;
                    FormChange.FormClosed += FormChangeTask_FormClosed;
                    FormChange.Show();
                    this.Hide();
                }
            }


            void buttonDel_Click(object sender, EventArgs e)  
            {
                if (listBoxTasks.SelectedIndex >= 0)    
                {
                ReadWriteFileTasksToDB.DBTask.RemoveAt(listBoxTasks.SelectedIndex);
                RWDB.WriteToFileDB();
                DisplayFromDB();
                }
            }

            void buttonToTray_Click(object sender, EventArgs e)       
            {
                this.Visible = false;
            }

            void notifyIconTray_MouseDoubleClick(object sender, MouseEventArgs e)       //Двойной клик мыши по значку в трее
            {
                this.Visible = true;
            }



        void FormAddTask_FormClosed(object sender, FormClosedEventArgs e)           //При закрытии формы Добавить
        {
            DisplayFromDB();

        }




        void FormChangeTask_FormClosed(object sender, FormClosedEventArgs e)        //При закрытии формы Изменить
        {
            DisplayFromDB();
        }



        private void FormAlarm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RWDB.WriteToFileDB();
            DisplayFromDB();


        }




        void timerTask_Tick(object sender, EventArgs e)     // добавить отложенные задачи      !!!!!!!!!!!!!!!!!!!
        {
            int n = 0;
            foreach (string st in ReadWriteFileTasksToDB.DBTask)
            {
                NumStringTask = n;
                RWDB.parseString(st, out string DatteTime, out string Task, out string Activity, out string extendHour, out string extendDay);
                 DateTime datetask = DateTime.Parse(DatteTime).AddHours(double.Parse(extendHour)).AddDays(double.Parse(extendDay));
                 if ((datetask < DateTime.Now) & (Activity == "1"))
                 {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "FormAlarm")
                        {
                            return;
                        }
                    }
                    FormAlarm FormAlarm = new FormAlarm(); //Создание новой формы
                    FormAlarm.Owner = this;
                    FormAlarm.FormClosed += FormAlarm_FormClosed;
                    FormAlarm.Show();
                    this.Hide();
                }
                n++;
            }
        }




        void DisplayFromDB()
        {
            listBoxTasks.Items.Clear();

            foreach (string st in ReadWriteFileTasksToDB.DBTask)
            {
                listBoxTasks.Items.Add(st);

            }
        }
    }
}

