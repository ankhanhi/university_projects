﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Lab5_PIN_24_Khan_Anna
{
    class TitleComparer : Paper, IComparer<Paper>
    {
        public new int Compare(Paper paper1, Paper paper2)
        {
            return String.Compare(paper1.Title, paper2.Title);
        }
    }
}
