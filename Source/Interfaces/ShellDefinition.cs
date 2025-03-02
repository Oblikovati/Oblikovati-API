namespace Oblikovati.API;

/// <summary>
/// The ShellDefinition object is used to define all of the input required for fillet features. It is also used to query and edit existing shell features.
/// </summary>
public interface ShellDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the shell boundary relative to part face.
    /// </summary>
    ShellDirectionEnum Direction { get; set; }
    /// <summary>
    /// Property that specifies the number of face sets currently defined in the defintion.
    /// </summary>
    int FaceSetCount { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    ShellFeature Parent { get; }
    /// <summary>
    /// Property that returns the parameter that controls the thickness of the shell. This property will return Nothing if the shell feature has not been created yet.
    /// </summary>
    Parameter Thickness { get; }
    /// <summary>
    /// Method that returns the specified ShellThicknessFaceSet object from the collection.
    /// </summary>
    ShellThicknessFaceSet FaceSetItem { get; }
    /// <summary>
    /// Gets and sets the faces that were specified to create or edit the Shell feature.
    /// </summary>
    FaceCollection InputFaces { get; set; }
    /// <summary>
    /// Gets and sets the approximation method used for the feature.
    /// </summary>
    FeatureApproximationTypeEnum ApproximationType { get; set; }
    /// <summary>
    /// Gets and sets whether the approximation is optimized.
    /// </summary>
    bool ApproximationOptimized { get; set; }
    /// <summary>
    /// Gets and sets the approximation tolerance.
    /// </summary>
    double ApproximationTolerance { get; set; }
    /// <summary>
    /// Method that creates a new thickness face set. The new ShellThicknessFaceSet is returned.
    /// </summary>
    /// <param name="Faces">Input FaceCollection object that contains faces that have a unique thickness defined.</param>
    /// <param name="Thickness">Input Variant that defines the unique thickness associated with the input Faces. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current distance units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    ShellThicknessFaceSet AddThicknessFaceSet([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection Faces, [In] [MarshalAs(UnmanagedType.Struct)] object Thickness);
    /// <summary>
    /// Method that returns a copy of the ShellDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ShellDefinition Copy();
}
