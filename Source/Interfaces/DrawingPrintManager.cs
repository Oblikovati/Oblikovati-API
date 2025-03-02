namespace Oblikovati.API;

/// <summary>
/// The DrawingPrintManager object supports properties and methods that allow you to get and set the printing parameters and submit the print.
/// </summary>
public interface DrawingPrintManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
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
    /// Gets/Sets the height of the paper to be printed (max value is 327.67cm). Setting this, sets PaperSize to kPaperSizeCustom.
    /// </summary>
    double PaperHeight { get; set; }
    /// <summary>
    /// Gets/Sets the width of the paper to be printed (max value is 327.67cm). Setting this, sets PaperSize to kPaperSizeCustom.
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
    /// Gets/Sets the Boolean flag indicating whether excluded sheets (when PrintRange is set to kPrintAllSheets or kPrintSheetRange) should be printed. Defaults to FALSE.
    /// </summary>
    bool PrintExcludedSheets { get; set; }
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
    /// Gets/Sets the Boolean flag indicating whether Tiling is enabled during print.
    /// </summary>
    bool TilingEnabled { get; set; }
    /// <summary>
    /// Method that prints using the current property settings defined by the PrintManager object.
    /// </summary>
    [PreserveSig]
    void SubmitPrint();
    /// <summary>
    /// Method that prints to the specified file using the current property settings defined by the PrintManager object.
    /// </summary>
    /// <param name="FileName">Input String that specifies the full path of the file to write the print information to. If the specified file already exists it will be overwritten.</param>
    [PreserveSig]
    void PrintToFile([In] [MarshalAs(UnmanagedType.BStr)] string FileName);
    /// <summary>
    /// Set the current view used for printing.
    /// </summary>
    /// <param name="CurrentView">Input a ClientView for the print manager to print.</param>
    [PreserveSig]
    void SetCurrentView([In] [MarshalAs(UnmanagedType.Interface)] ClientView CurrentView);
    /// <summary>
    /// Method that sets the sheet range to print. The range set is only used when the PrintRange property is set to kPrintSheetRange.
    /// </summary>
    /// <param name="FromSheet">Input Long value that specifies the first sheet of the range to print.</param>
    /// <param name="ToSheet">Input Long value that specifies the last sheet of the range to print.</param>
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
