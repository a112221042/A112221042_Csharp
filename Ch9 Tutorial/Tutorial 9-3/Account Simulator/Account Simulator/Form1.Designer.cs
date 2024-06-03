namespace Account_Simulator
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
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.depositGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositGroupBox
            // 
            this.depositGroupBox.Controls.Add(this.depositButton);
            this.depositGroupBox.Controls.Add(this.depositTextBox);
            this.depositGroupBox.Controls.Add(this.depositAmountDescriptionLabel);
            this.depositGroupBox.Location = new System.Drawing.Point(18, 91);
            this.depositGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depositGroupBox.Size = new System.Drawing.Size(226, 109);
            this.depositGroupBox.TabIndex = 0;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "Make a Deposit";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(57, 64);
            this.depositButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(112, 32);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(102, 28);
            this.depositTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(98, 29);
            this.depositTextBox.TabIndex = 1;
            // 
            // depositAmountDescriptionLabel
            // 
            this.depositAmountDescriptionLabel.AutoSize = true;
            this.depositAmountDescriptionLabel.Location = new System.Drawing.Point(24, 32);
            this.depositAmountDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depositAmountDescriptionLabel.Name = "depositAmountDescriptionLabel";
            this.depositAmountDescriptionLabel.Size = new System.Drawing.Size(67, 18);
            this.depositAmountDescriptionLabel.TabIndex = 0;
            this.depositAmountDescriptionLabel.Text = "Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withdrawButton);
            this.groupBox1.Controls.Add(this.withdrawTextBox);
            this.groupBox1.Controls.Add(this.withdrawAmountDescriptionLabel);
            this.groupBox1.Location = new System.Drawing.Point(254, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(226, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make a Withdrawal";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(57, 64);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(112, 32);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Location = new System.Drawing.Point(102, 28);
            this.withdrawTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(98, 29);
            this.withdrawTextBox.TabIndex = 1;
            // 
            // withdrawAmountDescriptionLabel
            // 
            this.withdrawAmountDescriptionLabel.AutoSize = true;
            this.withdrawAmountDescriptionLabel.Location = new System.Drawing.Point(24, 32);
            this.withdrawAmountDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.withdrawAmountDescriptionLabel.Name = "withdrawAmountDescriptionLabel";
            this.withdrawAmountDescriptionLabel.Size = new System.Drawing.Size(67, 18);
            this.withdrawAmountDescriptionLabel.TabIndex = 0;
            this.withdrawAmountDescriptionLabel.Text = "Amount:";
            // 
            // balanceDescriptionLabel
            // 
            this.balanceDescriptionLabel.AutoSize = true;
            this.balanceDescriptionLabel.Location = new System.Drawing.Point(134, 40);
            this.balanceDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceDescriptionLabel.Name = "balanceDescriptionLabel";
            this.balanceDescriptionLabel.Size = new System.Drawing.Size(69, 18);
            this.balanceDescriptionLabel.TabIndex = 2;
            this.balanceDescriptionLabel.Text = "Balance:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Location = new System.Drawing.Point(216, 33);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(149, 31);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(194, 224);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 32);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 280);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceDescriptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.depositGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Account Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox depositGroupBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label depositAmountDescriptionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Label withdrawAmountDescriptionLabel;
        private System.Windows.Forms.Label balanceDescriptionLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

