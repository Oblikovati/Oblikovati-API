namespace Oblikovati.API;

/// <summary>
/// BIMConnectorLink object.
/// </summary>
public interface BIMConnectorLink
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
    /// Read-only property that gets the first of two connectors that this link is between.
    /// </summary>
    BIMConnector ConnectorOne { get; }
    /// <summary>
    /// Read-only property that gets the first of two connectors that this link is between.
    /// </summary>
    BIMConnector ConnectorTwo { get; }
    /// <summary>
    /// Read-write property that gets and sets the displayed name of the connectorlink.&nbsp;This is the name that is visible in the browser and is editable by the end-user.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Method that deletes the connectorlink.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
