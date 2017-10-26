using DesignPattern.Observer.Classic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test.DesignPattern
{
    public class ObserverTest
    {
        [Fact]
        public void ClassicTest()
        {
            Subject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject));
           
            subject.SubjectState = 1;
            subject.Notify();
        }
    }
}
