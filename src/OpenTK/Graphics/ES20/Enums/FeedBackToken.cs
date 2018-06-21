//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FeedBackToken
    {
        /// <summary>
        /// Original was GL_PASS_THROUGH_TOKEN = 0x0700
        /// </summary>
        PassThroughToken = 0x0700,

        /// <summary>
        /// Original was GL_POINT_TOKEN = 0x0701
        /// </summary>
        PointToken = 0x0701,

        /// <summary>
        /// Original was GL_LINE_TOKEN = 0x0702
        /// </summary>
        LineToken = 0x0702,

        /// <summary>
        /// Original was GL_POLYGON_TOKEN = 0x0703
        /// </summary>
        PolygonToken = 0x0703,

        /// <summary>
        /// Original was GL_BITMAP_TOKEN = 0x0704
        /// </summary>
        BitmapToken = 0x0704,

        /// <summary>
        /// Original was GL_DRAW_PIXEL_TOKEN = 0x0705
        /// </summary>
        DrawPixelToken = 0x0705,

        /// <summary>
        /// Original was GL_COPY_PIXEL_TOKEN = 0x0706
        /// </summary>
        CopyPixelToken = 0x0706,

        /// <summary>
        /// Original was GL_LINE_RESET_TOKEN = 0x0707
        /// </summary>
        LineResetToken = 0x0707
    }
}