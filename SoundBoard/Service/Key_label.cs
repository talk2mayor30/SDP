using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.Service
{
    class Key_label<TKey, TItem> : List<TItem>
    {
        public TKey Key { protected set; get; }

    
        public Key_label(TKey key, IEnumerable<TItem> items)
            : base(items)
        {
            Key = key;
        }

        public Key_label(IGrouping<TKey, TItem> grouping)
            : base(grouping)
        {
            Key = grouping.Key;
           
        }
    }
    
    
}
