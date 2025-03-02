namespace Oblikovati.API;

/// <summary>
/// Represents a search box in the browser.
/// </summary>
public interface SearchBox
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    BrowserPane Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns a SearchBoxEvents object.
    /// </summary>
    SearchBoxEvents SearchBoxEvents { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the search box is enabled or not.
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Read-only property that returns the search box filter. This could be a bit-mask defining various of filters. Set this to 0 will clear the search filter.
    /// </summary>
    SearchBoxFilterEnum SearchFilter { get; }
    /// <summary>
    /// Read-only property that returns the search text.
    /// </summary>
    string SearchText { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the search box is displayed or hidden.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Method that start to search text.
    /// </summary>
    [PreserveSig]
    void Search([In] [MarshalAs(UnmanagedType.BStr)] string SearchText, [In] [MarshalAs(UnmanagedType.Struct)] object? SearchOptions = default);
}
