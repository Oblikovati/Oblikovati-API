namespace Oblikovati.API;

/// <summary>
/// The DeleteFaceFeatures object represents a collection of objects on a part.
/// </summary>
public interface DeleteFaceFeatures : IEnumerable
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
    /// Returns the specified DeleteFaceFeature object from the collection.
    /// </summary>
    DeleteFaceFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new DeleteFaceFeature. The new created DeleteFaceFeature is returned.
    /// </summary>
    /// <param name="FacesToDelete">Input object that defines the faces to be deleted. This can either be a FaceCollection or a FaceShell object. If a FaceShell is specified, and it defines a void, this method deletes the void and restores mass to the model. If the FaceShell does not define a void, it results in the deletion of all the faces of the lump that this FaceShell belongs to.</param>
    /// <param name="Heal">Optional input Boolean that specifies whether or not to attempt to heal gaps by extending adjacent faces until they intersect. If specified, this input is used only if a collection of faces is provided in the Faces argument. The default value is False indicating that the faces will not be healed.</param>
    /// <returns></returns>
    [PreserveSig]
    DeleteFaceFeature Add([In] [MarshalAs(UnmanagedType.IDispatch)] object FacesToDelete, [In] bool? Heal = false);
}
