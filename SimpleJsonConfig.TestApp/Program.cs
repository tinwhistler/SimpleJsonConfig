using System;
using SimpleJsonConfig;

var config = new Config("Test.json");

Console.WriteLine("now testing named Get(s) eg: GetInt(), GetBool() etc..."); 

int? maxUsers = config.GetInt("MaxUsers");
bool? debugMode = config.GetBool("debugMode");
string? name = config.GetString("AppName");
long? maxMemory = config.GetLong("maxMemory");
float? cpuLoad = config.GetFloat("cpuLoad");
decimal? piValue = config.GetDecimal("piValue");
Guid? sessionId = config.GetGuid("sessionId");
short? portNumber = config.GetShort("portNumber");
byte? retryCount = config.GetByte("retryCount");

Console.WriteLine("maxUsers: " + maxUsers);
Console.WriteLine("debugMode: " + debugMode);
Console.WriteLine("AppName: " + name);
Console.WriteLine("maxMemory: " + maxMemory);
Console.WriteLine("cpuLoad: " + cpuLoad);
Console.WriteLine("piValue: " + piValue);
Console.WriteLine("sessionId: " + sessionId);
Console.WriteLine("portNumber: " + portNumber);
Console.WriteLine("retryCount: " + retryCount);

Console.WriteLine("now testing generic Get<T>...");
maxUsers = config.Get<int?>("MaxUsers");
debugMode = config.Get<bool?>("debugMode");
name = config.Get<string?>("AppName");
maxMemory = config.Get<long>("maxMemory");
cpuLoad = config.Get<float?>("cpuLoad");
piValue = config.Get<decimal?>("piValue");
sessionId = config.Get<Guid?>("sessionId");
portNumber = config.Get<short?>("portNumber");
retryCount = config.Get<byte?>("retryCount");
Console.WriteLine("maxUsers: " + maxUsers);
Console.WriteLine("debugMode: " + debugMode);
Console.WriteLine("AppName: " + name);
Console.WriteLine("maxMemory: " + maxMemory);
Console.WriteLine("cpuLoad: " + cpuLoad);
Console.WriteLine("piValue: " + piValue);
Console.WriteLine("sessionId: " + sessionId);
Console.WriteLine("portNumber: " + portNumber);
Console.WriteLine("retryCount: " + retryCount);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();