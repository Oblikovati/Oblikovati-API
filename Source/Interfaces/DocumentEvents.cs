namespace Oblikovati.API;

/// <summary>
/// The DocumentEvents object provides notification of events that take place at the document level, such as activating, closing and saving particular documents.
/// </summary>
public interface DocumentEvents : DocumentEventsObject, DocumentEventsSink_Event
{
}
