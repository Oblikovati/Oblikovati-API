namespace Oblikovati.API;

/// <summary>
/// The TitleBlock object represents the instance of a title block on a sheet.
/// </summary>
public interface TitleBlock
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent sheet object.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property returning the title block definition object this title block is an instance of.
    /// </summary>
    TitleBlockDefinition Definition { get; }
    /// <summary>
    /// Property that returns the position of the title block on the sheet.
    /// </summary>
    TitleBlockLocationEnum Location { get; }
    /// <summary>
    /// Property that returns the position on the sheet where the origin of the title block definition's sketch is positioned.
    /// </summary>
    Point2d Position { get; }
    /// <summary>
    /// Property that provides the transform that is applied to display the associated title block definition in the correct location on the sheet. The matrix defines the sheet to title block transform.
    /// </summary>
    Matrix2d Transformation { get; }
    /// <summary>
    /// Gets and sets the name of the title block instance.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Method that deletes the title block from the sheet.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that returns the text that is currently displayed for a specific text box. This is useful for text boxes that use input from other sources to define their content, i.e. properties and prompted text. The string displayed within this text box is returned.
    /// </summary>
    /// <param name="DefinitionText">Input TextBox object from the referenced TitleBlockDefinition object. This text box is used as in index to specify which text box in the instance to return the text for.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetResultText([In] [MarshalAs(UnmanagedType.Interface)] TextBox DefinitionText);
    /// <summary>
    /// Method that sets the text that was supplied for a specified title block that contains prompted text. The string displayed within this title block is changed.
    /// </summary>
    /// <param name="DefinitionText">Input TextBox object from the referenced TitleBlockDefinition object. This text box is used to specify which prompted text box to set the text for.</param>
    /// <param name="NewValue">Input String that defines the new text to use for the specified prompted text.</param>
    [PreserveSig]
    void SetPromptResultText([In] [MarshalAs(UnmanagedType.Interface)] TextBox DefinitionText, [In] [MarshalAs(UnmanagedType.BStr)] string NewValue);
}
