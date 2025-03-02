namespace Oblikovati.API;

/// <summary>
/// Provides access to sketch constraints application settings.
/// </summary>
public interface SketchConstraintSettings
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    SketchOptions Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets whether to display constraints on creation.
    /// </summary>
    bool DisplayConstraintsOnCreation { get; set; }
    /// <summary>
    /// Gets and sets whether to show constraints for the selected objects.
    /// </summary>
    bool ShowConstraintsForSelectedObjects { get; set; }
    /// <summary>
    /// Gets and sets whether to display coincident constraints in sketch.
    /// </summary>
    bool DisplayCoincidentConstraintsInSketch { get; set; }
    /// <summary>
    /// Gets and sets whether to edit dimensions just after creation.
    /// </summary>
    bool EditDimensionsWhenCreated { get; set; }
    /// <summary>
    /// Gets and sets whether to create dimensions when inputting values into heads-up display fields.
    /// </summary>
    bool CreateDimensionsOnValueInput { get; set; }
    /// <summary>
    /// Gets and sets the behavior when create an over-constrained dimension.
    /// </summary>
    OverConstrainedDimensionBehaviorEnum OverConstrainedDimensionBehavior { get; set; }
    /// <summary>
    /// Gets and sets whether to enable inferred constraints.
    /// </summary>
    bool EnableInferConstraints { get; set; }
    /// <summary>
    /// Gets and sets whether to persist inferred constraints.
    /// </summary>
    bool EnablePersistConstraints { get; set; }
    /// <summary>
    /// Gets and sets the priority of inferred constraints when placing.
    /// </summary>
    ConstraintInferencePriorityEnum ConstraintInferencePriority { get; set; }
    /// <summary>
    /// Gets and sets which geometric constraints have their inference indicators shown to assist creating sketch entities.
    /// </summary>
    SketchConstraintInferenceTypeEnum SelectionForGeometricConstraintsInference { get; set; }
    /// <summary>
    /// Gets and sets whether to keep the dimensions with an equation in relax dragging and over-constraint solving.
    /// </summary>
    bool KeepDimensionsWithEquationInRelaxMode { get; set; }
    /// <summary>
    /// Gets and sets which geometric constraints can be removed in relax mode when dragging sketch entitiess.
    /// </summary>
    SketchGeometricConstraintTypeEnum GeometricConstraintsToRemoveInRelaxMode { get; set; }
    /// <summary>
    /// Gets and sets whether to enable relax mode.
    /// </summary>
    bool EnableRelaxMode { get; set; }
}
