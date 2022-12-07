using iText.IO.Util;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIText7.SampleCode;

namespace TestIText7
{
    class Program
    {
        public static readonly string SRC = "../../Template/hello.pdf";
        public static readonly string DEST = "../../Result/hellooutput.pdf";

        static void Main(string[] args)
        {
            Chapter1.Test();
            Chapter1.Test2();
            
            Chapter2.Test();

            Chapter3.Test();

            Chapter4.Test();

            //test replacing object
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();

            new Program().ManipulatePdf(DEST);
        }

        protected void ManipulatePdf(String dest)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(SRC), new PdfWriter(dest));
            PdfPage page = pdfDoc.GetFirstPage();
            PdfDictionary dict = page.GetPdfObject();

            PdfObject pdfObject = dict.Get(PdfName.Contents);
            if (pdfObject is PdfStream)
            {
                PdfStream stream = (PdfStream)pdfObject;
                byte[] data = stream.GetBytes();
                String replacedData4 = JavaUtil.GetStringForBytes(data).Replace("Hello", "ryaawefawefawefaw awefawefawefwaefn");
                stream.SetData((Encoding.UTF8.GetBytes(replacedData4)));
            }

            pdfDoc.Close();
        }
    }
}
