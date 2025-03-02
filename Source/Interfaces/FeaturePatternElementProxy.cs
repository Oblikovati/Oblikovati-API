namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface FeaturePatternElementProxy
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
    /// Property that returns the feature pattern this element is a member of.
    /// </summary>
    PartFeature Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the index of this element within the pattern.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Property that returns a collection object generated as a result of the feature.
    /// </summary>
    Faces Faces { get; }
    /// <summary>
    /// Property that gets and sets whether the element is suppressed or not. A value of True indicates it is suppressed.
    /// </summary>
    bool Suppressed { get; set; }
    /// <summary>
    /// Property that returns the transform that describes this occurrences relative position to the parent feature(s). The transform returned for the first element in a pattern (the parent feature(s)) will be an identity matrix.
    /// </summary>
    Matrix Transform { get; }
    /// <summary>
    /// Property that returns the features that were created for this pattern element. These can be work planes, work axes, work points and work surfaces.
    /// </summary>
    ObjectsEnumerator ResultFeatures { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    FeaturePatternElement NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
