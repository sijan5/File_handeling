using System;
using System.Diagnostics;
using System.IO;

Process process = new Process();
process.StartInfo.FileName = "cmd.exe";
process.StartInfo.Arguments = "/c mkdir sumitkando&&cd sumitkando&&dotnet new console&&dotnet restore";
process.Start();
process.WaitForExit();
File.WriteAllText("sumitkando/program.cs","Console.Write(\"sumit is kalo kando\");");
process.StartInfo.FileName = "cmd.exe";
process.StartInfo.Arguments = "/ccd sumitkando&&dotnet run";
process.Start();
process.WaitForExit();