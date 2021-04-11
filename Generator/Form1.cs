using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Generator
{
    public partial class Form1 : Form
    {
        int FinalSize = 8;
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
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Trimming = StringTrimming.Character;
            graphics.Clear(Color.White);
            graphics.DrawString(c.ToString(), new Font(Fnt.FontFamily, Size), Brushes.Black, new RectangleF(RightOffset, TopOffset, FinalSize, FinalSize), stringFormat);
            graphics.Flush();
            graphics.Dispose();
            stringFormat.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NotifyDataChanged();
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
            SaveFile();
        }

        private void SaveFile(bool SaveAsBase64 = false, bool SaveForCosmos = false)
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
                            Console.WriteLine(color);
                            if (color == Color.FromArgb(255, 255, 255, 255))
                            {
                                s += "0";
                            }
                            else
                            {
                                s += "1";
                            }
                        }
                        Console.WriteLine(s);
                        byte b = Convert.ToByte(s, 2);
                        Data.Add(b);
                    }
                }
            }

            if (!SaveAsBase64)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Binary File|*.bin";
                saveFileDialog.FileName = $"{Fnt.FontFamily.Name}CustomCharset{FinalSize}.bin";
                saveFileDialog.ShowDialog();
                File.WriteAllBytes(saveFileDialog.FileName, Data.ToArray());
            }
            else
            {
                if (!SaveForCosmos)
                {
                    Clipboard.SetText(Convert.ToBase64String(Data.ToArray()));
                    MessageBox.Show("The File Has Been Saved In Your Clipboard.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Clipboard.SetText($"string CustomCharset = \"{Charset}\";\nMemoryStream {Fnt.FontFamily.Name}CustomCharset{FinalSize} = new MemoryStream(Convert.FromBase64String(\"{Convert.ToBase64String(Data.ToArray())}\"));\nBitFont.RegisterBitFont(\"{Fnt.FontFamily.Name}CustomCharset{FinalSize}\", new BitFontDescriptor(CustomCharset, {Fnt.FontFamily.Name}CustomCharset{FinalSize}, {FinalSize}));");
                    MessageBox.Show("The File Has Been Saved In Your Clipboard.\nNote: In The Cosmos If The String Too Long Will Crash The NASM So Split Them.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            GC.Collect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFile(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFile(true, true);
        }
    }
}
