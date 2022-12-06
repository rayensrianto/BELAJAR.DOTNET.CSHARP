using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestIText7.SampleCode
{
    public static class Chapter3
    {
        static readonly string INST_IMG = "../../Template/Image1.PNG";
        static readonly string INST_TXT = "../../Template/INST_TXT.txt";
        static readonly string timesNewRoman = "Times New Roman"; 

        public static void Test()
        {
            string dest = "../../Result/Chapter3.pdf";
            //Initialize PDF document
            PdfDocument pdf = new PdfDocument(new PdfWriter(dest));
            PageSize ps = PageSize.A5;

            // Initialize document
            Document document = new Document(pdf, ps);

            //Set column parameters
            float offSet = 36;
            float columnWidth = (ps.GetWidth() - offSet * 2 + 10) / 3;
            float columnHeight = ps.GetHeight() - offSet * 2;

            //Define column areas
            Rectangle[] columns = new Rectangle[] {
                new Rectangle(offSet - 5, offSet, columnWidth, columnHeight),
                new Rectangle(offSet + columnWidth, offSet, columnWidth, columnHeight),
                new Rectangle(offSet + columnWidth * 2 + 5, offSet, columnWidth, columnHeight)
            };
            document.SetRenderer(new ColumnDocumentRenderer(document, columns));

            // adding content
            iText.Layout.Element.Image inst = new iText.Layout.Element.Image(ImageDataFactory.Create(INST_IMG)).SetWidth(columnWidth);
            String articleInstagram = File.ReadAllText(System.IO.Path.Combine(INST_TXT), Encoding.UTF8);
            Chapter3.AddArticle(document, "Instagram May Change Your Feed, Personalizing It With an Algorithm"
                            , "By MIKE ISAAC MARCH 15, 2016", inst, articleInstagram);
            document.Close();
        }

        public static void AddArticle(Document doc, String title, String author, iText.Layout.Element.Image img, String text)
        {
            Paragraph p1 = new Paragraph(title).SetFontSize(14);
            doc.Add(p1);
            doc.Add(img);
            Paragraph p2 = new Paragraph().Add(author);
            doc.Add(p2);
            Paragraph p3 = new Paragraph().SetFontSize(10).Add(text);
            doc.Add(p3);
        }
    }
}
