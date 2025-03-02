namespace Oblikovati.API;

/// <summary>
/// The CornerRoundFeatures collection object provides access to all of the objects in a sheet metal component definition.
/// </summary>
public interface CornerRoundFeatures : IEnumerable
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
    /// Returns the specified CornerRoundFeature object from the collection. This is the default property of the CornerRoundFeatures collection object.
    /// </summary>
    CornerRoundFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new sheet metal corner round feature.
    /// </summary>
    /// <param name="CornerRoundDefinition">Input CornerRoundDefinition object that defines the various edges and radii.</param>
    /// <returns></returns>
    [PreserveSig]
    CornerRoundFeature Add([In] [MarshalAs(UnmanagedType.Interface)] CornerRoundDefinition CornerRoundDefinition);
    /// <summary>
    /// Method that creates a new CornerRoundDefinition object.
    /// </summary>
    /// <param name="CornerEdges">Input EdgesCollection object that contains all of the corners to apply a corner round on. Any non-corner edges will be ignored.</param>
    /// <param name="Radius">Input Variant that defines the corner radius. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    CornerRoundDefinition CreateCornerRoundDefinition([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection CornerEdges, [In] [MarshalAs(UnmanagedType.Struct)] object Radius);
    /// <summary>
    /// Method that gets the edges from a part feature that can be used to create corner round feature.
    /// </summary>
    /// <param name="Feature">Input PartFeature object that specifies a part feature to get its edges for creating corner round feature.</param>
    /// <returns></returns>
    [PreserveSig]
    EdgeCollection GetEdgesFromFeature([In] [MarshalAs(UnmanagedType.Interface)] PartFeature Feature);
}
