using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.IObservable
{
    public class News : IObservable<Article>
    {
        private List<IObserver<Article>> observers = new List<IObserver<Article>>();

        public IDisposable Subscribe(IObserver<Article> observer)
        {
            if(!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscribe(observers, observer);
        }

        private class Unsubscribe : IDisposable
        {
            private IObserver<Article> _observer;
            private List<IObserver<Article>> _observers;

            public Unsubscribe(List<IObserver<Article>> observers, IObserver<Article> observer)
            {
                this._observer = observer;
                this._observers = observers;
            }

            public void Dispose()
            {
                if (this._observers != null && this._observers.Contains(this._observer))
                {
                    this._observers.Remove(this._observer);
                }
            }
        }

        public void Notify(Article article)
        {
            foreach (var observer in  observers)
            {
                observer.OnNext(article);
            }
        }
    }

    public class Article
    {
        public String Title;
        public DateTime Date;
        public String Author;
        public String Content;

        public override string ToString()
        {
            return $"{nameof(Title)}:{Title},{nameof(Date)}:{Date.ToShortDateString()},{nameof(Author)}:{Author},{nameof(Content)}:{Content}";
        }
    }
}
