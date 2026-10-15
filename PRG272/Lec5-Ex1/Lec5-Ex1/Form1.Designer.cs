namespace Lec5_Ex1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxJob = new TextBox();
            btnAddToList = new Button();
            button2 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            person = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 98);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 137);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 180);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Job: ";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(172, 98);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(156, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(172, 137);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(156, 23);
            textBoxSurname.TabIndex = 4;
            // 
            // textBoxJob
            // 
            textBoxJob.Location = new Point(172, 177);
            textBoxJob.Name = "textBoxJob";
            textBoxJob.Size = new Size(156, 23);
            textBoxJob.TabIndex = 5;
            // 
            // btnAddToList
            // 
            btnAddToList.Location = new Point(258, 217);
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(70, 23);
            btnAddToList.TabIndex = 6;
            btnAddToList.Text = "Add To list";
            btnAddToList.UseVisualStyleBackColor = true;
            btnAddToList.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(245, 291);
            button2.Name = "button2";
            button2.Size = new Size(83, 23);
            button2.TabIndex = 7;
            button2.Text = "Save To File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(245, 320);
            button3.Name = "button3";
            button3.Size = new Size(83, 47);
            button3.TabIndex = 8;
            button3.Text = "Read From File";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { person });
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listView1.Location = new Point(466, 99);
            listView1.Name = "listView1";
            listView1.Size = new Size(296, 250);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // person
            // 
            person.Width = 650;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAddToList);
            Controls.Add(textBoxJob);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxJob;
        private Button btnAddToList;
        private Button button2;
        private Button button3;
        private ListView listView1;
        private ColumnHeader person;
    }
}
