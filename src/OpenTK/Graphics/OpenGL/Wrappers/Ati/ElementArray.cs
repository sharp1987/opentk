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
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "ElementArray" in the extension "Ati".
        /// </summary>
        public static partial class Ati
        {
            /// <summary>
            /// [requires: ATI_element_array]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            [AutoGenerated(Category = "ATI_element_array", Version = "", EntryPoint = "glDrawElementArrayATI")]
            public static void DrawElementArray(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ATI_element_array]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="end">
            /// </param>
            /// <param name="count">
            /// </param>
            [AutoGenerated(Category = "ATI_element_array", Version = "", EntryPoint = "glDrawRangeElementArrayATI")]
            public static void DrawRangeElementArray(OpenTK.Graphics.OpenGL.PrimitiveType mode, uint start, uint end, int count)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ATI_element_array]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="pointer">
            /// [length: COMPSIZE(type)]
            /// </param>
            [AutoGenerated(Category = "ATI_element_array", Version = "", EntryPoint = "glElementPointerATI")]
            public static void ElementPointer(OpenTK.Graphics.OpenGL.AtiElementArray type, [CountAttribute(Computed = "type")] IntPtr pointer)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ATI_element_array]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="pointer">
            /// [length: COMPSIZE(type)]
            /// </param>
            [AutoGenerated(Category = "ATI_element_array", Version = "", EntryPoint = "glElementPointerATI")]
            public static void ElementPointer<T1>(OpenTK.Graphics.OpenGL.AtiElementArray type, [InAttribute, OutAttribute, CountAttribute(Computed = "type")] T1[] pointer)
                where T1 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ATI_element_array]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="pointer">
            /// [length: COMPSIZE(type)]
            /// </param>
            [AutoGenerated(Category = "ATI_element_array", Version = "", EntryPoint = "glElementPointerATI")]
            public static void ElementPointer<T1>(OpenTK.Graphics.OpenGL.AtiElementArray type, [InAttribute, OutAttribute, CountAttribute(Computed = "type")] T1[,] pointer)
                where T1 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ATI_element_array]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="pointer">
            /// [length: COMPSIZE(type)]
            /// </param>
            [AutoGenerated(Category = "ATI_element_array", Version = "", EntryPoint = "glElementPointerATI")]
            public static void ElementPointer<T1>(OpenTK.Graphics.OpenGL.AtiElementArray type, [InAttribute, OutAttribute, CountAttribute(Computed = "type")] T1[,,] pointer)
                where T1 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ATI_element_array]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="pointer">
            /// [length: COMPSIZE(type)]
            /// </param>
            [AutoGenerated(Category = "ATI_element_array", Version = "", EntryPoint = "glElementPointerATI")]
            public static void ElementPointer<T1>(OpenTK.Graphics.OpenGL.AtiElementArray type, [InAttribute, OutAttribute, CountAttribute(Computed = "type")] ref T1 pointer)
                where T1 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(490)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawElementArrayATI(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count);

            [Slot(503)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawRangeElementArrayATI(OpenTK.Graphics.OpenGL.PrimitiveType mode, uint start, uint end, int count);

            [Slot(521)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glElementPointerATI(OpenTK.Graphics.OpenGL.AtiElementArray type, [CountAttribute(Computed = "type")] IntPtr pointer);
        }
    }
}