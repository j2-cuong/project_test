using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProcessDataAllForm
{
    public class ProcessDataWithTabControl : XtraUserControl
    {

        protected Dictionary<string, object> TabData { get; set; } = new Dictionary<string, object>();

        public virtual string GetTabData()
        {
            CollectControlData();
            return JsonConvert.SerializeObject(TabData, Formatting.Indented);
        }

        public virtual void SetTabData(string jsonData)
        {
            if (string.IsNullOrEmpty(jsonData)) return;
            TabData = JsonConvert.DeserializeObject<Dictionary<string, object>>(
                jsonData,
                new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                }
            );
            RestoreControlData();
        }

        public virtual void LoadDataById(string id)
        {
            // Load data từ database theo id 
        }

        protected virtual void CollectControlData() { }
        protected virtual void RestoreControlData() { }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ProcessDataWithTabControl
            // 
            this.Name = "ProcessDataWithTabControl";
            this.ResumeLayout(false);

        }
    }
}
