using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuuDocVanBan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Plain text .txt|*.txt";

            if(saveFileDialog.ShowDialog() == DialogResult.OK )
            {
                rtNoiDung.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Đã lưu nội dung trên Richtextbox xuống tập tin thành công");
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Plain text .txt|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = openFileDialog.OpenFile();
                StreamReader sr = new StreamReader(stream);
                rtNoiDung.Text = sr.ReadToEnd(); sr.Close();
            }
        }
    }
}
