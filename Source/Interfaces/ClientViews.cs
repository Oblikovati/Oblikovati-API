namespace Oblikovati.API;

/// <summary>
/// The ClientViews collection object represents the collection of objects for a document/drawing sheet, along with the ability to add new views to the collection. See the article in the overviews section.
/// </summary>
public interface ClientViews : IEnumerable
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
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the specified object from the collection. This is the default property of the ClientViews collection object.
    /// </summary>
    ClientView Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that adds a new to the collection.
    /// </summary>
    /// <param name="HWND">Input Long that defines the hWnd for the window to add.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientView Add([In] int HWND);
    /// <summary>
    /// Add a new within a rectangular region of a window, identified by its hWnd. This allows multiple views in a single hWnd.
    /// </summary>
    /// <param name="HWND">Input Long that defines the hWnd for the window to add.</param>
    /// <param name="Left">Input Long that specifies the position of the left edge of the view.</param>
    /// <param name="Top">Input Long that specifies the position of the top edge of the view.</param>
    /// <param name="Width">Input Long that specifies the width of the view.</param>
    /// <param name="Height">Input Long that specifies the height of the view.</param>
    /// <returns></returns>
    [PreserveSig]
    ClientView AddBySubset([In] int HWND, [In] int Left, [In] int Top, [In] int Width, [In] int Height);
}
