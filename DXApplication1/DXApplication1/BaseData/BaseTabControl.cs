using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProcessDataAllForm
{
    public abstract class ProcessDataWithTabControl : XtraUserControl
    {
        protected Dictionary<string, object> TabData { get; set; } = new Dictionary<string, object>();

        public virtual string GetTabData()
        {
            CollectControlData();
            return JsonConvert.SerializeObject(TabData);
        }

        public virtual void SetTabData(string jsonData)
        {
            if (string.IsNullOrEmpty(jsonData)) return;
            TabData = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);
            RestoreControlData();
        }

        public virtual void LoadDataById(string id)
        {
            // Load data từ database theo id
        }

        protected abstract void CollectControlData();
        protected abstract void RestoreControlData();
    }
}
