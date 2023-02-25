namespace GUI
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
            this.userMoney = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.betValueRichTextBox = new System.Windows.Forms.RichTextBox();
            this.selectedValueLabel = new System.Windows.Forms.Label();
            this.betThird12Button = new System.Windows.Forms.Button();
            this.betSecond12Button = new System.Windows.Forms.Button();
            this.first12Button = new System.Windows.Forms.Button();
            this.betNineteenThirtySix = new System.Windows.Forms.Button();
            this.betBlue = new System.Windows.Forms.Button();
            this.betOneEighteenButton = new System.Windows.Forms.Button();
            this.betEven = new System.Windows.Forms.Button();
            this.betOdd = new System.Windows.Forms.Button();
            this.betRed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userMoney
            // 
            this.userMoney.AutoSize = true;
            this.userMoney.Location = new System.Drawing.Point(9, 10);
            this.userMoney.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.userMoney.Name = "userMoney";
            this.userMoney.Size = new System.Drawing.Size(90, 20);
            this.userMoney.TabIndex = 0;
            this.userMoney.Text = "Pénz: 5000Ft";
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.richTextBox2);
            this.userPanel.Controls.Add(this.betValueRichTextBox);
            this.userPanel.Controls.Add(this.userMoney);
            this.userPanel.Location = new System.Drawing.Point(10, 904);
            this.userPanel.Margin = new System.Windows.Forms.Padding(1);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(276, 71);
            this.userPanel.TabIndex = 1;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(90, 33);
            this.richTextBox2.MaxLength = 2;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(21, 27);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "Ft";
            // 
            // betValueRichTextBox
            // 
            this.betValueRichTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.betValueRichTextBox.Location = new System.Drawing.Point(9, 33);
            this.betValueRichTextBox.Name = "betValueRichTextBox";
            this.betValueRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.betValueRichTextBox.Size = new System.Drawing.Size(84, 27);
            this.betValueRichTextBox.TabIndex = 2;
            this.betValueRichTextBox.Text = "500";
            this.betValueRichTextBox.TextChanged += new System.EventHandler(this.ChangeingBet);
            // 
            // selectedValueLabel
            // 
            this.selectedValueLabel.AutoSize = true;
            this.selectedValueLabel.Location = new System.Drawing.Point(10, 976);
            this.selectedValueLabel.Name = "selectedValueLabel";
            this.selectedValueLabel.Size = new System.Drawing.Size(165, 20);
            this.selectedValueLabel.TabIndex = 2;
            this.selectedValueLabel.Text = "Kiválasztott Tétel: 500Ft";
            // 
            // betThird12Button
            // 
            this.betThird12Button.Location = new System.Drawing.Point(31, 91);
            this.betThird12Button.Name = "betThird12Button";
            this.betThird12Button.Size = new System.Drawing.Size(134, 31);
            this.betThird12Button.TabIndex = 18;
            this.betThird12Button.Text = "Harmadik 12";
            this.betThird12Button.UseVisualStyleBackColor = true;
            this.betThird12Button.Click += new System.EventHandler(this.BetPlaceing);
            // 
            // betSecond12Button
            // 
            this.betSecond12Button.Location = new System.Drawing.Point(31, 54);
            this.betSecond12Button.Name = "betSecond12Button";
            this.betSecond12Button.Size = new System.Drawing.Size(134, 31);
            this.betSecond12Button.TabIndex = 17;
            this.betSecond12Button.Text = "Második 12";
            this.betSecond12Button.UseVisualStyleBackColor = true;
            this.betSecond12Button.Click += new System.EventHandler(this.BetPlaceing);
            // 
            // first12Button
            // 
            this.first12Button.Location = new System.Drawing.Point(29, 17);
            this.first12Button.Name = "first12Button";
            this.first12Button.Size = new System.Drawing.Size(136, 31);
            this.first12Button.TabIndex = 16;
            this.first12Button.Text = "Első 12";
            this.first12Button.UseVisualStyleBackColor = true;
            this.first12Button.Click += new System.EventHandler(this.BetPlaceing);
            // 
            // betNineteenThirtySix
            // 
            this.betNineteenThirtySix.Location = new System.Drawing.Point(29, 175);
            this.betNineteenThirtySix.Name = "betNineteenThirtySix";
            this.betNineteenThirtySix.Size = new System.Drawing.Size(136, 31);
            this.betNineteenThirtySix.TabIndex = 15;
            this.betNineteenThirtySix.Text = "19-36";
            this.betNineteenThirtySix.UseVisualStyleBackColor = true;
            this.betNineteenThirtySix.Click += new System.EventHandler(this.BetPlaceing);
            // 
            // betBlue
            // 
            this.betBlue.Location = new System.Drawing.Point(29, 351);
            this.betBlue.Name = "betBlue";
            this.betBlue.Size = new System.Drawing.Size(136, 31);
            this.betBlue.TabIndex = 14;
            this.betBlue.Text = "Kék";
            this.betBlue.UseVisualStyleBackColor = true;
            this.betBlue.Click += new System.EventHandler(this.BetPlaceing);
            // 
            // betOneEighteenButton
            // 
            this.betOneEighteenButton.Location = new System.Drawing.Point(29, 138);
            this.betOneEighteenButton.Name = "betOneEighteenButton";
            this.betOneEighteenButton.Size = new System.Drawing.Size(136, 31);
            this.betOneEighteenButton.TabIndex = 13;
            this.betOneEighteenButton.Text = "1-18";
            this.betOneEighteenButton.UseVisualStyleBackColor = true;
            this.betOneEighteenButton.Click += new System.EventHandler(this.BetPlaceing);
            // 
            // betEven
            // 
            this.betEven.Location = new System.Drawing.Point(29, 232);
            this.betEven.Name = "betEven";
            this.betEven.Size = new System.Drawing.Size(136, 31);
            this.betEven.TabIndex = 12;
            this.betEven.Text = "Páros";
            this.betEven.UseVisualStyleBackColor = true;
            this.betEven.Click += new System.EventHandler(this.BetPlaceing);
            // 
            // betOdd
            // 
            this.betOdd.Location = new System.Drawing.Point(29, 269);
            this.betOdd.Name = "betOdd";
            this.betOdd.Size = new System.Drawing.Size(136, 31);
            this.betOdd.TabIndex = 11;
            this.betOdd.Text = "Páratlan";
            this.betOdd.UseVisualStyleBackColor = true;
            this.betOdd.Click += new System.EventHandler(this.BetPlaceing);
            // 
            // betRed
            // 
            this.betRed.Location = new System.Drawing.Point(29, 317);
            this.betRed.Name = "betRed";
            this.betRed.Size = new System.Drawing.Size(136, 31);
            this.betRed.TabIndex = 10;
            this.betRed.Text = "Píros";
            this.betRed.UseVisualStyleBackColor = true;
            this.betRed.Click += new System.EventHandler(this.BetPlaceing);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.first12Button);
            this.panel1.Controls.Add(this.betThird12Button);
            this.panel1.Controls.Add(this.betRed);
            this.panel1.Controls.Add(this.betSecond12Button);
            this.panel1.Controls.Add(this.betOdd);
            this.panel1.Controls.Add(this.betEven);
            this.panel1.Controls.Add(this.betNineteenThirtySix);
            this.panel1.Controls.Add(this.betOneEighteenButton);
            this.panel1.Controls.Add(this.betBlue);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 402);
            this.panel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(781, 1005);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectedValueLabel);
            this.Controls.Add(this.userPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userMoney;
        private Panel userPanel;
        private RichTextBox richTextBox2;
        private RichTextBox betValueRichTextBox;
        private Label selectedValueLabel;
        private Button betThird12Button;
        private Button betSecond12Button;
        private Button first12Button;
        private Button betNineteenThirtySix;
        private Button betBlue;
        private Button betOneEighteenButton;
        private Button betEven;
        private Button betOdd;
        private Button betRed;
        private Panel panel1;
    }
}