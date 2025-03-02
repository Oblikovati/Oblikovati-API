namespace Oblikovati.API;

/// <summary>
/// The TransactionManager object encapsulates all of the transaction-based functionality. See the article in the overviews section.
/// </summary>
public interface TransactionManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the collection of all committed transactions currently held by the system. These can be undone in reverse sequence.
    /// </summary>
    TransactionsEnumerator CommittedTransactions { get; }
    /// <summary>
    /// Gets the collection of all currently undone transactions. These can be redone in forward sequence.
    /// </summary>
    TransactionsEnumerator UndoneTransactions { get; }
    /// <summary>
    /// Gets the current transaction in progress.
    /// </summary>
    Transaction CurrentTransaction { get; }
    /// <summary>
    /// Gets the object that will fire transaction events.
    /// </summary>
    TransactionEvents TransactionEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    /// <param name="DisplayName">DisplayName</param>
    [PreserveSig]
    Transaction StartTransaction([In] [MarshalAs(UnmanagedType.Interface)] _Document Document, [In] [MarshalAs(UnmanagedType.BStr)] string DisplayName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    /// <param name="DisplayName">DisplayName</param>
    [PreserveSig]
    Transaction StartGlobalTransaction([In] [MarshalAs(UnmanagedType.Interface)] _Document Document, [In] [MarshalAs(UnmanagedType.BStr)] string DisplayName);
    /// <summary>
    /// Sets a bookmark in the current transaction in progress.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    CheckPoint SetCheckPoint();
    /// <summary>
    /// Undoes the current transaction.
    /// </summary>
    [PreserveSig]
    void UndoTransaction();
    /// <summary>
    /// Aborts back up to the checkpoint specified.
    /// </summary>
    /// <param name="CheckPoint">Input CheckPoint that specifies the checkpoint to abort back to.</param>
    [PreserveSig]
    void GoToCheckPoint([In] [MarshalAs(UnmanagedType.Interface)] CheckPoint CheckPoint);
    /// <summary>
    /// Redoes the transaction following the current (if that had been undone).
    /// </summary>
    [PreserveSig]
    void RedoTransaction();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    Transaction _StartUnidentifiedTransaction();
    /// <summary>
    /// Start a transaction that wraps a document open or new document operation.
    /// </summary>
    /// <param name="DisplayName">The display name of this transaction.</param>
    /// <returns></returns>
    [PreserveSig]
    Transaction StartTransactionForDocumentOpen([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName);
    /// <summary>
    /// Method that clears all the transactions in the committed and undone stacks. After this method is called a user may no longer Undo/Redo until another transaction is committed. This method fails if an identified transaction is in progress.
    /// </summary>
    [PreserveSig]
    void ClearAllTransactions();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Document">Document</param>
    /// <param name="DisplayName">DisplayName</param>
    /// <param name="Options">Options</param>
    [PreserveSig]
    Transaction StartTransactionWithOptions([In] [MarshalAs(UnmanagedType.Interface)] _Document Document, [In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    Transaction EndTransaction();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransactionPoint">TransactionPoint</param>
    /// <param name="TransactionObject">TransactionObject</param>
    [PreserveSig]
    void AbortTransaction([In] TransactionPointEnum TransactionPoint, [In] [MarshalAs(UnmanagedType.Struct)] object? TransactionObject = default);
}
