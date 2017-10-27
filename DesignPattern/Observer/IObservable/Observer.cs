using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.IObservable
{
    public class Person : IObserver<Article>
    {
        private string _personName;

        public Person(string name)
        {
            this._personName = name;
        }

        public string PersonName {
            get { return this._personName; }
        }

        public void OnCompleted()
        {
            Debug.WriteLine($"{nameof(Article)} Changed Completed!");
        }

        public void OnError(Exception error)
        {
            Debug.WriteLine($"{nameof(Article)} Changed Error!");
        }

        public void OnNext(Article value)
        {
            Debug.WriteLine($"{nameof(Article)} On Next {value}");
        }
    }
}
