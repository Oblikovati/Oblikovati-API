namespace Oblikovati.API;

/// <summary>
/// The HoleTableRows collection object provides access to the existing collection of HoleTableRow objects.
/// </summary>
public interface HoleTableRows : IEnumerable
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
    /// Returns the specified row object from the collection.
    /// </summary>
    HoleTableRow this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that adds a row to the table.
    /// </summary>
    /// <param name="Hole">Input object that specifies the hole to be added to the table. This can either be a DrawingCurve object (which represents the geometry of the hole to be added) or a Centermark object. The method returns an error if the input DrawingCurve does not represent a hole. For view based and feature type based hole tables, the method returns an error if the input hole feature type is not included in the hole table.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleTableRow Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Hole);
}
