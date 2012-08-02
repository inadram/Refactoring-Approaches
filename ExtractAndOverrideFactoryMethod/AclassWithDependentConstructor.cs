using System;

namespace StringCalculator
{
    public class AclassWithDependentConstructor
    {
        private VIPClass vipClass;
        public AclassWithDependentConstructor()
        {
            var ThewirttingIntoFile = new writtingIntoFile();
            var TheconnectiongToDB = new connectingToDB();
            vipClass = new VIPClass(ThewirttingIntoFile, TheconnectiongToDB);
        }
    }

    public class VIPClass
    {
        public VIPClass(writtingIntoFile thewirttingIntoFile, connectingToDB theconnectiongToDb)
        {
            throw new NotImplementedException();
        }
    }

    public class connectingToDB
    {
        public static void DoSomeTransaction()
        {
            throw new NotImplementedException();
        }
    }

    public class writtingIntoFile
    {
        public void DoSomeWriting()
        {
            throw new NotImplementedException();
        }
    }


   
}
