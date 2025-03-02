namespace Oblikovati.API;

/// <summary>
/// BIMConnectorLinks object.
/// </summary>
public interface BIMConnectorLinks : IEnumerable
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
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified BIMConnector object from the collection.
    /// </summary>
    BIMConnectorLink this[object Index] { get; }
    /// <summary>
    /// Method that creates a new BIMConnectorLink.The new BIMConnectorLink is returned.
    /// </summary>
    /// <param name="ConnectorOne">Input BIMConnector that defines the first of two connectors to be connected by the link.</param>
    /// <param name="ConnectorTwo">Input BIMConnector that defines the second of two connectors to be connected by the link.</param>
    /// <returns></returns>
    [PreserveSig]
    BIMConnectorLink Add([In] [MarshalAs(UnmanagedType.Interface)] BIMConnector ConnectorOne, [In] [MarshalAs(UnmanagedType.Interface)] BIMConnector ConnectorTwo);
}
