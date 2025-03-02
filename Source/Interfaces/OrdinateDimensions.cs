namespace Oblikovati.API;

/// <summary>
/// The OrdinateDimensions collection object provides access to all of the ordinate dimensions on the sheet.
/// </summary>
public interface OrdinateDimensions : IEnumerable
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
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified dimension object from the collection.
    /// </summary>
    OrdinateDimension Item { get; }
    /// <summary>
    /// Method that creates an ordinate dimension.
    /// </summary>
    /// <param name="Intent">Input GeometryIntent object that specifies the geometry to dimension. The GeometryIntent object can be created using the Sheet.CreateGeometryIntent method. Valid intent values are points that specify geometry to which an ordinate dimension can be attached. For example, the start, mid, end point of lines and start, end, center point of curves are valid intent values. If an invalid intent is specified, this method will fail.</param>
    /// <param name="TextOrigin">Input Point2d object that specifies the position of the dimension text on the sheet. The specified position of the dimension text together with the dimension alignment type (specified by the DimensionType argument) will determine the actual resulting position for the dimension text. If the specified dimension text position lies along the dimension line implied by the DimensionType argument, the dimension text will be placed exactly at the specified position. On the other hand, if the specified dimension text position does not lie along the dimension line implied by the DimensionType argument, the specified point will be projected onto the dimension line and the dimension text will be placed at this projected point. The following figures show how the specified position will be interpreted. In the first figure, the dimension type is specified to be a horizontal ordinate dimension and the specified point (P) lies on the horizontal line (L), therefore the dimension text will be placed exactly at the specified point (P).
    /// In the second figure (shown below), the dimension type is specified to be a horizontal ordinate dimension and the specified point (P) does not lie on the horizontal line (L), therefore the point P will be first projected onto the dimension line and this projected point (P') will be used as the placement point for the dimension text.</param>
    /// <param name="DimensionType">Input DimensionTypeEnum that specifies the ordinate dimension type. Valid values kHorizontalDimensionType, kVerticalDimensionType and kAlignedDimensionType. The value kAlignedDimensionType can be specified only if the geometry of the specified input intent represents a line in which case an ordinate dimension that is aligned along the direction of the line will be created. An error will occur if an invalid dimension type is specified. For instance, kArcLengthDimensionType, kDiametricDimensionType and kSymmetricDimensionType are invalid for all types of intent and kAlignedDimensionType is invalid if the geometry of the specified input intent does not represent a line. The following figures show the aligned, horizontal and vertical ordinate dimensions for the same input intent (the geometry of the intent represents a line whose direction is used to place the aligned ordinate dimension).
    /// Aligned Ordinate Dimension
    /// Horizontal Ordinate Dimension
    /// Vertical Ordinate Dimension</param>
    /// <param name="DimensionStyle">Optional input DimensionStyle object that specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    OrdinateDimension Add([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent Intent, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextOrigin, [In] DimensionTypeEnum DimensionType, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
}
