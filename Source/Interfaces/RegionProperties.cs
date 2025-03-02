namespace Oblikovati.API;

/// <summary>
/// The RegionProperties object. This object provides information relating to a profile region, including centroid, perimeter, rotation angle, moments of inertia, and axes.
/// </summary>
public interface RegionProperties
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Get and sets the desired accuracy of calculations.
    /// </summary>
    AccuracyEnum Accuracy { get; set; }
    /// <summary>
    /// Property that returns the area of the section in database units.
    /// </summary>
    double Area { get; }
    /// <summary>
    /// Property that returns the perimeter of the section in database units.
    /// </summary>
    double Perimeter { get; }
    /// <summary>
    /// Property that returns the centroid of the section.
    /// </summary>
    object Centroid { get; }
    /// <summary>
    /// Property that returns the angle of rotation of the principal axes.
    /// </summary>
    double RotationAngle { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="XAxis">XAxis</param>
    /// <param name="YAxis">YAxis</param>
    [PreserveSig]
    void PrincipalAxes([Out] [MarshalAs(UnmanagedType.Interface)] out Vector XAxis, [Out] [MarshalAs(UnmanagedType.Interface)] out Vector YAxis);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Ix">Ix</param>
    /// <param name="Iy">Iy</param>
    /// <param name="Iz">Iz</param>
    [PreserveSig]
    void PrincipalMomentsOfInertia([Out] out double Ix, [Out] out double Iy, [Out] out double Iz);
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
    void MomentsOfInertia([Out] out double Ixx, [Out] out double Iyy, [Out] out double Izz, [Out] out double Ixy, [Out] out double Iyz, [Out] out double Ixz);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Kxx">Kxx</param>
    /// <param name="Kyy">Kyy</param>
    /// <param name="Kzz">Kzz</param>
    [PreserveSig]
    void RadiusOfGyration([Out] out double Kxx, [Out] out double Kyy, [Out] out double Kzz);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Torsion">Torsion</param>
    /// <param name="WorstStressValue">WorstStressValue</param>
    /// <param name="WorstStressPosition">WorstStressPosition</param>
    /// <param name="FiniteElementNodeCount">FiniteElementNodeCount</param>
    [PreserveSig]
    void GetTorsionProperties([Out] out double Torsion, [Out] out double WorstStressValue, [Out] [MarshalAs(UnmanagedType.Interface)] out Point WorstStressPosition, [In] int? FiniteElementNodeCount = default);
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
    void CentroidMomentsOfInertia([Out] out double Ixx, [Out] out double Iyy, [Out] out double Izz, [Out] out double Ixy, [Out] out double Iyz, [Out] out double Ixz);
}
