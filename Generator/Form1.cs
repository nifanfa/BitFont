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
        string Charset = string.Empty;
        string CharsetFileName = string.Empty;

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

        private void SelectCharset_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT File|*.txt";
            openFileDialog.ShowDialog();
            Charset = File.ReadAllText(openFileDialog.FileName);
            CharsetFileName = openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.LastIndexOf("."));
        }

        private void Save_Click(object sender, EventArgs e)
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

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary File|*.bin";
            saveFileDialog.FileName = $"{Fnt.FontFamily.Name}{CharsetFileName}{Size}.bin";
            saveFileDialog.ShowDialog();
            File.WriteAllBytes(saveFileDialog.FileName, Data.ToArray());
            GC.Collect();
        }
    }
}
