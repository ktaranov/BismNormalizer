﻿
namespace BismNormalizer.TabularCompare
{
    /// <summary>
    /// Type of object that a validation message relates to. For example, Table, Measure, MeasureCalculationDependency, etc.
    /// </summary>
    public enum ValidationMessageType { DataSource, Table, Relationship, Measure, Kpi, Perspective, Culture, Role, Expression, Action, MeasureCalculationDependency, General }; //General used for command line only

    /// <summary>
    /// Status for a validation message, such as Informational and Warning.
    /// </summary>
    public enum ValidationMessageStatus { Informational, Warning };

    /// <summary>
    /// Type of comparison object. For example, Table, Measure, Relationship, etc.
    /// </summary>
    public enum ComparisonObjectType { DataSource, Table, Relationship, Measure, Kpi, Perspective, Culture, Role, Expression, Action };

    /// <summary>
    /// Status of comparison object, such as Same Definition, Different Definitions and Missing In Target.
    /// </summary>
    public enum ComparisonObjectStatus { SameDefinition, DifferentDefinitions, MissingInTarget, MissingInSource, Na };

    /// <summary>
    /// Action to be taken for a comparison object, such as Create, Update, Delete and Skip.
    /// </summary>
    public enum MergeAction { Create, Update, Delete, Skip };

    /// <summary>
    /// Processing option for database deployment.
    /// </summary>
    public enum ProcessingOption { Default, DoNotProcess, Full };

    /// <summary>
    /// Status of database deployment.
    /// </summary>
    public enum DeploymentStatus { Deploying = 0, Success = 1, Error = 2, Cancel = 3 };

    /// <summary>
    /// Type of dependency. For example, DataSource, Partition, Expression.
    /// </summary>
    public enum MDependencyObjectType { DataSource, Partition, Expression };
}
