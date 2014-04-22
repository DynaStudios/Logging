Dyna Logging Library
=======
The DynaStudios Logger is a very simple and minimalistic Logging Library. It's easy to use and extendable with your own Logging Appenders.

## Example Usage ##
Since the Logger is using the Singleton Pattern you can easily include the Logger to your classes:

```C#
private readonly Logger logger = Logger.Instance;
```

With the Logger instance you can now call log events with different LogLevels.

```C#
logger.Debug("Debug Log");
logger.Info("Info Log");
logger.Warn("Warning Log");
logger.Error("Error Log");
logger.Fatal("Fatal Log");
```

The Log Event calls also support string.format() style messages.

```C#
logger.debug("Hello {0} {1}", firstname, lastname);
```

## Defining Appenders ##
If you don't define any Appenders at application startup nothing will happen.

The Dyna Logging Library ships with two default Logging Appenders.

- ConsoleAppender - Used to print Log Events to the default Console
- FileAppender - Used to log events to a File

Use one or multiple ones to handle your Log Events. Adding a Appender is very simple and possible at runtime:

```C#
logger.RegisterLoggingAppender(new ConsoleLogger());
```

or with the FileAppender:

```C#
FileLogger fileAppender = new FileLogger(@"C:\Log\AppLog.txt");
logger.RegisterLoggingAppender(fileAppender);
```

## ToDo ##
This Library is in an early state of development. Features like Appender Log Thresholds and Namespace specific logging will follow, as soon as I get some more free time. :o)

I'm also accepting Community work of course. So if extended the Library with something cool, feel free to create a Pull Request.