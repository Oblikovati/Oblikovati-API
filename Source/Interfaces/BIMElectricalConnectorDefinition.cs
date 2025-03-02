namespace Oblikovati.API;

/// <summary>
/// BIMElectricalConnectorDefinition object.
/// </summary>
public interface BIMElectricalConnectorDefinition
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
    /// Read-write property that gets and sets the apparent load associated with this connector.
    /// </summary>
    double ApparentLoad { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the phase 1 apparent load associated with this connector.
    /// </summary>
    double ApparentLoadPhase1 { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the phase 2 apparent load associated with this connector.
    /// </summary>
    double ApparentLoadPhase2 { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the phase 3 apparent load associated with this connector.
    /// </summary>
    double ApparentLoadPhase3 { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the description of this connector.
    /// </summary>
    string Description { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether or not there is a motor associated with this connector.
    /// </summary>
    bool HasMotor { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the load classification associated with this connector.
    /// </summary>
    string LoadClassification { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the number of poles associated with this connector.&nbsp;Valid values are 1, 2, or 3.
    /// </summary>
    int NumberOfPoles { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the power factor associated with this connector.
    /// </summary>
    double PowerFactor { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the power factor associated with this connector.
    /// </summary>
    BIMElectricalPowerFactorStateEnum PowerFactorState { get; set; }
    /// <summary>
    /// Read-write property that specifies the system type for this connector.
    /// </summary>
    BIMElectricalSystemTypeEnum SystemType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the voltage associated with this connector.&nbsp;The units of voltage is the Volt.
    /// </summary>
    double Voltage { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if expose the apparent load as parameter.
    /// </summary>
    bool ExposeApparentLoadAsParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the apparent load with expression or parameter.
    /// </summary>
    object ApparentLoadParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if expose the apparent load phase 1 as parameter.
    /// </summary>
    bool ExposeApparentLoadPhase1AsParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the apparent load phase 1 with expression or parameter.
    /// </summary>
    object ApparentLoadPhase1Parameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if expose the apparent load phase 2 as parameter.
    /// </summary>
    bool ExposeApparentLoadPhase2AsParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the apparent load phase 2 with expression or parameter.
    /// </summary>
    object ApparentLoadPhase2Parameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if expose the apparent load phase 3 as parameter.
    /// </summary>
    bool ExposeApparentLoadPhase3AsParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the apparent load phase 3 with expression or parameter.
    /// </summary>
    object ApparentLoadPhase3Parameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if expose the number of poles as parameter.
    /// </summary>
    bool ExposeNumberOfPolesAsParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the number of poles with expression or parameter.
    /// </summary>
    object NumberOfPolesParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if expose the voltage as parameter.
    /// </summary>
    bool ExposeVoltageAsParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the voltage with expression or parameter.
    /// </summary>
    object VoltageParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if expose the load classification as parameter.
    /// </summary>
    bool ExposeLoadClassificationAsParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the load classification with expression or parameter.
    /// </summary>
    object LoadClassificationParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if expose the HasMotor as parameter.
    /// </summary>
    bool ExposeHasMotorAsParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the HasMotor with Boolean value or parameter.
    /// </summary>
    object HasMotorParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if expose the power factor as parameter.
    /// </summary>
    bool ExposePowerFactorAsParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the power factor with expression or parameter.
    /// </summary>
    object PowerFactorParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets if expose the description as parameter.
    /// </summary>
    bool ExposeDescriptionAsParameter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the description with expression or parameter.
    /// </summary>
    object DescriptionParameter { get; set; }
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
