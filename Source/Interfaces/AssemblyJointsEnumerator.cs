namespace Oblikovati.API;

/// <summary>
/// Provides access to the joints acting directly on a particular occurrence. This object may also be used wherever a snapshot of a set of assembly joints needs to be returned (this is a snapshot taken at the time this object is retrieved).
/// </summary>
public interface AssemblyJointsEnumerator : IEnumerable
{
    /// <summary>
    /// Method that returns the specified AssemblyJoint object from the collection. This is the default method of the AssemblyJointsEnumerator collection object.
    /// </summary>
    AssemblyJoint this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
