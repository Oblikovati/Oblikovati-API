namespace Oblikovati.API;

public interface SearchBoxEventsSink_Event
{
    event SearchBoxEventsSink_OnStartSearchEventHandler OnStartSearch;
    event SearchBoxEventsSink_OnEndSearchEventHandler OnEndSearch;
    event SearchBoxEventsSink_OnStopSearchEventHandler OnStopSearch;
    event SearchBoxEventsSink_OnClearSearchEventHandler OnClearSearch;
}
