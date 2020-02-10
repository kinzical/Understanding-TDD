using NUnit.Framework;
using StackService.Services;

namespace Tests.UnitTests.Services
{
    [TestFixture]
    public class StackTests
    {
        //StackS _stack;
        [SetUp]
        public void Setup()
        {
            //_stack = new StackS();
        }
        

        [Test]
        public void Creation()
        {
            StackS<int> s = new StackS<int>(3);
            Assert.AreEqual(0,s.Size);
        }
        //StackS<int> s = new StackS<int>(3);
        /*[Test]
        public void PushOp()
        {
            StackS<int> s = new StackS<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3,s.Size);
        }
        [Test]
        public void PopOp()
        {
            StackS<int> s = new StackS<int>(3);
            s.Push(1);
            int value= s.Pop();
            Assert.AreEqual(2, value);
        }*/
        [Test]
        public void Push_Pop()
        {
            StackS<int> s = new StackS<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            int value =s.Pop();
            Assert.AreEqual(3,value);
            Assert.AreEqual(2,s.Size);
        }
        [Test]
        public void PopException()
        {
            StackS<int> s = new StackS<int>(3);
            Assert.Throws<ProhibitedPop>(() => s.Pop());
        }
        [Test]
        public void PushException()
        {
            StackS<int> s = new StackS<int>(3);
            Assert.Throws<ProhibitedPush>(() => s.Pop());
        }
        
    }
}