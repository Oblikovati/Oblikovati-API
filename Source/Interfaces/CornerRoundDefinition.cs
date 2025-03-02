namespace Oblikovati.API;

/// <summary>
/// The CornerRoundDefinition object is a utility object used for creating, querying, and editing sheet metal corner round features.
/// </summary>
public interface CornerRoundDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of edge sets defined within this CornerRoundDefinition object.
    /// </summary>
    int EdgeSetCount { get; }
    /// <summary>
    /// Method that returns the specified CornerRoundEdgeSet object from this CornerRoundDefinition object.
    /// </summary>
    CornerRoundEdgeSet EdgeSetItem { get; }
    /// <summary>
    /// Property that returns the parent CornerRoundFeature of this CornerRoundDefinition object.
    /// </summary>
    CornerRoundFeature Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new edge set within the corner round definition.
    /// </summary>
    /// <param name="CornerEdges">Input EdgesCollection object that contains all of the corners to apply a corner round on. Any non-corner edges will be ignored.</param>
    /// <param name="Radius">Input Variant that defines the corner radius. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    CornerRoundEdgeSet AddEdgeSet([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection CornerEdges, [In] [MarshalAs(UnmanagedType.Struct)] object Radius);
    /// <summary>
    /// Method that removes the specified CornerRoundEdgeSet object from this CornerRoundDefinition object. This results in all the corner round being removed from the edges in this edge set.
    /// </summary>
    /// <param name="Index">Input Long value that specifies the index of the CornerRoundEdgeSet to return. If an out of range index is provided, an error occurs.</param>
    [PreserveSig]
    void RemoveEdgeSet([In] int Index);
    /// <summary>
    /// Function that creates a copy of this CornerRoundDefinition object. The copy is independent of any other object and can be edited without affecting anything else. It can then be used as input to either modify an existing corner round or create a new corner round feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    CornerRoundDefinition Copy();
}
