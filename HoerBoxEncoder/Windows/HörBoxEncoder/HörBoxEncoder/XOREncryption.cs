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

