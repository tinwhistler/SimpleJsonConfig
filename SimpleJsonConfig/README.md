# SimpleJsonConfig

A dead-simple JSON config reader for .NET.  
No ceremony. No POCOs. No dependency injection. No religion.

## Why?

Because modern .NET decided configuration needed to be a lifestyle choice.

You know the drill:
- Inject `IConfiguration` into something.
- Set up 12 layers of config providers.
- Bind to a POCO with optional snake_case massaging.
- Forget where your setting actually came from.
- Discover that what you *really* wanted was `GetValue<T>()`.

Meanwhile, you just wanted to read a number from a file.

## What This Does

It loads a JSON file and gives you strongly-typed values.  
You call `Config.Get<T>("key")`. You get the value. That’s it.

Supports all the basic types you care about:
- `string`
- `bool`
- `int`, `long`, `short`, `byte`
- `float`, `decimal`
- `Guid`

If you're trying to deserialize a polymorphic object graph or need runtime hot-reload across 3 microservices, this isn’t for you. Go enjoy your framework ceremony.

If you want to read `"maxUsers": 25` and move on with your life, welcome.

## Example

Look at `SimpleJsonConfig.TestApp` for an example in use.  
One line to load your config file. One line to get a value from it.  
That's it. Simple. The way we used to do it back in the day of INI files.

## License

MIT. Use it, break it, fork it, pretend you wrote it. I won't chase you.
