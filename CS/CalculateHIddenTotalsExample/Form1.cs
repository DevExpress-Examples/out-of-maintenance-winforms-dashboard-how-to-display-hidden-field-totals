using DevExpress.DashboardCommon;
using DevExpress.DashboardCommon.ViewerData;
using DevExpress.DashboardWin;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CalculateHIddenTotalsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dashboardViewer1.CalculateHiddenTotals = true;
            dashboardViewer1.ConfigureDataConnection += DashboardViewer1_ConfigureDataConnection;
            dashboardViewer1.CustomizeDashboardItemCaption += DashboardViewer1_CustomizeDashboardItemCaption;

            // Load the dashboard after all DashboardViewer options are set.
            dashboardViewer1.DashboardSource = typeof(Dashboard1);
        }
        private void DashboardViewer1_CustomizeDashboardItemCaption(object sender, CustomizeDashboardItemCaptionEventArgs e)
        {
            DashboardViewer viewer = (DashboardViewer)sender;
            if (e.DashboardItemName == "pieDashboardItem1")
            {
                DashboardToolbarItem infoButton = new DashboardToolbarItem();
                MultiDimensionalData mData = viewer.GetItemData(e.DashboardItemName);
                var orderCount = mData.GetValue(mData.GetMeasures().Where(m => m.DataMember == "OrderID").First()).Value ?? 0;
                e.FilterText += string.Format("{0:N0} distinct orders are displayed", orderCount);
            }
        }

        private void DashboardViewer1_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        {
            ExtractDataSourceConnectionParameters parameters = e.ConnectionParameters as ExtractDataSourceConnectionParameters;
            if (parameters != null) parameters.FileName = Path.GetFileName(parameters.FileName);
        }

    }
}
