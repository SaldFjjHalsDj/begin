﻿namespace ProjectBegin
{
    partial class FormNesoverRodstv
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Sotrudnik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VidRod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FamRod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImyRod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OtchRod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vozrast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Несовершеннолетние родственники сотрудников";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sotrudnik,
            this.VidRod,
            this.FamRod,
            this.ImyRod,
            this.OtchRod,
            this.Vozrast});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 373);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Sotrudnik
            // 
            this.Sotrudnik.Text = "Сотрудник";
            // 
            // VidRod
            // 
            this.VidRod.Text = "Член семьи";
            // 
            // FamRod
            // 
            this.FamRod.Text = "Фамилия родственника";
            // 
            // ImyRod
            // 
            this.ImyRod.Text = "Имя";
            // 
            // OtchRod
            // 
            this.OtchRod.Text = "Отчество";
            // 
            // Vozrast
            // 
            this.Vozrast.Text = "Возраст";
            // 
            // FormNesoverRodstv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "FormNesoverRodstv";
            this.Text = "FormNesoverRodstv";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Sotrudnik;
        private System.Windows.Forms.ColumnHeader VidRod;
        private System.Windows.Forms.ColumnHeader FamRod;
        private System.Windows.Forms.ColumnHeader ImyRod;
        private System.Windows.Forms.ColumnHeader OtchRod;
        private System.Windows.Forms.ColumnHeader Vozrast;
    }
}