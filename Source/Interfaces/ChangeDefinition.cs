namespace Oblikovati.API;

/// <summary>
/// The ChangeDefinition object is obtained from the ChangeManager object. It's purpose is to provide a ChangeProcessor object via the CreateChangeProcessor method, according to the settings of the ChangeDefinition object.
/// </summary>
public interface ChangeDefinition : ChangeDefinitionObject, ChangeDefinitionSink_Event
{
}
