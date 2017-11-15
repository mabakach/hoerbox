/*  License

All files are licensed under the MIT license.
The MIT License (MIT)

Copyright (c) 2017 Marc Baumgartner

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
associated documentation files (the "Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies 
of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS
OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*/

using System;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace HörBoxEncoder
{
    /// <summary>
    /// Class to 'encrypt' or 'decrypt' a file using XOR. This class supports only one byte long keys.
    /// </summary>
    public class XOREncryption
    {
        private byte key;
        public XOREncryption(byte key)
        {
            this.key = key;
        }

        public void EncryptFile(String inputFilePath, String outputFilePath)
        {
            if (File.Exists(inputFilePath))
            {
                MemoryMappedFile memoryMappedInputFile = null;
                Stream inputStream = null;
                FileStream outputStream = null;
                try
                {
                    memoryMappedInputFile = MemoryMappedFile.CreateFromFile(inputFilePath);
                    inputStream = memoryMappedInputFile.CreateViewStream();

                    outputStream = File.Create(outputFilePath);

                    int count;
                    byte[] inputByteBuffer = new byte[4096];

                    long remainingLength = new FileInfo(inputFilePath).Length;
                    int bytesToRead = inputByteBuffer.Length < remainingLength ? inputByteBuffer.Length : (int)remainingLength;
                    while ((count = inputStream.Read(inputByteBuffer, 0, bytesToRead)) > 0)
                    { 
                        byte[] outputByteBuffer = new byte[count];
                        for (int i = 0; i < count; i++)
                        {
                            outputByteBuffer[i] = (byte)(inputByteBuffer[i] ^ key);
                        }
                        outputStream.Write(outputByteBuffer, 0, count);

                        remainingLength = remainingLength - count;
                        bytesToRead = inputByteBuffer.Length < remainingLength ? inputByteBuffer.Length : (int)remainingLength;
                    }
                }
                finally
                {
                    if (inputStream != null)
                    {
                        inputStream.Close();
                    }
                    if (memoryMappedInputFile != null)
                    {
                        memoryMappedInputFile.Dispose();
                    }
                    if (outputStream != null)
                    {
                        outputStream.Close();
                    }
                }
            }
        }
    }
}

