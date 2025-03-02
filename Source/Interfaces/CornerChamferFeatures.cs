namespace Oblikovati.API;

/// <summary>
/// The CornerChamferFeatures collection object provides access to all of the objects in a sheet metal component definition.
/// </summary>
public interface CornerChamferFeatures : IEnumerable
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
    /// Returns the specified CornerChamferFeature object from the collection. This is the default property of the CornerChamferFeatures collection object.
    /// </summary>
    CornerChamferFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new corner chamfer feature. The newly created CornerChamferFeature object is returned.
    /// </summary>
    /// <param name="CornerChamferDefinition">Input CornerChamferFeature object that defines the corner chamfer feature you want to create. A CornerChamferDefinition object can be created using the CornerChamferFeatures.CreateCornerChamferDefinition method. It can also be obtained from an existing CornerChamferFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    CornerChamferFeature Add([In] [MarshalAs(UnmanagedType.Interface)] CornerChamferDefinition CornerChamferDefinition);
    /// <summary>
    /// Method that creates a new CornerChamferDefinition object.
    /// </summary>
    /// <param name="CornerEdges">Input object that defines the corner(s) to apply a corner chamfer on. This can be a single Edge object or an EdgeCollection that contains the Edge objects to chamfer. Any non-corner edges will be ignored.</param>
    /// <param name="Distance">Input Variant that defines the distance from the edge. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    CornerChamferDefinition CreateCornerChamferDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object CornerEdges, [In] [MarshalAs(UnmanagedType.Struct)] object Distance);
}
