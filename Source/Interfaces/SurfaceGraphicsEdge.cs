namespace Oblikovati.API;

/// <summary>
/// The SurfaceGraphicsEdge represents an individual edge displayed by the SurfaceGraphics object.
/// </summary>
public interface SurfaceGraphicsEdge
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the Edge object associated with the SurfaceGraphicsEdge.
    /// </summary>
    Edge Edge { get; }
    /// <summary>
    /// Gets and sets color associated with this primitive.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Property that gets and sets the line type override. Setting the property to kDefaultLineType restores the default line type. If the property returns kCustomLineType, the GetCustomLineType method can be used to get further details about the line type.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Gets and sets the LineWeight applied to this surface graphice edge.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Gets and sets the LineScale applied to this surface graphics edge.
    /// </summary>
    double LineScale { get; set; }
    /// <summary>
    /// Gets and sets the LineDefinitionSpace applied to this surface graphics edge.
    /// </summary>
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    /// <summary>
    /// Property that returns the index of the SurfaceGraphicsEdge object within the SurfaceGraphicsEdgeList.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Property that returns the parent SurfaceGraphics object.
    /// </summary>
    SurfaceGraphics Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that specifies whether the surface graphics edge can be selected or not.
    /// </summary>
    bool Selectable { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Method that sets a custom line type to the curve from the specified .lin file. The method automatically changes the value of LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">Input string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists. If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
}
