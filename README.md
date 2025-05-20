# ReSharper – Extract Local Function UI Test Samples

This repository contains C# code examples I prepared for manual testing of the new UI in ReSharper 2025.2 EAP1.  
Instead of the old dialog box, the feature now shows a hint in the editor and a small panel for selecting where to insert the local function.  
I wanted to see how this behaves in different situations: with simple code, nested blocks, async methods, lambdas and less typical selections.

The goal isn't to test the refactoring logic itself, but how the updated UI handles navigation, interaction and clarity across different contexts.

## Environment

- Visual Studio 2022 (17.12.4)
- ReSharper 2025.2 EAP1 (build 2025.2.0.1)
- .NET SDK 8.0.204

More on the feature:  
https://www.jetbrains.com/help/resharper/Refactorings__Extract_Method.html#local-function
