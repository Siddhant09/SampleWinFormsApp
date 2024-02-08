namespace WinFormsApp
{
    partial class SampleForm
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
            lblName = new Label();
            txtName = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblEmail = new Label();
            lblBirthday = new Label();
            lblColor = new Label();
            lblMarried = new Label();
            txtEMail = new TextBox();
            cbMarried = new CheckBox();
            dpBirthday = new DateTimePicker();
            btnSubmit = new Button();
            grdUsers = new DataGridView();
            plColor = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsers).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 37);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(82, 7);
            txtName.Margin = new Padding(3, 7, 3, 7);
            txtName.Name = "txtName";
            txtName.Size = new Size(365, 23);
            txtName.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.55556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.44444F));
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 1);
            tableLayoutPanel1.Controls.Add(lblBirthday, 0, 2);
            tableLayoutPanel1.Controls.Add(lblColor, 0, 3);
            tableLayoutPanel1.Controls.Add(lblMarried, 0, 4);
            tableLayoutPanel1.Controls.Add(txtEMail, 1, 1);
            tableLayoutPanel1.Controls.Add(cbMarried, 1, 4);
            tableLayoutPanel1.Controls.Add(dpBirthday, 1, 2);
            tableLayoutPanel1.Controls.Add(btnSubmit, 1, 5);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Controls.Add(grdUsers, 1, 6);
            tableLayoutPanel1.Controls.Add(plColor, 1, 3);
            tableLayoutPanel1.Location = new Point(17, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(450, 571);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 37);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 37);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email :";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBirthday
            // 
            lblBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(3, 74);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(57, 37);
            lblBirthday.TabIndex = 3;
            lblBirthday.Text = "Birthday :";
            lblBirthday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblColor
            // 
            lblColor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblColor.AutoSize = true;
            lblColor.Location = new Point(3, 111);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(42, 35);
            lblColor.TabIndex = 4;
            lblColor.Text = "Color :";
            lblColor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMarried
            // 
            lblMarried.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblMarried.AutoSize = true;
            lblMarried.Location = new Point(3, 146);
            lblMarried.Name = "lblMarried";
            lblMarried.Size = new Size(54, 33);
            lblMarried.TabIndex = 5;
            lblMarried.Text = "Married :";
            lblMarried.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEMail
            // 
            txtEMail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEMail.Location = new Point(82, 44);
            txtEMail.Margin = new Padding(3, 7, 3, 7);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(365, 23);
            txtEMail.TabIndex = 6;
            // 
            // cbMarried
            // 
            cbMarried.AutoSize = true;
            cbMarried.Location = new Point(82, 153);
            cbMarried.Margin = new Padding(3, 7, 3, 7);
            cbMarried.Name = "cbMarried";
            cbMarried.Size = new Size(43, 19);
            cbMarried.TabIndex = 8;
            cbMarried.Text = "Yes";
            cbMarried.UseVisualStyleBackColor = true;
            // 
            // dpBirthday
            // 
            dpBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dpBirthday.Location = new Point(82, 81);
            dpBirthday.Margin = new Padding(3, 7, 3, 7);
            dpBirthday.Name = "dpBirthday";
            dpBirthday.Size = new Size(365, 23);
            dpBirthday.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.ImageAlign = ContentAlignment.MiddleRight;
            btnSubmit.Location = new Point(347, 186);
            btnSubmit.Margin = new Padding(3, 7, 3, 7);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.RightToLeft = RightToLeft.No;
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // grdUsers
            // 
            grdUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(grdUsers, 2);
            grdUsers.Location = new Point(3, 226);
            grdUsers.MultiSelect = false;
            grdUsers.Name = "grdUsers";
            grdUsers.ReadOnly = true;
            grdUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsers.Size = new Size(444, 342);
            grdUsers.TabIndex = 11;
            // 
            // plColor
            // 
            plColor.Location = new Point(82, 114);
            plColor.Name = "plColor";
            plColor.Size = new Size(365, 29);
            plColor.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 603);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "Sample";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblEmail;
        private Label lblBirthday;
        private Label lblColor;
        private Label lblMarried;
        private TextBox txtEMail;
        private Button btnSubmit;
        private CheckBox cbMarried;
        private DateTimePicker dpBirthday;
        private DataGridView grdUsers;
        private Panel plColor;
    }
}
