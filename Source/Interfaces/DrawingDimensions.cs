namespace Oblikovati.API;

/// <summary>
/// The DrawingDimensions object provides access to all of the dimensions ( objects) on the sheet.
/// </summary>
public interface DrawingDimensions : IEnumerable
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
    /// Method that returns the specified dimension object from the collection.
    /// </summary>
    DrawingDimension Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns the GeneralDimensions collection object. This object provides access to all of the general dimensions on the sheet and provides functionality to create new general dimensions.
    /// </summary>
    GeneralDimensions GeneralDimensions { get; }
    /// <summary>
    /// Property that returns the OrdinateDimensions collection object.
    /// </summary>
    OrdinateDimensions OrdinateDimensions { get; }
    /// <summary>
    /// Property that returns the BaselineDimensionSets collection object.
    /// </summary>
    BaselineDimensionSets BaselineDimensionSets { get; }
    /// <summary>
    /// Property that returns the OrdinateDimensionSets collection object.
    /// </summary>
    OrdinateDimensionSets OrdinateDimensionSets { get; }
    /// <summary>
    /// Property that returns the ChainDimensionSets collection object. This object provides access to all of the chain dimension sets on the sheet and provides functionality to create new chain dimension sets.
    /// </summary>
    ChainDimensionSets ChainDimensionSets { get; }
    /// <summary>
    /// Method that automatically arranges the input drawing dimensions.
    /// </summary>
    /// <param name="DrawingDimensions">Input ObjectCollection that contains the drawing dimensions to arrange. The collection can contains dimensions from different drawing views. The collection can contain DrawingDimension and ChainDimensionSet objects. The input DrawingDimension objects should not be a member of an ordinate dimension set, a baseline dimension set or a chain dimension set.</param>
    /// <param name="ContourEntity">Optional input object that specifies a contour entity to use for dimension arrangement. This can either be a GeometryIntent object (which specifies a geometry) or a Point2d object (which specifies a 2d point in sheet space). This argument is applicable only when all the input dimension objects are along an axis (i.e. they are parallel).</param>
    [PreserveSig]
    void Arrange([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection DrawingDimensions, [In] [MarshalAs(UnmanagedType.Struct)] object? ContourEntity = default);
}
