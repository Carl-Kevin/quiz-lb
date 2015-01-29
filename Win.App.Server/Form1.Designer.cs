namespace Win.App.Server
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EasyDataGrid = new System.Windows.Forms.DataGridView();
            this.PostQuestion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.QuestionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EasyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(3, 412);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(703, 226);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Logs";
            this.columnHeader1.Width = 200;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(712, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 226);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Players";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Points";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1159, 394);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EasyDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1151, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Easy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Average";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EasyDataGrid
            // 
            this.EasyDataGrid.AllowUserToAddRows = false;
            this.EasyDataGrid.AllowUserToDeleteRows = false;
            this.EasyDataGrid.AllowUserToOrderColumns = true;
            this.EasyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EasyDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostQuestion,
            this.QuestionNumber,
            this.Question,
            this.TimeFrame,
            this.DifficultyLevel});
            this.EasyDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EasyDataGrid.Location = new System.Drawing.Point(3, 3);
            this.EasyDataGrid.Name = "EasyDataGrid";
            this.EasyDataGrid.ReadOnly = true;
            this.EasyDataGrid.Size = new System.Drawing.Size(1145, 362);
            this.EasyDataGrid.TabIndex = 0;
            // 
            // PostQuestion
            // 
            this.PostQuestion.HeaderText = "";
            this.PostQuestion.Name = "PostQuestion";
            this.PostQuestion.ReadOnly = true;
            this.PostQuestion.Text = "Post Now";
            // 
            // QuestionNumber
            // 
            this.QuestionNumber.HeaderText = "Question Number";
            this.QuestionNumber.Name = "QuestionNumber";
            this.QuestionNumber.ReadOnly = true;
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            // 
            // TimeFrame
            // 
            this.TimeFrame.HeaderText = "Time Frame";
            this.TimeFrame.Name = "TimeFrame";
            this.TimeFrame.ReadOnly = true;
            // 
            // DifficultyLevel
            // 
            this.DifficultyLevel.HeaderText = "DifficultyLevel";
            this.DifficultyLevel.Name = "DifficultyLevel";
            this.DifficultyLevel.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 643);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Server Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EasyDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView EasyDataGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewButtonColumn PostQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFrame;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyLevel;
    }
}

