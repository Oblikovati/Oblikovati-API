namespace Oblikovati.API;

/// <summary>
/// The BaselineDimensionSet object represents a baseline dimension set placed on a sheet.
/// </summary>
public interface BaselineDimensionSet
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
    /// Property that returns the dimension type of the baseline set. Possible values are kAlignedDimensionType, kHorizontalDimensionType and kVerticalDimensionType.
    /// </summary>
    DimensionTypeEnum DimensionType { get; }
    /// <summary>
    /// Gets and sets the layer for the dimension set.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Property that returns all the member LinearGeneralDimension objects.
    /// </summary>
    GeneralDimensionsEnumerator Members { get; }
    /// <summary>
    /// Gets and sets the origin for the baseline dimension set.
    /// </summary>
    GeometryIntent Origin { get; set; }
    /// <summary>
    /// Gets and sets the number of decimal places displayed for all the members in this set.
    /// </summary>
    int Precision { get; set; }
    /// <summary>
    /// Gets and sets the dimension style used for this dimension set.
    /// </summary>
    DimensionStyle Style { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that adds a member to the baseline set and returns a LinearGeneralDimension object. If an existing LinearGeneralDimension is input into the method, the same object is returned.
    /// </summary>
    /// <param name="DimensionOrGeometry">Input object that specifies the member. This can either be an existing LinearGeneralDimension object or a GeometryIntent object that specifies the geometry to dimension to.</param>
    /// <returns></returns>
    [PreserveSig]
    LinearGeneralDimension AddMember([In] [MarshalAs(UnmanagedType.IDispatch)] object DimensionOrGeometry);
    /// <summary>
    /// Method that automatically arranges the text of all members.
    /// </summary>
    [PreserveSig]
    void ArrangeText();
    /// <summary>
    /// Method that deletes the BaselineDimensionSet.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that detaches the member from the set. The member is not deleted, it is merely converted into a vanilla linear general dimension.
    /// </summary>
    [PreserveSig]
    void DetachMember([In] [MarshalAs(UnmanagedType.Interface)] LinearGeneralDimension Member);
}
