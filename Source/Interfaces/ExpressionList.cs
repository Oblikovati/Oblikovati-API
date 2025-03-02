namespace Oblikovati.API;

/// <summary>
/// The ExpressionList provides access to a list of possible expressions that can be used for the associated parameter.
/// </summary>
public interface ExpressionList : IEnumerable
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
    /// Property that returns the parent Parameter object.
    /// </summary>
    Parameter Parent { get; }
    /// <summary>
    /// Property that specifies the number of expressions in the list.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that gets the specified expression in the list.
    /// </summary>
    string this[int Index] { get; }
    /// <summary>
    /// Gets/Sets whether to allow users to specify custom values.
    /// </summary>
    bool AllowCustomValues { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to disable automatically sorting the custom values. If you assign a list of values using SetExpressionList, that operation will automatically set CustomOrder to True. If you want to assign a list using SetExpressi.
    /// </summary>
    bool CustomOrder { get; set; }
    /// <summary>
    /// Method that removes all items from the list.
    /// </summary>
    [PreserveSig]
    void ClearAll();
    /// <summary>
    /// Rreturns an array of Strings that represents the list of expressions used in the list.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    string[] GetExpressionList();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ExpressionList">ExpressionList</param>
    /// <param name="ChangeCurrentValue">ChangeCurrentValue</param>
    /// <param name="CurrentValueIndex">CurrentValueIndex</param>
    [PreserveSig]
    void SetExpressionList([In] [MarshalAs(UnmanagedType.SafeArray)] ref string[] ExpressionList, [In] bool? ChangeCurrentValue = false, [In] int? CurrentValueIndex = default);
}
