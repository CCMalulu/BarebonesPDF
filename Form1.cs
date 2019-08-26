using System;
using System.Windows.Forms;

namespace BarebonesPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens a file dialog to open the PDF to be viewed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // creates dialog
            OpenFileDialog fileDialog = new OpenFileDialog();

            // sets filter and shows
            fileDialog.Filter = "PDF files (*.pdf) |*.pdf;";
            fileDialog.ShowDialog();

            // load file and display if not null
            if (fileDialog.FileName != null)
                axAcroPDF1.LoadFile(fileDialog.FileName);
        }
    }
}
