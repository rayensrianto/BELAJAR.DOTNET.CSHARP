using iText.IO.Util;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIText7.SampleCode
{
    public class ReplaceStream
    {
        public static readonly String DEST = "../../Template/Template.pdf";
        public static readonly String SRC = "../../Result/Chapter4-1.pdf";

        public static void Test()
        {
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();

            new ReplaceStream().ManipulatePdf(DEST);
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
                String replacedData = JavaUtil.GetStringForBytes(data).Replace("nama", "Ryan");
                stream.SetData((Encoding.UTF8.GetBytes(replacedData)));
            }

            pdfDoc.Close();
        }
    }
}
