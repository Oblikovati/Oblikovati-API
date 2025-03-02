namespace Oblikovati.API;

/// <summary>
/// The Ribbon object represents the user interface containing a collection of tabs.
/// </summary>
public interface Ribbon
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent UserInterfaceManager object.
    /// </summary>
    UserInterfaceManager Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that returns the internal name of the ribbon.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the RibbonTabs collection object.
    /// </summary>
    RibbonTabs RibbonTabs { get; }
    /// <summary>
    /// Property that returns whether this ribbon is currently being displayed.
    /// </summary>
    bool Active { get; }
    /// <summary>
    /// Property that returns a CommandControls collection containing the controls in the Quick Access Toolbar (QAT).
    /// </summary>
    CommandControls QuickAccessControls { get; }
}
