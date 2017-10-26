using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Classic
{
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private int _state;
        private Subject _subject;

        public ConcreteObserver(Subject subject)
        {
            this._subject = subject;
        }

        public override void Update()
        {
            _state = _subject.SubjectState;
            Debug.WriteLine($"状态被修改为{_state}");
        }
    }
}
