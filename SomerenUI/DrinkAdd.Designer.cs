﻿namespace SomerenUI
{
    partial class DrinkAddForm
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
            btnAdd = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtStock = new System.Windows.Forms.TextBox();
            txtVat = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(278, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(199, 77);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add a drink";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(53, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(221, 32);
            label2.TabIndex = 3;
            label2.Text = "Enter a drink name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(53, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(213, 32);
            label3.TabIndex = 4;
            label3.Text = "Enter a drink price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(53, 216);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(216, 32);
            label4.TabIndex = 5;
            label4.Text = "Enter a drink stock:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(53, 295);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(201, 32);
            label5.TabIndex = 6;
            label5.Text = "Enter a drink VAT:";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(494, 51);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(200, 39);
            txtName.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(494, 132);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(200, 39);
            txtPrice.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(494, 213);
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(200, 39);
            txtStock.TabIndex = 9;
            // 
            // txtVat
            // 
            txtVat.Location = new System.Drawing.Point(494, 292);
            txtVat.Name = "txtVat";
            txtVat.Size = new System.Drawing.Size(200, 39);
            txtVat.TabIndex = 10;
            // 
            // DrinkAddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 500);
            Controls.Add(txtVat);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Name = "DrinkAddForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtVat;
    }
}