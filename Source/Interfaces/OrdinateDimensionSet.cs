namespace Oblikovati.API;

/// <summary>
/// The OrdinateDimensionSet object represents an ordinate dimension set placed on a sheet.
/// </summary>
public interface OrdinateDimensionSet
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
    /// Property that returns the parent sheet of the object.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets whether to align the text and the jog points of all the members.
    /// </summary>
    bool AlignMembers { get; set; }
    /// <summary>
    /// Gets and sets whether to allow jog points (movable vertices) on the dimensions.
    /// </summary>
    bool AllowBrokenLeaders { get; set; }
    /// <summary>
    /// Gets and sets whether to display continuity line between the set members.
    /// </summary>
    bool ContinuousRunning { get; set; }
    /// <summary>
    /// Property that returns the dimension type of the ordinate set. Possible values are kAlignedDimensionType, kHorizontalDimensionType and kVerticalDimensionType.
    /// </summary>
    DimensionTypeEnum DimensionType { get; }
    /// <summary>
    /// Gets and sets whether to reverse the direction of positive numbers.
    /// </summary>
    bool DirectionReversed { get; set; }
    /// <summary>
    /// Gets and sets the layer for the dimension set.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Property that returns all the member OrdinateDimension objects.
    /// </summary>
    OrdinateDimensionsEnumerator Members { get; }
    /// <summary>
    /// Gets and sets the origin for the ordinate dimension set.
    /// </summary>
    OrdinateDimension OriginMember { get; set; }
    /// <summary>
    /// Gets and sets whether dimension values should be positive in both directions of the origin.
    /// </summary>
    bool PositiveBothDirections { get; set; }
    /// <summary>
    /// Gets and sets the number of decimal places displayed for all the members in this set.
    /// </summary>
    int Precision { get; set; }
    /// <summary>
    /// Gets and sets whether to place an arrow on the origin dimension pointing in the positive direction.
    /// </summary>
    bool ShowDirection { get; set; }
    /// <summary>
    /// Gets and sets the dimension style used for this dimension set.
    /// </summary>
    DimensionStyle Style { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the arrowhead type for the origin member of the ordinate dimension set.
    /// </summary>
    ArrowheadTypeEnum OriginArrowheadType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that adds a member to the ordinate set and returns an OrdinateDimension object that represents the member.
    /// </summary>
    /// <param name="GeometryIntent">Input GeometryIntent object that specifies the member to add. A GeometryIntent object can be created using the Sheet.CreateGeometryIntent method.</param>
    /// <returns></returns>
    [PreserveSig]
    OrdinateDimension AddMember([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent GeometryIntent);
    /// <summary>
    /// Method that deletes the OrdinateDimensionSet.
    /// </summary>
    [PreserveSig]
    void Delete();
}
