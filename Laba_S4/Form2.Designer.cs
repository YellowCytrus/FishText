using System.Windows.Forms;

namespace Laba_S4
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
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            CancelButton = new Button();
            SaveButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(richTextBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(richTextBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBox4, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1058, 518);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(532, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(523, 253);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(3, 262);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(523, 253);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(532, 262);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(523, 253);
            richTextBox4.TabIndex = 1;
            richTextBox4.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(523, 253);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(958, 552);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(109, 29);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(828, 552);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(109, 29);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 593);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1100, 640);
            MinimumSize = new Size(1100, 640);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Словарь";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox2;
        private Button CancelButton;
        private Button SaveButton;
    }
}