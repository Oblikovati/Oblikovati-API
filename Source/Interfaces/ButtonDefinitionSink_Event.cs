namespace Oblikovati.API;

public interface ButtonDefinitionSink_Event
{
    event ButtonDefinitionSink_OnExecuteEventHandler OnExecute;
    event ButtonDefinitionSink_OnHelpEventHandler OnHelp;
}
