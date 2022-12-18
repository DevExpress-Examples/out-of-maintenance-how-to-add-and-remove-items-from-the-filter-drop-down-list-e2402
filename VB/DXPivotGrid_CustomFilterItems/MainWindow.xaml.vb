Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DXPivotGrid_CustomFilterItems.DataSet1TableAdapters

Namespace DXPivotGrid_CustomFilterItems

    Public Partial Class MainWindow
        Inherits Window

        Private productReportsDataTable As DataSet1.ProductReportsDataTable = New DataSet1.ProductReportsDataTable()

        Private productReportsDataAdapter As ProductReportsTableAdapter = New ProductReportsTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = productReportsDataAdapter.GetData()
        End Sub

        Private ReadOnly dummyItem As String = ""

        Private Sub pivotGridControl1_CustomFilterPopupItems(ByVal sender As Object, ByVal e As PivotCustomFilterPopupItemsEventArgs)
            If Object.ReferenceEquals(e.Field, Me.fieldCategoryName) Then
                For i As Integer = e.Items.Count - 1 To 0 Step -1
                    If Equals(e.Items(i).Value, "Beverages") Then
                        e.Items.RemoveAt(i)
                        Exit For
                    End If
                Next

                e.Items.Insert(0, New PivotGridFilterItem(dummyItem, "Dummy Item", e.Field.FilterValues.Contains(dummyItem)))
            End If
        End Sub
    End Class
End Namespace
