namespace Oblikovati.API;

/// <summary>
/// Test Programs Collection Object.
/// </summary>
public interface TestPrograms : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    TestProgram Item { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Refreshes the collection by scanning the files on the disk.
    /// </summary>
    [PreserveSig]
    void Refresh();
}
