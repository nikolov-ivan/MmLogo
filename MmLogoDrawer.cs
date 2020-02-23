namespace MmLogo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class MmLogoDrawer
    {
        private char filledSpace = '*';
        private char freeSpace = '-';
        private const int numberOfMDraw = 2;
        public string Draw(int width)
        {
            StringBuilder sb = new StringBuilder();
            this.DrawTopPart(sb, width);
            this.DrawBottomPart(sb, width);
            return sb.ToString();
        }

        private void DrawTopPart(StringBuilder sb, int width)
        {
            for (int rowNumber = 0; rowNumber < width - rowNumber; rowNumber++)
            {
                this.DrawTopMm(sb, width, rowNumber);

            }

        }

        private void DrawTopMm(StringBuilder sb, int width, int rowNumber)
        {
            for (int i = 0; i < numberOfMDraw; i++)
            {
                sb.Append(this.freeSpace, width - rowNumber);
                sb.Append(this.filledSpace, width + 2 * rowNumber);
                sb.Append(this.freeSpace, width - 2 * rowNumber);
                sb.Append(this.filledSpace, width + 2 * rowNumber);
                sb.Append(this.freeSpace, width - rowNumber);
            }
            sb.AppendLine();

        }


        private void DrawBottomPart(StringBuilder sb, int width)
        {
            for (int i = 0; i < width - i; i++)
            {
                this.DrawBottomMm(sb, width, i);
                
                sb.AppendLine();
            }
        }

        private void DrawBottomMm(StringBuilder sb, int width, int rowNumber)
        {
            for (int i = 0; i < numberOfMDraw; i++)
            {
                sb.Append(this.freeSpace, width / 2 - rowNumber);
                sb.Append(this.filledSpace, width);
                sb.Append(this.freeSpace, 1 + 2 * rowNumber);
                sb.Append(this.filledSpace, 2 * width - 1 - 2 * rowNumber);
                sb.Append(this.freeSpace, 1 + 2 * rowNumber);
                sb.Append(this.filledSpace, width);
                sb.Append(this.freeSpace, width / 2 - rowNumber);
            }
            
        }

    }
}
