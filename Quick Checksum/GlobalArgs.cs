using System.Collections.Generic;

namespace Quick_Checksum
{
    class GlobalArgs
    {

        private static List<string> _globalArgList = new List<string>();

        public static List<string> GlobalArgList
        {
            get { return _globalArgList; }
            set { _globalArgList = value; }
        }
    }
}
