<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXPivotGrid_CustomFilterItems/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXPivotGrid_CustomFilterItems/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_CustomFilterItems/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/DXPivotGrid_CustomFilterItems/MainWindow.xaml))
<!-- default file list end -->
# How to add and remove items from the filter drop-down list


<p>The following example shows how to add and remove items from the filter dropdown list.</p><p>In this example, the 'Beverages' item is hidden from the filter dropdown list of the Category field, and a dummy item is created and added to the list. To do this, the CustomFilterPopupItems event is handled. In the event handler, the 'Beverages' item is removed from the event parameter's Items collection, and a new item ('Dummy Item') is added to the collection.</p>

<br/>


