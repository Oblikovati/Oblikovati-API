namespace Oblikovati.API;

/// <summary>
/// The SurfaceBodyDefinition represents a transient definition of a B-Rep object.
/// </summary>
public interface SurfaceBodyDefinition
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
    /// Property that returns the collection of EdgeDefinition objects associated with this SurfaceBodyDefinition object.
    /// </summary>
    EdgeDefinitions EdgeDefinitions { get; }
    /// <summary>
    /// Property that returns the collection of LumpDefinition objects associated with this SurfaceBodyDefinition object. The primary use of the LumpDefinitions collection is to create new LumpDefinition objects.
    /// </summary>
    LumpDefinitions LumpDefinitions { get; }
    /// <summary>
    /// Property that returns the collection of VertexlDefinition objects associated with this SurfaceBodyDefinition object. The primary use of the VertexDefinitions collection is to create new VertexDefinition objects.
    /// </summary>
    VertexDefinitions VertexDefinitions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Errors">Errors</param>
    /// <param name="Options">Options</param>
    [PreserveSig]
    SurfaceBody CreateTransientSurfaceBody([Out] [MarshalAs(UnmanagedType.Interface)] out NameValueMap Errors, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
