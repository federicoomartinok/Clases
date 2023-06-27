using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Table = iText.Layout.Element.Table;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Borders;

namespace prueba_pfd_bd
{
    public class PruebaMain: DbHandler
    {
        static void Main(string[] args)
        {
            public void Page_Load(object sender, EventArgs e)
            {
                string dest = Server.MapPath("~/Files/table.pdf");
                GeneratePdf(dest);
            }

            public void GeneratePdf(string dest)
            {
                FileInfo file = new FileInfo(dest);
                file.Directory.Create();
                PdfDocument pdfDoc = new PdfDocument(new PdfWriter(dest));
                Document document = new Document(pdfDoc, new PageSize(595, 842));
                document.SetMargins(0, 0, 0, 0);
                float[] columnWidthsman = { 5, 5, 5, 5 };
                Table tableman = new Table(UnitValue.CreatePercentArray(columnWidthsman));
                PdfFont fman = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);


                //Probar la coneccion string
                string query = "SELECT TOP 10 ProductName 'fld3', QuantityPerUnit 'fld4', UnitPrice 'fld1'," +
                                " UnitsInStock 'fld2' FROM products ORDER BY fld3";
                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                Cell cellman = new Cell(1, 4)
                        .Add(new Paragraph("Header"))
                        .SetFont(fman)
                        .SetFontSize(13)
                        .SetFontColor(DeviceGray.WHITE)
                        .SetBackgroundColor(DeviceGray.BLACK)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetBorder(new SolidBorder(ColorConstants.GRAY, 2));
                // Add Header cell.
                tableman.AddHeaderCell(cellman);

                Cell cellGrado = new Cell(1, 1)
                            .Add(new Paragraph("Grado"))
                            .SetFont(fman)
                            .SetFontSize(13)
                            .SetFontColor(DeviceGray.BLACK)
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(new SolidBorder(ColorConstants.GRAY, 2));
                // Add cell 1.
                tableman.AddHeaderCell(cellGrado);

                Cell cellApellidoNombre = new Cell(1, 1)
                            .Add(new Paragraph("Apellido Nombre"))
                            .SetFont(fman)
                            .SetFontSize(13)
                            .SetFontColor(DeviceGray.BLACK)
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(new SolidBorder(ColorConstants.GRAY, 2));
                // Add cell 2.
                tableman.AddHeaderCell(cellApellidoNombre);

                Cell cellTitulo = new Cell(1, 1)
                            .Add(new Paragraph("Titulo (Apt Esp)"))
                            .SetFont(fman)
                            .SetFontSize(13)
                            .SetFontColor(DeviceGray.BLACK)
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(new SolidBorder(ColorConstants.GRAY, 2));
                // Add cell 3.
                tableman.AddHeaderCell(cellTitulo);

                Cell cellIAF = new Cell(1, 1)
                            .Add(new Paragraph("IAF"))
                            .SetFont(fman)
                            .SetFontSize(13)
                            .SetFontColor(DeviceGray.BLACK)
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(new SolidBorder(ColorConstants.GRAY, 2));
                // Add cell 4.
                tableman.AddHeaderCell(cellIAF);

                Cell cellDni = new Cell(1, 1)
                            .Add(new Paragraph("DNI"))
                            .SetFont(fman)
                            .SetFontSize(13)
                            .SetFontColor(DeviceGray.BLACK)
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(new SolidBorder(ColorConstants.GRAY, 2));
                // Add cell Dni.
                tableman.AddHeaderCell(cellDni);

                Cell cellDestino = new Cell(1, 1)
                            .Add(new Paragraph("DNI"))
                            .SetFont(fman)
                            .SetFontSize(13)
                            .SetFontColor(DeviceGray.BLACK)
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(new SolidBorder(ColorConstants.GRAY, 2));
                // Add cell Destino.
                tableman.AddHeaderCell(cellDestino);



                while (reader.Read())
                {
                    tableman.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).
                        Add(new Paragraph(Convert.ToInt32(reader["fld1"]).ToString("N0"))));
                    tableman.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).
                            Add(new Paragraph(Convert.ToInt32(reader["fld2"]).ToString("N0"))));
                    tableman.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).
                        Add(new Paragraph(reader["fld3"].ToString().Trim())));
                    tableman.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).
                        Add(new Paragraph(reader["fld4"].ToString().Trim())));
                }

                document.Add(tableman);
                document.Close();
                con.Close();
            }

        }

    }
}
