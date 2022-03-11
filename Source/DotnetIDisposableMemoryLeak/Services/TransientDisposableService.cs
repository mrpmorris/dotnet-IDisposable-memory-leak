namespace DotnetIDisposableMemoryLeak.Services
{
	public class TransientDisposableService : IDisposable
	{
		private static int _createdCount;
		private static int _disposedCount;
		private static int _finalizedCount;

		public TransientDisposableService()
		{
			Interlocked.Increment(ref _createdCount);
		}

		public int CreatedCount => _createdCount;
		public int DisposedCount => _disposedCount;
		public int FinalizedCount => _finalizedCount;

		void IDisposable.Dispose()
		{
			Interlocked.Decrement(ref _disposedCount);
		}

		~TransientDisposableService()
		{
			Interlocked.Increment(ref _finalizedCount);
		}
	}
}
