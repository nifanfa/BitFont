using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Generator
{
    public partial class Form1 : Form
    {
        int FinalSize = 16;
        int Size = 8;
        Font Fnt = new Font("Arial", 8);
        string Charset
        {
            get => CharsetBox.Text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            FinalSize += 8;
            NotifyDataChanged();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (FinalSize - 8 < 8) return;
            FinalSize -= 8;
            NotifyDataChanged();
        }

        Bitmap bitmap;

        private void NotifyDataChanged()
        {
            this.Text = $"{Fnt.FontFamily.Name} Custom Charset {FinalSize}";

            if (PreviewText.Text.Length == 0) return;

            SizeLabel.Text = FinalSize + "px";

            Draw(PreviewText.Text[0]);

            PreviewBox.Image = bitmap;
        }

        private void Draw(char c)
        {
            if (bitmap == null || bitmap.Width != FinalSize || bitmap.Height != FinalSize)
            {
                bitmap = new Bitmap(FinalSize, FinalSize);
            }
            Graphics graphics = Graphics.FromImage(bitmap);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Far;
            stringFormat.Trimming = StringTrimming.Character;
            graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            graphics.Clear(Color.White);
            graphics.DrawString(c.ToString(), new Font(Fnt.FontFamily, Size), Brushes.Black, new RectangleF(RightOffset, TopOffset, FinalSize, FinalSize), stringFormat);
            graphics.Flush();
            graphics.Dispose();
            stringFormat.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NotifyDataChanged();
            ChangeLan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            Fnt = fontDialog.Font;
            NotifyDataChanged();
        }

        int TopOffset = 0;
        int RightOffset = 0;

        private void Up_Click(object sender, EventArgs e)
        {
            TopOffset--;
            NotifyDataChanged();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            TopOffset++;
            NotifyDataChanged();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            RightOffset--;
            NotifyDataChanged();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            RightOffset++;
            NotifyDataChanged();
        }

        private void Bigger_Click(object sender, EventArgs e)
        {
            Size++;
            NotifyDataChanged();
        }

        private void Smaller_Click(object sender, EventArgs e)
        {
            Size--;
            NotifyDataChanged();
        }

        private void PreviewText_TextChanged(object sender, EventArgs e)
        {
            NotifyDataChanged();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFile(SaveFor.File);
        }

        enum SaveFor 
        {
            File,
            Base64,
            Cosmos,
            MOSA
        }

        private void SaveFile(SaveFor saveFor = SaveFor.File)
        {
            if (Charset == string.Empty)
            {
                MessageBox.Show("No Charset", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<byte> Data = new List<byte>();

            foreach (char c in Charset)
            {
                Draw(c);
                for (int h = 0; h < FinalSize; h++)
                {
                    for (int aw = 0; aw < FinalSize / 8; aw++)
                    {
                        string s = string.Empty;
                        for (int ww = 0; ww < 8; ww++)
                        {
                            Color color = bitmap.GetPixel((aw * 8) + ww, h);
                            if (color == Color.FromArgb(255, 255, 255, 255))
                            {
                                s += "0";
                            }
                            else
                            {
                                s += "1";
                            }
                        }
                        byte b = Convert.ToByte(s, 2);
                        Data.Add(b);
                    }
                }
            }

            switch (saveFor) 
            {
                case SaveFor.File:
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Binary File|*.bin";
                    saveFileDialog.FileName = $"{Fnt.FontFamily.Name.Replace(" ", "")}CustomCharset{FinalSize}.bin";
                    saveFileDialog.ShowDialog();
                    File.WriteAllBytes(saveFileDialog.FileName, Data.ToArray());
                    break;
                case SaveFor.Base64:
                    Clipboard.SetText(Convert.ToBase64String(Data.ToArray()));
                    MessageBox.Show("The File Has Been Saved In Your Clipboard.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case SaveFor.Cosmos:
                    Clipboard.SetText($"string CustomCharset = \"{Charset}\";\nMemoryStream {Fnt.FontFamily.Name.Replace(" ", "")}CustomCharset{FinalSize} = new MemoryStream(Convert.FromBase64String(\"{Convert.ToBase64String(Data.ToArray())}\"));\nBitFont.RegisterBitFont(\"{Fnt.FontFamily.Name.Replace(" ", "")}CustomCharset{FinalSize}\", new BitFontDescriptor(CustomCharset, {Fnt.FontFamily.Name.Replace(" ", "")}CustomCharset{FinalSize}, {FinalSize}));");
                    MessageBox.Show("The File Has Been Saved In Your Clipboard.\nNote: In The Cosmos If The String Too Long Will Crash The NASM So Split Them.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case SaveFor.MOSA:
                    Clipboard.SetText($"string CustomCharset = \"{Charset}\";\nbyte[] {Fnt.FontFamily.Name.Replace(" ", "")}CustomCharset{FinalSize} = Convert.FromBase64String(\"{Convert.ToBase64String(Data.ToArray())}\");\nBitFont.RegisterBitFont(new BitFontDescriptor(\"{Fnt.FontFamily.Name.Replace(" ", "")}CustomCharset{FinalSize}\",CustomCharset, {Fnt.FontFamily.Name.Replace(" ", "")}CustomCharset{FinalSize}, {FinalSize}));");
                    MessageBox.Show("The File Has Been Saved In Your Clipboard.\nNote: Thanks For Using MOSA-Core!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            GC.Collect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFile(SaveFor.Base64);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFile(SaveFor.Cosmos);
        }

        enum Lan
        {
            English, Chinese
        }

        Lan UILan = Lan.Chinese;

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UILan = Lan.English;
            ChangeLan();
        }

        private void 中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UILan = Lan.Chinese;
            ChangeLan();
        }

        void ChangeLan()
        {
            switch (UILan)
            {
                case Lan.Chinese:
                    CharsetLabel.Text = "字符集：";
                    PreviewCharLabel.Text = "预览字符：";
                    TipLabel.Text = "预览 (字体要左对齐)";

                    Bigger.Text = "增大";
                    Smaller.Text = "缩小";
                    SelectFontButton.Text = "选择字体";
                    Save.Text = "保存";
                    SaveAsBase64Button.Text = "保存为Base64";
                    SaveForCosmosButton.Text = "保存用于Cosmos";
                    SaveForMosaButton.Text = "保存用于MOSA";
                    break;
                case Lan.English:
                    CharsetLabel.Text = "Charset：";
                    PreviewCharLabel.Text = "Preview Char：";
                    TipLabel.Text = "PreviewBox (Please Keep Font Left Align)";

                    Bigger.Text = "Bigger";
                    Smaller.Text = "Smaller";
                    SelectFontButton.Text = "SelectFont";
                    Save.Text = "Save";
                    SaveAsBase64Button.Text = "SaveAsBase64";
                    SaveForCosmosButton.Text = "SaveForCosmos";
                    SaveForMosaButton.Text = "SaveForMOSA";
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFile(SaveFor.MOSA);
        }
    }
}
