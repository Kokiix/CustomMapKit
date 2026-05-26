using System;
using System.Collections.Generic;
using System.Threading;

namespace FluffyUnderware.DevTools
{
	public class ThreadPoolWorker<T> : IDisposable
	{
		private readonly SimplePool<QueuedCallback> queuedCallbackPool;

		private readonly SimplePool<LoopState<T>> loopStatePool;

		private int _remainingWorkItems;

		private ManualResetEvent _done;

		private WaitCallback handleWorkItemCallBack;

		private WaitCallback handleLoopCallBack;

		public void ParralelFor(Action<T> action, List<T> list)
		{
		}

		private bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return false;
		}

		private void ThrowIfDisposed()
		{
		}

		private void DoneWorkItem()
		{
		}

		public void Dispose()
		{
		}
	}
	public class ThreadPoolWorker : IDisposable
	{
		private int _remainingWorkItems;

		private ManualResetEvent _done;

		public void QueueWorkItem(WaitCallback callback)
		{
		}

		public void QueueWorkItem(Action act)
		{
		}

		public void ParralelFor<T>(Action<T> action, List<T> list)
		{
		}

		private void QueueWorkItem(QueuedCallback callback)
		{
		}

		public void QueueWorkItem(WaitCallback callback, object state)
		{
		}

		public void QueueWorkItem(Action act, object state)
		{
		}

		public bool WaitAll()
		{
			return false;
		}

		public bool WaitAll(TimeSpan timeout, bool exitContext)
		{
			return false;
		}

		public bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return false;
		}

		private void HandleWorkItem(object state)
		{
		}

		private void DoneWorkItem()
		{
		}

		private void ThrowIfDisposed()
		{
		}

		public void Dispose()
		{
		}
	}
}
