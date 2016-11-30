using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Multipage_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            leftRightPosNumA.Value = AppSettings.Default.Left_Right_LabelPositionA;
            bottomTopPosNumA.Value = AppSettings.Default.Bottom_Top_LabelPositionA;
            leftRightPosNumB.Value = AppSettings.Default.Left_Right_LabelPositionB;
            bottomTopPosNumB.Value = AppSettings.Default.Bottom_Top_LabelPositionB;
            textSpacingNum.Value = AppSettings.Default.Text_Spacing;
        }

        #region createPDF
        private void createPDFBtn_Click(object sender, EventArgs e)
        {
            int numberofpages = 0;
            string customerID = custIDTextBox.Text;
            string title = titleTextBox.Text;
            string address = addressTextBox.Text;
            string citystzip = cityStZipTextBox.Text;
            int leftrightposA = Convert.ToInt32(leftRightPosNumA.Value);
            int bottomtopposA = Convert.ToInt32(bottomTopPosNumA.Value);
            int linespacing = Convert.ToInt32(textSpacingNum.Value);
            int leftrightposB = Convert.ToInt32(leftRightPosNumB.Value);
            int bottomtopposB = Convert.ToInt32(bottomTopPosNumB.Value);
            //get blank pages
            string[] blankPagesArray = pageBlanksTextBox.Text.Split(new Char[] { ',' });

            if (numOPgsTextBox.Text != "")
            {
                try
                {
                    numberofpages = Convert.ToInt32(numOPgsTextBox.Text);
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = title;

                    //create however many pages we ask
                    for (int i = 1; i <= numberofpages; i++)
                    {
                        foreach (var b in blankPagesArray)
                        {
                            if (i == Convert.ToInt32(b))
                            {
                                //increment i because we added a blank page.
                                i++;
                                //create however many more "blank" pages
                                PdfPage pdfPage = pdf.AddPage();
                                pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                                XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
                                graph.DrawString("", font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
                            }
                        }

                        //even pages - Template A
                        if (i % 2 == 0)
                        {
                            //first page get the address label
                            PdfPage pdfPage = pdf.AddPage();
                            pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                            XFont font = new XFont("helvetica narrow", 10); //XFontStyle.Bold
                            //page width in pixels: 792
                            //page height in pixels: 612
                            //0,0 top left, 792,612 bottom right 
                            graph.DrawString(customerID, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA));
                            graph.DrawString(title, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA + linespacing));
                            graph.DrawString(address, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA + linespacing + linespacing));
                            graph.DrawString(citystzip, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA + linespacing + linespacing + linespacing));
                        }
                        //odd pages - Template B
                        if (i % 2 == 1)
                        {
                            //first page get the address label
                            PdfPage pdfPage = pdf.AddPage();
                            pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                            XFont font = new XFont("helvetica narrow", 10); //XFontStyle.Bold
                            //page width in pixels: 792
                            //page height in pixels: 612
                            //0,0 top left, 792,612 bottom right 
                            graph.DrawString(customerID, font, XBrushes.Black, new Point(leftrightposB, bottomtopposB));
                            graph.DrawString(title, font, XBrushes.Black, new Point(leftrightposB, bottomtopposB + linespacing));
                            graph.DrawString(address, font, XBrushes.Black, new Point(leftrightposB, bottomtopposB + linespacing + linespacing));
                            graph.DrawString(citystzip, font, XBrushes.Black, new Point(leftrightposB, bottomtopposB + linespacing + linespacing + linespacing));
                        }
                    }

                    //save method
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Title = "Save File";
                    saveFileDialog1.FileName = title;
                    saveFileDialog1.CheckFileExists = false;
                    saveFileDialog1.CheckPathExists = true;
                    saveFileDialog1.DefaultExt = "pdf";
                    saveFileDialog1.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 1;
                    saveFileDialog1.RestoreDirectory = true;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pdf.Save(saveFileDialog1.FileName);
                        //open the saved file
                        Process.Start(saveFileDialog1.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter the number of pages.");
            }
        }
        #endregion

        #region toolbar
        //toolbar items
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region settings
        private void saveSetBtn_Click(object sender, EventArgs e)
        {
            //save the settings back to AppSettings
            AppSettings.Default.Left_Right_LabelPositionA = Convert.ToInt32(leftRightPosNumA.Value);
            AppSettings.Default.Bottom_Top_LabelPositionA = Convert.ToInt32(bottomTopPosNumA.Value);
            AppSettings.Default.Left_Right_LabelPositionB = Convert.ToInt32(leftRightPosNumB.Value);
            AppSettings.Default.Bottom_Top_LabelPositionB = Convert.ToInt32(bottomTopPosNumB.Value);
            AppSettings.Default.Text_Spacing = Convert.ToInt32(textSpacingNum.Value);
            MessageBox.Show("App settings have been saved.");
        }
        #endregion
    }
}

