
namespace SOFAP_PPT_Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.songNumberLabel = new System.Windows.Forms.Label();
            this.songNumberInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.preMadeSlidesSelector = new System.Windows.Forms.ComboBox();
            this.addSongButton = new System.Windows.Forms.Button();
            this.addPreMadeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.notInBookLabel = new System.Windows.Forms.Label();
            this.notInBookSelector = new System.Windows.Forms.ComboBox();
            this.addSongNotInBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // songNumberLabel
            // 
            this.songNumberLabel.AutoSize = true;
            this.songNumberLabel.Location = new System.Drawing.Point(12, 26);
            this.songNumberLabel.Name = "songNumberLabel";
            this.songNumberLabel.Size = new System.Drawing.Size(142, 20);
            this.songNumberLabel.TabIndex = 0;
            this.songNumberLabel.Text = "Enter Song Number:";
            // 
            // songNumberInput
            // 
            this.songNumberInput.Location = new System.Drawing.Point(160, 23);
            this.songNumberInput.Name = "songNumberInput";
            this.songNumberInput.Size = new System.Drawing.Size(125, 27);
            this.songNumberInput.TabIndex = 1;
            this.songNumberInput.TextChanged += new System.EventHandler(this.songNumberInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Or Select a Pre-Made Slide:";
            // 
            // preMadeSlidesSelector
            // 
            this.preMadeSlidesSelector.FormattingEnabled = true;
            this.preMadeSlidesSelector.Items.AddRange(new object[] {
            "Welcome",
            "Prayer",
            "Lord\'s Supper",
            "Offering",
            "Lesson",
            "Announcements"});
            this.preMadeSlidesSelector.Location = new System.Drawing.Point(208, 59);
            this.preMadeSlidesSelector.Name = "preMadeSlidesSelector";
            this.preMadeSlidesSelector.Size = new System.Drawing.Size(151, 28);
            this.preMadeSlidesSelector.TabIndex = 4;
            this.preMadeSlidesSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(291, 23);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(94, 27);
            this.addSongButton.TabIndex = 5;
            this.addSongButton.Text = "Add Slide";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Visible = false;
            // 
            // addPreMadeButton
            // 
            this.addPreMadeButton.Location = new System.Drawing.Point(365, 59);
            this.addPreMadeButton.Name = "addPreMadeButton";
            this.addPreMadeButton.Size = new System.Drawing.Size(94, 28);
            this.addPreMadeButton.TabIndex = 6;
            this.addPreMadeButton.Text = "Add Slide";
            this.addPreMadeButton.UseVisualStyleBackColor = true;
            this.addPreMadeButton.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your Presentation (Drag to change order):";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(504, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 404);
            this.listBox1.TabIndex = 8;
            // 
            // notInBookLabel
            // 
            this.notInBookLabel.AutoSize = true;
            this.notInBookLabel.Location = new System.Drawing.Point(13, 100);
            this.notInBookLabel.Name = "notInBookLabel";
            this.notInBookLabel.Size = new System.Drawing.Size(216, 20);
            this.notInBookLabel.TabIndex = 9;
            this.notInBookLabel.Text = "Or Pick a Song Not in the Book:";
            // 
            // notInBookSelector
            // 
            this.notInBookSelector.FormattingEnabled = true;
            this.notInBookSelector.Location = new System.Drawing.Point(234, 97);
            this.notInBookSelector.Name = "notInBookSelector";
            this.notInBookSelector.Size = new System.Drawing.Size(151, 28);
            this.notInBookSelector.TabIndex = 10;
            this.notInBookSelector.SelectedIndexChanged += new System.EventHandler(this.notInBookSelector_SelectedIndexChanged);
            // 
            // addSongNotInBookButton
            // 
            this.addSongNotInBookButton.Location = new System.Drawing.Point(391, 97);
            this.addSongNotInBookButton.Name = "addSongNotInBookButton";
            this.addSongNotInBookButton.Size = new System.Drawing.Size(94, 28);
            this.addSongNotInBookButton.TabIndex = 11;
            this.addSongNotInBookButton.Text = "Add Slide";
            this.addSongNotInBookButton.UseVisualStyleBackColor = true;
            this.addSongNotInBookButton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addSongNotInBookButton);
            this.Controls.Add(this.notInBookSelector);
            this.Controls.Add(this.notInBookLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPreMadeButton);
            this.Controls.Add(this.addSongButton);
            this.Controls.Add(this.preMadeSlidesSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.songNumberInput);
            this.Controls.Add(this.songNumberLabel);
            this.Name = "Form1";
            this.Text = "PowerPoint Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label songNumberLabel;
        private System.Windows.Forms.TextBox songNumberInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox preMadeSlidesSelector;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Button addPreMadeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label notInBookLabel;
        private System.Windows.Forms.ComboBox notInBookSelector;
        private System.Windows.Forms.Button addSongNotInBookButton;
    }
}

