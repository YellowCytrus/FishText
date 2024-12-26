using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba_S4
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

        private void InitializeComponent()
        {
            Label SetLengthOfTextLabel;
            Label SetRegisterOfTextLabel;
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            useChatGPTCheckBox = new CheckBox();
            SetRegisterOfTextComboBox = new ComboBox();
            WathDataButton = new Button();
            GenerateTextButton = new Button();
            RandomRegisterCheckBox = new CheckBox();
            SetLengthOfTextNumeric = new NumericUpDown();
            GeneratedTextTextBox = new RichTextBox();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            GistogramPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            word1Label = new Label();
            word1Panel = new Panel();
            word2Label = new Label();
            word3Label = new Label();
            word2Panel = new Panel();
            word3Panel = new Panel();
            NumOfUnicWordsInTextLabel = new Label();
            NumOfWordsInTextLabel = new Label();
            NumOfCharsInTextLabel = new Label();
            SetLengthOfTextLabel = new Label();
            SetRegisterOfTextLabel = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SetLengthOfTextNumeric).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            GistogramPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SetLengthOfTextLabel
            // 
            SetLengthOfTextLabel.Location = new Point(3, 43);
            SetLengthOfTextLabel.Name = "SetLengthOfTextLabel";
            SetLengthOfTextLabel.Size = new Size(460, 25);
            SetLengthOfTextLabel.TabIndex = 0;
            SetLengthOfTextLabel.Text = "Укажите длину текста в предложении";
            SetLengthOfTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SetRegisterOfTextLabel
            // 
            SetRegisterOfTextLabel.Location = new Point(3, 141);
            SetRegisterOfTextLabel.Name = "SetRegisterOfTextLabel";
            SetRegisterOfTextLabel.Size = new Size(460, 25);
            SetRegisterOfTextLabel.TabIndex = 3;
            SetRegisterOfTextLabel.Text = "Выберите регистр";
            SetRegisterOfTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1058, 517);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(GeneratedTextTextBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1050, 484);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Генерация текста";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(useChatGPTCheckBox);
            panel1.Controls.Add(SetRegisterOfTextComboBox);
            panel1.Controls.Add(WathDataButton);
            panel1.Controls.Add(GenerateTextButton);
            panel1.Controls.Add(RandomRegisterCheckBox);
            panel1.Controls.Add(SetRegisterOfTextLabel);
            panel1.Controls.Add(SetLengthOfTextNumeric);
            panel1.Controls.Add(SetLengthOfTextLabel);
            panel1.Location = new Point(578, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 472);
            panel1.TabIndex = 1;
            // 
            // useChatGPTCheckBox
            // 
            useChatGPTCheckBox.AutoSize = true;
            useChatGPTCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            useChatGPTCheckBox.Location = new Point(160, 250);
            useChatGPTCheckBox.Name = "useChatGPTCheckBox";
            useChatGPTCheckBox.Size = new Size(142, 24);
            useChatGPTCheckBox.TabIndex = 1;
            useChatGPTCheckBox.Text = "ChatGPT - конец";
            useChatGPTCheckBox.UseVisualStyleBackColor = true;
            useChatGPTCheckBox.Click += useChatGPTCheckBox_Click;
            // 
            // SetRegisterOfTextComboBox
            // 
            SetRegisterOfTextComboBox.BackColor = SystemColors.InactiveBorder;
            SetRegisterOfTextComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SetRegisterOfTextComboBox.Items.AddRange(new object[] { "Заглавный", "Строчный", "Каждое слово с заглавной буквы" });
            SetRegisterOfTextComboBox.Location = new Point(74, 169);
            SetRegisterOfTextComboBox.Name = "SetRegisterOfTextComboBox";
            SetRegisterOfTextComboBox.Size = new Size(334, 28);
            SetRegisterOfTextComboBox.TabIndex = 8;
            SetRegisterOfTextComboBox.Text = "Каждое слово с заглавной буквы";
            SetRegisterOfTextComboBox.DropDownClosed += SetRegisterOfTextComboBox_DropDownClosed;
            SetRegisterOfTextComboBox.TextChanged += SetRegisterOfTextComboBox_TextChanged;
            // 
            // WathDataButton
            // 
            WathDataButton.Location = new Point(113, 368);
            WathDataButton.Name = "WathDataButton";
            WathDataButton.Size = new Size(250, 55);
            WathDataButton.TabIndex = 7;
            WathDataButton.Text = "Посмотреть словарь данных";
            WathDataButton.UseVisualStyleBackColor = true;
            WathDataButton.Click += WathDataButton_Click;
            // 
            // GenerateTextButton
            // 
            GenerateTextButton.Location = new Point(113, 293);
            GenerateTextButton.Name = "GenerateTextButton";
            GenerateTextButton.Size = new Size(250, 55);
            GenerateTextButton.TabIndex = 6;
            GenerateTextButton.Text = "Сгенерировать текст";
            GenerateTextButton.UseVisualStyleBackColor = true;
            GenerateTextButton.Click += GenerateTextButton_Click;
            // 
            // RandomRegisterCheckBox
            // 
            RandomRegisterCheckBox.AutoSize = true;
            RandomRegisterCheckBox.Location = new Point(160, 220);
            RandomRegisterCheckBox.Name = "RandomRegisterCheckBox";
            RandomRegisterCheckBox.Size = new Size(159, 24);
            RandomRegisterCheckBox.TabIndex = 5;
            RandomRegisterCheckBox.Text = "Случайный выбор";
            RandomRegisterCheckBox.UseVisualStyleBackColor = true;
            RandomRegisterCheckBox.Click += RandomRegisterCheckBox_Click;
            // 
            // SetLengthOfTextNumeric
            // 
            SetLengthOfTextNumeric.Location = new Point(160, 71);
            SetLengthOfTextNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            SetLengthOfTextNumeric.Name = "SetLengthOfTextNumeric";
            SetLengthOfTextNumeric.Size = new Size(150, 27);
            SetLengthOfTextNumeric.TabIndex = 2;
            SetLengthOfTextNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            SetLengthOfTextNumeric.ValueChanged += SetLengthOfTextNumeric_ValueChanged;
            // 
            // GeneratedTextTextBox
            // 
            GeneratedTextTextBox.Location = new Point(6, 6);
            GeneratedTextTextBox.Name = "GeneratedTextTextBox";
            GeneratedTextTextBox.Size = new Size(566, 472);
            GeneratedTextTextBox.TabIndex = 0;
            GeneratedTextTextBox.Text = "";
            GeneratedTextTextBox.TextChanged += updateLabels;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1050, 484);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Информация о тексте";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(GistogramPanel);
            panel2.Controls.Add(NumOfUnicWordsInTextLabel);
            panel2.Controls.Add(NumOfWordsInTextLabel);
            panel2.Controls.Add(NumOfCharsInTextLabel);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 472);
            panel2.TabIndex = 0;
            // 
            // GistogramPanel
            // 
            GistogramPanel.BackColor = Color.WhiteSmoke;
            GistogramPanel.BorderStyle = BorderStyle.FixedSingle;
            GistogramPanel.Controls.Add(tableLayoutPanel1);
            GistogramPanel.Location = new Point(3, 3);
            GistogramPanel.Name = "GistogramPanel";
            GistogramPanel.Size = new Size(708, 466);
            GistogramPanel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Center;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel1.Controls.Add(word1Label, 0, 1);
            tableLayoutPanel1.Controls.Add(word1Panel, 0, 0);
            tableLayoutPanel1.Controls.Add(word2Label, 1, 1);
            tableLayoutPanel1.Controls.Add(word3Label, 2, 1);
            tableLayoutPanel1.Controls.Add(word2Panel, 1, 0);
            tableLayoutPanel1.Controls.Add(word3Panel, 2, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(700, 458);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // word1Label
            // 
            word1Label.Location = new Point(3, 412);
            word1Label.Name = "word1Label";
            word1Label.Size = new Size(229, 46);
            word1Label.TabIndex = 0;
            word1Label.Text = "label1";
            word1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // word1Panel
            // 
            word1Panel.Anchor = AnchorStyles.Bottom;
            word1Panel.BackColor = Color.DarkGray;
            word1Panel.Location = new Point(80, 287);
            word1Panel.Name = "word1Panel";
            word1Panel.Size = new Size(74, 122);
            word1Panel.TabIndex = 3;
            // 
            // word2Label
            // 
            word2Label.Location = new Point(238, 412);
            word2Label.Name = "word2Label";
            word2Label.Size = new Size(229, 46);
            word2Label.TabIndex = 1;
            word2Label.Text = "label2";
            word2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // word3Label
            // 
            word3Label.Location = new Point(473, 412);
            word3Label.Name = "word3Label";
            word3Label.Size = new Size(224, 46);
            word3Label.TabIndex = 2;
            word3Label.Text = "label3";
            word3Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // word2Panel
            // 
            word2Panel.Anchor = AnchorStyles.Bottom;
            word2Panel.BackColor = Color.DarkGray;
            word2Panel.Location = new Point(315, 284);
            word2Panel.Name = "word2Panel";
            word2Panel.Size = new Size(74, 125);
            word2Panel.TabIndex = 4;
            // 
            // word3Panel
            // 
            word3Panel.Anchor = AnchorStyles.Bottom;
            word3Panel.BackColor = Color.DarkGray;
            word3Panel.Location = new Point(548, 284);
            word3Panel.Name = "word3Panel";
            word3Panel.Size = new Size(74, 125);
            word3Panel.TabIndex = 4;
            // 
            // NumOfUnicWordsInTextLabel
            // 
            NumOfUnicWordsInTextLabel.Location = new Point(730, 155);
            NumOfUnicWordsInTextLabel.Name = "NumOfUnicWordsInTextLabel";
            NumOfUnicWordsInTextLabel.Size = new Size(305, 28);
            NumOfUnicWordsInTextLabel.TabIndex = 2;
            NumOfUnicWordsInTextLabel.Text = "Всего уникальных слов в тексте:";
            // 
            // NumOfWordsInTextLabel
            // 
            NumOfWordsInTextLabel.Location = new Point(730, 100);
            NumOfWordsInTextLabel.Name = "NumOfWordsInTextLabel";
            NumOfWordsInTextLabel.Size = new Size(305, 28);
            NumOfWordsInTextLabel.TabIndex = 1;
            NumOfWordsInTextLabel.Text = "Всего слов в тексте:";
            // 
            // NumOfCharsInTextLabel
            // 
            NumOfCharsInTextLabel.Location = new Point(730, 40);
            NumOfCharsInTextLabel.Name = "NumOfCharsInTextLabel";
            NumOfCharsInTextLabel.Size = new Size(305, 28);
            NumOfCharsInTextLabel.TabIndex = 0;
            NumOfCharsInTextLabel.Text = "Всего символов в тексте:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 593);
            Controls.Add(tabControl);
            DoubleBuffered = true;
            MaximumSize = new Size(1100, 640);
            MinimumSize = new Size(1100, 640);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChatGPT - начало";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SetLengthOfTextNumeric).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            GistogramPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabControl tabControl;
        private TabPage tabPage1;
        private RichTextBox GeneratedTextTextBox;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox textBox1;
        private Label SetLengthOfTextLabel;
        private Button WathDataButton;
        private Button GenerateTextButton;
        private CheckBox RandomRegisterCheckBox;
        private Label SetRegisterOfTextLabel;
        private NumericUpDown SetLengthOfTextNumeric;
        private ToolTip toolTip1;
        private ComboBox SetRegisterOfTextComboBox;
        private Panel panel2;
        private Label NumOfCharsInTextLabel;
        private Label NumOfWordsInTextLabel;
        private Label NumOfUnicWordsInTextLabel;
        private Panel GistogramPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label word1Label;
        private Label word2Label;
        private Label word3Label;
        private Panel word1Panel;
        private Panel word2Panel;
        private Panel word3Panel;
        private CheckBox useChatGPTCheckBox;
    }
}
