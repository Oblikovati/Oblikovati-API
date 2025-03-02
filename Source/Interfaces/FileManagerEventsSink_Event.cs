namespace Oblikovati.API;

public interface FileManagerEventsSink_Event
{
    event FileManagerEventsSink_OnFileDeleteEventHandler OnFileDelete;
    event FileManagerEventsSink_OnFileCopyEventHandler OnFileCopy;
}
