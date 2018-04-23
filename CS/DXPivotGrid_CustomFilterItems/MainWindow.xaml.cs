using System.Windows;
using DevExpress.Xpf.PivotGrid;
using DevExpress.XtraPivotGrid.Data;
using DXPivotGrid_CustomFilterItems.DataSet1TableAdapters;

namespace DXPivotGrid_CustomFilterItems {
    public partial class MainWindow : Window {
        DataSet1.ProductReportsDataTable productReportsDataTable =
            new DataSet1.ProductReportsDataTable();
        ProductReportsTableAdapter productReportsDataAdapter = new ProductReportsTableAdapter();
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = productReportsDataAdapter.GetData();
        }
        readonly string dummyItem = "";
        private void pivotGridControl1_CustomFilterPopupItems(object sender,
                                    PivotCustomFilterPopupItemsEventArgs e) {
            if (object.ReferenceEquals(e.Field, fieldCategoryName)) {
                for (int i = e.Items.Count - 1; i >= 0; i--) {
                    if (object.Equals(e.Items[i].Value, "Beverages")) {
                        e.Items.RemoveAt(i);
                        break;
                    }
                }
                e.Items.Insert(0, new PivotGridFilterItem(dummyItem,
                                                          "Dummy Item",
                                                          e.Field.FilterValues.Contains(dummyItem)));
            }
        }
    }
}
