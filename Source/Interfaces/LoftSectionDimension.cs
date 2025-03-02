namespace Oblikovati.API;

/// <summary>
/// The LoftSectionDimension object is used to define the position and area for a placed section of an area-graph type loft.
/// </summary>
public interface LoftSectionDimension
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
    /// Read-write property that specifies whether the placed section for an area-graph type loft is driving or driven.
    /// </summary>
    bool IsDrivingSection { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the positional distance (from the starting section) of the placed section for an area-graph type loft.
    /// </summary>
    double Position { get; set; }
    /// <summary>
    /// Read-write Boolean property that gets and sets the whether the positional distance of the placed section for an area-graph type loft is specified as an absolute distance value.
    /// </summary>
    bool PositionAsAbsoluteDistance { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the size of the placed section for an area-graph type loft.
    /// </summary>
    double Size { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the size of the placed section for an area-graph type loft is specified as a scale factor with respect to its default size.
    /// </summary>
    bool SizeAsScaleFactor { get; set; }
    /// <summary>
    /// Method that deletes this placed section of an area-graph type loft.
    /// </summary>
    [PreserveSig]
    void Delete();
}
