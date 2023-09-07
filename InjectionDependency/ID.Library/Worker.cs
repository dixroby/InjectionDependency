namespace ID.Library
{
    public class Worker
    {
        readonly IMessageWriter messageWriter;

        public Worker(IMessageWriter messageWriter)
        {
                messageWriter = messageWriter;
        }
        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                messageWriter.Write(
                    $"worker runnung at: {DateTimeOffset.Now}");
                await Task.Delay( 1000, cancellationToken );
            }
        }
    }
    
}