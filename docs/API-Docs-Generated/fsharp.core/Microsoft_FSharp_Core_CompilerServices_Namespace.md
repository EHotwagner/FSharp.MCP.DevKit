# Microsoft.FSharp.Core.CompilerServices Namespace

**Types:** 28

## Classes (20)

### [AfterCode`2](./AfterCode`2.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.AfterCode`2`
**Summary:** Defines the implementation of the code run after the creation of a struct state machine.
**Members:** 3 methods, 0 properties

### [GeneratedSequenceBase`1](./GeneratedSequenceBase`1.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.GeneratedSequenceBase`1`
**Summary:** The F# compiler emits implementations of this type for compiled sequence expressions.
**Members:** 5 methods, 2 properties

### [MeasureInverse`1](./MeasureInverse`1.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.MeasureInverse`1`
**Summary:** Represents the inverse of a measure expressions when returned as a generic argument of a provided type.
**Members:** 0 methods, 0 properties

### [MeasureOne](./MeasureOne.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.MeasureOne`
**Summary:** Represents the '1' measure expression when returned as a generic argument of a provided type.
**Members:** 0 methods, 0 properties

### [MeasureProduct`2](./MeasureProduct`2.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.MeasureProduct`2`
**Summary:** Represents the product of two measure expressions when returned as a generic argument of a provided type.
**Members:** 0 methods, 0 properties

### [MoveNextMethodImpl`1](./MoveNextMethodImpl`1.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.MoveNextMethodImpl`1`
**Summary:** Defines the implementation of the MoveNext method for a struct state machine.
**Members:** 3 methods, 0 properties

### [NoEagerConstraintApplicationAttribute](./NoEagerConstraintApplicationAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.NoEagerConstraintApplicationAttribute`
**Summary:** Adding this attribute to the method adjusts the processing of some generic methods
 during overload resolution.
**Members:** 0 methods, 0 properties

### [ResumableCode](./ResumableCode.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`
**Summary:** Contains functions for composing resumable code blocks
**Members:** 15 methods, 0 properties

### [ResumableCode`2](./ResumableCode`2.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2`
**Summary:** A special compiler-recognised delegate type for specifying blocks of resumable code
 with access to the state machine.
**Members:** 3 methods, 0 properties

### [ResumptionDynamicInfo`1](./ResumptionDynamicInfo`1.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ResumptionDynamicInfo`1`
**Summary:** Represents the delegated runtime continuation of a resumable state machine created dynamically
**Members:** 6 methods, 2 properties

### [ResumptionFunc`1](./ResumptionFunc`1.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ResumptionFunc`1`
**Summary:** Represents the runtime continuation of a resumable state machine created dynamically
**Members:** 3 methods, 0 properties

### [RuntimeHelpers](./RuntimeHelpers.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers`
**Summary:** A group of functions used as part of the compiled representation of F# sequence expressions.
**Members:** 6 methods, 0 properties

### [SetStateMachineMethodImpl`1](./SetStateMachineMethodImpl`1.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.SetStateMachineMethodImpl`1`
**Summary:** Defines the implementation of the SetStateMachine method for a struct state machine.
**Members:** 3 methods, 0 properties

### [StateMachineHelpers](./StateMachineHelpers.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.StateMachineHelpers`
**Summary:** Contains compiler intrinsics related to the definition of state machines.
**Members:** 5 methods, 0 properties

### [TypeProviderAssemblyAttribute](./TypeProviderAssemblyAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute`
**Summary:** Place this attribute on a runtime assembly to indicate that there is a corresponding design-time 
 assembly that contains a type provider. Runtime and design-time assembly may be the same.
**Members:** 1 methods, 1 properties

### [TypeProviderAttribute](./TypeProviderAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute`
**Summary:** Place on a class that implements ITypeProvider to extend the compiler
**Members:** 0 methods, 0 properties

### [TypeProviderConfig](./TypeProviderConfig.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig`
**Summary:** If the class that implements ITypeProvider has a constructor that accepts TypeProviderConfig
 then it will be constructed with an instance of TypeProviderConfig.
**Members:** 15 methods, 7 properties

### [TypeProviderDefinitionLocationAttribute](./TypeProviderDefinitionLocationAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute`
**Summary:** A type provider may provide an instance of this attribute to indicate the definition location for a provided type or member.
**Members:** 6 methods, 3 properties

### [TypeProviderEditorHideMethodsAttribute](./TypeProviderEditorHideMethodsAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute`
**Summary:** Indicates that a code editor should hide all System.Object methods from the intellisense menus for instances of a provided type
**Members:** 0 methods, 0 properties

### [TypeProviderXmlDocAttribute](./TypeProviderXmlDocAttribute.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute`
**Summary:** A type provider may provide an instance of this attribute to indicate the documentation to show for 
 a provided type or member.
**Members:** 1 methods, 1 properties

## Enums (1)

### [TypeProviderTypeAttributes](./TypeProviderTypeAttributes.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.TypeProviderTypeAttributes`
**Summary:** Additional type attribute flags related to provided types
**Members:** 0 methods, 0 properties

## Interfaces (4)

### [IProvidedNamespace](./IProvidedNamespace.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.IProvidedNamespace`
**Summary:** Represents a namespace provided by a type provider component.
**Members:** 4 methods, 1 properties

### [IResumableStateMachine`1](./IResumableStateMachine`1.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.IResumableStateMachine`1`
**Members:** 3 methods, 2 properties

### [ITypeProvider](./ITypeProvider.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ITypeProvider`
**Summary:** Represents an instantiation of a type provider component.
**Members:** 7 methods, 0 properties

### [ITypeProvider2](./ITypeProvider2.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ITypeProvider2`
**Summary:** Represents additional, optional information for a type provider component
**Members:** 2 methods, 0 properties

## Structs (3)

### [ArrayCollector`1](./ArrayCollector`1.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ArrayCollector`1`
**Summary:** Collects elements and builds an array
**Members:** 4 methods, 0 properties

### [ListCollector`1](./ListCollector`1.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ListCollector`1`
**Summary:** Collects elements and builds a list
**Members:** 4 methods, 0 properties

### [ResumableStateMachine`1](./ResumableStateMachine`1.md)
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1`
**Summary:** Acts as a template for struct state machines introduced by __stateMachine, and also as a reflective implementation
**Members:** 0 methods, 0 properties

