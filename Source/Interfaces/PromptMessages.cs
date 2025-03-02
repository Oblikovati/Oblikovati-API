namespace Oblikovati.API;

public interface PromptMessages : IEnumerable
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PromptMessage this[object Index] { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Id">Id</param>
    /// <param name="PromptText">PromptText</param>
    /// <param name="Buttons">Buttons</param>
    /// <param name="Title">Title</param>
    /// <param name="DisplayedPromptText">DisplayedPromptText</param>
    /// <param name="DefaultAnswer">DefaultAnswer</param>
    /// <param name="Restrictions">Restrictions</param>
    /// <param name="PromptSettings">PromptSettings</param>
    [PreserveSig]
    PromptMessage Add([In] [MarshalAs(UnmanagedType.BStr)] string Id, [In] [MarshalAs(UnmanagedType.BStr)] string PromptText, [In] int Buttons, [In] [MarshalAs(UnmanagedType.Struct)] object? Title = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DisplayedPromptText = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DefaultAnswer = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Restrictions = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PromptSettings = default);
}
