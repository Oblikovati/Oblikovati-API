namespace Oblikovati.API;

/// <summary>
/// The Materials collection object allows for the creation of new objects and provides access to existing Material objects.
/// </summary>
public interface Materials : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property returning the parent Document object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns the specified Material object from the collection.
    /// </summary>
    Material Item { get; }
    /// <summary>
    /// Property that returns the number of Material objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new Material object. The density is specified during creation and all other material attributes default to zero. To specify any of the other material attributes you can use the properties supported by the Material object.
    /// </summary>
    /// <param name="Name">Input String that specifies the name of the material. The name must be unique with respect to the other materials in the collection. If the name is not unique an error will occur.</param>
    /// <param name="Density">Input Double that specifies the density of the material. The density is mass per unit volume. The units used to define density are g/cm3 (grams/cubic centimeter).</param>
    /// <returns></returns>
    [PreserveSig]
    Material Add([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] double Density);
}
