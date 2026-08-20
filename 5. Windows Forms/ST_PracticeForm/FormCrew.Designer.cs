namespace ST_PracticeForm
{
    partial class FormCrew
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
            this.dataGridViewCrewTable = new System.Windows.Forms.DataGridView();
            this.labelCrewHeading = new System.Windows.Forms.Label();
            this.buttonAddCrew = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCrewTable
            // 
            this.dataGridViewCrewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrewTable.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewCrewTable.Name = "dataGridViewCrewTable";
            this.dataGridViewCrewTable.Size = new System.Drawing.Size(776, 276);
            this.dataGridViewCrewTable.TabIndex = 0;
            // 
            // labelCrewHeading
            // 
            this.labelCrewHeading.AutoSize = true;
            this.labelCrewHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrewHeading.Location = new System.Drawing.Point(12, 9);
            this.labelCrewHeading.Name = "labelCrewHeading";
            this.labelCrewHeading.Size = new System.Drawing.Size(166, 29);
            this.labelCrewHeading.TabIndex = 1;
            this.labelCrewHeading.Text = "Crew Manifest";
            this.labelCrewHeading.Click += new System.EventHandler(this.labelCrewHeading_Click);
            // 
            // buttonAddCrew
            // 
            this.buttonAddCrew.Location = new System.Drawing.Point(37, 377);
            this.buttonAddCrew.Name = "buttonAddCrew";
            this.buttonAddCrew.Size = new System.Drawing.Size(90, 46);
            this.buttonAddCrew.TabIndex = 2;
            this.buttonAddCrew.Text = "Add Crew";
            this.buttonAddCrew.UseVisualStyleBackColor = true;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(662, 377);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(90, 46);
            this.buttonGoBack.TabIndex = 3;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            // 
            // FormCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonAddCrew);
            this.Controls.Add(this.labelCrewHeading);
            this.Controls.Add(this.dataGridViewCrewTable);
            this.Name = "FormCrew";
            this.Text = "FormCrew";
            this.Load += new System.EventHandler(this.FormCrew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCrewTable;
        private System.Windows.Forms.Label labelCrewHeading;
        private System.Windows.Forms.Button buttonAddCrew;
        private System.Windows.Forms.Button buttonGoBack;
    }
}