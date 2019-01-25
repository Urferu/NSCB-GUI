using System;
using System.ComponentModel;
using System.IO;

namespace NSCB_GUI
{
    class XCICutter
    {
        public static void cutter(string inPath)
        {
            decimal partes = 0;
            long cutterSize = 4294934528;
            Stream srOriginal;
            DirectoryInfo info = new DirectoryInfo(inPath);
            FileInfo[] files = info.GetFiles("*.xci");

            foreach (FileInfo fiOriginal in files)
            {
                srOriginal = new FileStream(fiOriginal.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
                if (fiOriginal.Length > cutterSize)
                {
                    FormCortando formCortando = new FormCortando(srOriginal, fiOriginal, cutterSize);
                    formCortando.ShowDialog();
                }
            }
        }

        public static void cutterParts(XCIFile archivoXCI, BackgroundWorker bwCutter)
        {
            Stream srDestino;
            for (int indice = 0; indice < archivoXCI.partesACortar; indice++)
            {
                if (archivoXCI.cutterActual > 0)
                {
                    srDestino = new FileStream(archivoXCI.nombreConRuta.Replace(".xci", "-cut.xc") + indice, FileMode.CreateNew, FileAccess.Write, FileShare.Write);
                    writePartCutter(archivoXCI, srDestino);
                    if (archivoXCI.tamanioArchivo - archivoXCI.totalBytes < archivoXCI.cutterActual)
                    {
                        archivoXCI.cutterActual = archivoXCI.tamanioArchivo - archivoXCI.totalBytes;
                    }
                }
                bwCutter.ReportProgress(indice + 1);
            }
            archivoXCI.Close();
        }

        private static void writePartCutter(XCIFile archivoXCI, Stream srDestino)
        {
            byte[] buffer = new byte[256];
            int leidos = 0;
            for (archivoXCI.bytesLeidos = 0; archivoXCI.bytesLeidos < archivoXCI.cutterActual; archivoXCI.bytesLeidos += leidos)
            {
                leidos = archivoXCI.LeerBytes(ref buffer);
                if(leidos < 256)
                {
                    Array.Resize<byte>(ref buffer, leidos);
                }
                srDestino.Write(buffer, 0, buffer.Length);
                archivoXCI.totalBytes += leidos;
            }
            srDestino.Close();
        }
    }
}
