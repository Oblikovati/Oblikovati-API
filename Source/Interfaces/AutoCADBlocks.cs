namespace Oblikovati.API;

/// <summary>
/// The AutoCADBlocks collection object provides access to the instances of the blocks on a specific sheet. It also provides the ability to place blocks onto a sheet.
/// </summary>
public interface AutoCADBlocks : IEnumerable
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
    /// Returns the specified AutoCADBlock object from the collection.
    /// </summary>
    AutoCADBlock this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that places an AutoCAD block onto the sheet.
    /// </summary>
    /// <param name="Definition">AutoCADBlockDefinition object to use for placing the block.</param>
    /// <param name="Position">Point2d that specifies the location on the sheet to place the block instance.</param>
    /// <param name="Rotation">Optional input double that specifies the rotation angle in radians.</param>
    /// <param name="Scale">Optional input double that specifies the scale.</param>
    /// <param name="PromptStrings">Optional input array of strings to use as input for prompted text fields that my be present in the block definition.</param>
    /// <param name="Static">Optional input Boolean that indicates whether to show the scale and rotation grip points on the block. If True, the grip points are disabled. If not specified, a value of False is used.</param>
    /// <returns></returns>
    [PreserveSig]
    AutoCADBlock Add([In] [MarshalAs(UnmanagedType.Interface)] AutoCADBlockDefinition Definition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] double? Rotation = default, [In] double? Scale = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PromptStrings = default, [In] bool? Static = false);
}
