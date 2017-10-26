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
        private ConcreteSubject _concreteSubject;

        public ConcreteObserver(ConcreteSubject concreteSubject)
        {
            this._concreteSubject = concreteSubject;
        }

        public override void Update()
        {
            _state = _concreteSubject.SubjectState;
            Debug.WriteLine("状态被修改了");
        }
    }
}
