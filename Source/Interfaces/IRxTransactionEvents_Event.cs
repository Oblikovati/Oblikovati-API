namespace Oblikovati.API;

public interface IRxTransactionEvents_Event
{
    event IRxTransactionEvents_OnCommitEventHandler OnCommit;
    event IRxTransactionEvents_OnUndoEventHandler OnUndo;
    event IRxTransactionEvents_OnRedoEventHandler OnRedo;
    event IRxTransactionEvents_OnAbortEventHandler OnAbort;
    event IRxTransactionEvents_OnDeleteEventHandler OnDelete;
}
