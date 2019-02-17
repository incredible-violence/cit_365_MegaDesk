namespace MegaDesk_3_BradKellogg
{
    partial class DisplayQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuote));
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.backButton_SearchQuotes = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.RushLabel = new System.Windows.Forms.Label();
            this.CustomerOutputLabel = new System.Windows.Forms.Label();
            this.PriceOutLabel = new System.Windows.Forms.Label();
            this.RushOutLabel = new System.Windows.Forms.Label();
            this.mainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteLabel.Location = new System.Drawing.Point(284, 51);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(131, 22);
            this.QuoteLabel.TabIndex = 1;
            this.QuoteLabel.Text = "Your Quote:";
            this.QuoteLabel.Click += new System.EventHandler(this.QuoteLabel_Click);
            // 
            // backButton_SearchQuotes
            // 
            this.backButton_SearchQuotes.BackColor = System.Drawing.Color.Red;
            this.backButton_SearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton_SearchQuotes.Location = new System.Drawing.Point(501, 321);
            this.backButton_SearchQuotes.Name = "backButton_SearchQuotes";
            this.backButton_SearchQuotes.Size = new System.Drawing.Size(171, 28);
            this.backButton_SearchQuotes.TabIndex = 7;
            this.backButton_SearchQuotes.Text = "Add Another Quote";
            this.backButton_SearchQuotes.UseVisualStyleBackColor = false;
            this.backButton_SearchQuotes.Click += new System.EventHandler(this.backButton_SearchQuotes_Click);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(209, 109);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(109, 22);
            this.CustomerLabel.TabIndex = 8;
            this.CustomerLabel.Text = "Customer:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(209, 157);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(76, 22);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price:";
            // 
            // RushLabel
            // 
            this.RushLabel.AutoSize = true;
            this.RushLabel.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushLabel.Location = new System.Drawing.Point(209, 203);
            this.RushLabel.Name = "RushLabel";
            this.RushLabel.Size = new System.Drawing.Size(120, 22);
            this.RushLabel.TabIndex = 10;
            this.RushLabel.Text = "Rush Days:";
            // 
            // CustomerOutputLabel
            // 
            this.CustomerOutputLabel.AutoSize = true;
            this.CustomerOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOutputLabel.Location = new System.Drawing.Point(396, 108);
            this.CustomerOutputLabel.Name = "CustomerOutputLabel";
            this.CustomerOutputLabel.Size = new System.Drawing.Size(60, 24);
            this.CustomerOutputLabel.TabIndex = 11;
            this.CustomerOutputLabel.Text = "label1";
            // 
            // PriceOutLabel
            // 
            this.PriceOutLabel.AutoSize = true;
            this.PriceOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceOutLabel.Location = new System.Drawing.Point(396, 155);
            this.PriceOutLabel.Name = "PriceOutLabel";
            this.PriceOutLabel.Size = new System.Drawing.Size(60, 24);
            this.PriceOutLabel.TabIndex = 12;
            this.PriceOutLabel.Text = "label1";
            // 
            // RushOutLabel
            // 
            this.RushOutLabel.AutoSize = true;
            this.RushOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOutLabel.Location = new System.Drawing.Point(396, 201);
            this.RushOutLabel.Name = "RushOutLabel";
            this.RushOutLabel.Size = new System.Drawing.Size(60, 24);
            this.RushOutLabel.TabIndex = 13;
            this.RushOutLabel.Text = "label1";
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Location = new System.Drawing.Point(322, 321);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(173, 28);
            this.mainButton.TabIndex = 14;
            this.mainButton.Text = "Back to Main Menu";
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.RushOutLabel);
            this.Controls.Add(this.PriceOutLabel);
            this.Controls.Add(this.CustomerOutputLabel);
            this.Controls.Add(this.RushLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.backButton_SearchQuotes);
            this.Controls.Add(this.QuoteLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.Button backButton_SearchQuotes;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label RushLabel;
        private System.Windows.Forms.Label CustomerOutputLabel;
        private System.Windows.Forms.Label PriceOutLabel;
        private System.Windows.Forms.Label RushOutLabel;
        private System.Windows.Forms.Button mainButton;
    }
}