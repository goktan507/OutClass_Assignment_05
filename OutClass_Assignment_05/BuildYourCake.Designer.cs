namespace OutClass_Assignment_05
{
    partial class BuildYourCake
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
            this.lbl_breadLayer = new System.Windows.Forms.Label();
            this.lbl_cakeType = new System.Windows.Forms.Label();
            this.lbl_ingredients = new System.Windows.Forms.Label();
            this.lbl_paymentSelection = new System.Windows.Forms.Label();
            this.box_breadLayer = new System.Windows.Forms.ComboBox();
            this.box_cakeType = new System.Windows.Forms.ComboBox();
            this.box_ingredients = new System.Windows.Forms.ComboBox();
            this.box_payment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_breadLayer
            // 
            this.lbl_breadLayer.AutoSize = true;
            this.lbl_breadLayer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_breadLayer.Location = new System.Drawing.Point(66, 80);
            this.lbl_breadLayer.Name = "lbl_breadLayer";
            this.lbl_breadLayer.Size = new System.Drawing.Size(100, 23);
            this.lbl_breadLayer.TabIndex = 0;
            this.lbl_breadLayer.Text = "Bread Layer";
            // 
            // lbl_cakeType
            // 
            this.lbl_cakeType.AutoSize = true;
            this.lbl_cakeType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cakeType.Location = new System.Drawing.Point(79, 134);
            this.lbl_cakeType.Name = "lbl_cakeType";
            this.lbl_cakeType.Size = new System.Drawing.Size(87, 23);
            this.lbl_cakeType.TabIndex = 1;
            this.lbl_cakeType.Text = "Cake Type";
            this.lbl_cakeType.Visible = false;
            // 
            // lbl_ingredients
            // 
            this.lbl_ingredients.AutoSize = true;
            this.lbl_ingredients.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingredients.Location = new System.Drawing.Point(71, 187);
            this.lbl_ingredients.Name = "lbl_ingredients";
            this.lbl_ingredients.Size = new System.Drawing.Size(95, 23);
            this.lbl_ingredients.TabIndex = 2;
            this.lbl_ingredients.Text = "Ingredients";
            this.lbl_ingredients.Visible = false;
            // 
            // lbl_paymentSelection
            // 
            this.lbl_paymentSelection.AutoSize = true;
            this.lbl_paymentSelection.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentSelection.Location = new System.Drawing.Point(24, 240);
            this.lbl_paymentSelection.Name = "lbl_paymentSelection";
            this.lbl_paymentSelection.Size = new System.Drawing.Size(142, 23);
            this.lbl_paymentSelection.TabIndex = 3;
            this.lbl_paymentSelection.Text = "Payment Selection";
            this.lbl_paymentSelection.Visible = false;
            // 
            // box_breadLayer
            // 
            this.box_breadLayer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_breadLayer.FormattingEnabled = true;
            this.box_breadLayer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.box_breadLayer.Location = new System.Drawing.Point(184, 76);
            this.box_breadLayer.Name = "box_breadLayer";
            this.box_breadLayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_breadLayer.Size = new System.Drawing.Size(160, 31);
            this.box_breadLayer.TabIndex = 4;
            this.box_breadLayer.SelectedIndexChanged += new System.EventHandler(this.box_breadLayer_SelectedIndexChanged);
            // 
            // box_cakeType
            // 
            this.box_cakeType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_cakeType.FormattingEnabled = true;
            this.box_cakeType.Items.AddRange(new object[] {
            "Chocolate Cake",
            "Fruit Cake",
            "Creamy Cake"});
            this.box_cakeType.Location = new System.Drawing.Point(184, 130);
            this.box_cakeType.Name = "box_cakeType";
            this.box_cakeType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_cakeType.Size = new System.Drawing.Size(160, 31);
            this.box_cakeType.TabIndex = 5;
            this.box_cakeType.Visible = false;
            this.box_cakeType.SelectedIndexChanged += new System.EventHandler(this.box_cakeType_SelectedIndexChanged);
            // 
            // box_ingredients
            // 
            this.box_ingredients.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_ingredients.FormattingEnabled = true;
            this.box_ingredients.Location = new System.Drawing.Point(184, 183);
            this.box_ingredients.Name = "box_ingredients";
            this.box_ingredients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_ingredients.Size = new System.Drawing.Size(160, 31);
            this.box_ingredients.TabIndex = 6;
            this.box_ingredients.Visible = false;
            this.box_ingredients.SelectedIndexChanged += new System.EventHandler(this.box_ingredients_SelectedIndexChanged);
            // 
            // box_payment
            // 
            this.box_payment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_payment.FormattingEnabled = true;
            this.box_payment.Items.AddRange(new object[] {
            "Credit Card",
            "Paypal",
            "Cash / Pick up",
            "Debit Card"});
            this.box_payment.Location = new System.Drawing.Point(184, 236);
            this.box_payment.Name = "box_payment";
            this.box_payment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_payment.Size = new System.Drawing.Size(160, 31);
            this.box_payment.TabIndex = 7;
            this.box_payment.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Build Your Cake";
            // 
            // btn_cost
            // 
            this.btn_cost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cost.Location = new System.Drawing.Point(135, 288);
            this.btn_cost.Name = "btn_cost";
            this.btn_cost.Size = new System.Drawing.Size(99, 35);
            this.btn_cost.TabIndex = 9;
            this.btn_cost.Text = "Total Cost";
            this.btn_cost.UseVisualStyleBackColor = true;
            this.btn_cost.Click += new System.EventHandler(this.btn_cost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 352);
            this.Controls.Add(this.btn_cost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_payment);
            this.Controls.Add(this.box_ingredients);
            this.Controls.Add(this.box_cakeType);
            this.Controls.Add(this.box_breadLayer);
            this.Controls.Add(this.lbl_paymentSelection);
            this.Controls.Add(this.lbl_ingredients);
            this.Controls.Add(this.lbl_cakeType);
            this.Controls.Add(this.lbl_breadLayer);
            this.Name = "Form1";
            this.Text = "Cake Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_breadLayer;
        private System.Windows.Forms.Label lbl_cakeType;
        private System.Windows.Forms.Label lbl_ingredients;
        private System.Windows.Forms.Label lbl_paymentSelection;
        private System.Windows.Forms.ComboBox box_breadLayer;
        private System.Windows.Forms.ComboBox box_cakeType;
        private System.Windows.Forms.ComboBox box_ingredients;
        private System.Windows.Forms.ComboBox box_payment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cost;
    }
}

