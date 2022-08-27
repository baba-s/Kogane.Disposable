using System;

namespace Kogane
{
    public static class Disposable
    {
        public static IDisposable Empty => EmptyDisposable.Singleton;

        public static IDisposable Create( Action disposeAction )
        {
            return new AnonymousDisposable( disposeAction );
        }

        private sealed class EmptyDisposable : IDisposable
        {
            public static EmptyDisposable Singleton { get; } = new();

            private EmptyDisposable()
            {
            }

            public void Dispose()
            {
            }
        }

        private sealed class AnonymousDisposable : IDisposable
        {
            private readonly Action m_dispose;

            private bool m_isDisposed;

            public AnonymousDisposable( Action dispose )
            {
                m_dispose = dispose;
            }

            public void Dispose()
            {
                if ( m_isDisposed ) return;

                m_dispose();
                m_isDisposed = true;
            }
        }
    }
}