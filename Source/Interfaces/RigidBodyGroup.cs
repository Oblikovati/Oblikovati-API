namespace Oblikovati.API;

/// <summary>
/// RigidBodyGroup Object.
/// </summary>
public interface RigidBodyGroup
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
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    RigidBodyGroups Parent { get; }
    /// <summary>
    /// Property that specifies if the group behaves as a grounded body or not. Returns True if the group is grounded.
    /// </summary>
    bool Grounded { get; }
    /// <summary>
    /// Property that returns the collection of occurrences that are in the group. A group can consist of a single occurrence.
    /// </summary>
    ComponentOccurrencesEnumerator Occurrences { get; }
    /// <summary>
    /// Read-only property that returns the unique group identifier.
    /// </summary>
    int GroupID { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Occurrences">Occurrences</param>
    /// <param name="States">States</param>
    [PreserveSig]
    void GetOccurrencesAndStates([Out] [MarshalAs(UnmanagedType.Interface)] out ComponentOccurrencesEnumerator Occurrences, [Out] [MarshalAs(UnmanagedType.SafeArray)] out OccurrenceDOFStateEnum[] States);
}
