namespace Oblikovati.API;

/// <summary>
/// The ContentTreeViewNode object represents nodes within the Content Center tree structure.
/// </summary>
public interface ContentTreeViewNode
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns a collection containing the child ContentTreeViewNode objects of this node.
    /// </summary>
    ContentTreeViewNodesEnumerator ChildNodes { get; }
    /// <summary>
    /// Property that returns the display name of this node. This is the name that the end-user sees and is localized for different languages.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Property that returns the set of families associated with this node. The collection returned may have a count of zero indicating there aren't any families associated with this node.
    /// </summary>
    ContentFamiliesEnumerator Families { get; }
    /// <summary>
    /// Property that provides the full path in the tree view for this node. For example, this can return 'Fasteners:Bolts:Countersunk:Oval Countersunk Head Metric Machine Screws' where a colon is used as the delimiter.
    /// </summary>
    string FullTreeViewPath { get; }
    /// <summary>
    /// Property that returns the icon used for this node.
    /// </summary>
    IPictureDisp Icon { get; }
    /// <summary>
    /// Property that returns the internal name of this node. This will be consistent regardless of the language version of Inventor.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the parent ContentTreeViewNode object. This property will return Nothing for the top node.
    /// </summary>
    ContentTreeViewNode ParentNode { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
