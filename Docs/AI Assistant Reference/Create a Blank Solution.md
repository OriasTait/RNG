You can create a solution without any projects in Visual Studio 2022 using the “Blank Solution” template. A .sln is just a container; it doesn’t have a project “type.”



How to create a solution without a project (VS 2022 Community):

1. Open Visual Studio 2022.
2. File → New → Project…
3. In the “Create a new project” dialog:
4. &nbsp;   Search for “Blank Solution”.
5. &nbsp;   If you don’t see it, set filters to:
6. &nbsp;     Language: All languages
7. &nbsp;     Platform: All platforms
8. &nbsp;     Project type: Other
9. &nbsp;   Select “Blank Solution” (by Microsoft).
10. &nbsp;Name it “MyProduct” and choose the location so it creates /MyProduct/MyProduct.sln.
11. &nbsp;Click Create.



Then add projects to match your structure:

* Right-click the solution in Solution Explorer → Add → New Project…
* &nbsp; Assemblies/Core: Class Library (.NET) → MyProduct.Core
* &nbsp; Assemblies/Infrastructure: Class Library (.NET) → MyProduct.Infrastructure
*   Assemblies/UIs/Console: Console App → MyProduct.Console
*   Assemblies/UIs/WPF: WPF App → MyProduct.Wpf
* &nbsp; Assemblies/Tests/Core.Tests: xUnit/MSTest/NUnit Test Project → Core.Tests
* &nbsp; Assemblies/Tests/Infrastructure.Tests: Test Project → Infrastructure.Tests
* Set the Startup Project by right-clicking the desired UI project (Console or WPF) → Set as Startup Project.



Notes:

* Solution folders vs. file system: Solution folders are virtual. To mirror your on-disk layout (Assemblies/, build/, Solution\_Information/, tools/), create those directories in the file system first, then place projects/files inside them and add them to the solution.
* Unity: Keep the Unity project under Assemblies/UIs/Unity with its own UnityApp.sln. You can include any adapter projects (.csproj) in the root MyProduct.sln, but you’ll typically open UnityApp.sln when working inside the Unity Editor.



CLI alternative (fast and deterministic): You can also create the solution and projects via the .NET CLI, which works great with your structure.

setup-dotnet.sh



\# Create the solution

dotnet new sln -n MyProduct



\# Core and Infrastructure (class libraries)

dotnet new classlib -n MyProduct.Core -o Assemblies/Core

dotnet new classlib -n MyProduct.Infrastructure -o Assemblies/Infrastructure



If “Blank Solution” still doesn’t appear:

* Ensure you’re on the latest Visual Studio 2022 update (Help → Check for Updates).
* Clear filters in the New Project dialog (All languages, All platforms, All project types).
* As a fallback, create any starter project (e.g., Console), then File → Save As to place the .sln in /MyProduct, and add/remove projects to shape it to your structure. You can delete the starter project after adding the ones you want.



