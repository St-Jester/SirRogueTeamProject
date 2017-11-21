using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SirRogue_alpha_v1._01
{
    class QuestCollection
    {
        public List<Quest> QuestDBase { get; private set; }

        public QuestCollection()
        {
            QuestDBase = new List<Quest>();
        }

        public void AddQuest(int id, string t)
        {
            if (id > 0 && t != null)
            {
                QuestDBase.Add(new Quest(id, t));
            }
            else
                MessageBox.Show("Wrong quest input data!");
        }

        public void DeleteQuest(int id)
        {
            if (id > 0)
            {
                int count = 0;
                foreach (var item in QuestDBase)
                {
                    if (item.QuestId == id)
                    {
                        QuestDBase.RemoveAt(count);
                    }
                    count++;
                }
            }
            else
                MessageBox.Show("Can't delete quest. Wrong id.");
        }
    }
}
