namespace Oblikovati.API;

public delegate void IRxTransactionEvents_OnAbortEventHandler( Transaction TransactionObject, EventTimingEnum BeforeOrAfter);

public delegate void IRxTransactionEvents_OnCommitEventHandler( Transaction TransactionObject, EventTimingEnum BeforeOrAfter,out HandlingCodeEnum HandlingCode);

public delegate void IRxTransactionEvents_OnDeleteEventHandler( Transaction TransactionObject, EventTimingEnum BeforeOrAfter);

public delegate void IRxTransactionEvents_OnRedoEventHandler( Transaction TransactionObject, EventTimingEnum BeforeOrAfter,out HandlingCodeEnum HandlingCode);

public delegate void IRxTransactionEvents_OnUndoEventHandler( Transaction TransactionObject, EventTimingEnum BeforeOrAfter,out HandlingCodeEnum HandlingCode);
