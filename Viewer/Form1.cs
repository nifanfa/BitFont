using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Viewer
{
    public partial class Form1 : Form
    {
        MemoryStream memoryStream;
        int Size = 8;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary File|*.bin";
            openFileDialog.ShowDialog();
            memoryStream = new MemoryStream(File.ReadAllBytes(openFileDialog.FileName));
        }

        private void Load_Click(object sender, EventArgs e)
        {
            int aIndex = Convert.ToInt32(Index.Text);
            int SizePerFont = Size * (Size / 8);
            byte[] buffer = new byte[SizePerFont];
            memoryStream.Seek(SizePerFont * aIndex, SeekOrigin.Begin);
            memoryStream.Read(buffer, 0, buffer.Length);

            Graphics graphics = PreviewBox.CreateGraphics();
            graphics.Clear(Color.White);
            for (int h = 0; h < Size; h++)
            {
                for (int aw = 0; aw < Size / 8; aw++)
                {
                    for (int ww = 0; ww < 8; ww++)
                    {
                        if ((buffer[(h * (Size / 8)) + aw] & (0x80 >> ww)) != 0)
                        {
                            graphics.DrawPoint((aw * 8) + ww, h, Color.Black);
                        }
                    }
                }
            }

            foreach (var v in buffer)
            {
                Console.WriteLine(Convert.ToString(v, 16));
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Size += 8;
            NotifyDataChanged();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (Size - 8 < 8) return;
            Size -= 8;
            NotifyDataChanged();
        }

        private void NotifyDataChanged()
        {
            SizeLabel.Text = $"Size：{Size}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NotifyDataChanged();
        }
    }
}
