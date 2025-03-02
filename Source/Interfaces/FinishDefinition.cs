namespace Oblikovati.API;

/// <summary>
/// The FinishDefinition object represents all of the information that defines a finish feature.
/// </summary>
public interface FinishDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that gets and sets the appearance for the finish feature.
    /// </summary>
    Asset Appearance { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the comment for the finish feature.
    /// </summary>
    string Comment { get; set; }
    /// <summary>
    /// Read-write property that provides access to the depth of the feature.
    /// </summary>
    string Depth { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the description for the finish feature.
    /// </summary>
    string Description { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the finish type for the finish feature.
    /// </summary>
    FinishTypeEnum FinishType { get; set; }
    /// <summary>
    /// Read-write property that provides access to the hardness of the feature.
    /// </summary>
    object Hardness { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the faces on which the finish feature is created.
    /// </summary>
    FaceCollection InputFaces { get; set; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    FinishFeature Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the process name for the finish feature.
    /// </summary>
    string ProcessName { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the short description for the finish feature.
    /// </summary>
    string ShortDescription { get; set; }
    /// <summary>
    /// Read-write property that provides access to the thickness of the feature.
    /// </summary>
    object Thickness { get; set; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a copy of this FinishDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    FinishDefinition Copy();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PropertyNames">PropertyNames</param>
    /// <param name="Disabled">Disabled</param>
    [PreserveSig]
    void DisableProperties([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] PropertyNames, bool Disabled);
    /// <summary>
    /// Method that returns whether the specified property is disabled or not.
    /// </summary>
    /// <param name="PropertyName">Input String value that specifies the property name to get its disabled status. The property name can be:
    /// Appearance
    /// Comment
    /// Description
    /// ShortDescription
    /// Thickness
    /// Hardness
    /// Depth</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsPropertyDisabled([MarshalAs(UnmanagedType.BStr)] string PropertyName);
}
