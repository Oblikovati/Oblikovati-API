namespace Oblikovati.API;

/// <summary>
/// BIMConnectors object.
/// </summary>
public interface BIMConnectors : IEnumerable
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
    BIMConnector this[object Index] { get; }
    /// <summary>
    /// Method that creates a new BIMConnector.&nbsp;The type of connector definition supplied will determine the type of connector created.&nbsp;The new BIMConnector is returned.
    /// </summary>
    /// <param name="Definition">Input definition object that defines all of the required inputs to create a new connector.</param>
    /// <param name="Name">Defines the name of the new connector.  It must be unique with respect to all existing connectors.  If not provided, or an empty string is supplied then BIM Exchange will generate a default name.</param>
    /// <returns></returns>
    [PreserveSig]
    BIMConnector Add([In] [MarshalAs(UnmanagedType.Interface)] BIMConnectorDefinition Definition, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Method that creates a new cable tray connector definition.&nbsp;The created definition object defines the inputs to create a cable tray connector and is used as input to the Add method of the BIMConnectors object to create a new connector.
    /// </summary>
    /// <param name="Geometry">Input object collection that contains the geometry that defines the shape of the connector. When the specified shape is rectangular, valid input includes a single rectangular face or four linear edges on a planar face that define a rectangle. These edges do not need to connect but two of them need to be parallel to each other and perpendicular to the other two edge. For example, the picture below illustrates four valid lines and the resulting rectangle.
    /// When the specified shape is undefined, valid input includes the input described above for a rectangular shape but also allows a circular planar face, a circular edge (it can be an arc), a planar face that has a slot shape, or four edges that define a slot or oval shape, as illustrated below.</param>
    /// <param name="ConnectorShape">Input value that specifies the shape of the connector.  This setting affects how the geometry is evaluated to determine the shape of the connector.  The following inputs are valid for a cable tray connector: kRectangularShapeConnector or kUndefinedShapeConnector</param>
    /// <returns></returns>
    [PreserveSig]
    BIMCableTrayConnectorDefinition CreateCableTrayConnectorDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Geometry, [In] BIMConnectorShapeEnum ConnectorShape);
    /// <summary>
    /// Method that creates a new conduit connector definition.&nbsp;The created definition object defines the inputs to create a conduit connector and is used as input to the Add method of the BIMConnectors object to create a new conduit connector.
    /// </summary>
    /// <param name="Geometry">Input object collection that contains the geometry that defines the shape of the connector. When the specified shape is circular, valid input includes a single circular face or a circular edge (it can be an arc).
    /// When the specified shape is undefined, valid input includes the input described above for a rectangular shape but also allows a rectangular planar face, four edges that define a rectangle as illustrated below.
    /// a planar face that has a slot shape, or four edges that define a slot or oval shape, as illustrated below.</param>
    /// <param name="ConnectorShape">Input value that specifies the shape of the connector.  This setting affects how the geometry is evaluated to determine the shape of the connector.  The following inputs are valid for a conduit connector: kCircularShapeConnector or kUndefinedShapeConnector</param>
    /// <returns></returns>
    [PreserveSig]
    BIMConduitConnectorDefinition CreateConduitConnectorDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Geometry, [In] BIMConnectorShapeEnum ConnectorShape);
    /// <summary>
    /// Method that creates a new duct connector definition.&nbsp;The created definition object defines the inputs to create a duct connector and is used as input to the Add method of the BIMConnectors object to create a new connector.
    /// </summary>
    /// <param name="Geometry">Input object collection that contains the geometry that defines the shape of the connector. When the specified shape is rectangular, valid input includes a single rectangular face or four linear edges on a planar face that define a rectangle. These edges do not need to connect but two of them need to be parallel to each other and perpendicular to the other two edge. For example, the picture below illustrates four valid lines and the resulting rectangle.
    /// When the specified shape is oval, valid input includes a face that defines an oval or four edges that define an oval as illustrated below.
    /// When the specified shape is circular, valid input includes a single circular face or a circular edge (it can be an arc). When the specified shape is undefined, valid input includes any of the above.</param>
    /// <param name="ConnectorShape">Input value that specifies the shape of the connector.  This setting affects how the geometry is evaluated to determine the shape of the connector.  The following inputs are valid for a duct connector: kRectangularShapeConnector, kCircularShapeConnector, kOvalShapeConnector or kUndefinedShapeConnector</param>
    /// <returns></returns>
    [PreserveSig]
    BIMDuctConnectorDefinition CreateDuctConnectorDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Geometry, [In] BIMConnectorShapeEnum ConnectorShape);
    /// <summary>
    /// Method that creates a new electrical connector definition.&nbsp;The created definition object defines the inputs to create a electrical connector and is used as input to the Add method of the BIMConnectors object to create a new connector.
    /// </summary>
    /// <param name="Geometry">Input object collection that contains the geometry that defines the shape of the connector. Valid input includes:
    /// Single circular face.
    /// Circular edge (it can be an arc)
    /// Rectangular planar face.
    /// Four edges that define a rectangle as illustrated below.
    /// Planar face that has a slot shape.
    /// Four edges that define a slot or oval shape, as illustrated below.</param>
    /// <returns></returns>
    [PreserveSig]
    BIMElectricalConnectorDefinition CreateElectricalConnectorDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Geometry);
    /// <summary>
    /// Method that creates a new pipe connector definition.&nbsp;The created definition object defines the inputs to create a pipe connector and is used as input to the Add method of the BIMConnectors object to create a new connector.
    /// </summary>
    /// <param name="Geometry">Input object collection that contains the geometry that defines the shape of the connector. When the specified shape is circular, valid input includes a single circular face or a circular edge (it can be an arc).
    /// When the specified shape is undefined, valid input includes the input described above for a rectangular shape but also allows a rectangular planar face, four edges that define a rectangle as illustrated below:
    /// a planar face that has a slot shape, or four edges that define a slot or oval shape, as illustrated below.</param>
    /// <param name="ConnectorShape">Input value that specifies the shape of the connector.  This setting affects how the geometry is evaluated to determine the shape of the connector.  The following inputs are valid for a pipe connector: kCircularShapeConnector or kUndefinedShapeConnector.</param>
    /// <returns></returns>
    [PreserveSig]
    BIMPipeConnectorDefinition CreatePipeConnectorDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Geometry, [In] BIMConnectorShapeEnum ConnectorShape);
}
