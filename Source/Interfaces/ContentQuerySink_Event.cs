namespace Oblikovati.API;

public interface ContentQuerySink_Event
{
    event ContentQuerySink_OnCancelEventHandler OnCancel;
    event ContentQuerySink_OnDoneEventHandler OnDone;
}
