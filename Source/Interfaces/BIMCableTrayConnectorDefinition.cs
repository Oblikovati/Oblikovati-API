namespace Oblikovati.API;

/// <summary>
/// BIMCableTrayConnectorDefinition object.
/// </summary>
public interface BIMCableTrayConnectorDefinition
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
    /// Property that returns the parent BIMConnector that this definition is associated with.&nbsp;If the definition was created using one of the Create methods this property will return Nothing since the definition isn’t associated with a connector yet.
    /// </summary>
    BIMConnector Parent { get; }
    /// <summary>
    /// Read-only property that specifies the shape of the connector.&nbsp;To change the shape, use the SetShape method.
    /// </summary>
    BIMConnectorShapeEnum ConnectorShape { get; }
    /// <summary>
    /// Read-only property that indicates the direction of the connection.&nbsp;This property will return Nothing in the case where a valid set of referenced geometries have not yet been defined.
    /// </summary>
    UnitVector Direction { get; }
    /// <summary>
    /// Read-only property that gets the geometry that defines the shape of the connection.&nbsp;The returned collection is independent of the connector and any changes made to the contents of the collection will not affect the connector.&nbsp;To change the geometry or the shape of the connector use the SetShape method.
    /// </summary>
    ObjectCollection Geometry { get; }
    /// <summary>
    /// Read-only property that returns the origin of the connector.
    /// </summary>
    Point Origin { get; }
    /// <summary>
    /// Read-write property that gets and sets the connection type for this connector.
    /// </summary>
    BIMCableTrayConnectionTypeEnum ConnectionType { get; set; }
    /// <summary>
    /// Read-only property that provides access to the connector height. When the BIMCableTrayConnectorDefinition object has been created using the CreateCableTrayConnectorDefinition method, this property returns a Double indicating the height, (in centimeters), of the connector as defined by the input geometry. After the definition object has been used to create a connector, this property returns a parameter that defines the height of the connector.
    /// To change the height of an existing connector you can either edit the geometry that’s controlling the height or set the override height using the HeightOverride property.
    /// </summary>
    object Height { get; }
    /// <summary>
    /// Read-write property that gets and sets the height override for this connector.
    /// </summary>
    object HeightOverride { get; set; }
    /// <summary>
    /// Read-only property that provides access to the connector width. When the BIMCableTrayConnectorDefinition object has been created using the CreateCableTrayConnectorDefinition method, this property returns a Double indicating the width, (in centimeters), of the connector as defined by the input geometry. After the definition object has been used to create a connector, this property returns a parameter that defines the width of the connector.
    /// To change the width of an existing connector you can either edit the geometry that’s controlling the width or set the override width using the WidthOverride property.
    /// </summary>
    object Width { get; }
    /// <summary>
    /// Read-write property that gets and sets the width override for this connector.
    /// </summary>
    object WidthOverride { get; set; }
    /// <summary>
    /// Read-only property that returns the direction of the connector height. This returns Nothing in the case where the height has not yet been defined.
    /// </summary>
    UnitVector HeightDirection { get; }
    /// <summary>
    /// Read-only property that returns the direction of the connector width. This returns Nothing in the case where the width has not yet been defined.
    /// </summary>
    UnitVector WidthDirection { get; }
    /// <summary>
    /// Method that will reverse the direction of the connection.
    /// </summary>
    [PreserveSig]
    void ReverseDirection();
    /// <summary>
    /// Method that used to set the shape of the connector.
    /// </summary>
    /// <param name="Geometry">Input ObjectCollection that specifies the set of geometry used to define the connector position and shape.</param>
    /// <param name="ConnectorShape">Input value that indicates the desired shape of the connector and how the geometry is to be evaluated. Valid values for the various types of connectors is shown below.
    /// Cable tray connectors: kRectangularShapeConnector or kUndefinedShapeConnector
    /// Conduit connectors: kCircularShapeConnector or kUndefinedShapeConnector
    /// Duct connectors: kRectangularShapeConnector, kCircularShapeConnector, kOvalShapeConnector or kUndefinedShapeConnector
    /// Electrical connectors: kUndefinedShapeConnector
    /// Pipe connectors: kCircularShapeConnector or kUndefinedShapeConnector
    /// The input geometry for the various shapes can be the following:
    /// Circular shape
    /// Single circular face.
    /// Circular edge (it can be an arc)
    /// Rectangular shape
    /// Rectangular planar face.
    /// Four edges that define a rectangle as illustrated below.
    /// Slot shape
    /// Planar face that has a slot shape.
    /// Four edges that define a slot or oval shape, as illustrated below</param>
    [PreserveSig]
    void SetShape([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Geometry, [In] BIMConnectorShapeEnum? ConnectorShape = BIMConnectorShapeEnum.kUndefinedShapeConnector);
}
