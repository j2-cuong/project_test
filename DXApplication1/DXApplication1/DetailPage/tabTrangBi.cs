using ProcessDataAllForm;

namespace DXApplication1.DetailPage
{
    public partial class tabTrangBi : ProcessDataWithTabControl
    {
        private static tabTrangBi instance;

        public static tabTrangBi Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new tabTrangBi();
                return instance;
            }
        }

        public tabTrangBi()
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
