using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Annot;
using iText.Layout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIText7.SampleCode
{
    public static class Chapter4
    {
        public static void Test()
        {
            string src = "../../Template/blank.pdf";
            string dest = "../../Result/Chapter4.pdf";


            PdfDocument pdf = new PdfDocument(new PdfReader(src), new PdfWriter(dest));
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdf, true);

            //Create text field
            PdfTextFormField nameField = PdfTextFormField.CreateText(pdf, new Rectangle(99, 753, 425, 15), "name", "");
            form.AddField(nameField);

            PdfTextFormField officeField = PdfTextFormField.CreateText(pdf, new Rectangle(10, 10, 425, 15), "office", "");
            form.AddField(officeField);

            PdfFormField toSet;

            IDictionary<String, PdfFormField> fields = form.GetFormFields();
            fields.TryGetValue("name", out toSet);
            toSet.SetValue("Ryan sssssssssssss");
            fields.TryGetValue("office", out toSet);
            toSet.SetValue("Indocyber - AXA aaaaaaaaaaaaa");
            form.FlattenFields();
            pdf.Close();
        }
    }
}
