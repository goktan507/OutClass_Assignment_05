namespace OutClass_Assignment_05
{
    partial class CakeCost
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
            this.cakeImage = new System.Windows.Forms.PictureBox();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_readyTime = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cakeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cakeImage
            // 
            this.cakeImage.Location = new System.Drawing.Point(1, -1);
            this.cakeImage.Name = "cakeImage";
            this.cakeImage.Size = new System.Drawing.Size(331, 253);
            this.cakeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cakeImage.TabIndex = 0;
            this.cakeImage.TabStop = false;
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.Location = new System.Drawing.Point(49, 267);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(0, 26);
            this.lbl_cost.TabIndex = 1;
            this.lbl_cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_readyTime
            // 
            this.lbl_readyTime.AutoSize = true;
            this.lbl_readyTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_readyTime.Location = new System.Drawing.Point(49, 311);
            this.lbl_readyTime.Name = "lbl_readyTime";
            this.lbl_readyTime.Size = new System.Drawing.Size(0, 26);
            this.lbl_readyTime.TabIndex = 2;
            this.lbl_readyTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1, 384);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(331, 49);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // CakeCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 431);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_readyTime);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.cakeImage);
            this.Name = "CakeCost";
            this.Text = "CakeCost";
            this.Load += new System.EventHandler(this.CakeCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cakeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cakeImage;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_readyTime;
        private System.Windows.Forms.Button btn_close;
    }
}