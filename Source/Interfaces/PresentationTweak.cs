namespace Oblikovati.API;

/// <summary>
/// PresentationTweak object.
/// </summary>
public interface PresentationTweak
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the name of this tweak.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the TweakTypeEnum indicating the type of the tweak.
    /// </summary>
    TweakTypeEnum TweakType { get; }
    /// <summary>
    /// Read-only property that returns the translation of the tweak. This is applicable only if the TweakType is kTranslationTweakType.
    /// </summary>
    Vector Translation { get; }
    /// <summary>
    /// Property that returns all the trail segments objects associative with this tweak.
    /// </summary>
    TrailSegmentsEnumerator TrailSegments { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Axis">Axis</param>
    /// <param name="BasePoint">BasePoint</param>
    /// <param name="Angle">Angle</param>
    [PreserveSig]
    void GetRotationData([Out] [MarshalAs(UnmanagedType.Interface)] out UnitVector Axis, [Out] [MarshalAs(UnmanagedType.Interface)] out Point BasePoint, [Out] out double Angle);
}
