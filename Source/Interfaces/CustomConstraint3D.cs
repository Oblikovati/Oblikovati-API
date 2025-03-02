namespace Oblikovati.API;

/// <summary>
/// The CustomConstraint3D object represents a custom constraint for a 3D sketch entity.
/// </summary>
public interface CustomConstraint3D
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
    /// Property that returns the entity to which this custom constraint has been applied.
    /// </summary>
    SketchEntity3D Entity { get; }
    /// <summary>
    /// Property that returns the string that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".
    /// </summary>
    string ClientId { get; }
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
