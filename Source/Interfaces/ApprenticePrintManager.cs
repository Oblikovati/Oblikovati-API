namespace Oblikovati.API;

/// <summary>
/// The ApprenticePrintManager object supports properties and methods that allow you to get and set the printing parameters and submit the print job.
/// </summary>
public interface ApprenticePrintManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets/Sets the name of the printer. This is the printer's identifier. Defaults to default printer for this machine.
    /// </summary>
    string Printer { get; set; }
    /// <summary>
    /// Gets/Sets the number of copies to be printed. Defaults to 1.
    /// </summary>
    int NumberOfCopies { get; set; }
    /// <summary>
    /// Gets/Sets the orientation of the printer. Defaults to the printer's default.
    /// </summary>
    PrintOrientationEnum Orientation { get; set; }
    /// <summary>
    /// Gets/Sets the size of the paper to be printed. Defaults to the printer's default.
    /// </summary>
    PaperSizeEnum PaperSize { get; set; }
    /// <summary>
    /// Gets/Sets the height of the paper to be printed. Setting this, sets PaperSize to kPaperSizeCustom.
    /// </summary>
    double PaperHeight { get; set; }
    /// <summary>
    /// Gets/Sets the width of the paper to be printed. Setting this, sets PaperSize to kPaperSizeCustom.
    /// </summary>
    double PaperWidth { get; set; }
    /// <summary>
    /// Gets/Sets the paper source (tray) on the printer. This is printer specific. Defaults to printer's default (denoted by -1).
    /// </summary>
    int PaperSource { get; set; }
    /// <summary>
    /// Gets/Sets the color mode to be used for printing. Defaults to using kPrintGrayScale.
    /// </summary>
    PrintColorModeEnum ColorMode { get; set; }
    /// <summary>
    /// Gets/Sets the printer's device context.
    /// </summary>
    int PrinterDeviceContext { get; set; }
    /// <summary>
    /// Method that prints using the current property settings defined by the ApprenticePrintManager object.
    /// </summary>
    [PreserveSig]
    void SubmitPrint();
    /// <summary>
    /// Method that prints to the specified file using the current property settings defined by the ApprenticePrintManager object.
    /// </summary>
    /// <param name="FileName">Input String that specifies the full path of the file to write the print information to. If the specified file already exists it will be overwritten.</param>
    [PreserveSig]
    void PrintToFile([In] [MarshalAs(UnmanagedType.BStr)] string FileName);
    /// <summary>
    /// Property to set the current view, to be used for printing.
    /// </summary>
    /// <param name="CurrentView">Input ClientView that defines the area to print.</param>
    [PreserveSig]
    void SetCurrentView([In] [MarshalAs(UnmanagedType.Interface)] ClientView CurrentView);
}
