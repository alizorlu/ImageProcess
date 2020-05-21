using AForge.Imaging.Filters;
using Emgu.CV.OCR;
using IPTutorial.ImageProcess.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace IPTutorial
{
    public partial class frmHome : Form
    {
        private ImageModal _imageModal = new ImageModal();
        public frmHome()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = od.FileName;
                _imageModal.InputImage = new Bitmap(selectedFile);
                _imageModal.OutputImage = new Bitmap(selectedFile); ;
                inputPic.Image = _imageModal.InputImage;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == 0)
            {
                _imageModal.ImageSharpening = true;
            }
            if (checkedListBox1.SelectedIndex == 1)
            {
                _imageModal.GrayScale = true;
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            if (_imageModal.ImageSharpening)
            {
                _imageModal.OutputImage = new GaussianSharpen(19, 215).Apply(_imageModal.OutputImage);
            }
            if (_imageModal.GrayScale)
            {
                _imageModal.OutputImage = new Grayscale(0.33333, 0.33333, 0.33333).Apply(_imageModal.OutputImage);
            }
            richTextBox1.Clear();
            string tessDataFolder = @"C:\Users\AZORLUA\Downloads\rnekhabercliplerihk\tessdata";

            using (var engine = new TesseractEngine(tessDataFolder, "tur", EngineMode.TesseractOnly))
            {
                //engine.SetVariable("tessedit_char_whitelist", "ABCÇDEFGHIİJKLMNOÖPRSŞTVUÜYZabcçdefgğhiıjklmnoöprsştuüvyz1234567890.,!?'");
                var page = engine.Process(_imageModal.OutputImage);
                page.Engine.DefaultPageSegMode = Tesseract.PageSegMode.Auto;
                var conf = page.GetMeanConfidence();

                string format = $"CONF :{conf}\n==\n{page.GetText()}";
                richTextBox1.Text = format;
                resultPic.Image = _imageModal.OutputImage;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            _imageModal = new ImageModal();
            inputPic.Image = null;
            resultPic.Image = null;
            richTextBox1.Clear();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);

        }

        private void resultSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                string path = sd.FileName;
                _imageModal.OutputImage.Save($"{path}.jpg");
            }
        }
    }
}
