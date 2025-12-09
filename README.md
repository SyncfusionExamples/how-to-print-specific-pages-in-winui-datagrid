# How to print specific pages in WinUI DataGrid?

This example describes how to print specific pages in WinUI DataGrid

**Printing specific pages**
The specific pages can be printed by customizing the print preview window to have options for custom page range through events and customizing the default print manager.

**Add custom page range option**

You can print the range of pages by adding the **CustomPageRanges** option to the PrintTaskOptions.DisplayedOptions property and also add all other available options in the StandardPrintTaskOptions and do the customization to support all other options in [SfDataGrid.PrintTaskRequested](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_PrintTaskRequested) event. You have to call the PrintTaskRequest.CreatePrintTask method using DataGridPrintTaskRequested.Request property. While performing the custom operation in this event, you have to set the [DataGridPrintTaskRequestedEventArgs.PrintDocumentSource](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.DataGrid.Print.DataGridPrintTaskRequestedEventArgs.html#Syncfusion_UI_Xaml_DataGrid_Print_DataGridPrintTaskRequestedEventArgs_PrintDocumentSource) property in PrintTaskSourceRequestedArgs.SetSource which is the event args for event handler available in PrintTaskRequest.CreatePrintTask method.

 
 ```csharp
sfDataGrid.PrintTaskRequested += DataGrid_PrintTaskRequested;

private void DataGrid_PrintTaskRequested(object sender, DataGridPrintTaskRequestedEventArgs e)
{
    e.PrintTask = e.Request.CreatePrintTask("Printing", sourceRequested =>
    {
        PrintTaskOptionDetails printDetailedOptions =
            PrintTaskOptionDetails.GetFromPrintTaskOptions(e.PrintTask.Options);

        IList<string> displayedOptions = printDetailedOptions.DisplayedOptions;
        displayedOptions.Add(Windows.Graphics.Printing.StandardPrintTaskOptions.CustomPageRanges);

        e.PrintTask.Options.PageRangeOptions.AllowCurrentPage = true;
        e.PrintTask.Options.PageRangeOptions.AllowAllPages = true;
        e.PrintTask.Options.PageRangeOptions.AllowCustomSetOfPages = true;

        sourceRequested.SetSource(e.PrintDocumentSource);
    });
} 
 ```