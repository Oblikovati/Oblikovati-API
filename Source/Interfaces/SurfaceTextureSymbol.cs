namespace Oblikovati.API;

/// <summary>
/// The SurfaceTextureSymbol object represents a surface texture symbol on a sheet.
/// </summary>
public interface SurfaceTextureSymbol
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
    /// Gets and sets the associated SurfaceTextureStyle object.
    /// </summary>
    SurfaceTextureStyle Style { get; set; }
    /// <summary>
    /// Gets and sets the layer associated with this object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Property that returns the leader associated with the surface texture symbol.
    /// </summary>
    Leader Leader { get; }
    /// <summary>
    /// Gets and sets the SurfaceTextureSymbolDefinition object associated with this symbol.
    /// </summary>
    SurfaceTextureSymbolDefinition Definition { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ForceTail { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Majority { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AllAroundSymbol { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string MaximumRoughness { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string MinimumRoughness { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ProductionMethod { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string AdditionalProductionMethod { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string SamplingLength { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string AdditionalSamplingLength { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    LayDirectionTypeEnum LayDirection { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string MachiningAllowance { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string AdditionalRoughness { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string SurfaceWaviness { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the SurfaceTextureSymbol.
    /// </summary>
    [PreserveSig]
    void Delete();
}
