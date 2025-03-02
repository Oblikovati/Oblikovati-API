namespace Oblikovati.API;

/// <summary>
/// The ChangeProcessor object is at the heart of Inventor's transaction and transcripting mechanism, exposed via its public API.
/// </summary>
public interface ChangeProcessor : ChangeProcessorObject, ChangeProcessorSink_Event
{
}
