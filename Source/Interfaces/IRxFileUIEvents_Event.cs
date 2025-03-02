namespace Oblikovati.API;

public interface IRxFileUIEvents_Event
{
    event IRxFileUIEvents_OnFileNewDialogEventHandler OnFileNewDialog;
    event IRxFileUIEvents_OnFileOpenDialogEventHandler OnFileOpenDialog;
    event IRxFileUIEvents_OnFileSaveAsDialogEventHandler OnFileSaveAsDialog;
    event IRxFileUIEvents_OnFileInsertNewDialogEventHandler OnFileInsertNewDialog;
    event IRxFileUIEvents_OnFileInsertDialogEventHandler OnFileInsertDialog;
}
