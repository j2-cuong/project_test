using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DXApplication1.DetailPage;
using Newtonsoft.Json;
using ProcessDataAllForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : XtraForm
    {
        private readonly XtraForm _parentForm;
        private readonly Dictionary<XtraTabPage, XtraUserControl> _tabContents;
        private Dictionary<string, string> _tabsData = new Dictionary<string, string>();

        public Form1(XtraForm parentForm = null)
        {
            _parentForm = parentForm;
            InitializeComponent();

            _tabContents = new Dictionary<XtraTabPage, XtraUserControl>
            {
                { menuInfomation, tabInfomation.Instance },
                { menuThongSo,   tabThongSo.Instance },
                { menuKichThuoc, tabKichThuoc.Instance },
                { menuCabin,     tabCabin.Instance },
                { menuCua,       tabCua.Instance },
                { menuDien, tabDien.Instance },
                { menuTrangBi,   tabTrangBi.Instance }
            };

            LoadTabContent();
            xtraTabControl1.SelectedPageChanged += XtraTabControl1_SelectedPageChanged;
        }

        private void LoadTabContent()
        {
            foreach (var kvp in _tabContents)
            {
                var page = kvp.Key;
                var control = kvp.Value;

                if (!page.Controls.Contains(control))
                {
                    control.Dock = DockStyle.Fill;
                    page.Controls.Add(control);
                }
            }
        }

        private void XtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            // Lưu data của tab trước
            if (e.PrevPage != null && _tabContents[e.PrevPage] is ProcessDataWithTabControl prevTab)
            {
                _tabsData[e.PrevPage.Name] = prevTab.GetTabData();
            }

            // Load data cho tab mới
            if (_tabContents[e.Page] is ProcessDataWithTabControl newTab && _tabsData.ContainsKey(e.Page.Name))
            {
                newTab.SetTabData(_tabsData[e.Page.Name]);
            }
        }

        public string GetAllTabsData()
        {
            var allData = new Dictionary<string, string>();
            
            foreach (var kvp in _tabContents)
            {
                if (kvp.Value is ProcessDataWithTabControl tab)
                {
                    allData[kvp.Key.Name] = tab.GetTabData();
                }
            }

            return JsonConvert.SerializeObject(allData);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm?.Close();
            Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var data = GetAllTabsData();
                MessageBox.Show("Data saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }

        private void btnViewPDF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = GetAllTabsData();
                MessageBox.Show("Export successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Export Data to PDF File: {ex.Message}");
            }
        }

        private void btnViewExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var data = GetAllTabsData();
                MessageBox.Show("Export successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Export Data to Excel File: {ex.Message}");
            }
        }
    }
}
