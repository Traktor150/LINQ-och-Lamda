﻿
namespace CarsForm2._0
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
            this.lib_AllCars = new System.Windows.Forms.ListBox();
            this.lbl_Facts = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Make = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.lbl_Km = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.cmb_Chose = new System.Windows.Forms.ComboBox();
            this.lib_ShowCarsOfColor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lib_AllCars
            // 
            this.lib_AllCars.FormattingEnabled = true;
            this.lib_AllCars.ItemHeight = 16;
            this.lib_AllCars.Location = new System.Drawing.Point(28, 33);
            this.lib_AllCars.Name = "lib_AllCars";
            this.lib_AllCars.Size = new System.Drawing.Size(166, 180);
            this.lib_AllCars.TabIndex = 0;
            this.lib_AllCars.SelectedIndexChanged += new System.EventHandler(this.lib_AllCars_SelectedIndexChanged);
            // 
            // lbl_Facts
            // 
            this.lbl_Facts.AutoSize = true;
            this.lbl_Facts.Location = new System.Drawing.Point(226, 33);
            this.lbl_Facts.Name = "lbl_Facts";
            this.lbl_Facts.Size = new System.Drawing.Size(46, 17);
            this.lbl_Facts.TabIndex = 1;
            this.lbl_Facts.Text = "label1";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(226, 60);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(46, 17);
            this.lbl_Id.TabIndex = 2;
            this.lbl_Id.Text = "label2";
            // 
            // lbl_Make
            // 
            this.lbl_Make.AutoSize = true;
            this.lbl_Make.Location = new System.Drawing.Point(226, 77);
            this.lbl_Make.Name = "lbl_Make";
            this.lbl_Make.Size = new System.Drawing.Size(46, 17);
            this.lbl_Make.TabIndex = 3;
            this.lbl_Make.Text = "label3";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Location = new System.Drawing.Point(226, 94);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(46, 17);
            this.lbl_Model.TabIndex = 4;
            this.lbl_Model.Text = "label4";
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(226, 111);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(46, 17);
            this.lbl_Color.TabIndex = 5;
            this.lbl_Color.Text = "label5";
            // 
            // lbl_Km
            // 
            this.lbl_Km.AutoSize = true;
            this.lbl_Km.Location = new System.Drawing.Point(226, 128);
            this.lbl_Km.Name = "lbl_Km";
            this.lbl_Km.Size = new System.Drawing.Size(46, 17);
            this.lbl_Km.TabIndex = 6;
            this.lbl_Km.Text = "label1";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(226, 145);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(46, 17);
            this.lbl_Price.TabIndex = 7;
            this.lbl_Price.Text = "label1";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(226, 162);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(46, 17);
            this.lbl_Year.TabIndex = 8;
            this.lbl_Year.Text = "label1";
            // 
            // cmb_Chose
            // 
            this.cmb_Chose.FormattingEnabled = true;
            this.cmb_Chose.Location = new System.Drawing.Point(440, 30);
            this.cmb_Chose.Name = "cmb_Chose";
            this.cmb_Chose.Size = new System.Drawing.Size(145, 24);
            this.cmb_Chose.TabIndex = 9;
            this.cmb_Chose.SelectedIndexChanged += new System.EventHandler(this.cmb_Chose_SelectedIndexChanged);
            // 
            // lib_ShowCarsOfColor
            // 
            this.lib_ShowCarsOfColor.FormattingEnabled = true;
            this.lib_ShowCarsOfColor.ItemHeight = 16;
            this.lib_ShowCarsOfColor.Location = new System.Drawing.Point(440, 94);
            this.lib_ShowCarsOfColor.Name = "lib_ShowCarsOfColor";
            this.lib_ShowCarsOfColor.Size = new System.Drawing.Size(145, 116);
            this.lib_ShowCarsOfColor.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lib_ShowCarsOfColor);
            this.Controls.Add(this.cmb_Chose);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Km);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.lbl_Make);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Facts);
            this.Controls.Add(this.lib_AllCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lib_AllCars;
        private System.Windows.Forms.Label lbl_Facts;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Make;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.Label lbl_Km;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.ComboBox cmb_Chose;
        private System.Windows.Forms.ListBox lib_ShowCarsOfColor;
    }
}

