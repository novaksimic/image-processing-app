using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imageprocessor
{
    public partial class frmImgProcessor : Form
    {
       
        Image File;

        public frmImgProcessor()
        {
            InitializeComponent();

            btnSave.Enabled = false;
            btnGrayscale.Enabled = false;
            btnNegative.Enabled = false;


        }



        private void LoadImage1_Click(object sender, EventArgs e)
        {


            OpenFileDialog oDlg = new OpenFileDialog();

            oDlg.InitialDirectory = "C:\\";


            oDlg.Filter = "Image Files (*.bmp,*.jpg)|*.bmp;*.jpg";

            if (DialogResult.OK == oDlg.ShowDialog())
            {

                this.File = Image.FromFile(oDlg.FileName);
                this.pictureBox1.Image = File;
                if (pictureBox1.Image != null)
                {
                    btnSave.Enabled = false;
                    btnGrayscale.Enabled = true;
                    btnNegative.Enabled = true;

                }

            }
        }

    

        private void button1_Click(object sender, EventArgs e)
        {


                btnSave.Enabled = true;
                Bitmap copy = new Bitmap((Bitmap)this.pictureBox1.Image);
                Processing.ConvertToGrayscale(copy);
                this.pictureBox2.Image = copy;
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

                btnSave.Enabled = true;
                Bitmap copy1 = new Bitmap(this.pictureBox1.Image);
                Processing.ConvertToNegative(copy1);
                this.pictureBox2.Image = copy1;
            
               
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            SaveFileDialog sDlg = new SaveFileDialog();

            sDlg.InitialDirectory = "C:\\";

            sDlg.Filter = "JPEG Files (*.jpeg)|*.jpeg";

            if (DialogResult.OK == sDlg.ShowDialog())
            {

                this.pictureBox2.Image.Save(sDlg.FileName, ImageFormat.Jpeg);


            }
        }

            
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();        
                
                
        }

    }
}
