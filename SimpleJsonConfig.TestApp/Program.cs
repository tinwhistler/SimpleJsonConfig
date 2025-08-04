using System;
using SimpleJsonConfig;

var config = new Config("Test.json");

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


Console.WriteLine("Press any key to exit...");
Console.ReadKey();