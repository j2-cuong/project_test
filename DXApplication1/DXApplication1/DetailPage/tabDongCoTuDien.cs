using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DXApplication1.Logic;
using ProcessDataAllForm;
using System;
using System.Drawing;
using System.IO;
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

        

        protected override void CollectControlData()
        {

            TabData["DC_Ten"] = txtDC_Ten.Text;
            TabData["Model"] = txtDC_Model.Text;
            TabData["CSuat"] = txtDC_CSuat.Text;
            TabData["Loai"] = txtDC_Loai.Text;
            TabData["SoSoiCap_1"] = txtDC_SoSoiCap_1.Text;
            TabData["SoSoiCap_2"] = txtDC_SoSoiCap_2.Text;
            if (picDC.Image != null)
                TabData["picDC"] = DevExpressLogic.SaveImageToBuildFolder(picDC.Image, "DC");

            TabData["TD_Ten"] = txtTD_Ten.Text;
            TabData["TD_Model"] = txtTD_Model.Text;
            TabData["TD_CSuat"] = txtTD_CSuat.Text;
            if (picTD.Image != null)
                TabData["picTD"] = DevExpressLogic.SaveImageToBuildFolder(picTD.Image, "TD");

            TabData["NguonDienTM"] = txtNguonDienTM.Text;
            TabData["NguonDienCS"] = txtNguonDienCS.Text;
        }

        protected override void RestoreControlData()
        {

        }

    }
}
