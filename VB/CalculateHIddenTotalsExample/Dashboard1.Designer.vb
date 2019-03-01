Namespace CalculateHIddenTotalsExample
	Partial Public Class Dashboard1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
			Me.dashboardExtractDataSource1 = New DevExpress.DashboardCommon.DashboardExtractDataSource()
			Me.listBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
			DirectCast(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dashboardExtractDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.listBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' pieDashboardItem1
			' 
			dimension1.DataMember = "CategoryName"
			Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
			measure1.DataMember = "Extended Price"
			measure1.Name = "Extended Price (Sum)"
			measure2.DataMember = "OrderID"
			measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.CountDistinct
			Me.pieDashboardItem1.DataItemRepository.Clear()
			Me.pieDashboardItem1.DataItemRepository.Add(measure1, "DataItem0")
			Me.pieDashboardItem1.DataItemRepository.Add(dimension1, "DataItem2")
			Me.pieDashboardItem1.DataItemRepository.Add(measure2, "DataItem1")
			Me.pieDashboardItem1.DataSource = Me.dashboardExtractDataSource1
			Me.pieDashboardItem1.HiddenMeasures.AddRange(New DevExpress.DashboardCommon.Measure() { measure2})
			Me.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.pieDashboardItem1.Name = ""
			Me.pieDashboardItem1.ShowCaption = True
			Me.pieDashboardItem1.ShowPieCaptions = False
			Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1})
			' 
			' dashboardExtractDataSource1
			' 
			Me.dashboardExtractDataSource1.ComponentName = "dashboardExtractDataSource1"
			Me.dashboardExtractDataSource1.FileName = "C:\Data\SalesPerson.dat"
			Me.dashboardExtractDataSource1.Name = "Extract Data Source 1"
			' 
			' listBoxDashboardItem1
			' 
			Me.listBoxDashboardItem1.ComponentName = "listBoxDashboardItem1"
			dimension2.DataMember = "CategoryName"
			Me.listBoxDashboardItem1.DataItemRepository.Clear()
			Me.listBoxDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
			Me.listBoxDashboardItem1.DataSource = Me.dashboardExtractDataSource1
			Me.listBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
			Me.listBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
			Me.listBoxDashboardItem1.Name = ""
			Me.listBoxDashboardItem1.ShowCaption = True
			' 
			' Dashboard1
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExtractDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.pieDashboardItem1, Me.listBoxDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.pieDashboardItem1
			dashboardLayoutItem1.Weight = 82.495511669658882R
			dashboardLayoutItem2.DashboardItem = Me.listBoxDashboardItem1
			dashboardLayoutItem2.Weight = 17.504488330341115R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Weight = 100R
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Dashboard"
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dashboardExtractDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.listBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private dashboardExtractDataSource1 As DevExpress.DashboardCommon.DashboardExtractDataSource
		Private pieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem
		Private listBoxDashboardItem1 As DevExpress.DashboardCommon.ListBoxDashboardItem
	End Class
End Namespace
