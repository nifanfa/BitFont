
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
            this.SelectCharset = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectCharset
            // 
            this.SelectCharset.Location = new System.Drawing.Point(12, 12);
            this.SelectCharset.Name = "SelectCharset";
            this.SelectCharset.Size = new System.Drawing.Size(102, 23);
            this.SelectCharset.TabIndex = 0;
            this.SelectCharset.Text = "SelectCharset";
            this.SelectCharset.UseVisualStyleBackColor = true;
            this.SelectCharset.Click += new System.EventHandler(this.SelectCharset_Click);
            // 
            // PreviewBox
            // 
            this.PreviewBox.Location = new System.Drawing.Point(212, 12);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(176, 176);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PreviewBox.TabIndex = 1;
            this.PreviewBox.TabStop = false;
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(93, 88);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(30, 30);
            this.Right.TabIndex = 4;
            this.Right.Text = "→";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(21, 88);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(30, 30);
            this.Left.TabIndex = 5;
            this.Left.Text = "←";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(57, 124);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(30, 30);
            this.Down.TabIndex = 7;
            this.Down.Text = "↓";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(57, 52);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(30, 30);
            this.Up.TabIndex = 8;
            this.Up.Text = "↑";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Smaller
            // 
            this.Smaller.Location = new System.Drawing.Point(12, 203);
            this.Smaller.Name = "Smaller";
            this.Smaller.Size = new System.Drawing.Size(75, 23);
            this.Smaller.TabIndex = 9;
            this.Smaller.Text = "Smaller";
            this.Smaller.UseVisualStyleBackColor = true;
            this.Smaller.Click += new System.EventHandler(this.Smaller_Click);
            // 
            // Bigger
            // 
            this.Bigger.Location = new System.Drawing.Point(12, 174);
            this.Bigger.Name = "Bigger";
            this.Bigger.Size = new System.Drawing.Size(75, 23);
            this.Bigger.TabIndex = 10;
            this.Bigger.Text = "Bigger";
            this.Bigger.UseVisualStyleBackColor = true;
            this.Bigger.Click += new System.EventHandler(this.Bigger_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(313, 203);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(212, 203);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(23, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(241, 203);
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
            this.SizeLabel.Location = new System.Drawing.Point(266, 208);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(41, 12);
            this.SizeLabel.TabIndex = 14;
            this.SizeLabel.Text = "label1";
            // 
            // PreviewText
            // 
            this.PreviewText.Location = new System.Drawing.Point(93, 205);
            this.PreviewText.MaxLength = 1;
            this.PreviewText.Name = "PreviewText";
            this.PreviewText.Size = new System.Drawing.Size(102, 21);
            this.PreviewText.TabIndex = 15;
            this.PreviewText.Text = "A";
            this.PreviewText.TextChanged += new System.EventHandler(this.PreviewText_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "SelectFont";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "Preview Char：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 238);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.SelectCharset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectCharset;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

