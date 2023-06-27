using System;
using System.IO;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace iText.Samples.Sandbox.Tables
{
    public class ColumnWidthExample
    {
        public static readonly string DEST = @"C:\Users\fedmartin\Desktop\Proyect\tabla_pdf.pdf";

        public static void Main(String[] args)
        {
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();

            new ColumnWidthExample().ManipulatePdf(DEST);

        }

        private void ManipulatePdf(string dest)
        {
            DateTime thisDay = DateTime.Today;

            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(dest));
            Document doc = new Document(pdfDoc, PageSize.A4.Rotate());

            float[] columnWidths = { 1, 5, 5, 5 ,5, 5, 5};
            Table table = new Table(UnitValue.CreatePercentArray(columnWidths));
            Table tableDate = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth();


            PdfFont f = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Cell cell = new Cell(1, 7)
                .Add(new Paragraph("SISESCA"))
                .SetFont(f)
                .SetFontSize(13)
                .SetFontColor(DeviceGray.WHITE)
                .SetBackgroundColor(DeviceGray.BLACK)
                .SetTextAlignment(TextAlignment.CENTER);

            table.AddHeaderCell(cell).SetTextAlignment(TextAlignment.CENTER);

            tableDate.SetHorizontalAlignment(HorizontalAlignment.RIGHT);
            tableDate.SetWidth(150);

            //Cell cellDate = new Cell().Add(new Paragraph("Fecha").SetFontColor(ColorConstants.BLACK));
            //cellDate.SetBackgroundColor(ColorConstants.GRAY);
            //cellDate.SetBorder(new SolidBorder(ColorConstants.GRAY, 2));
            //tableDate.AddCell(cellDate).SetTextAlignment(TextAlignment.CENTER);

            Cell cellDate = new Cell().Add(new Paragraph("Fecha: " + thisDay.ToString("dd-MMMM-yyyy")));
            cellDate.SetTextAlignment(TextAlignment.CENTER);
            //cellTwo.SetBorder(new SolidBorder(2));
            tableDate.AddCell(cellDate);


            for (int i = 0; i < 1; i++)
            {
                Cell[] headerFooter =
                {
                    new Cell().SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Nro")),
                    new Cell().SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Grado")),
                    new Cell().SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Apellido")),
                    new Cell().SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Nombre")),
                    new Cell().SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("IAF")),
                    new Cell().SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("DNI")),
                    new Cell().SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Destino"))

                };
                

                foreach (Cell hfCell in headerFooter)
                {
                    if (i == 0)
                    {
                        table.AddHeaderCell(hfCell);
                    }
                    else
                    {
                        table.AddFooterCell(hfCell);
                    }
                }
            }

            for (int counter = 0; counter < 50; counter++)
            {
                table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph((counter + 1).ToString())));
                table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Grado ")));
                table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Apellido " )));
                table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Nombre ")));
                table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("IAF ")));
                table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("DNI ")));
                table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Destino ")));

            }


            doc.Add(tableDate);
            doc.Add(table);

            doc.Close();
        }
    }
}