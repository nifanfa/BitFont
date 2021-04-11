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

            Title();
        }

        private void Title()
        {
            this.Text = "Number：" + (memoryStream.Length / (Size * (Size / 8))).ToString();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            int aIndex = Convert.ToInt32(Index.Text);
            int SizePerFont = Size * (Size / 8);
            byte[] buffer = new byte[SizePerFont];
            memoryStream.Seek(SizePerFont * aIndex, SeekOrigin.Begin);
            memoryStream.Read(buffer, 0, buffer.Length);

            Bitmap bitmap = new Bitmap(Size, Size);
            Graphics graphics = Graphics.FromImage(bitmap);
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
            graphics.Flush();
            graphics.Dispose();
            PreviewBox.Image = bitmap;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Size += 8;
            NotifyDataChanged();
            Title();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (Size - 8 < 8) return;
            Size -= 8;
            NotifyDataChanged();
            Title();
        }

        private void NotifyDataChanged()
        {
            switch (UILan)
            {
                case Lan.Chinese:
                    SizeLabel.Text = $"大小：{Size}";
                    break;
                case Lan.English:
                    SizeLabel.Text = $"Size：{Size}";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NotifyDataChanged();
            ChangeLan();
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
                    Open.Text = "打开";
                    LoadButton.Text = "加载";
                    label2.Text = "第几个：";
                    break;
                case Lan.English:
                    Open.Text = "Open";
                    LoadButton.Text = "Load";
                    label2.Text = "Index：";
                    break;
            }
            NotifyDataChanged();
        }
    }
}
