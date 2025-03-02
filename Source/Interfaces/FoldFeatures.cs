namespace Oblikovati.API;

/// <summary>
/// The FoldFeatures collection object provides access to all of the objects in a sheet metal component definition.
/// </summary>
public interface FoldFeatures : IEnumerable
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
    /// Returns the specified FoldFeature object from the collection. This is the default property of the FoldFeatures collection object.
    /// </summary>
    FoldFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new fold feature. The newly created CutFeature object is returned.
    /// </summary>
    /// <param name="FoldDefinition">Input FoldDefinition object that defines the fold feature you want to create. A FoldDefinition object can be created using the FoldFeatures.CreateFoldDefinition method. It can also be obtained from an existing FoldFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    FoldFeature Add([In] [MarshalAs(UnmanagedType.Interface)] FoldDefinition FoldDefinition);
    /// <summary>
    /// Method that creates a new FoldDefinition object.
    /// </summary>
    /// <param name="BendLine">Input SketchLine object that defines the location of the bend line. The bend line must be on the face you are folding, and must terminate at the edges of the face.</param>
    /// <param name="BendAngle">Input Variant that defines the bend angle. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    FoldDefinition CreateFoldDefinition([In] [MarshalAs(UnmanagedType.Interface)] SketchLine BendLine, [MarshalAs(UnmanagedType.Struct)] object BendAngle);
}
