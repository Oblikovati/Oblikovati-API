namespace Oblikovati.API;

/// <summary>
/// The TextureMaps collection returns all the texture maps applied to a face. There could be multiple maps that are 'wrapped' around a face.
/// </summary>
public interface TextureMaps : IEnumerable
{
    /// <summary>
    /// Returns the specified object from the collection.
    /// </summary>
    TextureMap this[int Index] { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
}
