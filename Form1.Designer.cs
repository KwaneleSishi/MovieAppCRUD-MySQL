namespace MovieApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvMovies = new DataGridView();
            txtGenre = new TextBox();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClear = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(26, 304);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.Size = new Size(435, 150);
            dgvMovies.TabIndex = 0;
            dgvMovies.CellClick += dgvMovies_CellClick;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(26, 173);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(127, 23);
            txtGenre.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(26, 119);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(127, 23);
            txtTitle.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(26, 227);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(127, 23);
            txtPrice.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(489, 67);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 37);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(489, 226);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 34);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(489, 172);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(489, 118);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 34);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 155);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 137);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 101);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 12;
            label4.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 209);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 13;
            label5.Text = "Price";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(78, 256);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 31);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 46);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 15;
            label1.Text = "Cinema";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(805, 484);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtTitle);
            Controls.Add(txtGenre);
            Controls.Add(dgvMovies);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMovies;
        private TextBox txtGenre;
        private TextBox txtTitle;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnClear;
        private Label label1;
    }
}
