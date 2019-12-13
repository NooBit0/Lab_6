using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba7
{
    internal class Collection
    {
        #region Fields
        private AgronomistRecord[] _content;
        #endregion

        #region Constructor
        public Collection(IEnumerable<AgronomistRecord> content)
        {
            _content = content.ToArray();
        }
        #endregion

        #region Properties
        public AgronomistRecord[] Items => _content;
        #endregion

        #region Indexer
        public AgronomistRecord this[int index]
        {
            get
            {
                return _content[index];
            }

            set
            {
                _content[index] = value;
            }
        }
        #endregion

        #region Metods

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in _content)
            {
                sb.Append(item).Append("\n");
            }

            return sb.ToString();
        }

        public void Add(AgronomistRecord newItem, int index)
        {
            Array.Resize(ref _content, _content.Length + 1);
            Array.Copy(_content, index, _content, index + 1, _content.Length - index - 1);
            _content[index + 1] = newItem;
        }

        public void Add(AgronomistRecord newItem)
        {
            Array.Resize(ref _content, _content.Length + 1);
            _content[_content.Length - 1] = newItem;
        }

        public void Remove(int key) => _content = _content.Where((obj, index) => index != key).ToArray();

        public void Sort() => Array.Sort(Items);

        public IEnumerable<AgronomistRecord> Get(int applicationRate) => Array.FindAll(Items, item => item.ApplicationRate == applicationRate);

        #endregion

        internal struct AgronomistRecord : IComparable<AgronomistRecord>
        {
            #region Fields
            private string _cultureName;
            private string _fertilizername;
            private int _applicationRate;
            private int _entryDate;
            private int _contentInVolume;
            #endregion

            #region Constructor
            public AgronomistRecord(string cultureName, string fertilizerName, int applicationRate, int entryDate, int contentInVolume)
            {
                _cultureName = cultureName;
                _fertilizername = fertilizerName;
                _applicationRate = applicationRate;
                _entryDate = entryDate;
                _contentInVolume = contentInVolume;
            }
            #endregion

            #region Properties
            public string CultureName { get => _cultureName; set => _cultureName = value; }

            public string FertilizerName { get => _fertilizername; set => _fertilizername = value; }

            public int ApplicationRate { get => _applicationRate; set => _applicationRate = value; }

            public int EntryDate { get => _entryDate; set => _entryDate = value; }

            public int ContentInVolume { get => _contentInVolume; set => _contentInVolume = value; }
            #endregion

            public int CompareTo(AgronomistRecord arr)
            {
                return this.ApplicationRate.CompareTo(arr.ApplicationRate);
            }

            #region Metods
            public override string ToString()
            {
                return $"{CultureName} | {FertilizerName} | {ApplicationRate} | {(Months)EntryDate} | {ContentInVolume}";
            }
            #endregion
        }
    }
}
