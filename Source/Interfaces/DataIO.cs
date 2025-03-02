namespace Oblikovati.API;

/// <summary>
/// Generic object that handles input and output of formatted data. IDataObject-style functionality that's IDispatch-compatible and simplified.
/// </summary>
public interface DataIO
{
    /// <summary>
    /// Writes out the contents of the supporting object in the specified format onto a file.
    /// </summary>
    /// <param name="Format">Input String that specifies the format of the data to be written to the file.</param>
    /// <param name="FileName">Input String that specifies the name of the file to write the data to.</param>
    [PreserveSig]
    void WriteDataToFile([In] [MarshalAs(UnmanagedType.BStr)] string Format, [In] [MarshalAs(UnmanagedType.BStr)] string FileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Format">Format</param>
    /// <param name="Stream">Stream</param>
    [PreserveSig]
    void WriteDataToStream([In] [MarshalAs(UnmanagedType.BStr)] string Format, [In] [Out] [MarshalAs(UnmanagedType.IUnknown)] ref object Stream);
    /// <summary>
    /// Reads in the specifically formatted contents of a file into the supporting object.
    /// </summary>
    /// <param name="Format">Input String that specifies the format of the data to be read from the file.</param>
    /// <param name="FileName">Input String that specifies the name of the file to read the data from.</param>
    [PreserveSig]
    void ReadDataFromFile([In] [MarshalAs(UnmanagedType.BStr)] string Format, [In] [MarshalAs(UnmanagedType.BStr)] string FileName);
    /// <summary>
    /// Reads in the specifically formatted contents of a Stream (IStream) into the supporting object.
    /// </summary>
    /// <param name="Format">Input String that specifies the format of the data to be read from the stream.</param>
    /// <param name="Stream">Input/output object from which to read the formatted data.</param>
    [PreserveSig]
    void ReadDataFromStream([In] [MarshalAs(UnmanagedType.BStr)] string Format, [In] [MarshalAs(UnmanagedType.IUnknown)] object Stream);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Formats">Formats</param>
    /// <param name="StorageTypes">StorageTypes</param>
    [PreserveSig]
    void GetOutputFormats([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref string[] Formats, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref StorageTypeEnum[] StorageTypes);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Formats">Formats</param>
    /// <param name="StorageTypes">StorageTypes</param>
    [PreserveSig]
    void GetInputFormats([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref string[] Formats, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref StorageTypeEnum[] StorageTypes);
}
