namespace Oblikovati.API;

/// <summary>
/// QueryManager Object.
/// </summary>
public interface QueryManager
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Criteria">Criteria</param>
    /// <param name="IncludingSubCategories">IncludingSubCategories</param>
    [PreserveSig]
    string Query([In] [MarshalAs(UnmanagedType.BStr)] string Criteria, [In] bool IncludingSubCategories);
}
