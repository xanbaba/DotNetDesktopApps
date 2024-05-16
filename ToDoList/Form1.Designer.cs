namespace ToDoList
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tasksListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isUrgentLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.expireDateLabel = new System.Windows.Forms.Label();
            this.createTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.addTask = new System.Windows.Forms.Button();
            this.expireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.urgentlyCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isDoneLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.createTaskGroupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasksListBox
            // 
            this.tasksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.ItemHeight = 18;
            this.tasksListBox.Location = new System.Drawing.Point(16, 15);
            this.tasksListBox.Margin = new System.Windows.Forms.Padding(4);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(365, 364);
            this.tasksListBox.TabIndex = 0;
            this.tasksListBox.SelectedIndexChanged += new System.EventHandler(this.tasksListBox_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(16, 411);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(125, 48);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(149, 411);
            this.doneButton.Margin = new System.Windows.Forms.Padding(4);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(125, 48);
            this.doneButton.TabIndex = 2;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(391, 185);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(477, 211);
            this.descriptionLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(391, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(391, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title:";
            // 
            // titleLabel
            // 
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(391, 43);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(477, 75);
            this.titleLabel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(391, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Is Urgent?:";
            // 
            // isUrgentLabel
            // 
            this.isUrgentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isUrgentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isUrgentLabel.Location = new System.Drawing.Point(527, 411);
            this.isUrgentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isUrgentLabel.Name = "isUrgentLabel";
            this.isUrgentLabel.Size = new System.Drawing.Size(62, 48);
            this.isUrgentLabel.TabIndex = 8;
            this.isUrgentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(609, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Priority:";
            // 
            // priorityLabel
            // 
            this.priorityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityLabel.Location = new System.Drawing.Point(719, 411);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(149, 48);
            this.priorityLabel.TabIndex = 10;
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(391, 506);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Expire Date:";
            // 
            // expireDateLabel
            // 
            this.expireDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expireDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expireDateLabel.Location = new System.Drawing.Point(551, 486);
            this.expireDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expireDateLabel.Name = "expireDateLabel";
            this.expireDateLabel.Size = new System.Drawing.Size(317, 48);
            this.expireDateLabel.TabIndex = 12;
            this.expireDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createTaskGroupBox
            // 
            this.createTaskGroupBox.Controls.Add(this.infoLabel);
            this.createTaskGroupBox.Controls.Add(this.addTask);
            this.createTaskGroupBox.Controls.Add(this.expireDateTimePicker);
            this.createTaskGroupBox.Controls.Add(this.label9);
            this.createTaskGroupBox.Controls.Add(this.urgentlyCheckBox);
            this.createTaskGroupBox.Controls.Add(this.label7);
            this.createTaskGroupBox.Controls.Add(this.priorityComboBox);
            this.createTaskGroupBox.Controls.Add(this.descriptionTextBox);
            this.createTaskGroupBox.Controls.Add(this.label5);
            this.createTaskGroupBox.Controls.Add(this.titleTextBox);
            this.createTaskGroupBox.Controls.Add(this.label3);
            this.createTaskGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTaskGroupBox.Location = new System.Drawing.Point(897, 15);
            this.createTaskGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.createTaskGroupBox.Name = "createTaskGroupBox";
            this.createTaskGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.createTaskGroupBox.Size = new System.Drawing.Size(609, 612);
            this.createTaskGroupBox.TabIndex = 13;
            this.createTaskGroupBox.TabStop = false;
            this.createTaskGroupBox.Text = "Create New Task";
            // 
            // infoLabel
            // 
            this.infoLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.infoLabel.Location = new System.Drawing.Point(184, 544);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(404, 28);
            this.infoLabel.TabIndex = 20;
            this.infoLabel.Text = "Fill all the the required fields";
            this.infoLabel.Visible = false;
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(24, 535);
            this.addTask.Margin = new System.Windows.Forms.Padding(4);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(125, 48);
            this.addTask.TabIndex = 14;
            this.addTask.Text = "Add";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // expireDateTimePicker
            // 
            this.expireDateTimePicker.Location = new System.Drawing.Point(184, 458);
            this.expireDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.expireDateTimePicker.Name = "expireDateTimePicker";
            this.expireDateTimePicker.Size = new System.Drawing.Size(293, 30);
            this.expireDateTimePicker.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(24, 466);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "Expire Date:";
            // 
            // urgentlyCheckBox
            // 
            this.urgentlyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urgentlyCheckBox.Location = new System.Drawing.Point(375, 380);
            this.urgentlyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.urgentlyCheckBox.Name = "urgentlyCheckBox";
            this.urgentlyCheckBox.Size = new System.Drawing.Size(144, 30);
            this.urgentlyCheckBox.TabIndex = 18;
            this.urgentlyCheckBox.Text = "Urgently";
            this.urgentlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Priority:";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Location = new System.Drawing.Point(184, 373);
            this.priorityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(140, 33);
            this.priorityComboBox.TabIndex = 17;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(184, 108);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(416, 226);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 110);
            this.label5.TabIndex = 14;
            this.label5.Text = "Description:\r\nCan be empty";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(184, 37);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(416, 30);
            this.titleTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Title:";
            // 
            // isDoneLabel
            // 
            this.isDoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isDoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isDoneLabel.Location = new System.Drawing.Point(527, 560);
            this.isDoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isDoneLabel.Name = "isDoneLabel";
            this.isDoneLabel.Size = new System.Drawing.Size(62, 48);
            this.isDoneLabel.TabIndex = 15;
            this.isDoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(391, 570);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 28);
            this.label11.TabIndex = 14;
            this.label11.Text = "Is Done?:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripDropDownButton1 });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1521, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 641);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.isDoneLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.createTaskGroupBox);
            this.Controls.Add(this.expireDateLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isUrgentLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.tasksListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.createTaskGroupBox.ResumeLayout(false);
            this.createTaskGroupBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.Label isDoneLabel;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label infoLabel;

        private System.Windows.Forms.Button addTask;

        private System.Windows.Forms.DateTimePicker expireDateTimePicker;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.CheckBox urgentlyCheckBox;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.ComboBox priorityComboBox;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionTextBox;

        private System.Windows.Forms.GroupBox createTaskGroupBox;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label expireDateLabel;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label priorityLabel;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label isUrgentLabel;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button doneButton;

        #endregion
    }
}