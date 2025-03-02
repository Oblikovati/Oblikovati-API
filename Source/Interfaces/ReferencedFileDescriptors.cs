namespace Oblikovati.API;

/// <summary>
/// Object that holds a collection of ReferencedFileDescriptor interfaces.
/// </summary>
public interface ReferencedFileDescriptors : IEnumerable
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
    /// Property that returns the specified ReferencedFileDescriptor object from the collection. This is the default property of the ReferencedFileDescriptors collection object.
    /// </summary>
    ReferencedFileDescriptor this[int Index] { get; }
    /// <summary>
    /// Allows string-indexed access to items in the collection. Usually found when this ability has been added to an pre-existing collection.
    /// </summary>
    ReferencedFileDescriptor ItemByName { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
