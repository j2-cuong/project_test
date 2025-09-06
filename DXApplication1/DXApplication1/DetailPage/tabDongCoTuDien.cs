using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ProcessDataAllForm;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace DXApplication1.DetailPage
{
    public partial class tabDongCoTuDien : ProcessDataWithTabControl
    {
        private static tabDongCoTuDien instance;

        public static tabDongCoTuDien Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new tabDongCoTuDien();
                return instance;
            }
        }

        public tabDongCoTuDien()
        {
            InitializeComponent();
        }

        protected override void CollectControlData()
        {
        }

        protected override void RestoreControlData()
        {
        }

        private void picDC_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Load ảnh vào PictureEdit
                    picDC.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                    picDC.EditValue = Image.FromFile(ofd.FileName);
                    // Nếu muốn giữ path
                    picDC.Tag = ofd.FileName;
                }
            }
        }

        private void picTD_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Load ảnh vào PictureEdit
                    picTD.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                    picTD.EditValue = Image.FromFile(ofd.FileName);

                    // Nếu muốn giữ path
                    picTD.Tag = ofd.FileName;
                }
            }
        }

    }
}
