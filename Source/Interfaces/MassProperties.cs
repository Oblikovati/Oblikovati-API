namespace Oblikovati.API;

/// <summary>
/// The MassProperties object provides access to properties that provide read and write access to various mass property information.
/// </summary>
public interface MassProperties
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the volume of the model in database units.
    /// </summary>
    double Volume { get; set; }
    /// <summary>
    /// Property that returns the area of the entity.
    /// </summary>
    double Area { get; }
    /// <summary>
    /// Gets and sets the mass of the model in database units.
    /// </summary>
    double Mass { get; set; }
    /// <summary>
    /// Read-write property that gets/sets the desired level of computational accuracy of the mass property calculations.
    /// </summary>
    MassPropertiesAccuracyEnum Accuracy { get; set; }
    /// <summary>
    /// Indicates the computational accuracy of mass properties calculations.
    /// </summary>
    MassPropertiesAccuracyEnum AvailableAccuracy { get; }
    /// <summary>
    /// Property that gets the center of mass.
    /// </summary>
    Point CenterOfMass { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double _AccuracyValue { get; }
    /// <summary>
    /// Property that deterimines whether mass property calculations are cached with the component.
    /// </summary>
    bool CacheResultsOnCompute { get; set; }
    /// <summary>
    /// Gets and sets whether cosmetic welds should be included for mass property calculations.
    /// </summary>
    bool IncludeCosmeticWelds { get; set; }
    /// <summary>
    /// Gets and sets whether BOM quantity overrides should be used for assembly components to perform mass property calculations.
    /// </summary>
    bool IncludeQuantityOverrides { get; set; }
    /// <summary>
    /// Gets and sets whether the mass value is overridden.
    /// </summary>
    bool MassOverridden { get; set; }
    /// <summary>
    /// Gets and sets whether the volume value is overridden.
    /// </summary>
    bool VolumeOverridden { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Ixx">Ixx</param>
    /// <param name="Iyy">Iyy</param>
    /// <param name="Izz">Izz</param>
    /// <param name="Ixy">Ixy</param>
    /// <param name="Iyz">Iyz</param>
    /// <param name="Ixz">Ixz</param>
    [PreserveSig]
    void XYZMomentsOfInertia([Out] out double Ixx, [Out] out double Iyy, [Out] out double Izz, [Out] out double Ixy, [Out] out double Iyz, [Out] out double Ixz);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="I1">I1</param>
    /// <param name="I2">I2</param>
    /// <param name="I3">I3</param>
    [PreserveSig]
    void PrincipalMomentsOfInertia([Out] out double I1, [Out] out double I2, [Out] out double I3);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Kx">Kx</param>
    /// <param name="Ky">Ky</param>
    /// <param name="Kz">Kz</param>
    [PreserveSig]
    void RadiusOfGyration([Out] out double Kx, [Out] out double Ky, [Out] out double Kz);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AchievedAccuracyArea">AchievedAccuracyArea</param>
    /// <param name="AchievedAccuracyVolume">AchievedAccuracyVolume</param>
    [PreserveSig]
    void AchievedAccuracy([Out] out double AchievedAccuracyArea, [Out] out double AchievedAccuracyVolume);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Rx">Rx</param>
    /// <param name="Ry">Ry</param>
    /// <param name="Rz">Rz</param>
    [PreserveSig]
    void RotationToPrincipal([Out] out double Rx, [Out] out double Ry, [Out] out double Rz);
}
