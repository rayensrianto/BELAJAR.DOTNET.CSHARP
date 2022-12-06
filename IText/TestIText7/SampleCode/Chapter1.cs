using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIText7.SampleCode
{
    public static class Chapter1
    {
        public static void Test()
        {
            string dest = "../../Result/Chapter1.pdf";

            var writer = new PdfWriter(dest);
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);
            document.Add(new Paragraph("Hello World!"));
            document.Close();
        }

        public static void Test2()
        {
            string dest = "../../Result/Chapter1.2.pdf";

            var writer = new PdfWriter(dest);
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);
            // Create a PdfFont
            var font = PdfFontFactory.CreateFont(iText.IO.Font.FontConstants.TIMES_ROMAN);
            // Add a Paragraph
            document.Add(new Paragraph("iText is:").SetFont(font));
            // Create a List
            List list = new List()
                .SetSymbolIndent(12)
                .SetListSymbol("u2022")
                .SetFont(font);
            // Add ListItem objects
            list.Add(new ListItem("Never gonna give you up"))
                .Add(new ListItem("Never gonna let you down"))
                .Add(new ListItem("Never gonna run around and desert you"))
                .Add(new ListItem("Never gonna make you cry"))
                .Add(new ListItem("Never gonna say goodbye"))
                .Add(new ListItem("Never gonna tell a lie and hurt you"));
            // Add the list
            document.Add(list);
            document.Close();
        }
    }
}
