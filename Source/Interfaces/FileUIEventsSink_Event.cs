namespace Oblikovati.API;

public interface FileUIEventsSink_Event
{
    event FileUIEventsSink_OnFileNewDialogEventHandler OnFileNewDialog;
    event FileUIEventsSink_OnFileOpenDialogEventHandler OnFileOpenDialog;
    event FileUIEventsSink_OnFileSaveAsDialogEventHandler OnFileSaveAsDialog;
    event FileUIEventsSink_OnFileInsertNewDialogEventHandler OnFileInsertNewDialog;
    event FileUIEventsSink_OnFileInsertDialogEventHandler OnFileInsertDialog;
    event FileUIEventsSink_OnFileOpenFromMRUEventHandler OnFileOpenFromMRU;
    event FileUIEventsSink_OnFileNewEventHandler OnFileNew;
    event FileUIEventsSink_OnPopulateFileMetadataEventHandler OnPopulateFileMetadata;
}
