// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Relational.Design;
using Microsoft.EntityFrameworkCore.Relational.Design.Specification.Tests.ReverseEngineering;
using Microsoft.EntityFrameworkCore.Relational.Tests.TestUtilities;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Xunit;

namespace Microsoft.EntityFrameworkCore.Design.Tests.Scaffolding.Internal
{
    public class ReverseEngineeringConfigurationTests
    {
        [Fact]
        public void Throws_exceptions_for_invalid_context_name()
        {
            ValidateContextNameInReverseEngineerGenerator("Invalid!CSharp*Class&Name");
            ValidateContextNameInReverseEngineerGenerator("1CSharpClassNameCannotStartWithNumber");
            ValidateContextNameInReverseEngineerGenerator("volatile");
        }

        private void ValidateContextNameInReverseEngineerGenerator(string contextName)
        {
            var scaffoldingUtility = new ScaffoldingUtilities();
            var reverseEngineer = new ReverseEngineeringGenerator(
                new FakeScaffoldingModelFactory(new FakeDiagnosticsLogger<LoggerCategory.Scaffolding>()),
                new ConfigurationFactory(CSharpUtilities.Instance, scaffoldingUtility),
                new StringBuilderCodeWriter(
                    new InMemoryFileService(),
                    new DbContextWriter(scaffoldingUtility, CSharpUtilities.Instance),
                    new EntityTypeWriter(CSharpUtilities.Instance)));

            Assert.Equal(
                DesignStrings.ContextClassNotValidCSharpIdentifier(contextName),
                Assert.Throws<ArgumentException>(
                        () => reverseEngineer.GenerateAsync(
                                connectionString: "connectionstring",
                                tableSelectionSet: TableSelectionSet.All,
                                projectPath: "FakeProjectPath",
                                outputPath: null,
                                rootNamespace: "FakeNamespace",
                                contextName: contextName,
                                useDataAnnotations: false,
                                overwriteFiles: false)
                            .Result)
                    .Message);
        }
    }
}
