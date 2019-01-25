using System.IO;
using System;

namespace NSCB_GUI
{
    class XCIFile
    {
        public bool cancelar;
        Stream srOriginal;
        FileInfo fiOriginal;
        long splitSize;
        long splitNow;
        long bytesLeidosTotales;
        long bytesDeParte;
        decimal totalPartes;

        public string nombreConRuta
        {
            get
            {
                return fiOriginal.FullName;
            }
        }

        public string soloNombre
        {
            get
            {
                return fiOriginal.Name;
            }
        }

        public long tamanioArchivo
        {
            get
            {
                return fiOriginal.Length;
            }
        }

        public long cutterSize
        {
            get
            {
                return splitSize;
            }
        }

        public long cutterActual
        {
            get
            {
                return splitNow;
            }
            set
            {
                splitNow = value;
            }
        }

        public int partesACortar
        {
            get
            {
                return Convert.ToInt32(totalPartes);
            }
        }

        public long totalBytes
        {
            get
            {
                return bytesLeidosTotales;
            }
            set
            {
                bytesLeidosTotales = value;
            }
        }

        public int progresoActual
        {
            get
            {
                int valueCalis = splitNow > 0 ? Convert.ToInt32((Convert.ToDecimal(bytesDeParte) / Convert.ToDecimal(splitNow)) * 100) : 0;
                return valueCalis;
            }
        }

        public long bytesLeidos
        {
            get
            {
                return bytesDeParte;
            }
            set
            {
                bytesDeParte = value;
            }
        }

        public XCIFile(Stream archivoOriginal, FileInfo infoOriginal, long cutterSize)
        {
            cancelar = false;
            srOriginal = archivoOriginal;
            fiOriginal = infoOriginal;
            splitSize = cutterSize;
            splitNow = cutterSize;
            bytesDeParte = 0;
            bytesLeidosTotales = 0;
            totalPartes = Math.Ceiling(Convert.ToDecimal(fiOriginal.Length) / Convert.ToDecimal(cutterSize));
        }

        public void Close()
        {
            srOriginal.Close();
        }

        public int LeerBytes(ref byte[] buffer)
        {
            return srOriginal.Read(buffer, 0, buffer.Length);
        }
    }
}
