namespace Oblikovati.API;

/// <summary>
/// BIMConnector object.
/// </summary>
public interface BIMConnector
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
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    BIMComponent Parent { get; }
    /// <summary>
    /// Read-only property that gets the definition object associated with this connector.
    /// </summary>
    BIMConnectorDefinition Definition { get; }
    /// <summary>
    /// Read-only property that returns the type of definition associated with this connector.&nbsp;This property lets you determine what type of connector this object represents.
    /// </summary>
    BIMConnectorDefinitionTypeEnum DefinitionType { get; }
    /// <summary>
    /// Read-write property that gets and sets the displayed name of the connector.&nbsp;This is the name that is visible in the browser and is editable by the end-user.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Read-write property that defines whether the connector is suppressed or not.&nbsp;A value of True indicates the connector is suppressed.
    /// </summary>
    bool Suppressed { get; set; }
    /// <summary>
    /// Read-only property that returns whether the attachment is missing or not.
    /// </summary>
    bool MissingAttachment { get; }
    /// <summary>
    /// Method that deletes the connector.
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
