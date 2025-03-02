namespace Oblikovati.API;

/// <summary>
/// The FeatureControlFrame object represents a feature control frame symbol on a sheet.
/// </summary>
public interface FeatureControlFrame
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
    /// Property that returns the parent Sheet object.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets the position of the symbol on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Gets and sets the FeatureControlFrameRows object.
    /// </summary>
    FeatureControlFrameRows FeatureControlFrameRows { get; set; }
    /// <summary>
    /// Gets and sets the associated FeatureControlFrameStyle object.
    /// </summary>
    FeatureControlFrameStyle Style { get; set; }
    /// <summary>
    /// Gets and sets the layer associated with this object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Property that returns the leader associated with the feature control frame symbol.
    /// </summary>
    Leader Leader { get; }
    /// <summary>
    /// Gets and sets the absolute rotation angle of the symbol in radians. The value can either be positive (counter-clockwise rotation) or negative (clockwise rotation).
    /// </summary>
    double Rotation { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AllAroundSymbol { get; set; }
    /// <summary>
    /// Gets and sets a datum identifier for the feature control frame. Setting this property fails if the associated style does not allow the specification of a datum identifier.
    /// </summary>
    string DatumIdentifier { get; set; }
    /// <summary>
    /// Gets and sets notes for the feature control frame. The string can contain symbols specified using the StyleOverride tag. For instance, use 'm' to specify (M).
    /// </summary>
    string Notes { get; set; }
    /// <summary>
    /// Gets and sets top notes for the feature control frame. The string can contain symbols specified using the StyleOverride tag. For instance, use 'm' to specify (M).
    /// </summary>
    string TopNotes { get; set; }
    /// <summary>
    /// Gets whether the OverrideMergeSymbol is set to override the MergeSymbol setting in FeatureControlFrameStyle. Set this to False will clear the override setting.
    /// </summary>
    bool MergeSymbolOverridden { get; set; }
    /// <summary>
    /// Gets and sets the merge symbol override value. Set this property will set the MergeSymbolOverridden to True.
    /// </summary>
    bool OverrideMergeSymbol { get; set; }
    /// <summary>
    /// Gets and sets the profile type for the feature control frame.
    /// </summary>
    FeatureControlFrameProfileTypeEnum ProfileType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the FeatureControlFrame.
    /// </summary>
    [PreserveSig]
    void Delete();
}
