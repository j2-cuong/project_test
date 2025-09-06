using ProcessDataAllForm;

namespace DXApplication1.DetailPage
{
    public partial class tabKichThuoc : ProcessDataWithTabControl
    {
        private static tabKichThuoc instance;

        public static tabKichThuoc Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new tabKichThuoc();
                return instance;
            }
        }

        public tabKichThuoc()
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
