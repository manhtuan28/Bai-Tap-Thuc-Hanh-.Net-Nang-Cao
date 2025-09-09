using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TH2_BT3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()
            {
                Title = "Chọn file .txt để mở",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                CheckFileExists = true
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string text = File.ReadAllText(ofd.FileName, Encoding.UTF8);
                        rtNotepad.Text = text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không đọc được file:\n" + ex.Message,
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog()
            {
                Title = "Lưu nội dung ra file",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                AddExtension = true,
                DefaultExt = "txt",
                FileName = "note.txt"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, rtNotepad.Text, Encoding.UTF8);
                        MessageBox.Show("Đã lưu xong ^^", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không lưu được file:\n" + ex.Message,
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
