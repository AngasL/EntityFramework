// <auto-generated />

using System;
using System.Reflection;
using System.Resources;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

namespace Microsoft.EntityFrameworkCore.Internal
{
    /// <summary>
    ///		This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public static class DesignStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Properties.DesignStrings", typeof(DesignStrings).GetTypeInfo().Assembly);

        /// <summary>
        ///     The name '{migrationName}' is used by an existing migration.
        /// </summary>
        public static string DuplicateMigrationName([CanBeNull] object migrationName)
            => string.Format(
                GetString("DuplicateMigrationName", nameof(migrationName)),
                migrationName);

        /// <summary>
        ///     More than one DbContext was found. Specify which one to use. Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands.
        /// </summary>
        public static string MultipleContexts
            => GetString("MultipleContexts");

        /// <summary>
        ///     More than one DbContext named '{name}' was found. Specify which one to use by providing its fully qualified name.
        /// </summary>
        public static string MultipleContextsWithName([CanBeNull] object name)
            => string.Format(
                GetString("MultipleContextsWithName", nameof(name)),
                name);

        /// <summary>
        ///     More than one DbContext named '{name}' was found. Specify which one to use by providing its fully qualified name using its exact case.
        /// </summary>
        public static string MultipleContextsWithQualifiedName([CanBeNull] object name)
            => string.Format(
                GetString("MultipleContextsWithQualifiedName", nameof(name)),
                name);

        /// <summary>
        ///     No DbContext was found in assembly '{assembly}'. Ensure that you're using the correct assembly and that the type is neither abstract nor generic.
        /// </summary>
        public static string NoContext([CanBeNull] object assembly)
            => string.Format(
                GetString("NoContext", nameof(assembly)),
                assembly);

        /// <summary>
        ///     No DbContext named '{name}' was found.
        /// </summary>
        public static string NoContextWithName([CanBeNull] object name)
            => string.Format(
                GetString("NoContextWithName", nameof(name)),
                name);

        /// <summary>
        ///     Using context '{name}'.
        /// </summary>
        public static string UseContext([CanBeNull] object name)
            => string.Format(
                GetString("UseContext", nameof(name)),
                name);

        /// <summary>
        ///     Dropping database '{name}'.
        /// </summary>
        public static string DroppingDatabase([CanBeNull] object name)
            => string.Format(
                GetString("DroppingDatabase", nameof(name)),
                name);

        /// <summary>
        ///     Successfully dropped database '{name}'.
        /// </summary>
        public static string DatabaseDropped([CanBeNull] object name)
            => string.Format(
                GetString("DatabaseDropped", nameof(name)),
                name);

        /// <summary>
        ///     Cancelled.
        /// </summary>
        public static string Cancelled
            => GetString("Cancelled");

        /// <summary>
        ///     A manual migration deletion was detected.
        /// </summary>
        public static readonly EventDefinition LogManuallyDeleted
            = new EventDefinition(
                DesignEventId.MigrationManuallyDeleted,
                LogLevel.Debug,
                LoggerMessage.Define(
                    LogLevel.Debug,
                    DesignEventId.MigrationManuallyDeleted,
                    _resourceManager.GetString("LogManuallyDeleted")));

        /// <summary>
        ///     No file named '{file}' was found. You must manually remove the migration class '{migrationClass}'.
        /// </summary>
        public static readonly EventDefinition<string, string> LogNoMigrationFile
            = new EventDefinition<string, string>(
                DesignEventId.MigrationFileNotFound,
                LogLevel.Warning,
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    DesignEventId.MigrationFileNotFound,
                    _resourceManager.GetString("LogNoMigrationFile")));

        /// <summary>
        ///     No file named '{file}' was found.
        /// </summary>
        public static readonly EventDefinition<string> LogNoMigrationMetadataFile
            = new EventDefinition<string>(
                DesignEventId.MigrationMetadataFileNotFound,
                LogLevel.Debug,
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    DesignEventId.MigrationMetadataFileNotFound,
                    _resourceManager.GetString("LogNoMigrationMetadataFile")));

        /// <summary>
        ///     No ModelSnapshot was found.
        /// </summary>
        public static string NoSnapshot
            => GetString("NoSnapshot");

        /// <summary>
        ///     No file named '{file}' was found. You must manually remove the model snapshot class '{snapshotClass}'.
        /// </summary>
        public static readonly EventDefinition<string, string> LogNoSnapshotFile
            = new EventDefinition<string, string>(
                DesignEventId.SnapshotFileNotFound,
                LogLevel.Warning,
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    DesignEventId.SnapshotFileNotFound,
                    _resourceManager.GetString("LogNoSnapshotFile")));

        /// <summary>
        ///     Removing migration '{name}'.
        /// </summary>
        public static readonly EventDefinition<string> LogRemovingMigration
            = new EventDefinition<string>(
                DesignEventId.MigrationRemoving,
                LogLevel.Warning,
                LoggerMessage.Define<string>(
                    LogLevel.Warning,
                    DesignEventId.MigrationRemoving,
                    _resourceManager.GetString("LogRemovingMigration")));

        /// <summary>
        ///     Removing model snapshot.
        /// </summary>
        public static readonly EventDefinition LogRemovingSnapshot
            = new EventDefinition(
                DesignEventId.SnapshotRemoving,
                LogLevel.Information,
                LoggerMessage.Define(
                    LogLevel.Information,
                    DesignEventId.SnapshotRemoving,
                    _resourceManager.GetString("LogRemovingSnapshot")));

        /// <summary>
        ///     Reverting model snapshot.
        /// </summary>
        public static readonly EventDefinition LogRevertingSnapshot
            = new EventDefinition(
                DesignEventId.SnapshotReverting,
                LogLevel.Information,
                LoggerMessage.Define(
                    LogLevel.Information,
                    DesignEventId.SnapshotReverting,
                    _resourceManager.GetString("LogRevertingSnapshot")));

        /// <summary>
        ///     The migration '{name}' has already been applied to the database. Unapply it and try again. If the migration has been applied to other databases, consider reverting its changes using a new migration.
        /// </summary>
        public static string UnapplyMigration([CanBeNull] object name)
            => string.Format(
                GetString("UnapplyMigration", nameof(name)),
                name);

        /// <summary>
        ///     The current CSharpMigrationOperationGenerator cannot scaffold operations of type '{operationType}'. Configure your services to use one that can.
        /// </summary>
        public static string UnknownOperation([CanBeNull] object operationType)
            => string.Format(
                GetString("UnknownOperation", nameof(operationType)),
                operationType);

        /// <summary>
        ///     The current CSharpHelper cannot scaffold literals of type '{literalType}'. Configure your services to use one that can.
        /// </summary>
        public static string UnknownLiteral([CanBeNull] object literalType)
            => string.Format(
                GetString("UnknownLiteral", nameof(literalType)),
                literalType);

        /// <summary>
        ///     Unable to find provider assembly with name {assemblyName}. Ensure the specified name is correct and is referenced by the project.
        /// </summary>
        public static string CannotFindRuntimeProviderAssembly([CanBeNull] object assemblyName)
            => string.Format(
                GetString("CannotFindRuntimeProviderAssembly", nameof(assemblyName)),
                assemblyName);

        /// <summary>
        ///     An operation was scaffolded that may result in the loss of data. Please review the migration for accuracy.
        /// </summary>
        public static readonly EventDefinition LogDestructiveOperation
            = new EventDefinition(
                DesignEventId.DestructiveOperation,
                LogLevel.Warning,
                LoggerMessage.Define(
                    LogLevel.Warning,
                    DesignEventId.DestructiveOperation,
                    _resourceManager.GetString("LogDestructiveOperation")));

        /// <summary>
        ///     Reusing directory of file '{file}'.
        /// </summary>
        public static readonly EventDefinition<string> LogReusingDirectory
            = new EventDefinition<string>(
                DesignEventId.DirectoryReusing,
                LogLevel.Debug,
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    DesignEventId.DirectoryReusing,
                    _resourceManager.GetString("LogReusingDirectory")));

        /// <summary>
        ///     Writing migration to '{file}'.
        /// </summary>
        public static readonly EventDefinition<string> LogWritingMigration
            = new EventDefinition<string>(
                DesignEventId.MigrationWriting,
                LogLevel.Debug,
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    DesignEventId.MigrationWriting,
                    _resourceManager.GetString("LogWritingMigration")));

        /// <summary>
        ///     Writing model snapshot to '{file}'.
        /// </summary>
        public static readonly EventDefinition<string> LogWritingSnapshot
            = new EventDefinition<string>(
                DesignEventId.SnapshotWriting,
                LogLevel.Debug,
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    DesignEventId.SnapshotWriting,
                    _resourceManager.GetString("LogWritingSnapshot")));

        /// <summary>
        ///     Done.
        /// </summary>
        public static string Done
            => GetString("Done");

        /// <summary>
        ///     Reusing namespace of type '{type}'.
        /// </summary>
        public static readonly EventDefinition<string> LogReusingNamespace
            = new EventDefinition<string>(
                DesignEventId.NamespaceReusing,
                LogLevel.Debug,
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    DesignEventId.NamespaceReusing,
                    _resourceManager.GetString("LogReusingNamespace")));

        /// <summary>
        ///     Reusing model snapshot name '{name}'.
        /// </summary>
        public static readonly EventDefinition<string> LogReusingSnapshotName
            = new EventDefinition<string>(
                DesignEventId.SnapshotNameReusing,
                LogLevel.Debug,
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    DesignEventId.SnapshotNameReusing,
                    _resourceManager.GetString("LogReusingSnapshotName")));

        /// <summary>
        ///     Unable to find design-time provider assembly. Please install the {designTimeProviderAssemblyName} NuGet package and ensure that the package is referenced by the project.
        /// </summary>
        public static string CannotFindDesignTimeProviderAssembly([CanBeNull] object designTimeProviderAssemblyName)
            => string.Format(
                GetString("CannotFindDesignTimeProviderAssembly", nameof(designTimeProviderAssemblyName)),
                designTimeProviderAssemblyName);

        /// <summary>
        ///     Unable to find expected assembly attribute named {attributeName} in provider assembly {runtimeProviderAssemblyName}. This attribute is required to identify the class which acts as the design-time service provider factory.
        /// </summary>
        public static string CannotFindDesignTimeProviderAssemblyAttribute([CanBeNull] object attributeName, [CanBeNull] object runtimeProviderAssemblyName)
            => string.Format(
                GetString("CannotFindDesignTimeProviderAssemblyAttribute", nameof(attributeName), nameof(runtimeProviderAssemblyName)),
                attributeName, runtimeProviderAssemblyName);

        /// <summary>
        ///     {provider} is not a Relational provider and therefore cannot be use with Migrations.
        /// </summary>
        public static string NonRelationalProvider([CanBeNull] object provider)
            => string.Format(
                GetString("NonRelationalProvider", nameof(provider)),
                provider);

        /// <summary>
        ///     Could not load assembly '{assembly}'. Ensure it is referenced by the startup project '{startupProject}'.
        /// </summary>
        public static string UnreferencedAssembly([CanBeNull] object assembly, [CanBeNull] object startupProject)
            => string.Format(
                GetString("UnreferencedAssembly", nameof(assembly), nameof(startupProject)),
                assembly, startupProject);

        /// <summary>
        ///     Finding DbContext classes...
        /// </summary>
        public static string FindingContexts
            => GetString("FindingContexts");

        /// <summary>
        ///     The namespace '{migrationsNamespace}' contains migrations for a different DbContext. This can result in conflicting migration names. It's recommend to put migrations for different DbContext classes into different namespaces.
        /// </summary>
        public static readonly EventDefinition<string> LogForeignMigrations
            = new EventDefinition<string>(
                DesignEventId.ForeignMigrations,
                LogLevel.Warning,
                LoggerMessage.Define<string>(
                    LogLevel.Warning,
                    DesignEventId.ForeignMigrations,
                    _resourceManager.GetString("LogForeignMigrations")));

        /// <summary>
        ///     The context class name passed in, {contextClassName}, is not a valid C# identifier.
        /// </summary>
        public static string ContextClassNotValidCSharpIdentifier([CanBeNull] object contextClassName)
            => string.Format(
                GetString("ContextClassNotValidCSharpIdentifier", nameof(contextClassName)),
                contextClassName);

        /// <summary>
        ///     Your target project '{assembly}' doesn't match your migrations assembly '{migrationsAssembly}'. Either change your target project or change your migrations assembly.
        ///     Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b =&gt; b.MigrationsAssembly("{assembly}")). By default, the migrations assembly is the assembly containing the DbContext.
        ///     Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.
        /// </summary>
        public static string MigrationsAssemblyMismatch([CanBeNull] object assembly, [CanBeNull] object migrationsAssembly)
            => string.Format(
                GetString("MigrationsAssemblyMismatch", nameof(assembly), nameof(migrationsAssembly)),
                assembly, migrationsAssembly);

        /// <summary>
        ///     To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        /// </summary>
        public static string SensitiveInformationWarning
            => GetString("SensitiveInformationWarning");

        /// <summary>
        ///     Removing migration '{name}' without checking the database. If this migration has been applied to the database, you will need to manually reverse the changes it made.
        /// </summary>
        public static readonly EventDefinition<string> LogForceRemoveMigration
            = new EventDefinition<string>(
                DesignEventId.MigrationForceRemove,
                LogLevel.Warning,
                LoggerMessage.Define<string>(
                    LogLevel.Warning,
                    DesignEventId.MigrationForceRemove,
                    _resourceManager.GetString("LogForceRemoveMigration")));

        /// <summary>
        ///     No parameterless constructor was found on '{contextType}'. Either add a parameterless constructor to '{contextType}' or add an implementation of 'IDbContextFactory&lt;{contextType}&gt;' in the same assembly as '{contextType}'.
        /// </summary>
        public static string NoParameterlessConstructor([CanBeNull] object contextType)
            => string.Format(
                GetString("NoParameterlessConstructor", nameof(contextType)),
                contextType);

        /// <summary>
        ///     Database '{name}' did not exist, no action was taken.
        /// </summary>
        public static string NotExistDatabase([CanBeNull] object name)
            => string.Format(
                GetString("NotExistDatabase", nameof(name)),
                name);

        /// <summary>
        ///     An error occurred while calling method '{method}' on startup class '{startupClass}'. Consider using IDbContextFactory to override the initialization of the DbContext at design-time. Error: {error}
        /// </summary>
        public static string InvokeStartupMethodFailed([CanBeNull] object method, [CanBeNull] object startupClass, [CanBeNull] object error)
            => string.Format(
                GetString("InvokeStartupMethodFailed", nameof(method), nameof(startupClass), nameof(error)),
                method, startupClass, error);

        /// <summary>
        ///     Could not serialize {obj} [{name}]
        /// </summary>
        public static string CouldNotSerialize([CanBeNull] object obj, [CanBeNull] object name)
            => string.Format(
                GetString("CouldNotSerialize", nameof(obj), nameof(name)),
                obj, name);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}
