namespace Oblikovati.API;

public interface TransactionEventsSink_Event
{
    event TransactionEventsSink_OnCommitEventHandler OnCommit;
    event TransactionEventsSink_OnUndoEventHandler OnUndo;
    event TransactionEventsSink_OnRedoEventHandler OnRedo;
    event TransactionEventsSink_OnAbortEventHandler OnAbort;
    event TransactionEventsSink_OnDeleteEventHandler OnDelete;
}
