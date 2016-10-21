using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberofpages = 0;
            string title = titleTextBox.Text;
            string address = addressTextBox.Text;
            string citystzip = cityStZipTextBox.Text;
            int leftrightposA = AppSettings.Default.Left_Right_LabelPositionA;
            int bottomtopposA = AppSettings.Default.Bottom_Top_LabelPositionA;
            int linespacing = AppSettings.Default.Text_Spacing;
            int leftrightposB = AppSettings.Default.Left_Right_LabelPositionB;
            int bottomtopposB = AppSettings.Default.Bottom_Top_LabelPositionB;

            if (numOPgsTextBox.Text != "")
            {
                try
                {
                    numberofpages = Convert.ToInt32(numOPgsTextBox.Text);
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = title;

                    //create however many pages we ask
                    for (int i = 0; i < numberofpages; i++)
                    {
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
                            graph.DrawString(title, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA));
                            graph.DrawString(address, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA + linespacing));
                            graph.DrawString(citystzip, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA + linespacing + linespacing));
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
                            graph.DrawString(title, font, XBrushes.Black, new Point(leftrightposB, bottomtopposB));
                            graph.DrawString(address, font, XBrushes.Black, new Point(leftrightposB, bottomtopposB + linespacing));
                            graph.DrawString(citystzip, font, XBrushes.Black, new Point(leftrightposB, bottomtopposB + linespacing + linespacing));
                        }
                        //Now I need to account for the blank pages....
                        //else
                        //{
                        //    //create however many more "blank" pages
                        //    PdfPage pdfPage = pdf.AddPage();
                        //    pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                        //    XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                        //    XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
                        //    graph.DrawString("", font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
                        //}
                    }
                    string pdfFilename = title + ".pdf";
                    pdf.Save(pdfFilename);
                    //opening the saved file
                    Process.Start(pdfFilename);
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


        #region toolbar
        //toolbar items

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            settingsPanel.Show();
            //load any settings that were saved
            leftRightPosNumA.Value = AppSettings.Default.Left_Right_LabelPositionA;
            bottomTopPosNumA.Value = AppSettings.Default.Bottom_Top_LabelPositionA;
            leftRightPosNumB.Value = AppSettings.Default.Left_Right_LabelPositionB;
            bottomTopPosNumB.Value = AppSettings.Default.Bottom_Top_LabelPositionB;
            textSpacingNum.Value = AppSettings.Default.Text_Spacing;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region settings
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //save the settings back to AppSettings
            AppSettings.Default.Left_Right_LabelPositionA = Convert.ToInt32(leftRightPosNumA.Value);
            AppSettings.Default.Bottom_Top_LabelPositionA = Convert.ToInt32(bottomTopPosNumA.Value);
            AppSettings.Default.Left_Right_LabelPositionB = Convert.ToInt32(leftRightPosNumB.Value);
            AppSettings.Default.Bottom_Top_LabelPositionB = Convert.ToInt32(bottomTopPosNumB.Value);
            AppSettings.Default.Text_Spacing = Convert.ToInt32(textSpacingNum.Value);
            settingsPanel.Hide();
            panel1.Show();
        }
        #endregion
    }
}

