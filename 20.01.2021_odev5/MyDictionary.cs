using System;
using System.Collections.Generic;
using System.Text;

namespace _20._01._2021_odev5
{
    class MyDictionary<Tkey, Tval>
    {
        Tkey[] _dictionaryKey;
        Tkey[] _tempKey;
        Tval[] _dictionaryValue;
        Tval[] _tempVal;

        public MyDictionary()
        {
            _dictionaryKey = new Tkey[0];
            _dictionaryValue = new Tval[0];
        }
        public void Add(Tkey item1,Tval item2)
        {
            _tempKey = _dictionaryKey;
            _tempVal = _dictionaryValue;

            _dictionaryKey = new Tkey[_dictionaryKey.Length + 1];
            _dictionaryValue = new Tval[_dictionaryValue.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _dictionaryKey[i] = _tempKey[i];
            }
            for (int i = 0; i < _tempVal.Length; i++)
            {
                _dictionaryValue[i] = _tempVal[i];
            }
            _dictionaryKey[_dictionaryKey.Length - 1] = item1;
            _dictionaryValue[_dictionaryValue.Length - 1] = item2;
        }

    }
}
