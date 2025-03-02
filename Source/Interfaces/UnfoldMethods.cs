namespace Oblikovati.API;

/// <summary>
/// Provides access to the unfold method list (collection of <link Inventor::UnfoldMethod, UnfoldMethod> objects) for a particular sheet metal style.
/// </summary>
public interface UnfoldMethods : IEnumerable
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
    /// Returns the specified UnfoldMethod object from the collection.
    /// </summary>
    UnfoldMethod Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that adds a linear unfold method to the collection and returns the created UnfoldMethod object.
    /// </summary>
    /// <param name="Name">Input String used to specify the name of the UnfoldMethod. This name must be unique with respect to other UnfoldMethod objects. If a unique name is not provided, an error will occur.</param>
    /// <param name="Value">Input String used to specify the k Factor value for this UnfoldMethod object. This can be an expression. This parameter determines where the bend allowance is calculated. The allowable range is from 0 to 1. The bend allowance is calculated using the following equation: 2*Pi*(Bend Radius + Linear Offset*Thickness/2)*(Bend Angle/360)</param>
    /// <returns></returns>
    [PreserveSig]
    UnfoldMethod AddLinearUnfoldMethod([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string Value);
    /// <summary>
    /// Method that adds a BendTable unfold method to the collection and returns the created UnfoldMethod object.
    /// </summary>
    /// <param name="Name">Input String used to specify the name of bendtable UnfoldMethod. This name must be unique with respect to other UnfoldMethod objects. If a unique name is not provided, an error will occur.</param>
    /// <param name="FileName">Input String used to specify the name of the bend table. This is a text file in the format specified in the Sheet Metal documentation. When the UnfoldMethod object is created, the bend table information is extracted from the input file and saved in the sheet metal document. Not relationship is maintained to the original bend table file to it can moved or deleted without any loss of bend table info. This also means that if the text file is changed later, the UnfoldMethod object will not detect the changes and it will have no impact on the bend table.</param>
    /// <returns></returns>
    [PreserveSig]
    UnfoldMethod AddBendTableFromFile([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.BStr)] string FileName);
    /// <summary>
    /// Method that adds an equation linear unfold method to the collection and returns the created UnfoldMethod object. The new unfold method will have a single equation that specifies that the bend compensation will be 0 for a bend from 0 to 180 degrees. You can edit the equation to the desired equation using the functionality of the returned UnfoldMethod object.
    /// </summary>
    /// <param name="Name">Input String used to specify the name of the UnfoldMethod. This name must be unique with respect to other UnfoldMethod objects. If a unique name is not provided, an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    UnfoldMethod AddEquationUnfoldMethod([In] [MarshalAs(UnmanagedType.BStr)] string Name);
}
