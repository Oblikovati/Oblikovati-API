namespace Oblikovati.API;

/// <summary>
/// The ChainDimensionSet object represents a chain dimension set placed on a sheet.
/// </summary>
public interface ChainDimensionSet
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the dimension type of the chain set. Possible values are kAlignedDimensionType, kHorizontalDimensionType and kVerticalDimensionType.
    /// </summary>
    DimensionTypeEnum DimensionType { get; }
    /// <summary>
    /// Read-write property that gets and sets the layer for the dimension set.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Property that returns all the member LinearGeneralDimension objects.
    /// </summary>
    GeneralDimensionsEnumerator Members { get; }
    /// <summary>
    /// Property that returns the parent sheet of the object.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the number of decimal places displayed for all the members in this set. Valid range of values is 0 to 8.
    /// </summary>
    int Precision { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the dimension style used for this dimension set.
    /// </summary>
    DimensionStyle Style { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the lock status of the dimension set.
    /// </summary>
    bool Locked { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that adds member(s) to the chain set based on the input geometry or dimension and returns the newly created member(s).
    /// </summary>
    /// <param name="DimensionOrGeometry">Input object that specifies the dimension or geometry used to define the chain dimension member(s). Valid input objects are GeometryIntent, LinearGeneralDimension and ChainDimensionSet.</param>
    /// <returns></returns>
    [PreserveSig]
    GeneralDimensionsEnumerator AddMembers([In] [MarshalAs(UnmanagedType.IDispatch)] object DimensionOrGeometry);
    /// <summary>
    /// Method that deletes the ChainDimensionSet.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that merges two members of the set by deleting the second member and healing (modifying) the first member to fill the gap. The input members must be contiguous, else the method will fail.
    /// </summary>
    /// <param name="MemberOne">Input LinearGeneralDimension object that specifies the first member of the set to merge. This member is retained and modified.</param>
    /// <param name="MemberTwo">Input LinearGeneralDimension object that specifies the second member of the set to merge. This member is deleted.</param>
    [PreserveSig]
    void MergeMembers([In] [MarshalAs(UnmanagedType.Interface)] LinearGeneralDimension MemberOne, [In] [MarshalAs(UnmanagedType.Interface)] LinearGeneralDimension MemberTwo);
    /// <summary>
    /// Method that resets the chain dimension set such that all members are equidistant from the view boundary. Dimensions are aligned to the specified base dimension.
    /// </summary>
    /// <param name="BaseDimension">Input LinearGeneralDimension object that specifies the member of the set. All set members are aligned to this member.</param>
    [PreserveSig]
    void Arrange([In] [MarshalAs(UnmanagedType.Interface)] LinearGeneralDimension BaseDimension);
}
