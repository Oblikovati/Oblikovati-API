namespace Oblikovati.API;

/// <summary>
/// Edge Collection Object.
/// </summary>
public interface RuledSurfaceEdgeFacePair
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that sets data for the edge face pair.
    /// </summary>
    /// <param name="Edge">Input Edge object.</param>
    /// <param name="Face">Input Face object.</param>
    [PreserveSig]
    void SetData([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.Interface)] Face Face);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edge">Edge</param>
    /// <param name="Face">Face</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.Interface)] out Edge Edge, [Out] [MarshalAs(UnmanagedType.Interface)] out Face Face);
    /// <summary>
    /// Method that deletes this object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
