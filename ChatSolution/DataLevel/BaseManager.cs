using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    abstract class BaseManager : IDisposable
    {
        protected ChatDbEntities _chatDb = new ChatDbEntities();
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                if (_chatDb != null)
                {
                    _chatDb.Dispose();
                    _chatDb = null;
                }
        }
        ~BaseManager()
        {
            Dispose(false);
        }
    }
}
