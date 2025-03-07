﻿using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Meziantou.Analyzer.Rules;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class DoNotDeclareStaticMembersOnGenericTypes : DiagnosticAnalyzer
{
    private static readonly DiagnosticDescriptor s_rule = new(
        RuleIdentifiers.DoNotDeclareStaticMembersOnGenericTypes,
        title: "Do not declare static members on generic types",
        messageFormat: "Do not declare static members on generic types",
        RuleCategories.Design,
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true,
        description: "",
        helpLinkUri: RuleIdentifiers.GetHelpUri(RuleIdentifiers.DoNotDeclareStaticMembersOnGenericTypes));

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(s_rule);

    public override void Initialize(AnalysisContext context)
    {
        context.EnableConcurrentExecution();
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

        context.RegisterSymbolAction(Analyze, SymbolKind.NamedType);
    }

    private static void Analyze(SymbolAnalysisContext context)
    {
        var symbol = (INamedTypeSymbol)context.Symbol;
        if (!symbol.IsGenericType)
            return;

        foreach (var member in symbol.GetMembers())
        {
            if (member.IsStatic && !member.IsConst())
            {
                // skip properties
                if (member is IMethodSymbol method && (method.MethodKind == MethodKind.PropertyGet || method.MethodKind == MethodKind.PropertySet))
                    continue;

                // skip operators
                if (member.IsOperator())
                    continue;

                // only public methods
                if (!member.IsVisibleOutsideOfAssembly())
                    continue;

                // Exclude protected member as the usage is easy from a derived class
                if (member.DeclaredAccessibility == Accessibility.Protected || member.DeclaredAccessibility == Accessibility.ProtectedOrInternal)
                    continue;

                context.ReportDiagnostic(s_rule, member);
            }
        }
    }
}
