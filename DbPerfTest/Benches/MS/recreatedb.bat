echo y|dotnet ef database drop -c DbPerfTest.Contexts.MSPerfTestContext -p "../../"
dotnet ef database update -c DbPerfTest.Contexts.MSPerfTestContext -p "../../"