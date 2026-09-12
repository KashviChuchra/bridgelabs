using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    public class CirculationLogger : IDisposable
    {
        private StreamWriter? writer;
        private bool disposed;
        public bool IsDisposed => disposed;
        public CirculationLogger(string filePath)
        {
            writer = new StreamWriter(filePath, append: true);
            writer.AutoFlush = true;
        }
        public void Log(string message)
        {
            if (disposed)   throw new ObjectDisposedException(nameof(CirculationLogger));

            writer?.WriteLine($"{DateTime.Now}| {message}");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)   return;

            if (disposing)
            {
                writer?.Dispose();
            }
            writer = null;
            disposed = true;
        }

        ~CirculationLogger()
        {
            Dispose(false);
        }
    }


}
