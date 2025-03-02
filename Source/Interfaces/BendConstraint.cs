namespace Oblikovati.API;

/// <summary>
/// The BendConstraint object represents a bend constraint within a 3D sketch.
/// </summary>
public interface BendConstraint
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
    /// Property that returns the parent sketch of the object.
    /// </summary>
    Sketch3D Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Indicates whether this object can be deleted.
    /// </summary>
    bool Deletable { get; }
    /// <summary>
    /// Property that returns the SketchArc3D object associated with the bend.
    /// </summary>
    SketchArc3D Arc { get; }
    /// <summary>
    /// Property that returns the Sketch Line used to construct the bend feature.
    /// </summary>
    SketchLine3D LineOne { get; }
    /// <summary>
    /// Property that returns the Sketch Line used to construct the bend feature.
    /// </summary>
    SketchLine3D LineTwo { get; }
    /// <summary>
    /// Property that returns the parameter controlling the radius of the bend.
    /// </summary>
    Parameter Radius { get; }
    /// <summary>
    /// Method that deletes the constraint. In the case of coincident constraint, all the connected lines are disconnected and the constraint is deleted.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
