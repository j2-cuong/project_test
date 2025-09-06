using ProcessDataAllForm;

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
            // Thu thập data
        }

        protected override void RestoreControlData()
        {
            // Khôi phục data
        }
    }
}
