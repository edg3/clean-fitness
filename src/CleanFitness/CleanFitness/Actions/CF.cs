namespace CleanFitness.Actions;

/// <summary>
/// Short hand way to get access to anything globally
/// </summary>
public static class CF
{
    public static DB DB => DB.I;
    public static ViewModelLocator VML => ViewModelLocator.I;
    public static Navigator Nav => Navigator.I;
    public static INotify Notifier { get; set; }

    // Html helpers
    public static string UpperHtml =>
        "<html><head><style>" +
        "body{background-color:#efefef;color:#090909}" +
        ".row{width:99%;padding:4px;}" +
        ".col-1{padding:2px;display:inline-block;width:32%;text-align:end;color:#00A5FF;}" +
        ".col-2{padding:2px;display:inline-block;width:64%}" +
        "</style></head><body>";
    public static string LowerHtml =>
        "</body></html>";
}
