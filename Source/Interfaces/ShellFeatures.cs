namespace Oblikovati.API;

/// <summary>
/// The ShellFeatures collection object provides access to all of the objects in a component definition and provides methods to create additional ShellFeatures.
/// </summary>
public interface ShellFeatures : IEnumerable
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
    /// Returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    ShellFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new ShellFeature. The new created ShellFeature is returned.
    /// </summary>
    /// <param name="Definition">Property that returns the object which defines the various input that was used to create the shell feature.</param>
    /// <returns></returns>
    [PreserveSig]
    ShellFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ShellDefinition Definition);
    /// <summary>
    /// Method that creates a new ShellDefinition object. The object returned by this method is used to define the inputs for a shell feature and is provided as the argument to the Add method of the ShellFeatures collection.
    /// </summary>
    /// <param name="InputFaces">Optional input FaceCollection object that defines the part faces to remove, leaving the remaining faces as shell walls. If no faces are specified, the shell creates a hollow part.</param>
    /// <param name="Thickness">Optional input Variant that specifies the thickness to be applied uniformly to shell walls. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <param name="Direction">Optional input enum that specifies the shell boundary relative to the part face. Valid inputs are kInside that offsets the shell wall to the part interior, kOutside that offsets the shell wall to the exterior of the part, and kBothSides that offsets the shell wall equal distances to inside and outside the part. The default value is kInside.</param>
    /// <returns></returns>
    [PreserveSig]
    ShellDefinition CreateShellDefinition([In] [MarshalAs(UnmanagedType.Struct)] object? InputFaces = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Thickness = default, [In] ShellDirectionEnum? Direction = ShellDirectionEnum.kInsideShellDirection);
}
