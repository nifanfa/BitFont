# BitFont
Convert Windows Fonts to BitFont For Cosmos and more!  
![image](https://github.com/nifanfa/BitFont/blob/master/QQ%E6%88%AA%E5%9B%BE20210411155353.png)

For Cosmos https://github.com/nifanfa/BitFontCosmosKernelSample  
![image](https://github.com/nifanfa/BitFont/blob/master/QQ%E6%88%AA%E5%9B%BE20210411155656.png)

Read Font Sample

        public static int DrawBitFontChar(this Canvas canvas, MemoryStream MemoryStream, int Size, Color Color, int Index, int X, int Y)
        {
            if (Index == -1) return 0;

            int MaxX = 0;

            int SizePerFont = Size * (Size / 8);
            byte[] Font = new byte[SizePerFont];
            MemoryStream.Seek(SizePerFont * Index, SeekOrigin.Begin);
            MemoryStream.Read(Font, 0, Font.Length);

            for (int h = 0; h < Size; h++)
            {
                for (int aw = 0; aw < Size / 8; aw++)
                {

                    for (int ww = 0; ww < 8; ww++)
                    {
                        if ((Font[(h * (Size / 8)) + aw] & (0x80 >> ww)) != 0)
                        {
                            canvas.DrawPoint(new Pen(Color), X + (aw * 8) + ww, Y + h);

                            if ((aw * 8) + ww > MaxX)
                            {
                                MaxX = (aw * 8) + ww;
                            }
                        }
                    }
                }
            }

            return MaxX;
        }
