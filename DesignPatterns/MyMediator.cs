using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class MyMediator
    {

        public IList<MyObject> _list = new List<MyObject>();

        public void Register(MyObject obj)
        {
            obj.Set(this);

            this._list.Add(obj);
        }

        public void IncrementCounter(int value)
        {
            foreach (var item in _list)
            {
                // item.IncrementCounter(value)
            }
        }
    }
}

class MyObject
{
    protected MyMediator _myMediator;
        
    public void Set(MyMediator myMediator)
    {
        _myMediator = myMediator; 
    }

    public void SendBackIncrement(int value)
    {
        _myMediator.IncrementCounter(value);
    }
}
