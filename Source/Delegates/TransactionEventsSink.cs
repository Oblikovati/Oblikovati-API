namespace Oblikovati.API;

public delegate void TransactionEventsSink_OnAbortEventHandler( Transaction TransactionObject, NameValueMap Context, EventTimingEnum BeforeOrAfter);

public delegate void TransactionEventsSink_OnCommitEventHandler( Transaction TransactionObject, NameValueMap Context, EventTimingEnum BeforeOrAfter,out HandlingCodeEnum HandlingCode);

public delegate void TransactionEventsSink_OnDeleteEventHandler( Transaction TransactionObject, NameValueMap Context, EventTimingEnum BeforeOrAfter);

public delegate void TransactionEventsSink_OnRedoEventHandler( Transaction TransactionObject, NameValueMap Context, EventTimingEnum BeforeOrAfter,out HandlingCodeEnum HandlingCode);

public delegate void TransactionEventsSink_OnUndoEventHandler( Transaction TransactionObject, NameValueMap Context, EventTimingEnum BeforeOrAfter,out HandlingCodeEnum HandlingCode);
