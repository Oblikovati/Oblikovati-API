namespace Oblikovati.API;

/// <summary>
/// BIMExchangeServer object.
/// </summary>
public interface BIMExchangeServer
{
    /// <summary>
    /// Method that returns the BIMComponent associated with the provided Oblikovati part or assembly component definition.
    /// </summary>
    /// <param name="ComponentDefinition">Input PartComponentDefinition or AssemblyComponentDefinition object that specifies which Inventor part or assembly you want to get the associated BIMComponent for.</param>
    /// <returns></returns>
    [PreserveSig]
    BIMComponent GetBIMComponent([In] [MarshalAs(UnmanagedType.Interface)] ComponentDefinition ComponentDefinition);
}
