namespace Oblikovati.API;

/// <summary>
/// Object that stores client resource ids with theme related icons.
/// </summary>
public interface ClientResourceMap
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Represents a ClientResourceMaps collection Object.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Represents a ClientResourceMaps collection Object.
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Represents a ClientResourceMaps collection Object.
    /// </summary>
    string Description { get; set; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Represents a ClientResourceMaps collection Object.
    /// </summary>
    /// <param name="IconData">Input NameValueMap that specifies the icon data. The data includes a batch of icon info as below: Name = A unique string in this NameValueMap to indicate the name of an icon. This name is also used for browser node definition to specify a client icon. Value = IPictureDisp object that indicate an icon of 16 pixels wide and 16 pixels high.</param>
    /// <param name="Theme">Input String value that indicates a Theme name.</param>
    /// <param name="AsDefault">Optional  input Boolean value that specifies whether this icon data will be used as default icons for other Theme if no icon data is set for that Theme.</param>
    [PreserveSig]
    void SetBrowserIconData([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap IconData, [In] [MarshalAs(UnmanagedType.BStr)] string Theme, [In] [MarshalAs(UnmanagedType.Struct)] object? AsDefault = default);
    /// <summary>
    /// Represents a ClientResourceMaps collection Object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
