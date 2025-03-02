namespace Oblikovati.API;

/// <summary>
/// The CosmeticWelds object provides access to all the existing objects within a weldment.
/// </summary>
public interface CosmeticWelds : IEnumerable
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
    /// Property that returns the number of items in the collection
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified CosmeticWeld object from the collection.
    /// </summary>
    CosmeticWeld this[object Index] { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CosmeticWeldDefinition">CosmeticWeldDefinition</param>
    [PreserveSig]
    CosmeticWeld Add([In] [MarshalAs(UnmanagedType.Interface)] CosmeticWeldDefinition CosmeticWeldDefinition);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Edges">Edges</param>
    [PreserveSig]
    CosmeticWeldDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection Edges);
}
