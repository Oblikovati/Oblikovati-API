namespace Oblikovati.API;

/// <summary>
/// A FeatureDimension object represents a dimension associated with a feature.
/// </summary>
public interface FeatureDimension
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent PartFeature object.
    /// </summary>
    PartFeature Parent { get; }
    /// <summary>
    /// Property that returns the parameter associated with the dimension.
    /// </summary>
    Parameter Parameter { get; }
    /// <summary>
    /// Property that returns the position of the dimension text.
    /// </summary>
    Point TextPoint { get; }
    /// <summary>
    /// Gets the anchor points of dimension.
    /// </summary>
    ObjectCollection AnchorPoints { get; }
    /// <summary>
    /// Gets the type of dimension.
    /// </summary>
    FeatureDimensionTypeEnum DimensionType { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
