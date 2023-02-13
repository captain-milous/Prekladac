using System.Collections.Generic;
using System;

namespace Prekladac
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
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.czechRadioButton = new System.Windows.Forms.RadioButton();
            this.translateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnglishLabel = new System.Windows.Forms.Label();
            this.CzechLabel = new System.Windows.Forms.Label();
            this.englishWordTextBox = new System.Windows.Forms.TextBox();
            this.czechWordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addTranstationButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wordTextBox.Location = new System.Drawing.Point(301, 86);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(173, 35);
            this.wordTextBox.TabIndex = 0;
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.englishRadioButton.Location = new System.Drawing.Point(65, 82);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(99, 32);
            this.englishRadioButton.TabIndex = 1;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "English";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Translate from";
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.translationLabel.Location = new System.Drawing.Point(528, 86);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(116, 28);
            this.translationLabel.TabIndex = 3;
            this.translationLabel.Text = "Translation";
            // 
            // czechRadioButton
            // 
            this.czechRadioButton.AutoSize = true;
            this.czechRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czechRadioButton.Location = new System.Drawing.Point(65, 120);
            this.czechRadioButton.Name = "czechRadioButton";
            this.czechRadioButton.Size = new System.Drawing.Size(89, 32);
            this.czechRadioButton.TabIndex = 4;
            this.czechRadioButton.TabStop = true;
            this.czechRadioButton.Text = "Czech";
            this.czechRadioButton.UseVisualStyleBackColor = true;
            // 
            // translateButton
            // 
            this.translateButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.translateButton.Location = new System.Drawing.Point(301, 139);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(129, 44);
            this.translateButton.TabIndex = 5;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(294, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(526, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Translation";
            // 
            // EnglishLabel
            // 
            this.EnglishLabel.AutoSize = true;
            this.EnglishLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnglishLabel.Location = new System.Drawing.Point(90, 372);
            this.EnglishLabel.Name = "EnglishLabel";
            this.EnglishLabel.Size = new System.Drawing.Size(110, 40);
            this.EnglishLabel.TabIndex = 8;
            this.EnglishLabel.Text = "English";
            // 
            // CzechLabel
            // 
            this.CzechLabel.AutoSize = true;
            this.CzechLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CzechLabel.Location = new System.Drawing.Point(326, 372);
            this.CzechLabel.Name = "CzechLabel";
            this.CzechLabel.Size = new System.Drawing.Size(95, 40);
            this.CzechLabel.TabIndex = 9;
            this.CzechLabel.Text = "Czech";
            // 
            // englishWordTextBox
            // 
            this.englishWordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.englishWordTextBox.Location = new System.Drawing.Point(97, 415);
            this.englishWordTextBox.Name = "englishWordTextBox";
            this.englishWordTextBox.Size = new System.Drawing.Size(173, 35);
            this.englishWordTextBox.TabIndex = 10;
            // 
            // czechWordTextBox
            // 
            this.czechWordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czechWordTextBox.Location = new System.Drawing.Point(333, 415);
            this.czechWordTextBox.Name = "czechWordTextBox";
            this.czechWordTextBox.Size = new System.Drawing.Size(173, 35);
            this.czechWordTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(28, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(526, 48);
            this.label4.TabIndex = 12;
            this.label4.Text = "Add translation into Dictonary";
            // 
            // addTranstationButton
            // 
            this.addTranstationButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTranstationButton.Location = new System.Drawing.Point(205, 473);
            this.addTranstationButton.Name = "addTranstationButton";
            this.addTranstationButton.Size = new System.Drawing.Size(200, 50);
            this.addTranstationButton.TabIndex = 13;
            this.addTranstationButton.Text = "Add word";
            this.addTranstationButton.UseVisualStyleBackColor = true;
            this.addTranstationButton.Click += new System.EventHandler(this.addTranstationButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(528, 417);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 29);
            this.errorLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 607);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.addTranstationButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.czechWordTextBox);
            this.Controls.Add(this.englishWordTextBox);
            this.Controls.Add(this.CzechLabel);
            this.Controls.Add(this.EnglishLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.czechRadioButton);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.englishRadioButton);
            this.Controls.Add(this.wordTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.RadioButton englishRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.RadioButton czechRadioButton;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EnglishLabel;
        private System.Windows.Forms.Label CzechLabel;
        private System.Windows.Forms.TextBox englishWordTextBox;
        private System.Windows.Forms.TextBox czechWordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addTranstationButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

