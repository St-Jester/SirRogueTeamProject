using System;
using System.Windows.Forms;

namespace SirRogue_alpha_v1._01
{
    class Quest
    {
        public int      QuestId     { get; private set; }
        public string   QuestText   { get; private set; }

        public Quest( int n, string t)
        {
            if (n > 0 && t != null)
            {
                QuestId     = n;
                QuestText   = t;
            }
            else
                MessageBox.Show("Wrong quest input data!");
        }        
    }
}
