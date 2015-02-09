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
            this.ContestantScoreDataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EasyDataGrid = new System.Windows.Forms.DataGridView();
            this.PostQuestion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AverageDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ContestantScoreDataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EasyDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AverageDataGrid)).BeginInit();
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
            // ContestantScoreDataGrid
            // 
            this.ContestantScoreDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContestantScoreDataGrid.Location = new System.Drawing.Point(712, 412);
            this.ContestantScoreDataGrid.Name = "ContestantScoreDataGrid";
            this.ContestantScoreDataGrid.Size = new System.Drawing.Size(446, 226);
            this.ContestantScoreDataGrid.TabIndex = 5;
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
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            // EasyDataGrid
            // 
            this.EasyDataGrid.AllowUserToAddRows = false;
            this.EasyDataGrid.AllowUserToDeleteRows = false;
            this.EasyDataGrid.AllowUserToOrderColumns = true;
            this.EasyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EasyDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostQuestion});
            this.EasyDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EasyDataGrid.Location = new System.Drawing.Point(3, 3);
            this.EasyDataGrid.Name = "EasyDataGrid";
            this.EasyDataGrid.ReadOnly = true;
            this.EasyDataGrid.Size = new System.Drawing.Size(1145, 362);
            this.EasyDataGrid.TabIndex = 0;
            this.EasyDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // PostQuestion
            // 
            this.PostQuestion.HeaderText = "";
            this.PostQuestion.Name = "PostQuestion";
            this.PostQuestion.ReadOnly = true;
            this.PostQuestion.Text = "Post Now";
            this.PostQuestion.UseColumnTextForButtonValue = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AverageDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1151, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Average";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AverageDataGrid
            // 
            this.AverageDataGrid.AllowUserToAddRows = false;
            this.AverageDataGrid.AllowUserToDeleteRows = false;
            this.AverageDataGrid.AllowUserToOrderColumns = true;
            this.AverageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AverageDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.AverageDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AverageDataGrid.Location = new System.Drawing.Point(3, 3);
            this.AverageDataGrid.Name = "AverageDataGrid";
            this.AverageDataGrid.ReadOnly = true;
            this.AverageDataGrid.Size = new System.Drawing.Size(1145, 362);
            this.AverageDataGrid.TabIndex = 1;
            this.AverageDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Post Now";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 643);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ContestantScoreDataGrid);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Server Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContestantScoreDataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EasyDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AverageDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.DataGridView ContestantScoreDataGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView EasyDataGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView AverageDataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn PostQuestion;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}

