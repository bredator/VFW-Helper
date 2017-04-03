using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace VWFCalc
{
    public class projectFile
    {
        private string strProjektname;
        private string strTextdateiLocation;
        private string strTableLocation;
        private int iMaxZeilenlaenge;
        private int iCritZeilenlaenge;
        private int iPixelsBetweenChars;
        private int iMinZeilenlaenge;
        private List<string> listIgnoreGroups;
        private bool bShowEmptyLines;
        private Encoding _textEncoding;

        #region Properties

        public string StrProjektname
        {
            get { return strProjektname; }
            set { strProjektname = value; }
        }

        public string StrTextdateiLocation
        {
            get { return strTextdateiLocation; }
            set { strTextdateiLocation = value; }
        }

        public string StrTableLocation
        {
            get { return strTableLocation; }
            set { strTableLocation = value; }
        }

        public int IMaxZeilenlaenge
        {
            get { return iMaxZeilenlaenge; }
            set { iMaxZeilenlaenge = value; }
        }

        public int ICritZeilenlaenge
        {
            get { return iCritZeilenlaenge; }
            set { iCritZeilenlaenge = value; }
        }

        public int IPixelsBetweenChars
        {
            get { return iPixelsBetweenChars; }
            set { iPixelsBetweenChars = value; }
        }

        public int IMinZeilenlaenge
        {
            get { return iMinZeilenlaenge; }
            set { iMinZeilenlaenge = value; }
        }

        public List<string> ListIgnoreGroups
        {
            get { return listIgnoreGroups; }
            set { listIgnoreGroups = value; }
        }

        public bool BShowEmptyLines
        {
            get { return bShowEmptyLines; }
            set { bShowEmptyLines = value; }
        }

        [XmlIgnore]
        public Encoding TextEncoding
        {
            get { return _textEncoding; }
            set { _textEncoding = value; }
        }

        #endregion

        public projectFile()
        {
            listIgnoreGroups = new List<string>();
        }
    }
}
