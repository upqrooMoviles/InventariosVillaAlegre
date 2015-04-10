using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosVillaAlegre.Clases_auxiliares
{
    class generarPDF
    {
        public static Boolean TablaPDF(DataGridView datos, string nombreArchivo, string ruta, string encabezado, string []encabezados) {
            DateTime hora = DateTime.Now;
            string fcha_ttal = Convert.ToDateTime(hora).Day + "/" + Convert.ToDateTime(hora).Month + "/" + Convert.ToDateTime(hora).Year;
            Document doc = new Document(PageSize.A4, 9, 9, 10, 10);
            string guion = "-";
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string formato = ".pdf";
            string filename = Path.Combine(ruta + guion + nombreArchivo + fecha + formato);
            valores.rutapdf = ruta + guion + nombreArchivo + fecha + formato;
            valores.nombrepdf = nombreArchivo + fecha + formato;
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@".../.../resources/logo.png");
            jpg.Alignment = Element.ALIGN_CENTER;
            jpg.ScaleAbsolute(300f, 43f);

            Chunk encab = new Chunk(encabezado+"\n " + fecha + "\n", FontFactory.GetFont("TIMES_ROMAN", 12));
            try
            {
                FileStream file = new FileStream
                (filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();

                doc.Add(new Paragraph(encab));
                doc.Add(jpg);

                PdfPTable tabla = generarTabla(encabezados);
                doc.Add(tabla);
                doc.Add(new Paragraph("\n\n"));
                generarDocumento(doc, datos);
                Process.Start(filename);
                doc.Close();
                MessageBox.Show("Archivo PDF Generado");
                //doc.Open();
                return true;
            }
            catch 
            {
                MessageBox.Show("Error al crear PDF. Intente de nuevo o contacte a su proovedor de software.", "Sistema Villa Alegre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public static PdfPTable generarTabla(string [] encabezados)
        {
            PdfPTable unaTabla = new PdfPTable(2);
            unaTabla.SetWidthPercentage(new float[] { 300, 300 }, PageSize.A4);
            //Headers
            for (int i = 0; i < encabezados.Length; i++)
            {
                unaTabla.AddCell(new Paragraph(encabezados[i]));
            }

            //¿Le damos un poco de formato?
            foreach (PdfPCell celda in unaTabla.Rows[0].GetCells())
            {
                celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                celda.HorizontalAlignment = 1;
                celda.Padding = 3;
            }
            return unaTabla;
        }
        public static void generarDocumento(Document document, DataGridView datos)
        {
            PdfPTable datatable = new PdfPTable(datos.ColumnCount);
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(datos);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);

            DataGridViewCellStyle style = datos.ColumnHeadersDefaultCellStyle;

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            for (int i = 0; i < datos.ColumnCount; i++)
            {

                objP = new Phrase(datos.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;
                datatable.AddCell(objP);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;

            for (int i = 0; i < datos.RowCount - 1; i++)
            {
                for (int j = 0; j < datos.ColumnCount; j++)
                {
                    objP = new Phrase(datos[j, i].Value.ToString(), fuente);
                    style.BackColor = Color.WhiteSmoke;
                    style.ForeColor = Color.Gray;
                    //cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        public static float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

    }
}
