namespace Oblikovati.API;

/// <summary>
/// This object and its behavior will remain in its current state to support backward compatibility but it will be hidden because it's no longer needed in the new implementation.
/// </summary>
public interface iFeatureComponents : IEnumerable
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    iFeatureComponent Item { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Definition">Definition</param>
    [PreserveSig]
    iFeatureComponent Add([In] [MarshalAs(UnmanagedType.Interface)] iFeatureDefinition Definition);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    [PreserveSig]
    iFeatureDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}
