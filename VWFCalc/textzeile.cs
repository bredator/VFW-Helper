namespace VWFCalc
{
    class textzeile
    {
        private int iLength;
        private int iLengthLeft;
        private int iId;
        private string strText;

        public int ILength
        {
            get { return iLength; }
            set { iLength = value; }
        }

        public int ILengthLeft
        {
            get { return iLengthLeft; }
            set { iLengthLeft = value; }
        }

        public string StrText
        {
            get { return strText; }
            set { strText = value; }
        }

        public int IId
        {
            get { return iId; }
            set { iId = value; }
        }
    }
}
