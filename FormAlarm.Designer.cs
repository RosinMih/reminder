
namespace reminder
{
    partial class FormAlarm
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
            this.labelTaskText = new System.Windows.Forms.Label();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonRepeatAfterAnHour = new System.Windows.Forms.Button();
            this.buttonRepeatAfterAnDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTaskText
            // 
            this.labelTaskText.AutoSize = true;
            this.labelTaskText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskText.Location = new System.Drawing.Point(34, 41);
            this.labelTaskText.Name = "labelTaskText";
            this.labelTaskText.Size = new System.Drawing.Size(0, 26);
            this.labelTaskText.TabIndex = 0;
            // 
            // buttonComplete
            // 
            this.buttonComplete.Location = new System.Drawing.Point(12, 152);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(100, 23);
            this.buttonComplete.TabIndex = 1;
            this.buttonComplete.Text = "Завершить";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // buttonRepeatAfterAnHour
            // 
            this.buttonRepeatAfterAnHour.Location = new System.Drawing.Point(140, 152);
            this.buttonRepeatAfterAnHour.Name = "buttonRepeatAfterAnHour";
            this.buttonRepeatAfterAnHour.Size = new System.Drawing.Size(155, 23);
            this.buttonRepeatAfterAnHour.TabIndex = 2;
            this.buttonRepeatAfterAnHour.Text = "Напомнить через час";
            this.buttonRepeatAfterAnHour.UseVisualStyleBackColor = true;
            this.buttonRepeatAfterAnHour.Click += new System.EventHandler(this.RepeatAfterAnHour_Click);
            // 
            // buttonRepeatAfterAnDay
            // 
            this.buttonRepeatAfterAnDay.Location = new System.Drawing.Point(313, 151);
            this.buttonRepeatAfterAnDay.Name = "buttonRepeatAfterAnDay";
            this.buttonRepeatAfterAnDay.Size = new System.Drawing.Size(139, 23);
            this.buttonRepeatAfterAnDay.TabIndex = 3;
            this.buttonRepeatAfterAnDay.Text = "Напомнить через день";
            this.buttonRepeatAfterAnDay.UseVisualStyleBackColor = true;
            this.buttonRepeatAfterAnDay.Click += new System.EventHandler(this.RepeatAfterAnDay_Click);
            // 
            // FormAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(464, 208);
            this.Controls.Add(this.buttonRepeatAfterAnDay);
            this.Controls.Add(this.buttonRepeatAfterAnHour);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.labelTaskText);
            this.Name = "FormAlarm";
            this.Text = "Событие";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAlarm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaskText;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonRepeatAfterAnHour;
        private System.Windows.Forms.Button buttonRepeatAfterAnDay;
    }
}