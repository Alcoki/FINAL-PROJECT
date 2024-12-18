namespace CSSFD_FinalProject
{
    partial class Form2
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.btnUpdateGrade = new System.Windows.Forms.Button();
            this.btnDeleteGrade = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblUpdateGrade = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblDeleteGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.txtDeleteSubject = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblWelcome.Location = new System.Drawing.Point(201, 88);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(103, 25);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome";
            // 
            // dgvGrades
            // 
            this.dgvGrades.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(72, 116);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.Size = new System.Drawing.Size(387, 150);
            this.dgvGrades.TabIndex = 5;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(352, 323);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(75, 23);
            this.btnAddGrade.TabIndex = 6;
            this.btnAddGrade.Text = "Create";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdateGrade
            // 
            this.btnUpdateGrade.Location = new System.Drawing.Point(229, 351);
            this.btnUpdateGrade.Name = "btnUpdateGrade";
            this.btnUpdateGrade.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateGrade.TabIndex = 7;
            this.btnUpdateGrade.Text = "Update";
            this.btnUpdateGrade.UseVisualStyleBackColor = true;
            this.btnUpdateGrade.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteGrade
            // 
            this.btnDeleteGrade.Location = new System.Drawing.Point(182, 388);
            this.btnDeleteGrade.Name = "btnDeleteGrade";
            this.btnDeleteGrade.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGrade.TabIndex = 8;
            this.btnDeleteGrade.Text = "Delete";
            this.btnDeleteGrade.UseVisualStyleBackColor = true;
            this.btnDeleteGrade.Click += new System.EventHandler(this.btnDeleteGrade_Click_1);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(89, 325);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(96, 20);
            this.txtSubject.TabIndex = 9;
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.Location = new System.Drawing.Point(384, 243);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(75, 23);
            this.btnViewGrades.TabIndex = 10;
            this.btnViewGrades.Text = "View";
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Unispace", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSubject.Location = new System.Drawing.Point(12, 325);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(71, 18);
            this.lblSubject.TabIndex = 12;
            this.lblSubject.Text = "Subject";
            // 
            // lblUpdateGrade
            // 
            this.lblUpdateGrade.AutoSize = true;
            this.lblUpdateGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateGrade.Font = new System.Drawing.Font("Unispace", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateGrade.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblUpdateGrade.Location = new System.Drawing.Point(5, 353);
            this.lblUpdateGrade.Name = "lblUpdateGrade";
            this.lblUpdateGrade.Size = new System.Drawing.Size(116, 18);
            this.lblUpdateGrade.TabIndex = 13;
            this.lblUpdateGrade.Text = "Update Grade";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblGrade.Font = new System.Drawing.Font("Unispace", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblGrade.Location = new System.Drawing.Point(191, 327);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(53, 18);
            this.lblGrade.TabIndex = 14;
            this.lblGrade.Text = "Grade";
            // 
            // lblDeleteGrade
            // 
            this.lblDeleteGrade.AutoSize = true;
            this.lblDeleteGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteGrade.Font = new System.Drawing.Font("Unispace", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteGrade.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDeleteGrade.Location = new System.Drawing.Point(12, 388);
            this.lblDeleteGrade.Name = "lblDeleteGrade";
            this.lblDeleteGrade.Size = new System.Drawing.Size(62, 18);
            this.lblDeleteGrade.TabIndex = 15;
            this.lblDeleteGrade.Text = "Delete";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(250, 325);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(96, 20);
            this.txtGrade.TabIndex = 16;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(127, 353);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(96, 20);
            this.txtUpdate.TabIndex = 17;
            // 
            // txtDeleteSubject
            // 
            this.txtDeleteSubject.Location = new System.Drawing.Point(80, 388);
            this.txtDeleteSubject.Name = "txtDeleteSubject";
            this.txtDeleteSubject.Size = new System.Drawing.Size(96, 20);
            this.txtDeleteSubject.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSSFD_FinalProject.Properties.Resources.backgroybndd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDeleteSubject);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblDeleteGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblUpdateGrade);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnViewGrades);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnDeleteGrade);
            this.Controls.Add(this.btnUpdateGrade);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.lblWelcome);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Button btnUpdateGrade;
        private System.Windows.Forms.Button btnDeleteGrade;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnViewGrades;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblUpdateGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblDeleteGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.TextBox txtDeleteSubject;
    }
}