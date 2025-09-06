using ProcessDataAllForm;

namespace DXApplication1.DetailPage
{
    public partial class tabInfomation : ProcessDataWithTabControl
    {
        private static tabInfomation instance;
        
        public static tabInfomation Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new tabInfomation();
                return instance;
            }
        }

        public tabInfomation()
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
