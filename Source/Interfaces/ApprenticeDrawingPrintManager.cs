namespace Oblikovati.API;

/// <summary>
/// The ApprenticeDrawingPrintManager object supports properties and methods that allow you to get and set the printing parameters and submit the print job.
/// </summary>
public interface ApprenticeDrawingPrintManager
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
    /// Gets/Sets the mode by which the scale of the print is defined. Defaults to kPrintBestFitScale.
    /// </summary>
    PrintScaleModeEnum ScaleMode { get; set; }
    /// <summary>
    /// Gets/Sets the scale of the print. Meaningless when the ScaleMode is not kPrintCustomScale.
    /// </summary>
    double Scale { get; set; }
    /// <summary>
    /// Gets/Sets information about which sheets are to be printed. Defaults to kPrintCurrentSheet.
    /// </summary>
    PrintRangeEnum PrintRange { get; set; }
    /// <summary>
    /// Gets/Sets the Boolean flag indicating whether the Drawing should be rotated 90-deg in the print.
    /// </summary>
    bool Rotate90Degrees { get; set; }
    /// <summary>
    /// Gets/Sets the Boolean flag indicating whether all the Drawing colors should be black in the print.
    /// </summary>
    bool AllColorsAsBlack { get; set; }
    /// <summary>
    /// Gets/Sets the Boolean flag indicating whether the Drawing line weights should be removed in the print.
    /// </summary>
    bool RemoveLineWeights { get; set; }
    /// <summary>
    /// Gets/Sets the Boolean flag indicating whether excluded sheets (when PrintRange is set to kPrintAllSheets or kPrintSheetRange) should be printed. Defaults to FALSE.
    /// </summary>
    bool PrintExcludedSheets { get; set; }
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
    /// <summary>
    /// Property to indicate the range of Sheets to be printed. Valid only when PrintRange is set to kPrintSheetRange.
    /// </summary>
    /// <param name="FromSheet">Specifies the first sheet of the range to print.</param>
    /// <param name="ToSheet">Specifies the last sheet of the range to print.</param>
    [PreserveSig]
    void SetSheetRange([In] int FromSheet, [In] int ToSheet);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FromSheet">FromSheet</param>
    /// <param name="ToSheet">ToSheet</param>
    [PreserveSig]
    void GetSheetRange([Out] out int FromSheet, [Out] out int ToSheet);
}
