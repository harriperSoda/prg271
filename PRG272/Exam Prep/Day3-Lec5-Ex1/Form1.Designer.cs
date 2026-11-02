namespace Day3_Lec5_Ex1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnAddToList = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 10);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 10);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 10);
            this.label3.TabIndex = 2;
            this.label3.Text = "Job: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(97, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(184, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(97, 122);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(184, 20);
            this.textBoxSurname.TabIndex = 4;
            // 
            // textBoxJob
            // 
            this.textBoxJob.Location = new System.Drawing.Point(97, 162);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(184, 20);
            this.textBoxJob.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(431, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(326, 299);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // BtnAddToList
            // 
            this.BtnAddToList.Location = new System.Drawing.Point(315, 216);
            this.BtnAddToList.Name = "BtnAddToList";
            this.BtnAddToList.Size = new System.Drawing.Size(75, 23);
            this.BtnAddToList.TabIndex = 7;
            this.BtnAddToList.Text = "Add To list";
            this.BtnAddToList.UseVisualStyleBackColor = true;
            this.BtnAddToList.Click += new System.EventHandler(this.BtnAddToList_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(315, 318);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save To File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(306, 365);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(97, 23);
            this.buttonRead.TabIndex = 9;
            this.buttonRead.Text = "Read From File";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.BtnAddToList);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxJob);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BtnAddToList;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRead;
    }
}

