namespace ST_PracticeForm
{
    partial class MissionControlForm
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
            this.dataGridViewMissions = new System.Windows.Forms.DataGridView();
            this.buttonBackMissionControl = new System.Windows.Forms.Button();
            this.buttonAddMission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Missions";
            // 
            // dataGridViewMissions
            // 
            this.dataGridViewMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMissions.Location = new System.Drawing.Point(19, 90);
            this.dataGridViewMissions.Name = "dataGridViewMissions";
            this.dataGridViewMissions.Size = new System.Drawing.Size(750, 175);
            this.dataGridViewMissions.TabIndex = 1;
            // 
            // buttonBackMissionControl
            // 
            this.buttonBackMissionControl.Location = new System.Drawing.Point(647, 323);
            this.buttonBackMissionControl.Name = "buttonBackMissionControl";
            this.buttonBackMissionControl.Size = new System.Drawing.Size(74, 40);
            this.buttonBackMissionControl.TabIndex = 2;
            this.buttonBackMissionControl.Text = "Back";
            this.buttonBackMissionControl.UseVisualStyleBackColor = true;
            this.buttonBackMissionControl.Click += new System.EventHandler(this.buttonBackMissionControl_Click);
            // 
            // buttonAddMission
            // 
            this.buttonAddMission.Location = new System.Drawing.Point(38, 323);
            this.buttonAddMission.Name = "buttonAddMission";
            this.buttonAddMission.Size = new System.Drawing.Size(74, 40);
            this.buttonAddMission.TabIndex = 3;
            this.buttonAddMission.Text = "Add Mission";
            this.buttonAddMission.UseVisualStyleBackColor = true;
            this.buttonAddMission.Click += new System.EventHandler(this.button1_Click);
            // 
            // MissionControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddMission);
            this.Controls.Add(this.buttonBackMissionControl);
            this.Controls.Add(this.dataGridViewMissions);
            this.Controls.Add(this.label1);
            this.Name = "MissionControlForm";
            this.Text = "MissionControlForm";
            this.Load += new System.EventHandler(this.MissionControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMissions;
        private System.Windows.Forms.Button buttonBackMissionControl;
        private System.Windows.Forms.Button buttonAddMission;
    }
}