using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadExt
{
    public class FindNextPrefs
    {
        String SearchText;
        bool Direction;
        int position;

        public String Text
        {
            get { return this.SearchText; }
            set { this.SearchText = value; }
        }

        public bool SearchDirection
        {
            get { return this.Direction; }
            set { this.Direction = value; }
        }

        public int CurrentPosition
        {
            get { return this.position; }
            set { this.position = value; }
        }
    }
}
