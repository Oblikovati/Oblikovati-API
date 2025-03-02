namespace Oblikovati.API;

/// <summary>
/// Object that holds a collection of interfaces.
/// </summary>
public interface ApplicationAddIns : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    ApplicationAddIn Item { get; }
    /// <summary>
    /// Returns the specified ApplicationAddIn object from the collection. Retrieves an ApplicationAddIn object based on the Client Id.
    /// </summary>
    ApplicationAddIn ItemById { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// This method searches for new Add-ins installed since Oblikovati started.&nbsp;If a new add-in is found, it is added to the add-in list and is loaded if appropriate.
    /// </summary>
    [PreserveSig]
    void UpdateAddInList();
}
