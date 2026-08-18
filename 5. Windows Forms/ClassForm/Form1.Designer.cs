namespace ClassForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.labelNext = new System.Windows.Forms.Label();
            this.labelPrev = new System.Windows.Forms.Label();
            this.labelVechineSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAllVech = new System.Windows.Forms.Button();
            this.buttonBusses = new System.Windows.Forms.Button();
            this.buttonCars = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonCars);
            this.groupBox1.Controls.Add(this.buttonBusses);
            this.groupBox1.Controls.Add(this.buttonAllVech);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.labelVechineSearch);
            this.groupBox1.Controls.Add(this.labelPrev);
            this.groupBox1.Controls.Add(this.labelNext);
            this.groupBox1.Controls.Add(this.buttonPrev);
            this.groupBox1.Controls.Add(this.buttonNext);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(373, 192);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(14, 192);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelNext
            // 
            this.labelNext.AutoSize = true;
            this.labelNext.Location = new System.Drawing.Point(394, 218);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(29, 13);
            this.labelNext.TabIndex = 3;
            this.labelNext.Text = "Next";
            // 
            // labelPrev
            // 
            this.labelPrev.AutoSize = true;
            this.labelPrev.Location = new System.Drawing.Point(27, 218);
            this.labelPrev.Name = "labelPrev";
            this.labelPrev.Size = new System.Drawing.Size(48, 13);
            this.labelPrev.TabIndex = 4;
            this.labelPrev.Text = "Previous";
            // 
            // labelVechineSearch
            // 
            this.labelVechineSearch.AutoSize = true;
            this.labelVechineSearch.Location = new System.Drawing.Point(11, 293);
            this.labelVechineSearch.Name = "labelVechineSearch";
            this.labelVechineSearch.Size = new System.Drawing.Size(110, 13);
            this.labelVechineSearch.TabIndex = 5;
            this.labelVechineSearch.Text = "Search Vehicle Name";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(127, 293);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(237, 20);
            this.textBoxSearch.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(405, 288);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(486, 288);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonAllVech
            // 
            this.buttonAllVech.Location = new System.Drawing.Point(633, 19);
            this.buttonAllVech.Name = "buttonAllVech";
            this.buttonAllVech.Size = new System.Drawing.Size(75, 53);
            this.buttonAllVech.TabIndex = 9;
            this.buttonAllVech.Text = "All Vehicles";
            this.buttonAllVech.UseVisualStyleBackColor = true;
            // 
            // buttonBusses
            // 
            this.buttonBusses.Location = new System.Drawing.Point(633, 78);
            this.buttonBusses.Name = "buttonBusses";
            this.buttonBusses.Size = new System.Drawing.Size(75, 53);
            this.buttonBusses.TabIndex = 10;
            this.buttonBusses.Text = "Busses";
            this.buttonBusses.UseVisualStyleBackColor = true;
            // 
            // buttonCars
            // 
            this.buttonCars.Location = new System.Drawing.Point(633, 137);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(75, 53);
            this.buttonCars.TabIndex = 11;
            this.buttonCars.Text = "Cars";
            this.buttonCars.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(633, 291);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelPrice);
            this.groupBox2.Controls.Add(this.labelType);
            this.groupBox2.Controls.Add(this.labelName);
            this.groupBox2.Location = new System.Drawing.Point(6, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Data";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(265, 59);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Type";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(477, 59);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelVechineSearch;
        private System.Windows.Forms.Label labelPrev;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Button buttonBusses;
        private System.Windows.Forms.Button buttonAllVech;
    }
}

