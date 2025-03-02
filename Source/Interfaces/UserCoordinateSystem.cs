namespace Oblikovati.API;

/// <summary>
/// The UserCoordinateSystem object represents a user coordinate system.
/// </summary>
public interface UserCoordinateSystem
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Property that returns whether this object is owned by a feature (such as a ClientFeature). If True, the OwnedBy property returns the feature.
    /// </summary>
    bool IsOwnedByFeature { get; }
    /// <summary>
    /// Property that returns the PartFeature object that owns this object. This property returns Nothing if the IsOwnedByFeature property returns False.
    /// </summary>
    PartFeature OwnedBy { get; }
    /// <summary>
    /// Property that returns the parent ComponentDefinition object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Gets and sets the name of the UserCoordinateSystem.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the work point that represents the origin of the coordinate system.
    /// </summary>
    WorkPoint Origin { get; }
    /// <summary>
    /// Gets and sets the transformation matrix for the coordinate system.
    /// </summary>
    Matrix Transformation { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the visibility of the coordinate system.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns the parameter associated with the rotation angle about the x-axis.
    /// </summary>
    Parameter XAngle { get; }
    /// <summary>
    /// Property that returns the work axis that represents the x-axis of the coordinate system.
    /// </summary>
    WorkAxis XAxis { get; }
    /// <summary>
    /// Property that returns the parameter associated with the X offset value.
    /// </summary>
    Parameter XOffset { get; }
    /// <summary>
    /// Property that returns the parameter associated with the rotation angle about the y-axis.
    /// </summary>
    Parameter YAngle { get; }
    /// <summary>
    /// Property that returns the work axis that represents the y-axis of the coordinate system.
    /// </summary>
    WorkAxis YAxis { get; }
    /// <summary>
    /// Property that returns the parameter associated with the Y offset value.
    /// </summary>
    Parameter YOffset { get; }
    /// <summary>
    /// Property that returns the parameter associated with the rotation angle about the z-axis.
    /// </summary>
    Parameter ZAngle { get; }
    /// <summary>
    /// Property that returns the work axis that represents the z-axis of the coordinate system.
    /// </summary>
    WorkAxis ZAxis { get; }
    /// <summary>
    /// Property that returns the parameter associated with the Z offset value.
    /// </summary>
    Parameter ZOffset { get; }
    /// <summary>
    /// Property that returns the work plane that represents the X-Y plane of the coordinate system.
    /// </summary>
    WorkPlane XYPlane { get; }
    /// <summary>
    /// Property that returns the work plane that represents the X-Z plane of the coordinate system.
    /// </summary>
    WorkPlane XZPlane { get; }
    /// <summary>
    /// Property that returns the work plane that represents the Y-Z plane of the coordinate system.
    /// </summary>
    WorkPlane YZPlane { get; }
    /// <summary>
    /// Property that returns the UserCoordinateSystemDefinition object that can be used to get and set the inputs for the coordinate system and redefine the coordinate system.
    /// </summary>
    UserCoordinateSystemDefinition Definition { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the UserCoordinateSystem.
    /// </summary>
    /// <param name="RetainDependentFeaturesAndSketches">Optional input Boolean that specifies whether to retain dependent features and sketches. Defaults to False.</param>
    /// <param name="RetainDependentWorkFeatures">Optional input Boolean that specifies whether to retain dependent work features. Defaults to False.</param>
    [PreserveSig]
    void Delete([In] bool? RetainDependentFeaturesAndSketches = false, [In] bool? RetainDependentWorkFeatures = false);
    /// <summary>
    /// Method that repositions the end of part marker relative to the object.
    /// </summary>
    /// <param name="Before">Input Boolean that specifies whether to position the end of part marker before or after the object.</param>
    [PreserveSig]
    void SetEndOfPart([In] bool Before);
}
