namespace Oblikovati.API;

/// <summary>
/// ParallelToZAxisConstraint3D Object.
/// </summary>
public interface ParallelToZAxisConstraint3D
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
    /// Read-only property that returns the SketchLine3D being constrained.
    /// </summary>
    SketchLine3D Line { get; }
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
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
