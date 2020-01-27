namespace WindowsFormsApp3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SaveAsBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReplacedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReplaceBtn2 = new System.Windows.Forms.Button();
            this.DeletedTextBox = new System.Windows.Forms.TextBox();
            this.SavedAsTextBox = new System.Windows.Forms.TextBox();
            this.AddedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(529, 149);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // replaceBtn
            // 
            this.replaceBtn.Location = new System.Drawing.Point(222, 167);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(103, 23);
            this.replaceBtn.TabIndex = 1;
            this.replaceBtn.Text = "Replace";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.ReplaceBtn);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(62, 52);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add ";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn);
            // 
            // SaveAsBtn
            // 
            this.SaveAsBtn.Location = new System.Drawing.Point(417, 52);
            this.SaveAsBtn.Name = "SaveAsBtn";
            this.SaveAsBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveAsBtn.TabIndex = 3;
            this.SaveAsBtn.Text = "Save As";
            this.SaveAsBtn.UseVisualStyleBackColor = true;
            this.SaveAsBtn.Click += new System.EventHandler(this.SaveAsBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(154, 52);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.ReplacedTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ReplaceBtn2);
            this.groupBox1.Controls.Add(this.DeletedTextBox);
            this.groupBox1.Controls.Add(this.SavedAsTextBox);
            this.groupBox1.Controls.Add(this.AddedTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.SaveAsBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 249);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add, Replace, Save As, Delete Files:";
            // 
            // ReplacedTextBox
            // 
            this.ReplacedTextBox.Location = new System.Drawing.Point(325, 102);
            this.ReplacedTextBox.Name = "ReplacedTextBox";
            this.ReplacedTextBox.ReadOnly = true;
            this.ReplacedTextBox.Size = new System.Drawing.Size(167, 20);
            this.ReplacedTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Replaced:";
            // 
            // ReplaceBtn2
            // 
            this.ReplaceBtn2.Location = new System.Drawing.Point(325, 52);
            this.ReplaceBtn2.Name = "ReplaceBtn2";
            this.ReplaceBtn2.Size = new System.Drawing.Size(75, 23);
            this.ReplaceBtn2.TabIndex = 11;
            this.ReplaceBtn2.Text = "Replace";
            this.ReplaceBtn2.UseVisualStyleBackColor = true;
            this.ReplaceBtn2.Click += new System.EventHandler(this.ReplaceBtn2_Click);
            // 
            // DeletedTextBox
            // 
            this.DeletedTextBox.Location = new System.Drawing.Point(62, 145);
            this.DeletedTextBox.Name = "DeletedTextBox";
            this.DeletedTextBox.ReadOnly = true;
            this.DeletedTextBox.Size = new System.Drawing.Size(167, 20);
            this.DeletedTextBox.TabIndex = 10;
            // 
            // SavedAsTextBox
            // 
            this.SavedAsTextBox.Location = new System.Drawing.Point(325, 145);
            this.SavedAsTextBox.Name = "SavedAsTextBox";
            this.SavedAsTextBox.ReadOnly = true;
            this.SavedAsTextBox.Size = new System.Drawing.Size(167, 20);
            this.SavedAsTextBox.TabIndex = 9;
            // 
            // AddedTextBox
            // 
            this.AddedTextBox.Location = new System.Drawing.Point(62, 102);
            this.AddedTextBox.Name = "AddedTextBox";
            this.AddedTextBox.ReadOnly = true;
            this.AddedTextBox.Size = new System.Drawing.Size(167, 20);
            this.AddedTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deleted:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saved As:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Added:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(210, 195);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(103, 23);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.replaceBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Removing HTML tags";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button SaveAsBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DeletedTextBox;
        private System.Windows.Forms.TextBox SavedAsTextBox;
        private System.Windows.Forms.TextBox AddedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ReplaceBtn2;
        private System.Windows.Forms.TextBox ReplacedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ClearBtn;
    }
}

