using NUnit.Framework;

namespace StringCalculator
{
    public class ExtractInterface
    {
        private readonly ISomeDetail _someDetail;
        public ExtractInterface(ISomeDetail someDetail)
        {
            _someDetail = someDetail;
        }
        public string calculate()
        {
            return _someDetail.DoSomeThing();
        }
    }

    public interface ISomeDetail
    {
        string DoSomeThing();
    }

    public class SomeDetail : ISomeDetail
    {
        public string DoSomeThing()
        {
            return "some text";
        }
    }



    [TestFixture]
    public class testExtractInterface
    {
        [Test]
        public void call_Calculate_should_return()
        {
            ISomeDetail fakeSomeDetail = new fakeSomeDetail();
            var extractInterface = new ExtractInterface(fakeSomeDetail);
            var value=extractInterface.calculate();

            Assert.That(value, Is.EqualTo("some text"));
        }

    }
    public class fakeSomeDetail:ISomeDetail
    {
       public string DoSomeThing()
        {
            return "some text";
        }
    }


}
