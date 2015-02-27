using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Drawing2D;

namespace BankCardPersonalization
{
    public static class ExtBitmap
    {
        public static Bitmap CopyToSquareCanvas(this Bitmap sourceBitmap, int canvasWidthLenght)
        {
            float ratio = 1.0f;
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ?
                          sourceBitmap.Width : sourceBitmap.Height;

            ratio = (float)maxSide / (float)canvasWidthLenght;

            Bitmap bitmapResult = (sourceBitmap.Width > sourceBitmap.Height ?
                                    new Bitmap(canvasWidthLenght, (int)(sourceBitmap.Height / ratio))
                                    : new Bitmap((int)(sourceBitmap.Width / ratio), canvasWidthLenght));

            using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
            {
                graphicsResult.CompositingQuality = CompositingQuality.HighQuality;
                graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality;

                graphicsResult.DrawImage(sourceBitmap,
                                        new Rectangle(0, 0,
                                            bitmapResult.Width, bitmapResult.Height),
                                        new Rectangle(0, 0,
                                            sourceBitmap.Width, sourceBitmap.Height),
                                            GraphicsUnit.Pixel);
                graphicsResult.Flush();
            }

            return bitmapResult;
        }

        public static Bitmap GradientBasedEdgeDetectionFilter(
                                        this Bitmap sourceBitmap,
                                        EdgeFilterType filterType,
                                        DerivativeLevel derivativeLevel,
                                        float redFactor = 1.0f,
                                        float greenFactor = 1.0f,
                                        float blueFactor = 1.0f,
                                        byte threshold = 0)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];

            byte[] resultBuffer = new byte[sourceData.Stride *
                                           sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                                       pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            int derivative = (int)derivativeLevel;
            int byteOffset = 0;
            int blueGradient, greenGradient, redGradient = 0;
            double blue = 0, green = 0, red = 0;

            bool exceedsThreshold = false;

            for (int offsetY = 1; offsetY < sourceBitmap.Height - 1; offsetY++)
            {
                for (int offsetX = 1; offsetX <
                    sourceBitmap.Width - 1; offsetX++)
                {
                    byteOffset = offsetY * sourceData.Stride +
                                 offsetX * 4;

                    blueGradient =
                    Math.Abs(pixelBuffer[byteOffset - 4] -
                    pixelBuffer[byteOffset + 4]) / derivative;

                    blueGradient +=
                    Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] -
                    pixelBuffer[byteOffset + sourceData.Stride]) / derivative;

                    byteOffset++;

                    greenGradient =
                    Math.Abs(pixelBuffer[byteOffset - 4] -
                    pixelBuffer[byteOffset + 4]) / derivative;

                    greenGradient +=
                    Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] -
                    pixelBuffer[byteOffset + sourceData.Stride]) / derivative;

                    byteOffset++;

                    redGradient =
                    Math.Abs(pixelBuffer[byteOffset - 4] -
                    pixelBuffer[byteOffset + 4]) / derivative;

                    redGradient +=
                    Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] -
                    pixelBuffer[byteOffset + sourceData.Stride]) / derivative;

                    if (blueGradient + greenGradient + redGradient > threshold)
                    { exceedsThreshold = true; }
                    else
                    {
                        byteOffset -= 2;

                        blueGradient = Math.Abs(pixelBuffer[byteOffset - 4] -
                                                pixelBuffer[byteOffset + 4]);
                        byteOffset++;

                        greenGradient = Math.Abs(pixelBuffer[byteOffset - 4] -
                                                 pixelBuffer[byteOffset + 4]);
                        byteOffset++;

                        redGradient = Math.Abs(pixelBuffer[byteOffset - 4] -
                                               pixelBuffer[byteOffset + 4]);

                        if (blueGradient + greenGradient + redGradient > threshold)
                        { exceedsThreshold = true; }
                        else
                        {
                            byteOffset -= 2;

                            blueGradient =
                            Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] -
                            pixelBuffer[byteOffset + sourceData.Stride]);

                            byteOffset++;

                            greenGradient =
                            Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] -
                            pixelBuffer[byteOffset + sourceData.Stride]);

                            byteOffset++;

                            redGradient =
                            Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] -
                            pixelBuffer[byteOffset + sourceData.Stride]);

                            if (blueGradient + greenGradient +
                                      redGradient > threshold)
                            { exceedsThreshold = true; }
                            else
                            {
                                byteOffset -= 2;

                                blueGradient =
                                Math.Abs(pixelBuffer[byteOffset - 4 - sourceData.Stride] -
                                pixelBuffer[byteOffset + 4 + sourceData.Stride]) / derivative;

                                blueGradient +=
                                Math.Abs(pixelBuffer[byteOffset - sourceData.Stride + 4] -
                                pixelBuffer[byteOffset + sourceData.Stride - 4]) / derivative;

                                byteOffset++;

                                greenGradient =
                                Math.Abs(pixelBuffer[byteOffset - 4 - sourceData.Stride] -
                                pixelBuffer[byteOffset + 4 + sourceData.Stride]) / derivative;

                                greenGradient +=
                                Math.Abs(pixelBuffer[byteOffset - sourceData.Stride + 4] -
                                pixelBuffer[byteOffset + sourceData.Stride - 4]) / derivative;

                                byteOffset++;

                                redGradient =
                                Math.Abs(pixelBuffer[byteOffset - 4 - sourceData.Stride] -
                                pixelBuffer[byteOffset + 4 + sourceData.Stride]) / derivative;

                                redGradient +=
                                Math.Abs(pixelBuffer[byteOffset - sourceData.Stride + 4] -
                                pixelBuffer[byteOffset + sourceData.Stride - 4]) / derivative;

                                if (blueGradient + greenGradient + redGradient > threshold)
                                { exceedsThreshold = true; }
                                else
                                { exceedsThreshold = false; }
                            }
                        }
                    }

                    byteOffset -= 2;

                    if (exceedsThreshold)
                    {
                        if (filterType == EdgeFilterType.EdgeDetectMono)
                        {
                            blue = green = red = 255;
                        }
                        else if (filterType == EdgeFilterType.EdgeDetectGradient)
                        {
                            blue = blueGradient * blueFactor;
                            green = greenGradient * greenFactor;
                            red = redGradient * redFactor;
                        }
                        else if (filterType == EdgeFilterType.Sharpen)
                        {
                            blue = pixelBuffer[byteOffset] * blueFactor;
                            green = pixelBuffer[byteOffset + 1] * greenFactor;
                            red = pixelBuffer[byteOffset + 2] * redFactor;
                        }
                        else if (filterType == EdgeFilterType.SharpenGradient)
                        {
                            blue = pixelBuffer[byteOffset] + blueGradient * blueFactor;
                            green = pixelBuffer[byteOffset + 1] + greenGradient * greenFactor;
                            red = pixelBuffer[byteOffset + 2] + redGradient * redFactor;
                        }
                    }
                    else
                    {
                        if (filterType == EdgeFilterType.EdgeDetectMono ||
                            filterType == EdgeFilterType.EdgeDetectGradient)
                        {
                            blue = green = red = 0;
                        }
                        else if (filterType == EdgeFilterType.Sharpen ||
                                 filterType == EdgeFilterType.SharpenGradient)
                        {
                            blue = pixelBuffer[byteOffset];
                            green = pixelBuffer[byteOffset + 1];
                            red = pixelBuffer[byteOffset + 2];
                        }
                    }

                    blue = (blue > 255 ? 255 :
                           (blue < 0 ? 0 :
                            blue));

                    green = (green > 255 ? 255 :
                            (green < 0 ? 0 :
                             green));

                    red = (red > 255 ? 255 :
                          (red < 0 ? 0 :
                           red));

                    resultBuffer[byteOffset] = (byte)blue;
                    resultBuffer[byteOffset + 1] = (byte)green;
                    resultBuffer[byteOffset + 2] = (byte)red;
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                                             sourceBitmap.Height);

            BitmapData resultData =
                       resultBitmap.LockBits(new Rectangle(0, 0,
                       resultBitmap.Width, resultBitmap.Height),
                       ImageLockMode.WriteOnly,
                       PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                                       resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
        public static Bitmap FlipPixels(this Bitmap sourceImage)
        {
            List<ArgbPixel> pixelList = GetPixelListFromBitmap(sourceImage);

            pixelList.Reverse();

            Bitmap resultBitmap = GetBitmapFromPixelList(pixelList,
                                sourceImage.Width, sourceImage.Height);

            return resultBitmap;
        }

        private static Bitmap GetBitmapFromPixelList(List<ArgbPixel> pixelList, int width, int height)
        {
            Bitmap resultBitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                        resultBitmap.Width, resultBitmap.Height),
                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] resultBuffer = new byte[resultData.Stride * resultData.Height];

            using (MemoryStream memoryStream = new MemoryStream(resultBuffer))
            {
                memoryStream.Position = 0;
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

                foreach (ArgbPixel pixel in pixelList)
                {
                    binaryWriter.Write(pixel.GetColorBytes());
                }

                binaryWriter.Close();
            }

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
        private static List<ArgbPixel> GetPixelListFromBitmap(Bitmap sourceImage)
        {
            BitmapData sourceData = sourceImage.LockBits(new Rectangle(0, 0,
                        sourceImage.Width, sourceImage.Height),
                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] sourceBuffer = new byte[sourceData.Stride * sourceData.Height];
            Marshal.Copy(sourceData.Scan0, sourceBuffer, 0, sourceBuffer.Length);
            sourceImage.UnlockBits(sourceData);

            List<ArgbPixel> pixelList = new List<ArgbPixel>(sourceBuffer.Length / 4);

            int x = 0;
            int y = 0;

            using (MemoryStream memoryStream = new MemoryStream(sourceBuffer))
            {
                memoryStream.Position = 0;
                BinaryReader binaryReader = new BinaryReader(memoryStream);

                while (memoryStream.Position + 4 <= memoryStream.Length)
                {
                    ArgbPixel pixel = new ArgbPixel(binaryReader.ReadBytes(4), x, y);
                    pixelList.Add(pixel);

                    x += 1;

                    if (x >= sourceData.Width)
                    {
                        x = 0;
                        y += 1;
                    }
                }

                binaryReader.Close();
            }

            return pixelList;
        }
        public class ArgbPixel
        {
            public int pixelX = 0;
            public int pixelY = 0;

            public byte blue = 0;
            public byte green = 0;
            public byte red = 0;
            public byte alpha = 0;

            public ArgbPixel()
            {

            }

            public ArgbPixel(byte[] colorComponents)
            {
                blue = colorComponents[0];
                green = colorComponents[1];
                red = colorComponents[2];
                alpha = colorComponents[3];
            }

            public ArgbPixel(byte[] colorComponents, int x, int y)
            {
                blue = colorComponents[0];
                green = colorComponents[1];
                red = colorComponents[2];
                alpha = colorComponents[3];

                pixelX = x;
                pixelY = y;
            }

            public byte[] GetColorBytes()
            {
                return new byte[] { blue, green, red, alpha };
            }

            public byte this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return blue;
                        case 1: return green;
                        case 2: return red;
                        case 3: return alpha;
                        default: return 0;
                    }
                }
            }
        }
        public static Bitmap SwapColorsCopy(this Bitmap originalImage, ColorSwapFilter swapFilterData)
        {
            BitmapData sourceData = originalImage.LockBits
                                    (new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                                    ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];
            Marshal.Copy(sourceData.Scan0, resultBuffer, 0, resultBuffer.Length);
            originalImage.UnlockBits(sourceData);

            byte sourceBlue = 0, resultBlue = 0,
                 sourceGreen = 0, resultGreen = 0,
                 sourceRed = 0, resultRed = 0;
            byte byte2 = 2, maxValue = 255;

            for (int k = 0; k < resultBuffer.Length; k += 4)
            {
                sourceBlue = resultBuffer[k];
                sourceGreen = resultBuffer[k + 1];
                sourceRed = resultBuffer[k + 2];

                if (swapFilterData.InvertColorsWhenSwapping == true)
                {
                    sourceBlue = (byte)(maxValue - sourceBlue);
                    sourceGreen = (byte)(maxValue - sourceGreen);
                    sourceRed = (byte)(maxValue - sourceRed);
                }

                if (swapFilterData.SwapHalfColorValues == true)
                {
                    sourceBlue = (byte)(sourceBlue / byte2);
                    sourceGreen = (byte)(sourceGreen / byte2);
                    sourceRed = (byte)(sourceRed / byte2);
                }

                switch (swapFilterData.SwapType)
                {
                    case ColorSwapFilter.ColorSwapType.ShiftRight:
                        {
                            resultBlue = sourceGreen;
                            resultRed = sourceBlue;
                            resultGreen = sourceRed;

                            break;
                        }
                    case ColorSwapFilter.ColorSwapType.ShiftLeft:
                        {
                            resultBlue = sourceRed;
                            resultRed = sourceGreen;
                            resultGreen = sourceBlue;

                            break;
                        }
                    case ColorSwapFilter.ColorSwapType.SwapBlueAndRed:
                        {
                            resultBlue = sourceRed;
                            resultRed = sourceBlue;

                            break;
                        }
                    case ColorSwapFilter.ColorSwapType.SwapBlueAndGreen:
                        {
                            resultBlue = sourceGreen;
                            resultGreen = sourceBlue;

                            break;
                        }
                    case ColorSwapFilter.ColorSwapType.SwapRedAndGreen:
                        {
                            resultRed = sourceGreen;
                            resultGreen = sourceGreen;

                            break;
                        }
                }

                resultBuffer[k] = resultBlue;
                resultBuffer[k + 1] = resultGreen;
                resultBuffer[k + 2] = resultRed;
            }

            Bitmap resultBitmap = new Bitmap(originalImage.Width, originalImage.Height,
                                             PixelFormat.Format32bppArgb);

            BitmapData resultData = resultBitmap.LockBits
                                    (new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
    }

    public class ColorSwapFilter
    {
        private ColorSwapType swapType = ColorSwapType.ShiftRight;
        public ColorSwapType SwapType
        {
            get { return swapType; }
            set { swapType = value; }
        }

        private bool swapHalfColorValues = false;
        public bool SwapHalfColorValues
        {
            get { return swapHalfColorValues; }
            set { swapHalfColorValues = value; }
        }

        private bool invertColorsWhenSwapping = false;
        public bool InvertColorsWhenSwapping
        {
            get { return invertColorsWhenSwapping; }
            set { invertColorsWhenSwapping = value; }
        }

        public enum ColorSwapType
        {
            ShiftRight,
            ShiftLeft,
            SwapBlueAndRed,
            SwapBlueAndGreen,
            SwapRedAndGreen,
        }
    }
    public enum EdgeFilterType
    {
        None,
        EdgeDetectMono,
        EdgeDetectGradient,
        Sharpen,
        SharpenGradient,
    }

    public enum DerivativeLevel
    {
        First = 1,
        Second = 2
    }
}
       
