using System;

namespace StringCalculator
{
    public class ExtractAndOverrideFactoryMethod
    {
        private _VIPClass vipClass;
        public ExtractAndOverrideFactoryMethod()
        {
            vipClass = vipclassGetter();
        }

        protected virtual _VIPClass vipclassGetter()
        {
            var ThewirttingIntoFile = new _writtingIntoFile();
            var TheconnectiongToDB = new _connectingToDB();
             return vipClass = new _VIPClass(ThewirttingIntoFile, TheconnectiongToDB);
        }
    }

    public class _VIPClass
    {
        public _VIPClass(_writtingIntoFile thewirttingIntoFile, _connectingToDB theconnectiongToDb)
        {
            throw new NotImplementedException();
        }
    }

    public class _connectingToDB
    {
        public static void DoSomeTransaction()
        {
            throw new NotImplementedException();
        }
    }

    public class _writtingIntoFile
    {
        public void DoSomeWriting()
        {
            throw new NotImplementedException();
        }
    }

    public class TestExtractAndOverrideFactoryMethod:ExtractAndOverrideFactoryMethod
    {

        protected override _VIPClass vipclassGetter()
        {
            return  fakevipclassGetter();
        }

        private static _VIPClass fakevipclassGetter()
        {
            throw new NotImplementedException();
        }
    }

}
