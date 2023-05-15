namespace WinFormsApp1
{
    partial class FormList
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
            dgvPerson = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnOK = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPerson
            // 
            dgvPerson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvPerson.Location = new Point(12, 12);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.RowHeadersWidth = 51;
            dgvPerson.RowTemplate.Height = 29;
            dgvPerson.Size = new Size(776, 336);
            dgvPerson.TabIndex = 0;
            dgvPerson.RowHeaderMouseClick += dgvPerson_RowHeaderMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "编号";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "名字";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Age";
            Column3.HeaderText = "年龄";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Sex";
            Column4.HeaderText = "性别";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnOK);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(12, 364);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 74);
            panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(591, 22);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(125, 34);
            btnOK.TabIndex = 1;
            btnOK.Text = "确认";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(406, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 34);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgvPerson);
            Name = "FormList";
            Text = "FormList";
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPerson;
        private Panel panel1;
        private Button btnOK;
        private Button btnCancel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}