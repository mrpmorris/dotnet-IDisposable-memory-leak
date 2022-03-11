namespace DotnetIDisposableMemoryLeak.Services
{
	public class TransientNonDisposableService
	{
		private static int _createdCount;
		private static int _finalizedCount;

		public TransientNonDisposableService()
		{
			Interlocked.Increment(ref _createdCount);
		}

		public int CreatedCount => _createdCount;
		public int FinalizedCount => _finalizedCount;

		~TransientNonDisposableService()
		{
			Interlocked.Increment(ref _finalizedCount);
		}
	}
}
