using System;
using Microsoft.Extensions.Logging;

namespace Spectre.Console.Extensions.Logging
{
    public class SpectreConsoleLoggerConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Information;
        public int EventId { get; set; } = 0;
        public Action<IAnsiConsole> ConsoleConfiguration { get; set; }
        public AnsiConsoleSettings ConsoleSettings {get;set;} = null;

        /// <summary>
        /// Include the LogLevel in the log entry.
        /// </summary>
        public bool IncludePrefix {get;set;} = true;

        /// <summary>
        /// Include the EventId in the log entry.
        /// </summary>
        public bool IncludeEventId {get;set;} = false;

        /// <summary>
        /// Put the entire log entry on 1 line.
        /// </summary>
        public bool SingleLine { get; set; } = false;

        /// <summary>
        /// Include the current DateTime on the log entry.
        /// </summary>
        public bool IncludeDateTime { get; set; } = false;
    }
}
