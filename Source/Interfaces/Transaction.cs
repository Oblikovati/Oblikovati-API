namespace Oblikovati.API;

/// <summary>
/// The Transaction object that stands for a single transaction. See the article in the overviews section.
/// </summary>
public interface Transaction
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    TransactionManager Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the unique identifier for this transaction.
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Gets the display name of this transaction.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Gets the affected by this transaction.
    /// </summary>
    _Document Document { get; }
    /// <summary>
    /// Gets the Boolean flag indicating if this transaction is a child of another transaction.
    /// </summary>
    bool HasParentTransaction { get; }
    /// <summary>
    /// Property that returns the parent transaction, if one exists; else returns a NULL pointer.
    /// </summary>
    Transaction ParentTransaction { get; }
    /// <summary>
    /// Gets the enumeration of all of the check points that may be present in this transaction.
    /// </summary>
    CheckPointsEnumerator CheckPoints { get; }
    /// <summary>
    /// Gets the enumeration of all of the child transactions that this transaction may contain.
    /// </summary>
    TransactionsEnumerator ChildTransactions { get; }
    /// <summary>
    /// Property that returns a TransactionStateEnum that describes the current state of the transaction.
    /// </summary>
    TransactionStateEnum State { get; }
    /// <summary>
    /// Gets and sets whether to merge this transaction with the previously committed transaction.
    /// </summary>
    bool MergeWithPrevious { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    [PreserveSig]
    void IdentifyForDocumentOpen([In] [MarshalAs(UnmanagedType.Interface)] _Document Document);
    /// <summary>
    /// Method that ends this transaction. This method will fail if this transaction is not the current transaction.
    /// </summary>
    [PreserveSig]
    void End();
    /// <summary>
    /// Method that aborts this transaction. This method will fail if this transaction is not the current transaction.
    /// </summary>
    [PreserveSig]
    void Abort();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SuppressedEvents">SuppressedEvents</param>
    /// <param name="Suppressed">Suppressed</param>
    [PreserveSig]
    void SuppressChangeNotifications([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] SuppressedEvents, [In] bool Suppressed);
}
