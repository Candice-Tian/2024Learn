namespace NetCoreLearn.LifeTime
{
    public interface IMessageWritter
    {
        void Write(string message);
    }

    public class MessageWriter : IMessageWritter
    {
        public void Write(string message)
        {
            Console.WriteLine($"MessageWriter.Write(message: \"{message}\")");
        }
    }

    public class LoggingMessageWriter : IMessageWritter
    {
        private readonly ILogger<LoggingMessageWriter> _logger;

        public LoggingMessageWriter(ILogger<LoggingMessageWriter> logger) =>
            _logger = logger;

        public void Write(string message) =>
            _logger.LogInformation("Info: {Msg}", message);
    }

    public class TestForMultipleImplementServices
    {
        public static void Test(WebApplicationBuilder builder)
        {
            //test adding multiple services

            builder.Services.AddSingleton<IMessageWritter, MessageWriter>();
            builder.Services.AddSingleton<IMessageWritter, LoggingMessageWriter>();

            var result = builder.Services.Where(p => p.ServiceType == typeof(IMessageWritter));
            Console.WriteLine(result.Count());
            Console.WriteLine(result.First().ImplementationType);
            Console.WriteLine(result.Last().ImplementationType);
        }
    }
}
