using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DXApplication1.Logic
{
    public class DevExpressLogic
    {
        private static readonly Dictionary<string, string> fieldMap = new Dictionary<string, string>
        {
            // menuInfomation
            ["MaSo"] = "maSo",
            ["NgayBH"] = "ngayBH",
            ["SoHD"] = "soHD",
            ["Trang"] = "trangHD",
            ["TenCTrinh"] = "lblTenCtrinh",
            ["NgayXH"] = "lblNgayXuatHang",
            ["LuuY"] = "lblLuuY",
            ["DiaChi"] = "lblDiaChi",

            // menuThongSo
            ["LoaiThang_1"] = "lblLoaiThang_1",
            ["LoaiThang_2"] = "lblLoaiThang_2",
            ["LoaiThang_3"] = "lblLoaiThang_3",
            ["TaiTrong"] = "lblTaiTrong",
            ["TocDo"] = "lblTocDo",
            ["SoTang_1"] = "lblSoTang_1",
            ["SoTang_2"] = "lblSoTang_2",
            ["SoTang_3"] = "lblSoTang_3",
            ["SoTang_4"] = "lblSoTang_4",
            ["SLThang_1"] = "lblSoLuongThang_1",
            ["SLThang_2"] = "lblSoLuongThang_2",
            ["MaMauSon"] = "lblMaSon",
            ["KTHoThang"] = "lblKichThuocHoThang",
            ["Pit"] = "lblPit",
            ["OH"] = "lblOh",
            ["ChieuCao"] = "lblChieuCaoPhongMay",
            ["KieuTruyen"] = "lblKieuTruyen",
            ["KC"] = "lblKetCauHoThang",
            ["DoiTrong_1"] = "lblDoiTrong_1",
            ["DoiTrong_2"] = "lblDoiTrong_2",
            ["Tang_1"] = "lblTang_1",
            ["Tang_2"] = "lblTang_2",
            ["Tang_3"] = "lblTang_3",
            ["Tang_4"] = "lblTang_4",

            // menuDongCoTuDien
            ["DC_Ten"] = "lblDCD_DC_Ten",
            ["Model"] = "lblDCD_DC_Model",
            ["CSuat"] = "lblDCD_DC_CongSuat",
            ["Loai"] = "lblDCD_DC_Loai",
            ["SoSoiCap_1"] = "lblDCD_DC_SoiCap_1",
            ["SoSoiCap_2"] = "lblDCD_DC_SoiCap_2",
            ["picDC"] = "lblDCD_DC_Image", 
            ["TD_Ten"] = "lblDCD_TD_Ten",
            ["TD_Model"] = "lblDCD_TD_Model",
            ["TD_CSuat"] = "lblDCD_TD_CongSuat",
            ["picTD"] = "lblDCD_TD_Image", 
            ["NguonDienTM"] = "lblDongCoTuDien_DienTM",
            ["NguonDienCS"] = "lblDongCoTuDien_DienCS"
        };

        public static DataSet ConvertJsonToDataSetWithMapping(string json)
        {
            var root = JObject.Parse(json);
            var table = new DataTable("DuLieuBaoCao");

            foreach (var kvp in fieldMap)
            {
                table.Columns.Add(kvp.Value, typeof(string));
            }

            var row = table.NewRow();

            foreach (var section in root)
            {
                JObject obj = section.Value as JObject;
                if (obj != null)
                {
                    foreach (var prop in obj.Properties())
                    {
                        string originalKey = prop.Name;
                        if (fieldMap.ContainsKey(originalKey))
                        {
                            string mappedKey = fieldMap[originalKey];
                            row[mappedKey] = prop.Value?.ToString()?.Trim() ?? string.Empty;
                        }
                    }
                }
            }

            table.Rows.Add(row);
            var ds = new DataSet();
            ds.Tables.Add(table);
            return ds;
        }

        public static void PopulateImages(XtraReport report, DataSet dataSet)
        {
            if (dataSet == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0)
            {
                return;
            }

            DataRow dataRow = dataSet.Tables[0].Rows[0];
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            foreach (var control in report.AllControls<XRControl>())
            {
                if (control is XRPictureBox pictureBox)
                {
                    string controlName = pictureBox.Name;

                    if (dataRow.Table.Columns.Contains(controlName))
                    {
                        string imagePath = dataRow[controlName]?.ToString();
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(Path.Combine(baseDirectory, imagePath)))
                        {
                            try
                            {
                                using (var originalImage = Image.FromFile(Path.Combine(baseDirectory, imagePath)))
                                {
                                    pictureBox.Image = new Bitmap(originalImage);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Lỗi khi tải ảnh: {ex.Message}");
                            }
                        }
                    }
                }
            }
        }

        public static void ExportReportWithDialog(bool isPdf, string json)
        {
            try
            {
                var dsDieuChinh = ConvertJsonToDataSetWithMapping(json);

                var report = XtraReport.FromFile("DevExpressServices/ReportFile/Report.repx", true);

                report.DataSource = dsDieuChinh;
                if (dsDieuChinh.Tables.Count > 0)
                {
                    report.DataMember = dsDieuChinh.Tables[0].TableName;
                }

                PopulateImages(report, dsDieuChinh);

                report.CreateDocument();

                using (var sfd = new SaveFileDialog())
                {
                    sfd.Title = "Chọn nơi lưu báo cáo";
                    sfd.FileName = "BaoCao";
                    sfd.Filter = isPdf ? "PDF File|*.pdf" : "Excel File|*.xlsx";
                    sfd.DefaultExt = isPdf ? "pdf" : "xlsx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (isPdf)
                            report.ExportToPdf(sfd.FileName);
                        else
                            report.ExportToXlsx(sfd.FileName);
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi export: " + ex.Message);
            }
        }

        public static string SaveImageToBuildFolder(Image image, string prefix)
        {
            string id = Guid.NewGuid().ToString();
            string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            if (!Directory.Exists(imageFolder))
                Directory.CreateDirectory(imageFolder);
            string fileName = $"{prefix}_{id}.png";
            string fullPath = Path.Combine(imageFolder, fileName);
            image.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
            return Path.Combine("Images", fileName);
        }
    }
}