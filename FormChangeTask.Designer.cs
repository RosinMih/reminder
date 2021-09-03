
namespace reminder
{
    partial class FormChangeTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTaskChangeTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerChangeTask = new System.Windows.Forms.DateTimePicker();
            this.checkBoxActivity = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(580, 102);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(468, 102);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 17;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Описание";
            // 
            // textBoxTaskChangeTask
            // 
            this.textBoxTaskChangeTask.Location = new System.Drawing.Point(203, 52);
            this.textBoxTaskChangeTask.Name = "textBoxTaskChangeTask";
            this.textBoxTaskChangeTask.Size = new System.Drawing.Size(376, 20);
            this.textBoxTaskChangeTask.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Начало";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // dateTimePickerChangeTask
            // 
            this.dateTimePickerChangeTask.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerChangeTask.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChangeTask.Location = new System.Drawing.Point(33, 52);
            this.dateTimePickerChangeTask.Name = "dateTimePickerChangeTask";
            this.dateTimePickerChangeTask.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerChangeTask.TabIndex = 13;
            // 
            // checkBoxActivity
            // 
            this.checkBoxActivity.AutoSize = true;
            this.checkBoxActivity.Location = new System.Drawing.Point(599, 54);
            this.checkBoxActivity.Name = "checkBoxActivity";
            this.checkBoxActivity.Size = new System.Drawing.Size(68, 17);
            this.checkBoxActivity.TabIndex = 20;
            this.checkBoxActivity.Text = "Активно";
            this.checkBoxActivity.UseVisualStyleBackColor = true;
            // 
            // FormChangeTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 171);
            this.Controls.Add(this.checkBoxActivity);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTaskChangeTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerChangeTask);
            this.Name = "FormChangeTask";
            this.Text = "Изменить задачу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChangeTask_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTaskChangeTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerChangeTask;
        private System.Windows.Forms.CheckBox checkBoxActivity;
    }
}