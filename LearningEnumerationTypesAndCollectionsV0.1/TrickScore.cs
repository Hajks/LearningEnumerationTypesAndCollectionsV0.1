using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEnumerationTypesAndCollectionsV0._1
{
    public enum TrickScore //If we won't set up any values, they gonna get default one, like sit = 0, beg = 1 etc. etc.
    {
        Sit = 7, 
        Beg = 25,
        RollOver = 50,
        Fetch = 10,
        ComeHere = 5,
        Speak = 30,
    }
    public enum TrickScore2 : long // TrickScore as default is int type, if we wanna set up bigger values we have to decalre it in this way. Otherwise we gonna get error .
    {
        Sit = 7,
        Beg = 250000000025
    }
}
