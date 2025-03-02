namespace Oblikovati.API;

/// <summary>
/// The SheetMetalStyles collection object provides access to all of the objects in a part component definition and provides methods to create additional sheet metal styles.
/// </summary>
public interface SheetMetalStyles : IEnumerable
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
    /// Method that returns the specified SheetMetalStyle object from the collection.
    /// </summary>
    SheetMetalStyle Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ExistingStyle">ExistingStyle</param>
    /// <param name="NewStyleName">NewStyleName</param>
    [PreserveSig]
    SheetMetalStyle Copy([In] [MarshalAs(UnmanagedType.Interface)] SheetMetalStyle ExistingStyle, [In] [MarshalAs(UnmanagedType.BStr)] string NewStyleName);
}
