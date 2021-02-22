using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EdlinSoftware.Adviser
{
    /// <summary>
    /// Represents history of topics.
    /// </summary>
    public class History
    {
        private readonly List<long> _topics = new List<long>();
        private int _current = -1;

        public bool CanGoBack
        {
            [DebuggerStepThrough]
            get { return _current > 0; }
        }

        public bool CanGoForward
        {
            [DebuggerStepThrough]
            get { return _current < _topics.Count - 1; }
        }

        public void Add(long topicId)
        {
            if (_current >= 0 && _current < _topics.Count && topicId == _topics[_current])
            { return; }

            _topics.Insert(++_current, topicId);

            if (CanGoForward)
            {
                _topics.RemoveRange(_current + 1, _topics.Count - (_current + 1));
            }
        }

        public long GoBack()
        {
            return _topics[--_current];
        }

        public long GoForward()
        {
            return _topics[++_current];
        }
    }
}
