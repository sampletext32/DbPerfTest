echo y|dotnet ef database drop --no-build -c DbPerfTest.Contexts.PostgresPerfTestContext -p "../../"
dotnet ef database update --no-build -c DbPerfTest.Contexts.PostgresPerfTestContext -p "../../"