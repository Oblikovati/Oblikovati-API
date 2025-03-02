namespace Oblikovati.API;

/// <summary>
/// The FeatureControlFrameRows object provides access to all rows of a feature control frame.
/// </summary>
public interface FeatureControlFrameRows : IEnumerable
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
    /// Method that returns the specified FeatureControlFrameRow object from the collection.
    /// </summary>
    FeatureControlFrameRow Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that adds a row to the feature control frame.
    /// </summary>
    /// <param name="GeometricCharacteristic">Input GeometricCharacteristicEnum that specifies the geometric characteristic symbol for the row.</param>
    /// <param name="Tolerance">Input String that specifies the tolerance associated with this geometric characteristic. The string can contain symbols specified using the StyleOverride tag. Input String that specifies the tolerance associated with this geometric characteristic. The string can contain symbols specified using the StyleOverride tag. For example, use "<StyleOverride Font='AIGDT'\>m</StyleOverride>" to specify .</param>
    /// <param name="LowerTolerance">Optional input String that specifies the lower tolerance associated with this geometric characteristic. Applies to ANSI standard only. The string can contain symbols specified using the StyleOverride tag. For example, use "<StyleOverride Font='AIGDT'\>m</StyleOverride>" to specify .</param>
    /// <param name="DatumOne">Optional input String that specifies the first datum that affects the tolerance. The string can contain symbols specified using the StyleOverride tag. For example, use "<StyleOverride Font='AIGDT'\>m</StyleOverride>" to specify .</param>
    /// <param name="DatumTwo">Optional input String that specifies the second datum that affects the tolerance. The string can contain symbols specified using the StyleOverride tag. For example, use "<StyleOverride Font='AIGDT'\>m</StyleOverride>" to specify .</param>
    /// <param name="DatumThree">Optional input String that specifies the third datum that affects the tolerance. The string can contain symbols specified using the StyleOverride tag. For example, use "<StyleOverride Font='AIGDT'\>m</StyleOverride>" to specify .</param>
    /// <returns></returns>
    [PreserveSig]
    FeatureControlFrameRow Add([In] GeometricCharacteristicEnum GeometricCharacteristic, [In] [MarshalAs(UnmanagedType.BStr)] string Tolerance, [In] [MarshalAs(UnmanagedType.BStr)] string? LowerTolerance = "", [In] [MarshalAs(UnmanagedType.BStr)] string? DatumOne = "", [In] [MarshalAs(UnmanagedType.BStr)] string? DatumTwo = "", [In] [MarshalAs(UnmanagedType.BStr)] string? DatumThree = "");
}
