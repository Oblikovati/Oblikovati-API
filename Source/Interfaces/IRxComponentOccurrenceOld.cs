namespace Oblikovati.API;

public interface IRxComponentOccurrenceOld
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxComponentDefinition ContextDefinition { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxComponentDefinition Definition { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxComponentOccurrence ParentOccurrence { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumComponentOccurrences SubOccurrences { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxMatrix Transformation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pGeometry">pGeometry</param>
    /// <param name="ppResult">ppResult</param>
    void CreateGeometryProxy([In] [MarshalAs(UnmanagedType.Interface)] IRxReferenceKey pGeometry, [Out] [MarshalAs(UnmanagedType.Interface)] out IRxGeometryProxy ppResult);
}
