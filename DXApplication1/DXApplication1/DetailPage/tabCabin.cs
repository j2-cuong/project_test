using ProcessDataAllForm;

namespace DXApplication1.DetailPage
{
    public partial class tabCabin : ProcessDataWithTabControl
    {
        private static tabCabin instance;

        public static tabCabin Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new tabCabin();
                return instance;
            }
        }

        public tabCabin()
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
