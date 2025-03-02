namespace Oblikovati.API;

/// <summary>
/// The DrawingBOMs collection object returns the collection of all locally stored BOMs in the drawing document.
/// </summary>
public interface DrawingBOMs : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified DrawingBOM object from the collection.
    /// </summary>
    DrawingBOM Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that returns whether BOM properties have been defined in the drawing for the input model.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies a model document.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsDrawingBOMDefined([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}
