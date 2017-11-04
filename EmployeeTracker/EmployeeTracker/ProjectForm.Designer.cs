namespace EmployeeTracker
{
    partial class ProjectForm
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
            this.lblResult = new System.Windows.Forms.Label();
            this.projectId = new System.Windows.Forms.Label();
            this.projectIdTxt = new System.Windows.Forms.TextBox();
            this.projectName = new System.Windows.Forms.Label();
            this.projectNameTxt = new System.Windows.Forms.TextBox();
            this.projectDescription = new System.Windows.Forms.Label();
            this.projectDescriptionTxt = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(367, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 17);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "label1";
            // 
            // projectId
            // 
            this.projectId.AutoSize = true;
            this.projectId.Location = new System.Drawing.Point(13, 65);
            this.projectId.Name = "projectId";
            this.projectId.Size = new System.Drawing.Size(69, 17);
            this.projectId.TabIndex = 1;
            this.projectId.Text = "Project ID";
            // 
            // projectIdTxt
            // 
            this.projectIdTxt.Location = new System.Drawing.Point(89, 65);
            this.projectIdTxt.Name = "projectIdTxt";
            this.projectIdTxt.Size = new System.Drawing.Size(159, 22);
            this.projectIdTxt.TabIndex = 2;
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Location = new System.Drawing.Point(13, 121);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(93, 17);
            this.projectName.TabIndex = 3;
            this.projectName.Text = "Project Name";
            // 
            // projectNameTxt
            // 
            this.projectNameTxt.Location = new System.Drawing.Point(112, 121);
            this.projectNameTxt.Name = "projectNameTxt";
            this.projectNameTxt.Size = new System.Drawing.Size(172, 22);
            this.projectNameTxt.TabIndex = 4;
            // 
            // projectDescription
            // 
            this.projectDescription.AutoSize = true;
            this.projectDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.projectDescription.Location = new System.Drawing.Point(13, 169);
            this.projectDescription.Name = "projectDescription";
            this.projectDescription.Size = new System.Drawing.Size(127, 17);
            this.projectDescription.TabIndex = 5;
            this.projectDescription.Text = "Project Description";
            
            // 
            // projectDescriptionTxt
            // 
            this.projectDescriptionTxt.BackColor = System.Drawing.Color.White;
            this.projectDescriptionTxt.Location = new System.Drawing.Point(163, 163);
            this.projectDescriptionTxt.Multiline = true;
            this.projectDescriptionTxt.Name = "projectDescriptionTxt";
            this.projectDescriptionTxt.Size = new System.Drawing.Size(250, 155);
            this.projectDescriptionTxt.TabIndex = 6;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(16, 362);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(72, 17);
            this.startDate.TabIndex = 7;
            this.startDate.Text = "Start Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 362);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(16, 426);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(67, 17);
            this.endDate.TabIndex = 9;
            this.endDate.Text = "End Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(163, 420);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(163, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 517);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.projectDescriptionTxt);
            this.Controls.Add(this.projectDescription);
            this.Controls.Add(this.projectNameTxt);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.projectIdTxt);
            this.Controls.Add(this.projectId);
            this.Controls.Add(this.lblResult);
            this.Name = "s";
            this.Text = "ProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label projectId;
        private System.Windows.Forms.TextBox projectIdTxt;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.TextBox projectNameTxt;
        private System.Windows.Forms.Label projectDescription;
        private System.Windows.Forms.TextBox projectDescriptionTxt;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnSave;
    }
}