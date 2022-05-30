using System;

namespace StringExtension
{
    public static class _Extensions
    {
        public static string _Concat(this string str0, string str1)
        {
            return str0 + str1;
        }
        public static string _Copy(this string source)
        {
            if (source != null)
                return source;
            return default(string);
        }
        public static bool _Equals(this string str0, string str1)
        {
            if (str0 == str1) return true;
            return false;
        }
        public static bool _IsNullOrEmpty(this string source)
        {
            if ((source == null) || (source == string.Empty)) return true;
            return false;
        }
        public static bool _IsNullOrWhiteSpace(this string source)
        {
            if ((source == null) || (source == string.Empty)) return true;
            for (int i = 0; i < source.Length; i++)
                if (source[i] != ' ') return false;
            return true;
        }
        public static bool _Contains(this string source, char ch)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            };
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == ch) return true;
            }
            return false;
        }
        public static string _TrimStart(this string source, char ch)
        {
            string result = null;
            if (source == null) throw new ArgumentNullException();
            if (source[0] != ch)
                return source;
            else
            {
                for (int i = 1; i < source.Length; i++)
                {
                    result += source[i];
                }
                return result;
            }
        }
        public static string _TrimEnd(this string source, char ch)
        {
            string result = null;
            if (source == null) throw new ArgumentNullException();
            if (source[source.Length - 1] != ch)
                return source;
            else
            {
                for (int i = 0; i < source.Length - 1; i++)
                {
                    result += source[i];
                }
                return result;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "AB"._Concat("CD");
            string b = null;

            string c = a._Copy();

            c = null;
            bool comp = b._Equals(null);

            b = "a";
            comp = b._IsNullOrEmpty();

            b = "s              sssqsttaqqq          q";
            comp = b._IsNullOrWhiteSpace();

            comp = b._Contains('a');

            c = b._TrimStart('s');

            c = b._TrimEnd('q');
        }
    }
}
