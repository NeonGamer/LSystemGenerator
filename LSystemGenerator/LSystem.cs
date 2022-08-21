using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSystemGenerator
{
    public class LSystem
    {
        public static string Generate(string axiom, int iterations, Dictionary<string, string> rules)
        {
            var sb = new StringBuilder();
            sb.Append(axiom);
            for (int i = 0; i < iterations; i++)
            {
                sb = ApplyRules(sb, rules);
            }
            return sb.ToString();
        }
        public static StringBuilder ApplyRules(StringBuilder sb, Dictionary<string, string> rules)
        {
            int oriLength = sb.Length;
            for (int i = 0; i < sb.Length; i++)
            {
                sb.Append(rules[sb[i].ToString()]);
            }
            sb.Remove(0, oriLength);
            return sb;
        }
    }
}
