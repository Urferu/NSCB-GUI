using System;
using System.IO;

namespace NSCB_GUI
{
    /*public partial class XCIFile
    {
        private FileStream InfileStream;
        private FileStream OutfileStream;
        private UInt64 pDataSize, pCartSize, pRealfileSize;
        private string pInPath, pOutPath;
        private bool pFileOK = true;
        internal readonly UInt32 ChunkSize = Convert.ToUInt32(Math.Pow(2, 32) - 32 * 1024);
        private byte pChunkCount;
        internal BinaryReader br;
        internal BinaryWriter bw;

        public bool FileOK
        {
            get
            {
                return pFileOK;
            }
        }
        public string OutPath
        {
            get
            {
                return pOutPath;
            }
            set
            {
                pOutPath = value;
                OutfileStream = new FileStream(pOutPath, FileMode.Create, FileAccess.Write, FileShare.Write);
                bw = new BinaryWriter(OutfileStream);
            }
        }
        public string InPath
        {
            get
            {
                return pInPath;
            }
            set
            {
                pInPath = value;
                InfileStream = new FileStream(pInPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                br = new BinaryReader(InfileStream);
            }
        }
        public long InPos
        {
            get
            {
                return InfileStream.Position;
            }
            set
            {
                InfileStream.Position = value;
            }
        }
        public long OutPos
        {
            get
            {
                return OutfileStream.Position;
            }
            set
            {
                OutfileStream.Position = value;
            }
        }
        public UInt64 DataSize
        {
            get
            {
                return pDataSize;
            }
        }
        public UInt64 CartSize
        {
            get
            {
                return pCartSize * 1048576; // Return CartSize in Bytes
            }
        }
        public UInt64 RealFileSize
        {
            get
            {
                return pRealfileSize;
            }
        }
        public byte ChunkCount
        {
            get
            {
                return pChunkCount;
            }
        }

        internal void OpenReaders()
        {
            // True if reader wasn't initiated at all, or if it was closed
            if (Information.IsNothing(br) || Information.IsNothing(br.BaseStream))
            {
                InfileStream = new FileStream(pInPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                br = new BinaryReader(InfileStream);
            }
            // only open writer if a destination-file was set
            if (pOutPath != null)
            {
                if (Information.IsNothing(bw) || Information.IsNothing(bw.BaseStream))
                {
                    OutfileStream = new FileStream(pOutPath, FileMode.Create, FileAccess.Write, FileShare.Write);
                    bw = new BinaryWriter(OutfileStream);
                }
            }
        }

        internal void CloseReaders()
        {
            if (!Information.IsNothing(br) && !Information.IsNothing(br.BaseStream))
                br.Close();
            if (!Information.IsNothing(bw) && !Information.IsNothing(bw.BaseStream))
                bw.Close();
            // run garbage collector to free resources/unlock files
            GC.Collect();
        }

        public XCIFile(string InPath, string OutPath = null)
        {
            pInPath = InPath;
            pOutPath = OutPath;
            ReadSizes();
        }

        private void ReadSizes()
        {
            try
            {
                OpenReaders();
                InfileStream.Position = 269;
                switch (br.ReadByte())
                {
                    case 248:
                        {
                            pCartSize = 1904;
                            break;
                        }

                    case 240:
                        {
                            pCartSize = 3808;
                            break;
                        }

                    case 224:
                        {
                            pCartSize = 7616;
                            break;
                        }

                    case 225:
                        {
                            pCartSize = 15232;
                            break;
                        }

                    case 226:
                        {
                            pCartSize = 30464;
                            break;
                        }

                    default:
                        {
                            if (IsNothing(frmXCIcutter.BatchForm))
                                MessageBox.Show("The source file doesn't look like an XCI file", "Can't determine cartridge size!");
                            pFileOK = false;
                            return;
                        }
                }
                InfileStream.Position = 280;
                pDataSize = 512 + (BitConverter.ToUInt32(br.ReadBytes(4), 0) * 512);
                pChunkCount = pDataSize / ChunkSize + 1;
                pRealfileSize = InfileStream.Length;
                if (InPath.EndsWith(".xc0"))
                {
                    for (byte n = 1; n <= ChunkCount - 1; n++)
                    {
                        try
                        {
                            pRealfileSize = pRealfileSize + FileSystem.FileLen(InPath.TrimEnd(0.ToString()) + n.ToString());
                        }
                        catch (Exception ex)
                        {
                            if (IsNothing(frmXCIcutter.BatchForm))
                                MessageBox.Show(ex.Message);
                            if (IsNothing(frmXCIcutter.BatchForm))
                                MessageBox.Show("Make sure that all parts of the dump are accessible.", "Dump incomplete!");
                            pFileOK = false;
                        }
                    }
                }
                else
                {
                }
                if (pRealfileSize < 32 * 1024)
                {
                    if (IsNothing(frmXCIcutter.BatchForm))
                        MessageBox.Show("The source file doesn't look like an XCI file", "File to small!");
                    pFileOK = false;
                    return;
                }
                CloseReaders();
            }
            catch (Exception ex)
            {
                if (IsNothing(frmXCIcutter.BatchForm))
                    MessageBox.Show(ex.Message);
                pFileOK = false;
                pDataSize = 0;
                pCartSize = 0;
                pRealfileSize = 0;
                pChunkCount = 0;
            }
        }
    }*/
}
