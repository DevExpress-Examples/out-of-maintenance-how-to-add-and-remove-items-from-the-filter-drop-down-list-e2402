Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DXPivotGrid_CustomFilterItems.DataSet1TableAdapters

Namespace DXPivotGrid_CustomFilterItems
	Partial Public Class MainWindow
		Inherits Window

'INSTANT VB NOTE: The variable productReportsDataTable was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Private productReportsDataTable_Conflict As New DataSet1.ProductReportsDataTable()
		Private productReportsDataAdapter As New ProductReportsTableAdapter()
		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = productReportsDataAdapter.GetData()
		End Sub
		Private ReadOnly dummyItem As String = ""
		Private Sub pivotGridControl1_CustomFilterPopupItems(ByVal sender As Object, ByVal e As PivotCustomFilterPopupItemsEventArgs)
			If Object.ReferenceEquals(e.Field, fieldCategoryName) Then
				For i As Integer = e.Items.Count - 1 To 0 Step -1
					If Object.Equals(e.Items(i).Value, "Beverages") Then
						e.Items.RemoveAt(i)
						Exit For
					End If
				Next i
				e.Items.Insert(0, New PivotGridFilterItem(dummyItem, "Dummy Item", e.Field.FilterValues.Contains(dummyItem)))
			End If
		End Sub
	End Class
End Namespace
