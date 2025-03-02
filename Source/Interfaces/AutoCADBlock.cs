namespace Oblikovati.API;

/// <summary>
/// The AutoCADBlock object represents an instance of an AutoCAD block definition on a sheet.
/// </summary>
public interface AutoCADBlock
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
    /// Read-write property that gets and sets the AutoCADBlockDefinition object referenced by the block.
    /// </summary>
    AutoCADBlockDefinition Definition { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the origin position of the block on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Property that provides the transform that is applied to display the associated AutoCAD block definition in the correct location on the sheet. The matrix defines the sheet to block transform.
    /// </summary>
    Matrix2d Transformation { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-write property that gets and sets the layer associated with the block.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the scale of the block.
    /// </summary>
    double Scale { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the rotation angle of the block in radians.
    /// </summary>
    double Rotation { get; set; }
    /// <summary>
    /// Property that indicates the name of this object or instance.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-write property that gets and sets the color for the block.&nbsp;Setting the property to Nothing restores the block to the color defined by the layer on which this block resides.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the line weight override for the symbol.&nbsp;Setting the property to 0 restores the symbol to the line weight defined by the layer on which this curve resides.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the line type override for the block.&nbsp;Setting the property to kDefaultLineType restores the block to the line type defined by the layer on which this block resides.&nbsp;If the property returns kCustomLineType, the GetCustom.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to show the scale and rotation grip points on the block.&nbsp;If True, the grip points are disabled.
    /// </summary>
    bool Static { get; set; }
    /// <summary>
    /// Method that deletes the AutoCAD block from the sheet.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Method that sets a custom line type to the symbol from the specified .lin file. The method automatically changes the value of LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">Specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">Specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Specifies whether to replace the existing line type if a line type of the same name exists. If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PromptTags">PromptTags</param>
    /// <param name="Values">Values</param>
    [PreserveSig]
    void GetPromptTextValues([Out] [MarshalAs(UnmanagedType.Struct)] out object PromptTags, [Out] [MarshalAs(UnmanagedType.Struct)] out object Values);
    /// <summary>
    /// Method that sets the prompt string values (attributes) of the block.
    /// </summary>
    /// <param name="PromptTags">String array that specifies the prompt tag strings.</param>
    /// <param name="Values">String array that specifies the corresponding values of the prompt fields.</param>
    [PreserveSig]
    void SetPromptTextValues([In] [MarshalAs(UnmanagedType.Struct)] object PromptTags, [In] [MarshalAs(UnmanagedType.Struct)] object Values);
}
