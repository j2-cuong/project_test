using ProcessDataAllForm;

namespace DXApplication1.DetailPage
{
    public partial class tabCua : ProcessDataWithTabControl
    {
        private static tabCua instance;

        public static tabCua Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new tabCua();
                return instance;
            }
        }

        public tabCua()
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
