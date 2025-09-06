using ProcessDataAllForm;

    namespace DXApplication1.DetailPage
    {
    public partial class tabDien : ProcessDataWithTabControl
    {
        private static tabDien instance;

        public static tabDien Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new tabDien();
                return instance;
            }
        }

        public tabDien()
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
