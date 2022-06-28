using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFA_To_Reduced_DFA_Converter.MyLibrary
{

    //************************ 사용자 정의 클래스 (제네릭 컬렉션 재정의) ************************//

    public class Set : SortedSet<string>
    {
        public bool Equals(Set other) => SetEquals(other);

        public override bool Equals(object obj) => obj is Set other && SetEquals(other);

        public override int GetHashCode()
        {
            int hashCode = 10988934;
            foreach (string item in this) hashCode = hashCode * -1521134295 + item.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Set point1, Set point2) => Equals(point1, point2);

        public static bool operator !=(Set point1, Set point2) => !Equals(point1, point2);

        public Set Union(Set other)
        {
            Set result = new Set();
            foreach (var item in this) result.Add(item);
            foreach (var item in other) result.Add(item);
            return result;
        }

        public Set Intersect(Set other)
        {
            Set result = new Set();
            foreach (var item in this)
                if (other.Contains(item)) result.Add(item);
            return result;
        }

        public Set Difference(Set other)
        {
            Set result = this.Copy();
            foreach (var item in this)
                if (other.Contains(item)) result.Remove(item);
            return result;
        }

        public void UnionWith(Set other)
        {
            foreach (var item in other) Add(item);
        }

        public Set Copy()
        {
            Set result = new Set();
            foreach (var item in this) result.Add(item);
            return result;
        }

        public bool Empty() => Count == 0 ? true : false;
    }


    public class Map2D : Dictionary<Set, Dictionary<string, Set>>
    {
        public Set this[string key1, string key2]
        {
            get { return this[new Set { key1 }, key2]; }
            set { this[new Set { key1 }, key2] = value; }
        }

        public Set this[Set key1, string key2]
        {
            get
            {
                if (!this.ContainsKey(key1)) this.Add(key1, new Dictionary<string, Set> { { key2, new Set() } });
                else if (!this[key1].ContainsKey(key2)) this[key1].Add(key2, new Set());
                return this[key1][key2];
            }
            set
            {
                if (!this.ContainsKey(key1)) this.Add(key1, new Dictionary<string, Set> { { key2, value } });
                else if (!this[key1].ContainsKey(key2)) this[key1].Add(key2, value);
                else this[key1][key2] = value;
            }
        }

        public Map2D Copy()
        {
            Map2D result = new Map2D();
            foreach(var key1 in this.Keys)
                foreach(var key2 in this[key1].Keys) result[key1, key2] = this[key1][key2].Copy();
            return result;
        }
    }


    public class DictionaryStringToSet : Dictionary<string, Set>
    {
        public new Set this[string key]
        {
            get
            {
                if (!ContainsKey(key)) Add(key, new Set());
                return base[key];
            }
            set
            {
                if (!ContainsKey(key)) Add(key, value);
                else base[key] = value;
            }
        }
    }


    public abstract class AbstractEpsilonClosureTable : Dictionary<string, Set>
    {
        public new Set this[string key]
        {
            get
            {
                if (!ContainsKey(key)) Add(key, new Set());
                return base[key];
            }
            set
            {
                if (!ContainsKey(key)) Add(key, value);
                else base[key] = value;
            }
        }
    }

    public class StateRenaming : Dictionary<Set, string>
    {
        public new string this[Set key]
        {
            get
            {
                if (!ContainsKey(key)) Add(key, "");
                return base[key];
            }
            set
            {
                if (!ContainsKey(key)) Add(key, value);
                else base[key] = value;
            }
        }
    }


    public class StateToGroup : Dictionary<Set, string>
    {
        public new string this[Set key]
        {
            get
            {
                if (!ContainsKey(key)) Add(key, "");
                return base[key];
            }
            set
            {
                if (!ContainsKey(key)) Add(key, value);
                else base[key] = value;
            }
        }
    }

    public class GroupToState : Dictionary<string, Set>
    {
        public new Set this[string key]
        {
            get
            {
                if (!ContainsKey(key)) Add(key, new Set());
                return base[key];
            }
            set
            {
                if (!ContainsKey(key)) Add(key, value);
                else base[key] = value;
            }
        }
    }




    //********************************* 클래스 기능 확장 ************************************//

    public static class Extensions
    {
        public static string ToStr(this Set set)
        {
            string temp = "";
            foreach (var e in set) temp += temp == "" ? e : ", " + e;
            return temp;
        }

        public static string ToSetStr(this Set set)
        {
            string temp = "[";
            foreach (var e in set) temp += temp.Length == 1 ? e : ',' + e;
            return temp + "]";
        }
    }
}
