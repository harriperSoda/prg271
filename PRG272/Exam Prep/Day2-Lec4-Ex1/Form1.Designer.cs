namespace Day2_Lec4_Ex1
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
            this.BtnReadData = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnSort = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnReadData
            // 
            this.BtnReadData.Location = new System.Drawing.Point(105, 85);
            this.BtnReadData.Name = "BtnReadData";
            this.BtnReadData.Size = new System.Drawing.Size(75, 23);
            this.BtnReadData.TabIndex = 0;
            this.BtnReadData.Text = "Read Data";
            this.BtnReadData.UseVisualStyleBackColor = true;
            this.BtnReadData.Click += new System.EventHandler(this.BtnReadData_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(61, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(187, 185);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(597, 85);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(75, 23);
            this.BtnSort.TabIndex = 2;
            this.BtnSort.Text = "Sort Asscending";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(547, 143);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(187, 185);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnReadData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnReadData;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.ListView listView2;
    }
}

