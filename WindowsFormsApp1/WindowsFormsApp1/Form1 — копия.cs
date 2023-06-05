using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEnhancer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void applyButton_Click(object sender, EventArgs e)
        {
            var newBmp = new Bitmap(originalBmp.Width, originalBmp.Height);
            if (filtersComboBox.SelectedItem.ToString()=="Осветление/затемнение")
            {
                var k=(double)((NumericUpDown)parametersPanel.Controls["coefficient"]).Value
                for(var x =0; x< originalBmp.Width; x++)
                    for (var y = 0; y < originalBmp.Height; y++)
                    {
                        var color = originalBmp.GetPixel(x, y);
                        var newR = (int)(pixelColor.R * k);
                        var newG = (int)(pixelColor.G * k);
                        var newB = (int)(pixelColor.B * k);

                        newBmp.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                    }
                
            }
            resultBmp = newBmp;
            resultPictureBox.Image = resultBmp;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(613, 456);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}//сделать кнопку сохранить
