﻿namespace LostArkApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.txtWEP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AttackFinal = new System.Windows.Forms.Label();
            this.AtkUpgrade = new System.Windows.Forms.Label();
            this.txtDex2 = new System.Windows.Forms.TextBox();
            this.txtWEP2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDex
            // 
            this.txtDex.Location = new System.Drawing.Point(138, 33);
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(64, 20);
            this.txtDex.TabIndex = 1;
            this.txtDex.Text = "0";
            // 
            // txtWEP
            // 
            this.txtWEP.Location = new System.Drawing.Point(212, 32);
            this.txtWEP.Name = "txtWEP";
            this.txtWEP.Size = new System.Drawing.Size(75, 20);
            this.txtWEP.TabIndex = 2;
            this.txtWEP.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Stats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dexterity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weapon Power";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Attack Power";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Attack Power After Upgrade";
            // 
            // AttackFinal
            // 
            this.AttackFinal.AutoSize = true;
            this.AttackFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackFinal.Location = new System.Drawing.Point(380, 30);
            this.AttackFinal.Name = "AttackFinal";
            this.AttackFinal.Size = new System.Drawing.Size(103, 20);
            this.AttackFinal.TabIndex = 8;
            this.AttackFinal.Text = "Attack Power";
            // 
            // AtkUpgrade
            // 
            this.AtkUpgrade.AutoSize = true;
            this.AtkUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtkUpgrade.Location = new System.Drawing.Point(360, 76);
            this.AtkUpgrade.Name = "AtkUpgrade";
            this.AtkUpgrade.Size = new System.Drawing.Size(103, 20);
            this.AtkUpgrade.TabIndex = 9;
            this.AtkUpgrade.Text = "Attack Power";
            // 
            // txtDex2
            // 
            this.txtDex2.Location = new System.Drawing.Point(138, 71);
            this.txtDex2.Name = "txtDex2";
            this.txtDex2.Size = new System.Drawing.Size(64, 20);
            this.txtDex2.TabIndex = 10;
            this.txtDex2.Text = "0";
            // 
            // txtWEP2
            // 
            this.txtWEP2.Location = new System.Drawing.Point(212, 71);
            this.txtWEP2.Name = "txtWEP2";
            this.txtWEP2.Size = new System.Drawing.Size(75, 20);
            this.txtWEP2.TabIndex = 11;
            this.txtWEP2.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "After Enhance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Attack Power Gain";
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGain.Location = new System.Drawing.Point(399, 105);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(32, 20);
            this.lblGain.TabIndex = 14;
            this.lblGain.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 163);
            this.Controls.Add(this.lblGain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWEP2);
            this.Controls.Add(this.txtDex2);
            this.Controls.Add(this.AtkUpgrade);
            this.Controls.Add(this.AttackFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWEP);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Lost Ark Enhance Calculator Attack Power";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.TextBox txtWEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AttackFinal;
        private System.Windows.Forms.Label AtkUpgrade;
        private System.Windows.Forms.TextBox txtDex2;
        private System.Windows.Forms.TextBox txtWEP2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGain;
    }
}

