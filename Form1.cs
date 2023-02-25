using PictureApp.Properties;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PictureApp
{
    public partial class Main : Form
    {
        private string filePath = "";
        public string PicturePath
        {
            get
            {
                return Settings.Default.PicturePath;
            }
            set
            {
                Settings.Default.PicturePath = value;
            }
        }
        public Main()
        {
            InitializeComponent();
            if (File.Exists(PicturePath))
            {
                SetView(PicturePath);
                filePath = PicturePath;
            }
        }

        private void SetView(string filePath)
        {
            if (File.Exists(filePath))
            {
                pictureBox.Image = Image.FromFile(filePath);
                pictureBox.Height = pictureBox.Image.Height;
                pictureBox.Width = pictureBox.Image.Width;
                btRemove.Visible = true;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Pliki graficzne (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg|Wszystkie pilki (*.*)|*.*";
                    ofd.ShowDialog();
                    if (File.Exists(ofd.FileName))//U¿ycie przyisku 'Anuluj', równie¿ przekazuje œcie¿kê
                        filePath = ofd.FileName;
                    SetView(filePath);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wybra³eœ niew³aœciwy typ pliku. Spróbuj jeszcze raz, albo naciœnij " +
                         '"' + "Anuluj" + '"' + "\n\nKomunikat b³êdu: " + ex.Message, "Niew³aœciwy typ pliku",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    filePath = PicturePath;
                }
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            filePath = "";
            btRemove.Visible = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            PicturePath = filePath;
            Settings.Default.Save();
        }

        private void btRotateR90_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Image img = pictureBox.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox.Image = img;
            }
        }

        private void btRotateL90_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Image img = pictureBox.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox.Image = img;
            }
        }
    }
}