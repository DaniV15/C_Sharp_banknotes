namespace BankNotes_Calculator
{
    partial class MainForm
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
            this.NotesList = new System.Windows.Forms.ListBox();
            this.AnswerList = new System.Windows.Forms.ListBox();
            this.NumAmount = new System.Windows.Forms.NumericUpDown();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.currencyList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // NotesList
            // 
            this.NotesList.FormattingEnabled = true;
            this.NotesList.Location = new System.Drawing.Point(11, 39);
            this.NotesList.Name = "NotesList";
            this.NotesList.Size = new System.Drawing.Size(255, 134);
            this.NotesList.TabIndex = 0;
            // 
            // AnswerList
            // 
            this.AnswerList.FormattingEnabled = true;
            this.AnswerList.Location = new System.Drawing.Point(13, 227);
            this.AnswerList.Name = "AnswerList";
            this.AnswerList.Size = new System.Drawing.Size(254, 95);
            this.AnswerList.TabIndex = 1;
            // 
            // NumAmount
            // 
            this.NumAmount.Location = new System.Drawing.Point(11, 188);
            this.NumAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumAmount.Name = "NumAmount";
            this.NumAmount.Size = new System.Drawing.Size(120, 20);
            this.NumAmount.TabIndex = 2;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(176, 188);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 3;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // currencyList
            // 
            this.currencyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyList.FormattingEnabled = true;
            this.currencyList.Items.AddRange(new object[] {
            "HUF",
            "CZK"});
            this.currencyList.Location = new System.Drawing.Point(11, 12);
            this.currencyList.MaxDropDownItems = 1;
            this.currencyList.Name = "currencyList";
            this.currencyList.Size = new System.Drawing.Size(121, 21);
            this.currencyList.TabIndex = 4;
            this.currencyList.SelectedIndexChanged += new System.EventHandler(this.currencyList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencyList);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.NumAmount);
            this.Controls.Add(this.AnswerList);
            this.Controls.Add(this.NotesList);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox NotesList;
        private System.Windows.Forms.ListBox AnswerList;
        private System.Windows.Forms.NumericUpDown NumAmount;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.ComboBox currencyList;
        private System.Windows.Forms.Button button1;
    }
}

