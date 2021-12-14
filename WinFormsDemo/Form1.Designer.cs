
namespace WinFormsDemo
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
            this.userInputText = new System.Windows.Forms.TextBox();
            this.calculationResultText = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.equalsButton = new System.Windows.Forms.Button();
            this.comaButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.plusMinusButton = new System.Windows.Forms.Button();
            this.addingButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInputText
            // 
            this.userInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInputText.Location = new System.Drawing.Point(12, 13);
            this.userInputText.Name = "userInputText";
            this.userInputText.Size = new System.Drawing.Size(435, 23);
            this.userInputText.TabIndex = 0;
            // 
            // calculationResultText
            // 
            this.calculationResultText.Location = new System.Drawing.Point(12, 43);
            this.calculationResultText.Name = "calculationResultText";
            this.calculationResultText.Size = new System.Drawing.Size(342, 61);
            this.calculationResultText.TabIndex = 1;
            this.calculationResultText.Text = "Please enter an operation and press Enter or = to calculate";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.ColumnCount = 4;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.Controls.Add(this.equalsButton, 3, 4);
            this.buttonsPanel.Controls.Add(this.comaButton, 2, 4);
            this.buttonsPanel.Controls.Add(this.zeroButton, 1, 4);
            this.buttonsPanel.Controls.Add(this.plusMinusButton, 0, 4);
            this.buttonsPanel.Controls.Add(this.addingButton, 3, 3);
            this.buttonsPanel.Controls.Add(this.threeButton, 2, 3);
            this.buttonsPanel.Controls.Add(this.twoButton, 1, 3);
            this.buttonsPanel.Controls.Add(this.oneButton, 0, 3);
            this.buttonsPanel.Controls.Add(this.minusButton, 3, 2);
            this.buttonsPanel.Controls.Add(this.sixButton, 2, 2);
            this.buttonsPanel.Controls.Add(this.fiveButton, 1, 2);
            this.buttonsPanel.Controls.Add(this.fourButton, 0, 2);
            this.buttonsPanel.Controls.Add(this.multiplyButton, 3, 1);
            this.buttonsPanel.Controls.Add(this.nineButton, 2, 1);
            this.buttonsPanel.Controls.Add(this.eightButton, 1, 1);
            this.buttonsPanel.Controls.Add(this.sevenButton, 0, 1);
            this.buttonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.buttonsPanel.Controls.Add(this.CButton, 1, 0);
            this.buttonsPanel.Controls.Add(this.deleteButton, 2, 0);
            this.buttonsPanel.Controls.Add(this.divideButton, 3, 0);
            this.buttonsPanel.Location = new System.Drawing.Point(12, 118);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 5;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.Size = new System.Drawing.Size(435, 441);
            this.buttonsPanel.TabIndex = 2;
            // 
            // equalsButton
            // 
            this.equalsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalsButton.Location = new System.Drawing.Point(327, 355);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(105, 83);
            this.equalsButton.TabIndex = 19;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // comaButton
            // 
            this.comaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comaButton.Location = new System.Drawing.Point(219, 355);
            this.comaButton.Name = "comaButton";
            this.comaButton.Size = new System.Drawing.Size(102, 83);
            this.comaButton.TabIndex = 18;
            this.comaButton.Text = ",";
            this.comaButton.UseVisualStyleBackColor = true;
            this.comaButton.Click += new System.EventHandler(this.comaButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroButton.Location = new System.Drawing.Point(111, 355);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(102, 83);
            this.zeroButton.TabIndex = 17;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusMinusButton.Location = new System.Drawing.Point(3, 355);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.Size = new System.Drawing.Size(102, 83);
            this.plusMinusButton.TabIndex = 16;
            this.plusMinusButton.Text = "+/-";
            this.plusMinusButton.UseVisualStyleBackColor = true;
            this.plusMinusButton.Click += new System.EventHandler(this.plusMinusButton_Click);
            // 
            // addingButton
            // 
            this.addingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addingButton.Location = new System.Drawing.Point(327, 267);
            this.addingButton.Name = "addingButton";
            this.addingButton.Size = new System.Drawing.Size(105, 82);
            this.addingButton.TabIndex = 15;
            this.addingButton.Text = "+";
            this.addingButton.UseVisualStyleBackColor = true;
            this.addingButton.Click += new System.EventHandler(this.addingButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeButton.Location = new System.Drawing.Point(219, 267);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(102, 82);
            this.threeButton.TabIndex = 14;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoButton.Location = new System.Drawing.Point(111, 267);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(102, 82);
            this.twoButton.TabIndex = 13;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneButton.Location = new System.Drawing.Point(3, 267);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(102, 82);
            this.oneButton.TabIndex = 12;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusButton.Location = new System.Drawing.Point(327, 179);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(105, 82);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixButton.Location = new System.Drawing.Point(219, 179);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(102, 82);
            this.sixButton.TabIndex = 10;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveButton.Location = new System.Drawing.Point(111, 179);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(102, 82);
            this.fiveButton.TabIndex = 9;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourButton.Location = new System.Drawing.Point(3, 179);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(102, 82);
            this.fourButton.TabIndex = 8;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyButton.Location = new System.Drawing.Point(327, 91);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(105, 82);
            this.multiplyButton.TabIndex = 7;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.Location = new System.Drawing.Point(219, 91);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(102, 82);
            this.nineButton.TabIndex = 6;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.Location = new System.Drawing.Point(111, 91);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(102, 82);
            this.eightButton.TabIndex = 5;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenButton.Location = new System.Drawing.Point(3, 91);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(102, 82);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(102, 82);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(111, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(102, 82);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(219, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(102, 82);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideButton.Location = new System.Drawing.Point(327, 3);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(105, 82);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.equalsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(459, 581);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.calculationResultText);
            this.Controls.Add(this.userInputText);
            this.MinimumSize = new System.Drawing.Size(475, 620);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputText;
        private System.Windows.Forms.Label calculationResultText;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button comaButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button plusMinusButton;
        private System.Windows.Forms.Button addingButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button divideButton;
    }
}

