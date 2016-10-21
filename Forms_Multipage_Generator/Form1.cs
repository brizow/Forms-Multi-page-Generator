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
            int leftrightpos = AppSettings.Default.Left_Right_LabelPosition;
            int bottomtoppos = AppSettings.Default.Bottom_Top_LabelPosition;
            int linespacing = AppSettings.Default.Text_Spacing;

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
                        if (i == 0)
                        {
                            //first page get the address label
                            PdfPage pdfPage = pdf.AddPage();
                            pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                            XFont font = new XFont("helvetica narrow", 10); //XFontStyle.Bold
                            //page width in pixels: 792
                            //page height in pixels: 612
                            //0,0 top left, 792,612 bottom right 
                            graph.DrawString(title, font, XBrushes.Black, new Point(leftrightpos, bottomtoppos));
                            graph.DrawString(address, font, XBrushes.Black, new Point(leftrightpos, bottomtoppos + linespacing));
                            graph.DrawString(citystzip, font, XBrushes.Black, new Point(leftrightpos, bottomtoppos + linespacing + linespacing));
                        }
                        else
                        {
                            //create however many more "blank" pages
                            PdfPage pdfPage = pdf.AddPage();
                            pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
                            graph.DrawString("", font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
                        }
                    }
                    string pdfFilename = title;
                    pdf.Save(pdfFilename);
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
            settingsPanel.Show();
            //load any settings that were saved
            leftRightPosNum.Value = AppSettings.Default.Left_Right_LabelPosition;
            bottomTopPosNum.Value = AppSettings.Default.Bottom_Top_LabelPosition;
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
            AppSettings.Default.Left_Right_LabelPosition = Convert.ToInt32(leftRightPosNum.Value);
            AppSettings.Default.Bottom_Top_LabelPosition = Convert.ToInt32(bottomTopPosNum.Value);
            AppSettings.Default.Text_Spacing = Convert.ToInt32(textSpacingNum.Value);
            settingsPanel.Hide();
        }
        #endregion
    }
}

