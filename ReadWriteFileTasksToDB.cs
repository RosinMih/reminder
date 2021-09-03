using System.Text;
using System.IO;
using System.Collections.Generic;

namespace reminder
{
    class ReadWriteFileTasksToDB
    {
        public static List<string> DBTask = new List<string>();

        public void readFileToDB ()
        {
            DBTask.Clear();
            string[] tasks = File.ReadAllLines(@"tasks.txt", Encoding.GetEncoding(1251));   
            for (int i=0; i < tasks.Length; i++)
            {
                DBTask.Add(tasks[i]);
            }
        }

        public void parseString (string InString, out string DateTime, out string Task, out string Activity, out string extendHour, out string extendDay)
        {
            int position_first_space = InString.IndexOf(" ");
            int position_second_space = position_first_space + 1 + InString.Substring(position_first_space + 1).IndexOf(" ");
            int position_first_separator = InString.IndexOf(":;");
            int position_seconf_separator = position_first_separator + 2 + InString.Substring(position_first_separator + 2).IndexOf(":;");
            int position_third_separator = position_seconf_separator + 2 + InString.Substring(position_seconf_separator + 2).IndexOf(":;");
            int position_fourth_separator = position_third_separator + 2 + InString.Substring(position_third_separator + 2).IndexOf(":;");
            DateTime = InString.Substring(0, position_second_space);
            Task = InString.Substring(position_second_space + 1, position_first_separator - position_second_space - 1);
            Activity = InString.Substring(position_first_separator + 2, position_seconf_separator - position_first_separator - 2);
            extendHour = InString.Substring(position_seconf_separator + 2, position_third_separator - position_seconf_separator - 2);
            extendDay = InString.Substring(position_third_separator + 2, position_fourth_separator - position_third_separator - 2);
        }


        public void WriteToFileDB ()
        {
            FileStream fs = new FileStream(@"tasks.txt", FileMode.Create, FileAccess.Write);
            StreamWriter TaskFile = new StreamWriter(fs, Encoding.GetEncoding(1251));

            foreach (string st in ReadWriteFileTasksToDB.DBTask)
            {
                TaskFile.WriteLine(st);
            }

            TaskFile.Close();
        }
    }
}
