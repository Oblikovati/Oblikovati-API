namespace Oblikovati.API;

/// <summary>
/// The ASideFaceDefinition object provides the properties and methods for this object.
/// </summary>
public interface ASideDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    SheetMetalComponentDefinition Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the status of the A-side face.
    /// </summary>
    ASideFaceStatusEnum Status { get; }
    /// <summary>
    /// Read-only property that returns all the faces that are tangentially connected with each other to define the A-side face definition, includes the ASideFace.
    /// </summary>
    Faces Faces { get; }
    /// <summary>
    /// Read-only property that returns the face object that is used to define the A-side face definition.
    /// </summary>
    Face ASideFace { get; }
    /// <summary>
    /// Method that deletes this ASideFaceDefinition object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
