using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Forms_Multipage_Generator
{
    public partial class Form1 : Form
    {
        //global vars
        string[] blankPagesArray = null;
        PdfDocument pdf = new PdfDocument();

        public Form1()
        {
            InitializeComponent();

            leftRightPosNumA.Value = Properties.Settings.Default.Left_Right_LabelPositionA;
            bottomTopPosNumA.Value = Properties.Settings.Default.Bottom_Top_LabelPositionA;
            leftRightPosNumB.Value = Properties.Settings.Default.Left_Right_LabelPositionB;
            bottomTopPosNumB.Value = Properties.Settings.Default.Bottom_Top_LabelPositionB;
            textSpacingNum.Value = Properties.Settings.Default.Text_Spacing;
        }

        #region functions
        private void pageBlanksTextBox_Enter(object sender, EventArgs e)
        {
            pageBlanksTextBox.Clear();
        }

        //only accept commas and numbers
        private void pageBlanksTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region createPDF
        private void createPDFBtn_Click(object sender, EventArgs e)
        {
            //init variables
            blankPagesArray = null;
            pdf = new PdfDocument();
            int numberofpages = Convert.ToInt32(numOPgsTextBox.Text);
            string customerID = "." + custIDTextBox.Text;
            //add period to front
            string title = titleTextBox.Text;
            string address = addressTextBox.Text;
            string address2 = address2TextBox.Text;
            string citystzip = cityStZipTextBox.Text;
            int leftrightposA = Convert.ToInt32(leftRightPosNumA.Value);
            int bottomtopposA = Convert.ToInt32(bottomTopPosNumA.Value);
            int linespacing = Convert.ToInt32(textSpacingNum.Value);
            int leftrightposB = Convert.ToInt32(leftRightPosNumB.Value);
            int bottomtopposB = Convert.ToInt32(bottomTopPosNumB.Value);
            //get blank pages from textbox, catch if box is blank or prepopulated
            if (pageBlanksTextBox.Text != "")
            {
                if (pageBlanksTextBox.Text.Contains("Comma "))
                {
                    //do nothing
                }
                else
                {
                    blankPagesArray = pageBlanksTextBox.Text.Split(new Char[] { ',' });
                }
            }

            if (numOPgsTextBox.Text != "")
            {
                try
                {
                    pdf.Info.Title = title;

                    //create however many pages we ask
                    for (int i = 1; i <= numberofpages; i++)
                    {
                        //if the array is not blank
                        if (blankPagesArray != null)
                        {

                            if (createBlankPage(i) == false)
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
                                    graph.DrawString(customerID, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA));
                                    graph.DrawString(title, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA + linespacing));
                                    graph.DrawString(address, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA + linespacing + linespacing));
                                    if(address2 != "")
                                    {
                                        graph.DrawString(address2, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA + linespacing + linespacing + linespacing));
                                        graph.DrawString(citystzip, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA + linespacing + linespacing + linespacing + linespacing));
                                    }
                                    else
                                    {
                                        graph.DrawString(citystzip, font, XBrushes.Black, new Point(leftrightposA, bottomtopposA + linespacing + linespacing + linespacing));
                                    }
                                    
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
                                    if (address2 != "")
                                    {
                                        graph.DrawString(address2, font, XBrushes.Black, new Point(leftrightposB, bottomtopposB + linespacing + linespacing + linespacing));
                                        graph.DrawString(citystzip, font, XBrushes.Black, new Point(leftrightposB, bottomtopposB + linespacing + linespacing + linespacing + linespacing));
                                    }
                                    else
                                    {
                                        graph.DrawString(citystzip, font, XBrushes.Black, new Point(leftrightposB, bottomtopposB + linespacing + linespacing + linespacing));
                                    }
                                }

                            }

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

        private bool createBlankPage(int i)
        {
            foreach (var b in blankPagesArray)
            {
                if (i == Convert.ToInt32(b))
                {
                    //create however many more "blank" pages
                    PdfPage pdfPage = pdf.AddPage();
                    pdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
                    XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                    XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
                    graph.DrawString("", font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
                    return true;
                }
            }
            return false;
        }

        public static string ConvertTo_ProperCase(string text)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            return myTI.ToTitleCase(text.ToLower());
        }

        #endregion

        #region toolbar
        //toolbar items
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("HelpDoc.mht");
            }
            catch
            {
                MessageBox.Show("Looks like the help text is missing.");
            }
        }
        #endregion

        #region settings
        private void saveSetBtn_Click(object sender, EventArgs e)
        {
            //save the settings back to AppSettings
            Properties.Settings.Default.Left_Right_LabelPositionA = Convert.ToInt32(leftRightPosNumA.Value);
            Properties.Settings.Default.Bottom_Top_LabelPositionA = Convert.ToInt32(bottomTopPosNumA.Value);
            Properties.Settings.Default.Left_Right_LabelPositionB = Convert.ToInt32(leftRightPosNumB.Value);
            Properties.Settings.Default.Bottom_Top_LabelPositionB = Convert.ToInt32(bottomTopPosNumB.Value);
            Properties.Settings.Default.Text_Spacing = Convert.ToInt32(textSpacingNum.Value);
            Properties.Settings.Default.Save();
            MessageBox.Show("App settings have been saved.");
        }
        #endregion

        private void pageBlanksTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

