namespace Lab23
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
            this.btn_getToken = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_numTokens = new System.Windows.Forms.Label();
            this.lbl_numQrtrs = new System.Windows.Forms.Label();
            this.txtBox_tokens = new System.Windows.Forms.TextBox();
            this.txtBox_qrtrs = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_getToken
            // 
            this.btn_getToken.Location = new System.Drawing.Point(0, 53);
            this.btn_getToken.Name = "btn_getToken";
            this.btn_getToken.Size = new System.Drawing.Size(75, 23);
            this.btn_getToken.TabIndex = 0;
            this.btn_getToken.Text = "Get Token";
            this.btn_getToken.UseVisualStyleBackColor = true;
            this.btn_getToken.Click += new System.EventHandler(this.btn_getToken_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(0, 87);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_numTokens
            // 
            this.lbl_numTokens.AutoSize = true;
            this.lbl_numTokens.Location = new System.Drawing.Point(281, 54);
            this.lbl_numTokens.Name = "lbl_numTokens";
            this.lbl_numTokens.Size = new System.Drawing.Size(95, 13);
            this.lbl_numTokens.TabIndex = 2;
            this.lbl_numTokens.Text = "Number of Tokens";
            // 
            // lbl_numQrtrs
            // 
            this.lbl_numQrtrs.AutoSize = true;
            this.lbl_numQrtrs.Location = new System.Drawing.Point(281, 173);
            this.lbl_numQrtrs.Name = "lbl_numQrtrs";
            this.lbl_numQrtrs.Size = new System.Drawing.Size(99, 13);
            this.lbl_numQrtrs.TabIndex = 3;
            this.lbl_numQrtrs.Text = "Number of Quarters";
            // 
            // txtBox_tokens
            // 
            this.txtBox_tokens.Location = new System.Drawing.Point(280, 70);
            this.txtBox_tokens.Name = "txtBox_tokens";
            this.txtBox_tokens.Size = new System.Drawing.Size(100, 20);
            this.txtBox_tokens.TabIndex = 4;
            this.txtBox_tokens.Text = "100";
            // 
            // txtBox_qrtrs
            // 
            this.txtBox_qrtrs.Location = new System.Drawing.Point(280, 189);
            this.txtBox_qrtrs.Name = "txtBox_qrtrs";
            this.txtBox_qrtrs.Size = new System.Drawing.Size(100, 20);
            this.txtBox_qrtrs.TabIndex = 5;
            this.txtBox_qrtrs.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(0, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Sound Toggle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Lab23.Properties.Resources.token_vending_machine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(407, 270);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtBox_qrtrs);
            this.Controls.Add(this.txtBox_tokens);
            this.Controls.Add(this.lbl_numQrtrs);
            this.Controls.Add(this.lbl_numTokens);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_getToken);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CS1400 Lab23";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getToken;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_numTokens;
        private System.Windows.Forms.Label lbl_numQrtrs;
        private System.Windows.Forms.TextBox txtBox_tokens;
        private System.Windows.Forms.TextBox txtBox_qrtrs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

