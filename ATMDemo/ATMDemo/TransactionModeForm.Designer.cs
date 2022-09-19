namespace ATMDemo
{
    partial class TransactionModeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionModeForm));
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.btnWithdrawl = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.AutoSize = true;
            this.btnCheckBalance.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCheckBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.Location = new System.Drawing.Point(258, 194);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(366, 91);
            this.btnCheckBalance.TabIndex = 0;
            this.btnCheckBalance.Text = "Check Your Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.AutoSize = true;
            this.btnTransactionHistory.BackColor = System.Drawing.Color.RosyBrown;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionHistory.Location = new System.Drawing.Point(774, 194);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(361, 91);
            this.btnTransactionHistory.TabIndex = 1;
            this.btnTransactionHistory.Text = "Chech Your Transaction History";
            this.btnTransactionHistory.UseVisualStyleBackColor = false;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnWithdrawl
            // 
            this.btnWithdrawl.BackColor = System.Drawing.Color.RosyBrown;
            this.btnWithdrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawl.Location = new System.Drawing.Point(774, 412);
            this.btnWithdrawl.Name = "btnWithdrawl";
            this.btnWithdrawl.Size = new System.Drawing.Size(361, 78);
            this.btnWithdrawl.TabIndex = 2;
            this.btnWithdrawl.Text = "Withdrawl";
            this.btnWithdrawl.UseVisualStyleBackColor = false;
            this.btnWithdrawl.Click += new System.EventHandler(this.btnWithdrawl_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.AutoSize = true;
            this.btnDeposit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(247, 412);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(347, 78);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit Money";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECT YOUR TRANSACTION TYPE";
            // 
            // TransactionModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdrawl);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.btnCheckBalance);
            this.DoubleBuffered = true;
            this.Name = "TransactionModeForm";
            this.Text = "TransactionModeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.Button btnWithdrawl;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label1;
    }
}