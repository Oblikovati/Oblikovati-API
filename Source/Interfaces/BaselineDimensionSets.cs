namespace Oblikovati.API;

/// <summary>
/// The BaselineDimensionSets collection object provides access to all of the baseline dimension sets on the sheet.
/// </summary>
public interface BaselineDimensionSets : IEnumerable
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
    /// Method that returns the specified dimension set object from the collection.
    /// </summary>
    BaselineDimensionSet this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a baseline dimension set and returns the newly created BaselineDimensionSet object.
    /// </summary>
    /// <param name="GeometryIntents">Input ObjectCollection containing GeometryIntent objects. The GeometryIntent objects specify the geometries to use for the dimension. The first geometry in the collection is assumed to be the origin.</param>
    /// <param name="PlacementPoint">Input Point2d object that specifies the placement point of the dimension set on the sheet.</param>
    /// <param name="DimensionType">' Input DimensionTypeEnum that specifies the dimension type. Valid values kHorizontalDimensionType, kVerticalDimensionType and kAlignedDimensionType. See Remarks.</param>
    /// <param name="DimensionStyle">Optional input DimensionStyle object that specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    BaselineDimensionSet Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection GeometryIntents, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] DimensionTypeEnum DimensionType, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
}
