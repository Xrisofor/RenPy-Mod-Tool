using System;
using System.Linq;
using System.Text;

namespace ModTool
{
    public class StringExtension
    {

        static string[] CyrilicToLatinL = "a,b,v,g,d,e,zh,z,i,j,k,l,m,n,o,p,r,s,t,u,f,kh,c,ch,sh,sch,j,y,j,e,yu,ya".Split(',');
        static string[] CyrilicToLatinU = "A,B,V,G,D,E,Zh,Z,I,J,K,L,M,N,O,P,R,S,T,U,F,Kh,C,Ch,Sh,Sch,J,Y,J,E,Yu,Ya".Split(',');
        static Random random = new Random();

        public static string CyrilicToLatin(string s)
        {
            var sb = new StringBuilder((int)(s.Length * 1.5));
            foreach (char c in s)
            {
                if (c >= '\x430' && c <= '\x44f') sb.Append(CyrilicToLatinL[c - '\x430']);
                else if (c >= '\x410' && c <= '\x42f') sb.Append(CyrilicToLatinU[c - '\x410']);
                else if (c == '\x401') sb.Append("Yo");
                else if (c == '\x451') sb.Append("yo");
                else sb.Append(c);
            }
            return sb.ToString();
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
