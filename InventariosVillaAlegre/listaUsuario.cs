﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosVillaAlegre
{
    public partial class listaUsuario : Form
    {
        public listaUsuario()
        {
            InitializeComponent();
        }

        private void listaUsuario_Load(object sender, EventArgs e)
        {
            metodosSQL m = new metodosSQL();
            DataSet resultados=m.busqueda("usuarios", "nombre, usuario, tipo_usuario, correo", null);
                usuarios.DataSource = resultados.Tables[0];
                usuarios.Columns[0].HeaderText = "Nombre";
                usuarios.Columns[1].HeaderText = "Usuario";
                usuarios.Columns[2].HeaderText = "Tipo de usuario";
                usuarios.Columns[3].HeaderText = "Correo";
        }

        private void archivo_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4, 9, 9, 10, 10);
                string ruta = @".../.../resources/";
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string formato = "temp.pdf";
                string filename = Path.Combine(ruta + formato);
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@".../.../resources/logo.png");
                jpg.Alignment = Element.ALIGN_CENTER;
                jpg.ScaleAbsolute(150f, 46f);
                Chunk encab = new Chunk(" Lista de usuarios\n "+fecha+"\n", FontFactory.GetFont("TIMES_ROMAN", 12));
                try
                {
                    FileStream file = new FileStream
                    (filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, file);
                    doc.Open();

                    doc.Add(new Paragraph(encab));
                    doc.Add(jpg);

                    PdfPTable tabla = generarTabla();
                    doc.Add(tabla);
                    doc.Add(new Paragraph("\n\n"));
                    generarDocumento(doc);
                    ////PARRAFO
                    //Paragraph unParrafo = GenerarParrafo3();
                    //doc.Add(unParrafo);
                    Process.Start(filename);
                    doc.Close();
                    MessageBox.Show("Archivo temporal generado . Guardar en el lugar deseado");
                    doc.Open();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear PDF", "Sistema Gamers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                }
            }
        public PdfPTable generarTabla()
        {
            PdfPTable unaTabla = new PdfPTable(2);
            unaTabla.SetWidthPercentage(new float[] { 300, 300 }, PageSize.A4);
            //Headers
            unaTabla.AddCell(new Paragraph("Nombre"));
            unaTabla.AddCell(new Paragraph("Usuario"));
            unaTabla.AddCell(new Paragraph("Tipo de usuario"));
            unaTabla.AddCell(new Paragraph("Correo"));

            //¿Le damos un poco de formato?
            foreach (PdfPCell celda in unaTabla.Rows[0].GetCells())
            {
                celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                celda.HorizontalAlignment = 1;
                celda.Padding = 3;
            }
            return unaTabla;
        }
        public void generarDocumento(Document document)
        {
            PdfPTable datatable = new PdfPTable(usuarios.ColumnCount);
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(usuarios);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);

            DataGridViewCellStyle style = this.usuarios.ColumnHeadersDefaultCellStyle;

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            for (int i = 0; i < usuarios.ColumnCount; i++)
            {

                objP = new Phrase(usuarios.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;
                datatable.AddCell(objP);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;

            for (int i = 0; i < usuarios.RowCount - 1; i++)
            {
                for (int j = 0; j < usuarios.ColumnCount; j++)
                {
                    objP = new Phrase(usuarios[j, i].Value.ToString(), fuente);
                    style.BackColor = Color.WhiteSmoke;
                    style.ForeColor = Color.Gray;
                    //cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas(DataGridView dg)
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

