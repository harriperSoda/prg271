namespace Lec4_Ex1
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
            lstView1 = new ListView();
            No = new ColumnHeader();
            listView2 = new ListView();
            button1 = new Button();
            button2 = new Button();
            Num = new ColumnHeader();
            SuspendLayout();
            // 
            // lstView1
            // 
            lstView1.Columns.AddRange(new ColumnHeader[] { No });
            lstView1.Location = new Point(149, 115);
            lstView1.Name = "lstView1";
            lstView1.Size = new Size(121, 252);
            lstView1.TabIndex = 0;
            lstView1.UseCompatibleStateImageBehavior = false;
            lstView1.View = View.Details;
            lstView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { Num });
            listView2.Location = new Point(552, 115);
            listView2.Name = "listView2";
            listView2.Size = new Size(121, 252);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(170, 61);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 2;
            button1.Text = "Read Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(563, 61);
            button2.Name = "button2";
            button2.Size = new Size(98, 31);
            button2.TabIndex = 3;
            button2.Text = "Sort Ascending";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView2);
            Controls.Add(lstView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView lstView1;
        private ListView listView2;
        private Button button1;
        private Button button2;
        private ColumnHeader No;
        private ColumnHeader Num;
    }
}
