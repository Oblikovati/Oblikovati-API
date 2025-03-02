namespace Oblikovati.API;

/// <summary>
/// EdgeSymbolDefinition Object.
/// </summary>
public interface EdgeSymbolDefinition
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
    EdgeSymbol Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the indication type of the edge symbol.
    /// </summary>
    EdgeSymbolIndicationTypeEnum IndicationType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the value position type of the edge symbol.
    /// </summary>
    EdgeSymbolValuePositionTypeEnum ValuePositionType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the edges text.
    /// </summary>
    string Edges { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the layer associated with this object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to use range of values.
    /// </summary>
    bool RangeOfValues { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to enable the states of all edges around the profile of a part.
    /// </summary>
    bool StatesOfAllEdgesAroundProfile { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to enable the states of all edges around the profile of a part with sides clearly defined.
    /// </summary>
    bool SidesDefined { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to reference to ISO 13715.
    /// </summary>
    bool ReferenceToISO { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the vertical value of the EdgeSymbol.
    /// </summary>
    string VerticalValue { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the vertical value lower of the EdgeSymbol.
    /// </summary>
    string VerticalValueLower { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the horizontal value of the EdgeSymbol.
    /// </summary>
    string HorizontalValue { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the horizontal value lower of the EdgeSymbol.
    /// </summary>
    string HorizontalValueLower { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the undefined value of the EdgeSymbol.
    /// </summary>
    string UndefinedValue { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the undefined value lower of the EdgeSymbol.
    /// </summary>
    string UndefinedValueLower { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the edge symbol style associated with this object.
    /// </summary>
    EdgeSymbolStyle Style { get; set; }
    /// <summary>
    /// Method that creates a copy of this EdgeSymbolDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    EdgeSymbolDefinition Copy();
}
