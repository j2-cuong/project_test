using ProcessDataAllForm;
using System;

namespace DXApplication1.DetailPage
{
    public partial class tabThongSo : ProcessDataWithTabControl
    {
        private static tabThongSo instance;

        public static tabThongSo Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new tabThongSo();
                return instance;
            }
        }

        public tabThongSo()
        {
            InitializeComponent();
        }

        protected override void CollectControlData()
        {
            TabData["LoaiThang_1"] = txtLoaiThang_1.Text;
            TabData["LoaiThang_2"] = txtLoaiThang_2.Text;
            TabData["LoaiThang_3"] = txtLoaiThang_3.Text;
            TabData["TaiTrong"] = txtTaiTrong.Text;
            TabData["TocDo"] = txtTocDo.Text;
            TabData["SoTang_1"] = txtSoTang_1.Text;
            TabData["SoTang_2"] = txtSoTang_2.Text;
            TabData["SoTang_3"] = txtSoTang_3.Text;
            TabData["SoTang_4"] = txtSoTang_4.Text;
            TabData["SLThang_1"] = txtSLThang_1.Text;
            TabData["SLThang_2"] = txtSLThang_2.Text;
            TabData["MaMauSon"] = txtMaMauSon.Text;
            TabData["KTHoThang"] = txtKTHoThang.Text;
            TabData["Pit"] = txtPit.Text;
            TabData["OH"] = txtOH.Text;
            TabData["Pit"] = txtPit.Text;
            TabData["ChieuCao"] = txtChieuCao.Text;
            TabData["KieuTruyen"] = txtKieuTruyen.Text;
            TabData["KC"] = txtKC.Text;
            TabData["DoiTrong_1"] = txtDoiTrong_1.Text;
            TabData["DoiTrong_2"] = txtDoiTrong_2.Text;
            TabData["Tang_1"] = txtTang_1.Text;
            TabData["Tang_2"] = txtTang_2.Text;
            TabData["Tang_3"] = txtTang_3.Text;
            TabData["Tang_4"] = txtTang_4.Text;
        }

        protected override void RestoreControlData()
        {
        }
    }
}
