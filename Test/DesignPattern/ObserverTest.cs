using DesignPattern.Observer.Classic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Observer.IObservable;
using Xunit;

namespace Test.DesignPattern
{
    public class ObserverTest
    {
        /// <summary>
        /// 经典观察者测试
        /// </summary>
        [Fact]
        public void ClassicTest()
        {
            Subject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject));
           
            subject.SubjectState = 1;
            subject.Notify();
        }

        [Fact]
        // ReSharper disable once InconsistentNaming
        public void IObservableTest()
        {
            News news = new News();
            Person person = new Person("John");
            news.Subscribe(person);
            Article article = new Article();
            article.Author = "Mark Twain";
            article.Content = "blablabla";
            article.Date = new DateTime(1999, 1, 1);
            article.Title = "Tom And Jerry";
            news.Notify(article);
        }
    }
}
