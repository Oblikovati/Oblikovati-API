namespace Oblikovati.API;

/// <summary>
/// The Lights collection object allows for the creation of new Light objects and provides access to existing model space and view space lights.
/// </summary>
public interface Lights : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the specified Light from the collection.
    /// </summary>
    Light Item { get; }
    /// <summary>
    /// Property that returns the number of Light objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new Light object.
    /// </summary>
    /// <param name="LightType">Specifies the light type - model space or view space.</param>
    /// <returns></returns>
    [PreserveSig]
    Light Add([In] LightTypeEnum LightType);
}
