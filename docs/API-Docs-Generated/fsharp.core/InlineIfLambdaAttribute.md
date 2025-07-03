# InlineIfLambdaAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.InlineIfLambdaAttribute`
- **Base Type:** `System.Attribute`

Adding this attribute to a parameter of function type indicates that, if the overall function or method is inlined and the parameter is
 determined to be a known lambda, then this function should be statically inlined throughout the body of the function of method.