using System;

namespace NotepadExt
{
    //-----------------------------------------------------------------------------------------------------
    public class FindNextPrefs
    {
        String SearchText;
        String Content;
        String Direction;
        int position;
        bool MatchCase;

        //-----------------------------------------------------------------------------------------------------
        public String SearchString
        {
            get { return this.SearchText; }
            set { this.SearchText = value; }
        }

        //-----------------------------------------------------------------------------------------------------
        public String SearchDirection
        {
            get { return this.Direction; }
            set { this.Direction = value; }
        }

        //-----------------------------------------------------------------------------------------------------
        public int CurrentPosition
        {
            get { return this.position; }
            set { this.position = value; }
        }

        //-----------------------------------------------------------------------------------------------------
        public bool HardMatch
        {
            get { return this.MatchCase; }
            set { this.MatchCase = value; }
        }

        //-----------------------------------------------------------------------------------------------------
        public String content
        {
            get { return this.Content; }
            set { this.Content = value; }
        }
    }
}



