using ProcessDataAllForm;
using System;

namespace DXApplication1.DetailPage
{
    public partial class tabInfomation : ProcessDataWithTabControl
    {
        private static tabInfomation instance;
        
        public static tabInfomation Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new tabInfomation();
                return instance;
            }
        }

        public tabInfomation()
        {
            InitializeComponent();
        }

        protected override void CollectControlData() 
        {
            TabData["Id"] = Guid.NewGuid();
            TabData["MaSo"] = txtMaSo.Text;
            TabData["NgayBH"] = dtpNgayBH.Text;
            TabData["SoHD"] = txtSoHD.Text;
            TabData["TenCTrinh"] = txtTenCTrinh.Text;
            TabData["NgayXH"] = dtpNgayXH.Text;
            TabData["LuuY"] = txtLuuY.Text;
            TabData["DiaChi"] = txtDiaChi.Text;
            TabData["NgayBH"] = dtpNgayBH.Text;
            TabData["Trang"] = txtTrang.Text;
        }

        protected override void RestoreControlData()
        {
            if (TabData.ContainsKey("MaSo"))
                txtMaSo.Text = TabData["MaSo"].ToString();
            if (TabData.ContainsKey("SoHD"))
                txtSoHD.Text = TabData["SoHD"].ToString();
        }
    }
}
