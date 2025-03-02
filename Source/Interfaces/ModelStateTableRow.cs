namespace Oblikovati.API;

/// <summary>
/// The ModelStateTableRow Object.
/// </summary>
public interface ModelStateTableRow : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets the index of this row within the ModelStateTableRows collection where the first row has an index of 1.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelStateTable Parent { get; }
    /// <summary>
    /// Read-only property that returns the member name of the ModelStateTableRow.
    /// </summary>
    string MemberName { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ModelStateTableCell this[object Index] { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the ModelStateTableRow.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that creates a copy of the ModelStateTableRow. The new created ModelStateTableRow is returned.
    /// </summary>
    /// <param name="NewName">Optional input String that specify the member name of the new ModelStateTableRow. If not specified a default name will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelStateTableRow Copy([In] [MarshalAs(UnmanagedType.BStr)] string? NewName = "");
}
