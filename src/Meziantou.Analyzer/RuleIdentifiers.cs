﻿using System.Globalization;

namespace Meziantou.Analyzer;

internal static class RuleIdentifiers
{
    public const string UseStringComparison = "MA0001";
    public const string UseStringComparer = "MA0002";
    public const string UseNamedParameter = "MA0003";
    public const string UseConfigureAwaitFalse = "MA0004";
    public const string UseArrayEmpty = "MA0005";
    public const string UseStringEquals = "MA0006";
    public const string MissingCommaInObjectInitializer = "MA0007";
    public const string MissingStructLayoutAttribute = "MA0008";
    public const string MissingTimeoutParameterForRegex = "MA0009";
    public const string MarkAttributesWithAttributeUsageAttribute = "MA0010";
    public const string UseIFormatProviderParameter = "MA0011";
    public const string DoNotRaiseReservedExceptionType = "MA0012";
    public const string TypesShouldNotExtendSystemApplicationException = "MA0013";
    public const string DoNotRaiseApplicationException = "MA0014";
    public const string ArgumentExceptionShouldSpecifyArgumentName = "MA0015";
    public const string PreferReturningCollectionAbstractionInsteadOfImplementation = "MA0016";
    public const string AbstractTypesShouldNotHaveConstructors = "MA0017";
    public const string DoNotDeclareStaticMembersOnGenericTypes = "MA0018";
    public const string UseEventArgsEmpty = "MA0019";
    public const string UseListOfTMethodsInsteadOfEnumerableExtensionMethods = "MA0020";
    public const string DoNotUseStringGetHashCode = "MA0021";
    public const string ReturnTaskFromResultInsteadOfReturningNull = "MA0022";
    public const string UseRegexExplicitCaptureOptions = "MA0023";
    public const string DoNotUseEqualityComparerDefaultOfString = "MA0024";
    public const string DoNotRaiseNotImplementedException = "MA0025";
    public const string FixToDo = "MA0026";
    public const string DoNotRemoveOriginalExceptionFromThrowStatement = "MA0027";
    public const string OptimizeStringBuilderUsage = "MA0028";
    public const string OptimizeEnumerable_CombineMethods = "MA0029";
    public const string DuplicateEnumerable_OrderBy = "MA0030";
    public const string OptimizeEnumerable_Count = "MA0031";
    public const string UseAnOverloadThatHasCancellationToken = "MA0032";
    public const string DontTagInstanceFieldsWithThreadStaticAttribute = "MA0033";
    public const string DontUseDangerousThreadingMethods = "MA0035";
    public const string MakeClassStatic = "MA0036";
    public const string RemoveEmptyStatement = "MA0037";
    public const string MakeMethodStatic = "MA0038";
    public const string DoNotUseServerCertificateValidationCallback = "MA0039";
    public const string UseAnOverloadThatHasCancellationTokenWhenACancellationTokenIsAvailable = "MA0040";
    public const string MakePropertyStatic = "MA0041";
    public const string DoNotUseBlockingCallInAsyncContext = "MA0042";
    public const string UseNameofOperator = "MA0043";
    public const string RemoveUselessToString = "MA0044";
    public const string DoNotUseBlockingCall = "MA0045";
    public const string UseEventHandlerOfT = "MA0046";
    public const string DeclareTypesInNamespaces = "MA0047";
    public const string FileNameMustMatchTypeName = "MA0048";
    public const string TypeNameMustNotMatchNamespace = "MA0049";
    public const string ValidateArgumentsCorrectly = "MA0050";
    public const string MethodShouldNotBeTooLong = "MA0051";
    public const string ReplaceEnumToStringWithNameof = "MA0052";
    public const string ClassMustBeSealed = "MA0053";
    public const string EmbedCaughtExceptionAsInnerException = "MA0054";
    public const string DoNotUseFinalizer = "MA0055";
    public const string DoNotCallVirtualMethodInConstructor = "MA0056";
    public const string AttributeNameShouldEndWithAttribute = "MA0057";
    public const string ExceptionNameShouldEndWithException = "MA0058";
    public const string EventArgsNameShouldEndWithEventArgs = "MA0059";
    public const string TheReturnValueOfStreamReadShouldBeUsed = "MA0060";
    public const string MethodOverridesShouldNotChangeParameterDefaults = "MA0061";
    public const string NonFlagsEnumsShouldNotBeMarkedWithFlagsAttribute = "MA0062";
    public const string OptimizeEnumerable_WhereBeforeOrderBy = "MA0063";
    public const string AvoidLockingOnPubliclyAccessibleInstance = "MA0064";
    public const string DoNotUseDefaultEqualsOnValueType = "MA0065";
    public const string StructWithDefaultEqualsImplementationUsedAsAKey = "MA0066";
    public const string UseGuidEmpty = "MA0067";
    public const string NotNullIfNotNullArgumentShouldExist = "MA0068";
    public const string NonConstantStaticFieldsShouldNotBeVisible = "MA0069";
    public const string ObsoleteAttributesShouldIncludeExplanations = "MA0070";
    public const string AvoidUsingRedundantElse = "MA0071";
    public const string DoNotThrowFromFinallyBlock = "MA0072";
    public const string AvoidComparisonWithBoolConstant = "MA0073";
    public const string AvoidCultureSensitiveMethod = "MA0074";
    public const string DoNotUseImplicitCultureSensitiveToString = "MA0075";
    public const string DoNotUseImplicitCultureSensitiveToStringInterpolation = "MA0076";
    public const string ClassWithEqualsTShouldImplementIEquatableT = "MA0077";
    public const string OptimizeEnumerable_CastInsteadOfSelect = "MA0078";
    public const string FlowCancellationTokenInAwaitForEachWhenACancellationTokenIsAvailable = "MA0079";
    public const string FlowCancellationTokenInAwaitForEach = "MA0080";
    public const string PreserveParamsOnOverride = "MA0081";
    public const string DoNotNaNInComparisons = "MA0082";
    public const string ConstructorArgumentParametersShouldExistInConstructors = "MA0083";
    public const string LocalVariablesShouldNotHideSymbols = "MA0084";
    public const string AnonymousDelegatesShouldNotBeUsedToUnsubscribeFromEvents = "MA0085";
    public const string DoNotThrowFromFinalizer = "MA0086";
    public const string ParametersWithDefaultValueShouldBeMarkedWithOptionalParameter = "MA0087";
    public const string DefaultValueShouldNotBeUsedWhenParameterDefaultValueIsMeant = "MA0088";
    public const string OptimizeStartsWith = "MA0089";
    public const string RemoveEmptyBlock = "MA0090";
    public const string SenderShouldBeThisForInstanceEvents = "MA0091";
    public const string SenderShouldBeNullForStaticEvents = "MA0092";
    public const string EventArgsSenderShouldNotBeNullForEvents = "MA0093";
    public const string ClassWithCompareToTShouldImplementIComparableT = "MA0094";
    public const string ClassWithEqualsTShouldOverrideEqualsObject = "MA0095";
    public const string ClassImplementingIComparableTShouldImplementIEquatableT = "MA0096";
    public const string TheComparisonOperatorsShouldBeOverriddenWhenImplementingIComparable = "MA0097";
    public const string UseIndexerInsteadOfElementAt = "MA0098";
    public const string DoNotUseZeroToInitializeAnEnumValue = "MA0099";
    public const string AwaitTaskBeforeDisposingResources = "MA0100";
    public const string StringShouldNotContainsNonDeterministicEndOfLine = "MA0101";
    public const string MakeStructMemberReadOnly = "MA0102";
    public const string DoNotUseEqualityOperatorsForSpanOfChar = "MA0103";
    public const string DotNotUseNameFromBCL = "MA0104";
    public const string AvoidClosureWhenUsingConcurrentDictionary = "MA0105";
    public const string AvoidClosureWhenUsingConcurrentDictionaryByUsingFactoryArg = "MA0106";
    public const string DoNotUseCultureSensitiveObjectToString = "MA0107";
    public const string SimplifyCallerArgumentExpression = "MA0108";
    public const string AddOverloadWithSpanOrMemory = "MA0109";
    public const string UseRegexSourceGenerator = "MA0110";
    public const string UseStringCreateInsteadOfFormattableString = "MA0111";
    public const string OptimizeEnumerable_UseCountInsteadOfAny = "MA0112";
    public const string UseDateTimeUnixEpoch = "MA0113";
    public const string UseDateTimeOffsetUnixEpoch = "MA0114";
    public const string DoNotUseUnknownParameterForRazorComponent = "MA0115";

    public static string GetHelpUri(string idenfifier)
    {
        return string.Format(CultureInfo.InvariantCulture, "https://github.com/meziantou/Meziantou.Analyzer/blob/main/docs/Rules/{0}.md", idenfifier);
    }
}
