namespace ST_PracticeForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubTitle = new System.Windows.Forms.Label();
            this.buttonCrewManagement = new System.Windows.Forms.Button();
            this.buttonMissionControl = new System.Windows.Forms.Button();
            this.buttonEventLog = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(278, 49);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(241, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "THE ODDESY";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSubTitle
            // 
            this.labelSubTitle.AutoSize = true;
            this.labelSubTitle.Location = new System.Drawing.Point(355, 88);
            this.labelSubTitle.Name = "labelSubTitle";
            this.labelSubTitle.Size = new System.Drawing.Size(116, 13);
            this.labelSubTitle.TabIndex = 1;
            this.labelSubTitle.Text = "Voyager Control Centre";
            // 
            // buttonCrewManagement
            // 
            this.buttonCrewManagement.Location = new System.Drawing.Point(285, 161);
            this.buttonCrewManagement.Name = "buttonCrewManagement";
            this.buttonCrewManagement.Size = new System.Drawing.Size(241, 33);
            this.buttonCrewManagement.TabIndex = 2;
            this.buttonCrewManagement.Text = "Crew Management";
            this.buttonCrewManagement.UseVisualStyleBackColor = true;
            this.buttonCrewManagement.Click += new System.EventHandler(this.buttonCrewManagement_Click);
            // 
            // buttonMissionControl
            // 
            this.buttonMissionControl.Location = new System.Drawing.Point(285, 200);
            this.buttonMissionControl.Name = "buttonMissionControl";
            this.buttonMissionControl.Size = new System.Drawing.Size(241, 33);
            this.buttonMissionControl.TabIndex = 3;
            this.buttonMissionControl.Text = "Mission Control";
            this.buttonMissionControl.UseVisualStyleBackColor = true;
            // 
            // buttonEventLog
            // 
            this.buttonEventLog.Location = new System.Drawing.Point(285, 239);
            this.buttonEventLog.Name = "buttonEventLog";
            this.buttonEventLog.Size = new System.Drawing.Size(241, 33);
            this.buttonEventLog.TabIndex = 4;
            this.buttonEventLog.Text = "Event Log";
            this.buttonEventLog.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(285, 278);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(241, 33);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEventLog);
            this.Controls.Add(this.buttonMissionControl);
            this.Controls.Add(this.buttonCrewManagement);
            this.Controls.Add(this.labelSubTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubTitle;
        private System.Windows.Forms.Button buttonCrewManagement;
        private System.Windows.Forms.Button buttonMissionControl;
        private System.Windows.Forms.Button buttonEventLog;
        private System.Windows.Forms.Button buttonExit;
    }
}

