namespace Oblikovati.API;

/// <summary>
/// The SurfaceGraphicsFaceList object contains a list of faces currently displayed by a SurfaceGraphics primitive and allows you to add faces to the list.
/// </summary>
public interface SurfaceGraphicsFaceList : IEnumerable
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
    /// Property that returns the number of SurfaceGraphicsFace objects in the list.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns a SurfaeGraphicsFace object.
    /// </summary>
    SurfaceGraphicsFace Item { get; }
    /// <summary>
    /// Method that specifies additional faces to be displayed.
    /// </summary>
    /// <param name="Faces">Input object that defines the additional faces to display. This can be one of the following: Face, Faces or a FaceCollection object. The faces provided must belong to the SurfaceBody associated with the SurfaceGraphics, else an error will occur.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Faces);
    /// <summary>
    /// Method that removes a face from the list. The face will no longer be displayed.
    /// </summary>
    /// <param name="Index">Input Long that specifies the SurfaceGraphicsFace to remove from the list.</param>
    [PreserveSig]
    void Remove([In] int Index);
    /// <summary>
    /// Method that removes all the faces from the list. No faces will be displayed after the method is called.
    /// </summary>
    [PreserveSig]
    void Clear();
}
