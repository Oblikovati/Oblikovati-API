namespace Oblikovati.API;

/// <summary>
/// ModelStates Object.
/// </summary>
public interface ModelStates : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ModelState this[object Index] { get; }
    /// <summary>
    /// Read-only property that returns the excel spreadsheet that represents the model states table.
    /// </summary>
    object ExcelWorkSheet { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the edits to a member should affect just the active member or all members.
    /// </summary>
    MemberEditScopeEnum MemberEditScope { get; set; }
    /// <summary>
    /// Read-only property that gets the ModelStateTable object that represents the model states table. If the ModelStates is from a model state member document then this property will return Nothing.
    /// </summary>
    ModelStateTable ModelStateTable { get; }
    /// <summary>
    /// Read-only property that returns the active model state for this document.
    /// </summary>
    ModelState ActiveModelState { get; }
    /// <summary>
    /// Method that creates a new ModelState. The newly created ModelState is returned.
    /// </summary>
    /// <param name="Name">Optional input String that specifies the name of the new ModelState. If not specified a default name will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelState Add([In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Method that creates a new ModelState. The newly created ModelState is returned.
    /// </summary>
    /// <param name="FullFileName">Input String value that specifies the full name of the file to create the substitute model state with.</param>
    /// <param name="Name">Optional input String that specifies the name of the new ModelState. If not specified a default name will be used.</param>
    /// <param name="SkipDocumentSave">Optional input Boolean that indicates whether to suppress the save dialogs that appear for dirty documents that are about to be closed as a result of this action. If set to True, any edits performed on the documents needing to be closed are lost. Also, any document never saved to disk and needing to be closed is lost. The default value is False indicating that the user will be prompted to save documents about to be closed.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelState AddSubstitute([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Struct)] object? Name = default, [In] [MarshalAs(UnmanagedType.Struct)] object? SkipDocumentSave = default);
}
