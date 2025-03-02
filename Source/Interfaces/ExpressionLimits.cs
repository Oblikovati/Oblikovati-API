namespace Oblikovati.API;

/// <summary>
/// The ExpressionLimits object provides access to the various range values that can be specified when defining a custom expression for a column.
/// </summary>
public interface ExpressionLimits
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets/Sets the default value for this expression.
    /// </summary>
    string DefaultValue { get; set; }
    /// <summary>
    /// Gets/Sets the increment value for this expression.
    /// </summary>
    string IncrementValue { get; set; }
    /// <summary>
    /// Gets/Sets the maximum value for this expression.
    /// </summary>
    string MaximumValue { get; set; }
    /// <summary>
    /// Gets/Sets the type of comparison to perform against the maximum value.
    /// </summary>
    ComparisonTypeEnum MaximumValueComparisonType { get; set; }
    /// <summary>
    /// Gets/Sets the minimum value for this expression.
    /// </summary>
    string MinimumValue { get; set; }
    /// <summary>
    /// Gets/Sets the type of comparison to perform against the minimum value.
    /// </summary>
    ComparisonTypeEnum MinimumValueComparisonType { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
