namespace Oblikovati.API;

/// <summary>
/// Creates and provides access to the parameters that reference parameters in another Inventor document.
/// </summary>
public interface DerivedParameterTables : IEnumerable
{
    /// <summary>
    /// Method that returns the specified DerivedParameterTable object from the collection. This is the default method of the DerivedParameterTables collection object.
    /// </summary>
    DerivedParameterTable this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new DerivedParameterTable object, given an existing Oblikovati part or assembly document as input. Returns the resulting DerivedParameterTable object. The creation fails if the input document does not have any exported parameters.
    /// </summary>
    /// <param name="FullFileName">String value that contains the full path to the part or assembly document.</param>
    /// <returns></returns>
    [PreserveSig]
    DerivedParameterTable Add([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that creates a new DerivedParameterTable object, given an existing Oblikovati part or assembly document as input. Returns the resulting DerivedParameterTable object. This method fails if the input document has already been linked.
    /// </summary>
    /// <param name="FullFileName">Input String value that contains the full path to the part or assembly document.</param>
    /// <param name="ParametersToLink">Optional input ObjectCollection that specifies the parameters in the input file to link. If this argument is not specified, all the exported parameters in the input file are linked. If there are no exported parameters, the method will fail. If specified, all parameters in the input file that are not already exported are automatically exported.</param>
    /// <returns></returns>
    [PreserveSig]
    DerivedParameterTable Add2([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Struct)] object? ParametersToLink = default);
}
