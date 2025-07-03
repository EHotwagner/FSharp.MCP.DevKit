# Microsoft.FSharp.Core Namespace

**Types:** 78

## Classes (74)

### [AbstractClassAttribute](./AbstractClassAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.AbstractClassAttribute`
**Summary:** Adding this attribute to class definition makes it abstract, which means it need not
 implement all its methods. Instances of abstract classes may not be constructed directly.
**Members:** 0 methods, 0 properties

### [AllowNullLiteralAttribute](./AllowNullLiteralAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.AllowNullLiteralAttribute`
**Summary:** Adding this attribute to a type lets the 'null' literal be used for the type 
 within F# code. This attribute may only be added to F#-defined class or 
 interface types.
**Members:** 1 methods, 1 properties

### [AutoOpenAttribute](./AutoOpenAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.AutoOpenAttribute`
**Summary:** Indicates a construct is automatically opened when brought into scope through
 an assembly reference or then opening of the containing namespace or module.
**Members:** 1 methods, 1 properties

### [AutoSerializableAttribute](./AutoSerializableAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.AutoSerializableAttribute`
**Summary:** Adding this attribute to a type with value 'false' disables the behaviour where F# makes the
 type Serializable by default.
**Members:** 1 methods, 1 properties

### [ByRefKinds](./ByRefKinds.md)
**Full Name:** `Microsoft.FSharp.Core.ByRefKinds`
**Summary:** Represents the types of byrefs in F# 4.5+
**Members:** 0 methods, 0 properties

### [CLIEventAttribute](./CLIEventAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CLIEventAttribute`
**Summary:** Adding this attribute to a property with event type causes it to be compiled with as a CLI
 metadata event, through a syntactic translation to a pair of 'add_EventName' and 
 'remove_EventName' methods.
**Members:** 0 methods, 0 properties

### [CLIMutableAttribute](./CLIMutableAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CLIMutableAttribute`
**Summary:** Adding this attribute to a record type causes it to be compiled to a CLI representation
 with a default constructor with property getters and setters.
**Members:** 0 methods, 0 properties

### [ClassAttribute](./ClassAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.ClassAttribute`
**Summary:** Adding this attribute to a type causes it to be represented using a CLI class.
**Members:** 0 methods, 0 properties

### [ComparisonConditionalOnAttribute](./ComparisonConditionalOnAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.ComparisonConditionalOnAttribute`
**Summary:** This attribute is used to indicate a generic container type satisfies the F# 'comparison' 
 constraint only if a generic argument also satisfies this constraint.
**Members:** 0 methods, 0 properties

### [CompilationArgumentCountsAttribute](./CompilationArgumentCountsAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilationArgumentCountsAttribute`
**Summary:** This attribute is generated automatically by the F# compiler to tag functions and members 
 that accept a partial application of some of their arguments and return a residual function.
**Members:** 1 methods, 1 properties

### [CompilationMappingAttribute](./CompilationMappingAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilationMappingAttribute`
**Summary:** This attribute is inserted automatically by the F# compiler to tag types 
 and methods in the generated CLI code with flags indicating the correspondence 
 with original source constructs.
**Members:** 5 methods, 5 properties

### [CompilationRepresentationAttribute](./CompilationRepresentationAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilationRepresentationAttribute`
**Summary:** This attribute is used to adjust the runtime representation for a type. 
 For example, it may be used to note that the null representation
 may be used for a type. This affects how some constructs are compiled.
**Members:** 1 methods, 1 properties

### [CompilationSourceNameAttribute](./CompilationSourceNameAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilationSourceNameAttribute`
**Summary:** This attribute is inserted automatically by the F# compiler to tag 
 methods which are given the 'CompiledName' attribute.
**Members:** 1 methods, 1 properties

### [CompiledNameAttribute](./CompiledNameAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompiledNameAttribute`
**Summary:** Adding this attribute to a value or function definition in an F# module changes the name used
 for the value in compiled CLI code.
**Members:** 1 methods, 1 properties

### [CompilerMessageAttribute](./CompilerMessageAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerMessageAttribute`
**Summary:** Indicates that a message should be emitted when F# source code uses this construct.
**Members:** 6 methods, 4 properties

### [CustomComparisonAttribute](./CustomComparisonAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CustomComparisonAttribute`
**Summary:** Adding this attribute to a type indicates it is a type with a user-defined implementation of comparison.
**Members:** 0 methods, 0 properties

### [CustomEqualityAttribute](./CustomEqualityAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CustomEqualityAttribute`
**Summary:** Adding this attribute to a type indicates it is a type with a user-defined implementation of equality.
**Members:** 0 methods, 0 properties

### [CustomOperationAttribute](./CustomOperationAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CustomOperationAttribute`
**Summary:** Indicates that a member on a computation builder type is a custom query operator,
 and indicates the name of that operator.
**Members:** 15 methods, 8 properties

### [DefaultAugmentationAttribute](./DefaultAugmentationAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.DefaultAugmentationAttribute`
**Summary:** Adding this attribute to a discriminated union with value false
 turns off the generation of standard helper member tester, constructor 
 and accessor members for the generated CLI class for that type.
**Members:** 1 methods, 1 properties

### [DefaultValueAttribute](./DefaultValueAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.DefaultValueAttribute`
**Summary:** Adding this attribute to a field declaration means that the field is 
 not initialized. During type checking a constraint is asserted that the field type supports 'null'. 
 If the 'check' value is false then the constraint is not asserted.
**Members:** 1 methods, 1 properties

### [EntryPointAttribute](./EntryPointAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.EntryPointAttribute`
**Summary:** Adding this attribute to a function indicates it is the entrypoint for an application.
 If this attribute is not specified for an EXE then the initialization implicit in the
 module bindings in the last file in the compilation sequence are used as the entrypoint.
**Members:** 0 methods, 0 properties

### [EqualityConditionalOnAttribute](./EqualityConditionalOnAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.EqualityConditionalOnAttribute`
**Summary:** This attribute is used to indicate a generic container type satisfies the F# 'equality' 
 constraint only if a generic argument also satisfies this constraint.
**Members:** 0 methods, 0 properties

### [ExperimentalAttribute](./ExperimentalAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.ExperimentalAttribute`
**Summary:** This attribute is used to tag values that are part of an experimental library
 feature.
**Members:** 1 methods, 1 properties

### [ExtraTopLevelOperators](./ExtraTopLevelOperators.md)
**Full Name:** `Microsoft.FSharp.Core.ExtraTopLevelOperators`
**Summary:** A set of extra operators and functions. This module is automatically opened in all F# code.
**Members:** 25 methods, 2 properties

### [FSharpChoice`2](./FSharpChoice`2.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpChoice`2`
**Summary:** Helper types for active patterns with 2 choices.
**Members:** 14 methods, 3 properties

### [FSharpChoice`3](./FSharpChoice`3.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpChoice`3`
**Summary:** Helper types for active patterns with 3 choices.
**Members:** 16 methods, 4 properties

### [FSharpChoice`4](./FSharpChoice`4.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpChoice`4`
**Summary:** Helper types for active patterns with 4 choices.
**Members:** 18 methods, 5 properties

### [FSharpChoice`5](./FSharpChoice`5.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpChoice`5`
**Summary:** Helper types for active patterns with 5 choices.
**Members:** 20 methods, 6 properties

### [FSharpChoice`6](./FSharpChoice`6.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpChoice`6`
**Summary:** Helper types for active patterns with 6 choices.
**Members:** 22 methods, 7 properties

### [FSharpChoice`7](./FSharpChoice`7.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpChoice`7`
**Summary:** Helper types for active patterns with 7 choices.
**Members:** 24 methods, 8 properties

### [FSharpFunc`2](./FSharpFunc`2.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpFunc`2`
**Summary:** The CLI type used to represent F# function values. This type is not
 typically used directly, though may be used from other CLI languages.
**Members:** 9 methods, 0 properties

### [FSharpInterfaceDataVersionAttribute](./FSharpInterfaceDataVersionAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute`
**Summary:** This attribute is added to generated assemblies to indicate the 
 version of the data schema used to encode additional F#
 specific information in the resource attached to compiled F# libraries.
**Members:** 3 methods, 3 properties

### [FSharpOption`1](./FSharpOption`1.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpOption`1`
**Summary:** The type of optional values. When used from other CLI languages the
 empty option is the null value.
**Members:** 17 methods, 4 properties

### [FSharpRef`1](./FSharpRef`1.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpRef`1`
**Summary:** The type of mutable references. Use the functions [!] and [:=] to get and
 set values of this type.
**Members:** 13 methods, 2 properties

### [FSharpTypeFunc](./FSharpTypeFunc.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpTypeFunc`
**Summary:** The CLI type used to represent F# first-class type function values. This type is for use
 by compiled F# code.
**Members:** 1 methods, 0 properties

### [FuncConvert](./FuncConvert.md)
**Full Name:** `Microsoft.FSharp.Core.FuncConvert`
**Summary:** Helper functions for converting F# first class function values to and from CLI representations
 of functions using delegates.
**Members:** 18 methods, 0 properties

### [GeneralizableValueAttribute](./GeneralizableValueAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.GeneralizableValueAttribute`
**Summary:** Adding this attribute to a non-function value with generic parameters indicates that 
 uses of the construct can give rise to generic code through type inference.
**Members:** 0 methods, 0 properties

### [InlineIfLambdaAttribute](./InlineIfLambdaAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.InlineIfLambdaAttribute`
**Summary:** Adding this attribute to a parameter of function type indicates that, if the overall function or method is inlined and the parameter is
 determined to be a known lambda, then this function should be statically inlined throughout the body of the function of method.
**Members:** 0 methods, 0 properties

### [InterfaceAttribute](./InterfaceAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.InterfaceAttribute`
**Summary:** Adding this attribute to a type causes it to be represented using a CLI interface.
**Members:** 0 methods, 0 properties

### [LanguagePrimitives](./LanguagePrimitives.md)
**Full Name:** `Microsoft.FSharp.Core.LanguagePrimitives`
**Summary:** Language primitives associated with the F# language
**Members:** 76 methods, 3 properties

### [LiteralAttribute](./LiteralAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.LiteralAttribute`
**Summary:** Adding this attribute to a value causes it to be compiled as a CLI constant literal.
**Members:** 0 methods, 0 properties

### [MatchFailureException](./MatchFailureException.md)
**Full Name:** `Microsoft.FSharp.Core.MatchFailureException`
**Summary:** Non-exhaustive match failures will raise the MatchFailureException exception
**Members:** 9 methods, 4 properties

### [MeasureAnnotatedAbbreviationAttribute](./MeasureAnnotatedAbbreviationAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute`
**Summary:** Adding this attribute to a type causes it to be interpreted as a refined type, currently limited to measure-parameterized types.
 This may only be used under very limited conditions.
**Members:** 0 methods, 0 properties

### [MeasureAttribute](./MeasureAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.MeasureAttribute`
**Summary:** Adding this attribute to a type causes it to be interpreted as a unit of measure.
 This may only be used under very limited conditions.
**Members:** 0 methods, 0 properties

### [NoComparisonAttribute](./NoComparisonAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.NoComparisonAttribute`
**Summary:** Adding this attribute to a type indicates it is a type where comparison is an abnormal operation.
 This means that the type does not satisfy the F# 'comparison' constraint. Within the bounds of the 
 F# type system, this helps ensure that the F# generic comparison function is not instantiated directly
 at this type. The attribute and checking does not constrain the use of comparison with base or child 
 types of this type.
**Members:** 0 methods, 0 properties

### [NoCompilerInliningAttribute](./NoCompilerInliningAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.NoCompilerInliningAttribute`
**Summary:** Indicates a value or a function that must not be inlined by the F# compiler,
 but may be inlined by the JIT compiler.
**Members:** 0 methods, 0 properties

### [NoDynamicInvocationAttribute](./NoDynamicInvocationAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.NoDynamicInvocationAttribute`
**Summary:** This attribute is used to tag values that may not be dynamically invoked at runtime. This is
 typically added to inlined functions whose implementations include unverifiable code. It
 causes the method body emitted for the inlined function to raise an exception if 
 dynamically invoked, rather than including the unverifiable code in the generated
 assembly.
**Members:** 0 methods, 0 properties

### [NoEqualityAttribute](./NoEqualityAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.NoEqualityAttribute`
**Summary:** Adding this attribute to a type indicates it is a type where equality is an abnormal operation.
 This means that the type does not satisfy the F# 'equality' constraint. Within the bounds of the 
 F# type system, this helps ensure that the F# generic equality function is not instantiated directly
 at this type. The attribute and checking does not constrain the use of comparison with base or child 
 types of this type.
**Members:** 0 methods, 0 properties

### [NumericLiterals](./NumericLiterals.md)
**Full Name:** `Microsoft.FSharp.Core.NumericLiterals`
**Summary:** Provides a default implementations of F# numeric literal syntax  for literals of the form 'dddI'
**Members:** 0 methods, 0 properties

### [Operators](./Operators.md)
**Full Name:** `Microsoft.FSharp.Core.Operators`
**Summary:** Basic F# Operators. This module is automatically opened in all F# code.
**Members:** 183 methods, 4 properties

### [OptimizedClosures](./OptimizedClosures.md)
**Full Name:** `Microsoft.FSharp.Core.OptimizedClosures`
**Summary:** An implementation module used to hold some private implementations of function
 value invocation.
**Members:** 0 methods, 0 properties

### [OptionModule](./OptionModule.md)
**Full Name:** `Microsoft.FSharp.Core.OptionModule`
**Summary:** Contains operations for working with options.
**Members:** 28 methods, 0 properties

### [OptionalArgumentAttribute](./OptionalArgumentAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.OptionalArgumentAttribute`
**Summary:** This attribute is added automatically for all optional arguments.
**Members:** 0 methods, 0 properties

### [PrintfFormat`4](./PrintfFormat`4.md)
**Full Name:** `Microsoft.FSharp.Core.PrintfFormat`4`
**Summary:** Type of a formatting expression.
**Members:** 4 methods, 3 properties

### [PrintfFormat`5](./PrintfFormat`5.md)
**Full Name:** `Microsoft.FSharp.Core.PrintfFormat`5`
**Summary:** Type of a formatting expression.
**Members:** 0 methods, 0 properties

### [PrintfModule](./PrintfModule.md)
**Full Name:** `Microsoft.FSharp.Core.PrintfModule`
**Summary:** Extensible printf-style formatting for numbers and other datatypes
**Members:** 13 methods, 0 properties

### [ProjectionParameterAttribute](./ProjectionParameterAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.ProjectionParameterAttribute`
**Summary:** Indicates that, when a custom operator is used in a computation expression,
 a parameter is automatically parameterized by the variable space of the computation expression
**Members:** 0 methods, 0 properties

### [ReferenceEqualityAttribute](./ReferenceEqualityAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.ReferenceEqualityAttribute`
**Summary:** Adding this attribute to a record or union type disables the automatic generation
 of overrides for 'System.Object.Equals(obj)', 'System.Object.GetHashCode()' 
 and 'System.IComparable' for the type. The type will by default use reference equality.
**Members:** 0 methods, 0 properties

### [ReflectedDefinitionAttribute](./ReflectedDefinitionAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.ReflectedDefinitionAttribute`
**Summary:** Adding this attribute to the let-binding for the definition of a top-level 
 value makes the quotation expression that implements the value available
 for use at runtime.
**Members:** 1 methods, 1 properties

### [RequireQualifiedAccessAttribute](./RequireQualifiedAccessAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.RequireQualifiedAccessAttribute`
**Summary:** This attribute is used to indicate that references to the elements of a module, record or union 
 type require explicit qualified access.
**Members:** 0 methods, 0 properties

### [RequiresExplicitTypeArgumentsAttribute](./RequiresExplicitTypeArgumentsAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute`
**Summary:** Adding this attribute to a type, value or member requires that 
 uses of the construct must explicitly instantiate any generic type parameters.
**Members:** 0 methods, 0 properties

### [ResultModule](./ResultModule.md)
**Full Name:** `Microsoft.FSharp.Core.ResultModule`
**Summary:** Contains operations for working with values of type .
**Members:** 18 methods, 0 properties

### [SealedAttribute](./SealedAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.SealedAttribute`
**Summary:** Adding this attribute to class definition makes it sealed, which means it may not
 be extended or implemented.
**Members:** 1 methods, 1 properties

### [StringModule](./StringModule.md)
**Full Name:** `Microsoft.FSharp.Core.StringModule`
**Summary:** Functional programming operators for string processing.  Further string operations
 are available via the member functions on strings and other functionality in
  System.String
 and System.Text.RegularExpressions types.
**Members:** 12 methods, 0 properties

### [StructAttribute](./StructAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.StructAttribute`
**Summary:** Adding this attribute to a type causes it to be represented using a CLI struct.
**Members:** 0 methods, 0 properties

### [StructuralComparisonAttribute](./StructuralComparisonAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.StructuralComparisonAttribute`
**Summary:** Adding this attribute to a record, union, exception, or struct type confirms the 
 automatic generation of implementations for 'System.IComparable' for the type.
**Members:** 0 methods, 0 properties

### [StructuralEqualityAttribute](./StructuralEqualityAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.StructuralEqualityAttribute`
**Summary:** Adding this attribute to a record, union or struct type confirms the automatic 
 generation of overrides for 'System.Object.Equals(obj)' and 
 'System.Object.GetHashCode()' for the type.
**Members:** 0 methods, 0 properties

### [StructuredFormatDisplayAttribute](./StructuredFormatDisplayAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.StructuredFormatDisplayAttribute`
**Summary:** This attribute is used to mark how a type is displayed by default when using 
 '%A' printf formatting patterns and other two-dimensional text-based display layouts. 
 In this version of F# valid values are of the form PreText {PropertyName1} PostText {PropertyName2} ... {PropertyNameX} PostText.
 The property names indicate properties to evaluate and to display instead of the object itself.
**Members:** 1 methods, 1 properties

### [TailCallAttribute](./TailCallAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.TailCallAttribute`
**Summary:** Indicates a function that should be called in a tail recursive way inside its recursive scope.
 A warning is emitted if the function is analyzed as not tail recursive after the optimization phase.
**Members:** 0 methods, 0 properties

### [Unit](./Unit.md)
**Full Name:** `Microsoft.FSharp.Core.Unit`
**Summary:** The type 'unit', which has only one value "()". This value is special and
 always uses the representation 'null'.
**Members:** 2 methods, 0 properties

### [UnverifiableAttribute](./UnverifiableAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.UnverifiableAttribute`
**Summary:** This attribute is used to tag values whose use will result in the generation
 of unverifiable code. These values are inevitably marked 'inline' to ensure that
 the unverifiable constructs are not present in the actual code for the F# library,
 but are rather copied to the source code of the caller.
**Members:** 0 methods, 0 properties

### [ValueOption](./ValueOption.md)
**Full Name:** `Microsoft.FSharp.Core.ValueOption`
**Summary:** Contains operations for working with value options.
**Members:** 28 methods, 0 properties

### [VolatileFieldAttribute](./VolatileFieldAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.VolatileFieldAttribute`
**Summary:** Adding this attribute to an F# mutable binding causes the "volatile"
 prefix to be used for all accesses to the field.
**Members:** 0 methods, 0 properties

### [WarnOnWithoutNullArgumentAttribute](./WarnOnWithoutNullArgumentAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.WarnOnWithoutNullArgumentAttribute`
**Summary:** When used in a compilation with null-checking enabled, indicates that a function is meant to be used only with potentially-nullable values and warns accordingly.
**Members:** 1 methods, 1 properties

## Enums (2)

### [CompilationRepresentationFlags](./CompilationRepresentationFlags.md)
**Full Name:** `Microsoft.FSharp.Core.CompilationRepresentationFlags`
**Summary:** Indicates one or more adjustments to the compiled representation of an F# type or member.
**Members:** 0 methods, 0 properties

### [SourceConstructFlags](./SourceConstructFlags.md)
**Full Name:** `Microsoft.FSharp.Core.SourceConstructFlags`
**Summary:** Indicates the relationship between a compiled entity in a CLI binary and an element in F# source code.
**Members:** 0 methods, 0 properties

## Structs (2)

### [FSharpResult`2](./FSharpResult`2.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpResult`2`
**Summary:** Helper type for error handling without exceptions.
**Members:** 16 methods, 5 properties

### [FSharpValueOption`1](./FSharpValueOption`1.md)
**Full Name:** `Microsoft.FSharp.Core.FSharpValueOption`1`
**Summary:** The type of optional values, represented as structs.
**Members:** 22 methods, 9 properties

