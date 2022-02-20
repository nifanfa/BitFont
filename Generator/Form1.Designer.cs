
namespace Generator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Smaller = new System.Windows.Forms.Button();
            this.Bigger = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.PreviewText = new System.Windows.Forms.TextBox();
            this.SelectFontButton = new System.Windows.Forms.Button();
            this.PreviewCharLabel = new System.Windows.Forms.Label();
            this.CharsetBox = new System.Windows.Forms.TextBox();
            this.CharsetLabel = new System.Windows.Forms.Label();
            this.SaveAsBase64Button = new System.Windows.Forms.Button();
            this.SaveForCosmosButton = new System.Windows.Forms.Button();
            this.TipLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveForMosaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewBox
            // 
            this.PreviewBox.Location = new System.Drawing.Point(311, 55);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(256, 198);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PreviewBox.TabIndex = 1;
            this.PreviewBox.TabStop = false;
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(275, 134);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(30, 30);
            this.Right.TabIndex = 4;
            this.Right.Text = "→";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(203, 134);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(30, 30);
            this.Left.TabIndex = 5;
            this.Left.Text = "←";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(239, 170);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(30, 30);
            this.Down.TabIndex = 7;
            this.Down.Text = "↓";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(239, 98);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(30, 30);
            this.Up.TabIndex = 8;
            this.Up.Text = "↑";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Smaller
            // 
            this.Smaller.Location = new System.Drawing.Point(12, 286);
            this.Smaller.Name = "Smaller";
            this.Smaller.Size = new System.Drawing.Size(75, 23);
            this.Smaller.TabIndex = 9;
            this.Smaller.Text = "Smaller";
            this.Smaller.UseVisualStyleBackColor = true;
            this.Smaller.Click += new System.EventHandler(this.Smaller_Click);
            // 
            // Bigger
            // 
            this.Bigger.Location = new System.Drawing.Point(12, 257);
            this.Bigger.Name = "Bigger";
            this.Bigger.Size = new System.Drawing.Size(75, 23);
            this.Bigger.TabIndex = 10;
            this.Bigger.Text = "Bigger";
            this.Bigger.UseVisualStyleBackColor = true;
            this.Bigger.Click += new System.EventHandler(this.Bigger_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(387, 288);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(282, 288);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(23, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(358, 288);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(23, 23);
            this.Minus.TabIndex = 13;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(311, 293);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(41, 12);
            this.SizeLabel.TabIndex = 14;
            this.SizeLabel.Text = "label1";
            // 
            // PreviewText
            // 
            this.PreviewText.Location = new System.Drawing.Point(93, 288);
            this.PreviewText.MaxLength = 1;
            this.PreviewText.Name = "PreviewText";
            this.PreviewText.Size = new System.Drawing.Size(102, 21);
            this.PreviewText.TabIndex = 15;
            this.PreviewText.Text = "A";
            this.PreviewText.TextChanged += new System.EventHandler(this.PreviewText_TextChanged);
            // 
            // SelectFontButton
            // 
            this.SelectFontButton.Location = new System.Drawing.Point(201, 286);
            this.SelectFontButton.Name = "SelectFontButton";
            this.SelectFontButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFontButton.TabIndex = 16;
            this.SelectFontButton.Text = "SelectFont";
            this.SelectFontButton.UseVisualStyleBackColor = true;
            this.SelectFontButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PreviewCharLabel
            // 
            this.PreviewCharLabel.AutoSize = true;
            this.PreviewCharLabel.Location = new System.Drawing.Point(93, 268);
            this.PreviewCharLabel.Name = "PreviewCharLabel";
            this.PreviewCharLabel.Size = new System.Drawing.Size(89, 12);
            this.PreviewCharLabel.TabIndex = 17;
            this.PreviewCharLabel.Text = "Preview Char：";
            // 
            // CharsetBox
            // 
            this.CharsetBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CharsetBox.Location = new System.Drawing.Point(14, 40);
            this.CharsetBox.Multiline = true;
            this.CharsetBox.Name = "CharsetBox";
            this.CharsetBox.Size = new System.Drawing.Size(183, 211);
            this.CharsetBox.TabIndex = 18;
            this.CharsetBox.Text = "!\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopq" +
    "rstuvwxyz{|}~";
            // 
            // CharsetLabel
            // 
            this.CharsetLabel.AutoSize = true;
            this.CharsetLabel.Location = new System.Drawing.Point(12, 25);
            this.CharsetLabel.Name = "CharsetLabel";
            this.CharsetLabel.Size = new System.Drawing.Size(59, 12);
            this.CharsetLabel.TabIndex = 19;
            this.CharsetLabel.Text = "Charset：";
            // 
            // SaveAsBase64Button
            // 
            this.SaveAsBase64Button.Location = new System.Drawing.Point(468, 288);
            this.SaveAsBase64Button.Name = "SaveAsBase64Button";
            this.SaveAsBase64Button.Size = new System.Drawing.Size(97, 23);
            this.SaveAsBase64Button.TabIndex = 20;
            this.SaveAsBase64Button.Text = "SaveAsBase64";
            this.SaveAsBase64Button.UseVisualStyleBackColor = true;
            this.SaveAsBase64Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveForCosmosButton
            // 
            this.SaveForCosmosButton.Location = new System.Drawing.Point(468, 259);
            this.SaveForCosmosButton.Name = "SaveForCosmosButton";
            this.SaveForCosmosButton.Size = new System.Drawing.Size(97, 23);
            this.SaveForCosmosButton.TabIndex = 21;
            this.SaveForCosmosButton.Text = "SaveForCosmos";
            this.SaveForCosmosButton.UseVisualStyleBackColor = true;
            this.SaveForCosmosButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(309, 40);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(245, 12);
            this.TipLabel.TabIndex = 22;
            this.TipLabel.Text = "PreviewBox (Please Keep Font Left Align)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.中文ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 25);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.中文ToolStripMenuItem.Text = "中文";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click);
            // 
            // SaveForMosaButton
            // 
            this.SaveForMosaButton.Location = new System.Drawing.Point(358, 259);
            this.SaveForMosaButton.Name = "SaveForMosaButton";
            this.SaveForMosaButton.Size = new System.Drawing.Size(104, 23);
            this.SaveForMosaButton.TabIndex = 24;
            this.SaveForMosaButton.Text = "SaveForMosa";
            this.SaveForMosaButton.UseVisualStyleBackColor = true;
            this.SaveForMosaButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 321);
            this.Controls.Add(this.SaveForMosaButton);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.SaveForCosmosButton);
            this.Controls.Add(this.SaveAsBase64Button);
            this.Controls.Add(this.CharsetLabel);
            this.Controls.Add(this.CharsetBox);
            this.Controls.Add(this.PreviewCharLabel);
            this.Controls.Add(this.SelectFontButton);
            this.Controls.Add(this.PreviewText);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Bigger);
            this.Controls.Add(this.Smaller);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Smaller;
        private System.Windows.Forms.Button Bigger;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.TextBox PreviewText;
        private System.Windows.Forms.Button SelectFontButton;
        private System.Windows.Forms.Label PreviewCharLabel;
        private System.Windows.Forms.TextBox CharsetBox;
        private System.Windows.Forms.Label CharsetLabel;
        private System.Windows.Forms.Button SaveAsBase64Button;
        private System.Windows.Forms.Button SaveForCosmosButton;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.Button SaveForMosaButton;
    }
}

