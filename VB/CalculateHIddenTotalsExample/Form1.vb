Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardCommon.ViewerData
Imports DevExpress.DashboardWin
Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms

Namespace CalculateHIddenTotalsExample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			dashboardViewer1.CalculateHiddenTotals = True
			AddHandler dashboardViewer1.ConfigureDataConnection, AddressOf DashboardViewer1_ConfigureDataConnection
			AddHandler dashboardViewer1.CustomizeDashboardItemCaption, AddressOf DashboardViewer1_CustomizeDashboardItemCaption

			' Load the dashboard after all DashboardViewer options are set.
			dashboardViewer1.DashboardSource = GetType(Dashboard1)
		End Sub
		Private Sub DashboardViewer1_CustomizeDashboardItemCaption(ByVal sender As Object, ByVal e As CustomizeDashboardItemCaptionEventArgs)
			Dim viewer As DashboardViewer = DirectCast(sender, DashboardViewer)
			If e.DashboardItemName = "pieDashboardItem1" Then
				Dim infoButton As New DashboardToolbarItem()
				Dim mData As MultiDimensionalData = viewer.GetItemData(e.DashboardItemName)
				Dim orderCount = If(mData.GetValue(mData.GetMeasures().Where(Function(m) m.DataMember = "OrderID").First()).Value, 0)
				e.FilterText &= String.Format("{0:N0} distinct orders are displayed", orderCount)
			End If
		End Sub

		Private Sub DashboardViewer1_ConfigureDataConnection(ByVal sender As Object, ByVal e As DashboardConfigureDataConnectionEventArgs)
			Dim parameters As ExtractDataSourceConnectionParameters = TryCast(e.ConnectionParameters, ExtractDataSourceConnectionParameters)
			If parameters IsNot Nothing Then
				parameters.FileName = Path.GetFileName(parameters.FileName)
			End If
		End Sub

	End Class
End Namespace
