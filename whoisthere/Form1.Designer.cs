﻿namespace whoisthere
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipRequestBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipRequestBox
            // 
            this.ipRequestBox.AccessibleName = "";
            this.ipRequestBox.Location = new System.Drawing.Point(73, 57);
            this.ipRequestBox.Name = "ipRequestBox";
            this.ipRequestBox.Size = new System.Drawing.Size(101, 20);
            this.ipRequestBox.TabIndex = 0;
            this.ipRequestBox.Text = "192.168.1.1";
            this.ipRequestBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pingBtn
            // 
            this.pingBtn.Location = new System.Drawing.Point(174, 128);
            this.pingBtn.Name = "pingBtn";
            this.pingBtn.Size = new System.Drawing.Size(75, 23);
            this.pingBtn.TabIndex = 2;
            this.pingBtn.Text = "Ping";
            this.pingBtn.UseVisualStyleBackColor = true;
            this.pingBtn.Click += new System.EventHandler(this.pingBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 163);
            this.Controls.Add(this.pingBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipRequestBox);
            this.Name = "Form1";
            this.Text = "Who is there? ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipRequestBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pingBtn;
    }
}

