using System;
using System.Text;
namespace Utilities{
    public class StringManipulator{
        public string Reverse(string input){
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public int CountVowels(string input){
            int count = 0;
            foreach(char c in input.ToLower()){
                if("aeiou".Contains(c)){
                    count++;
                }
            }
            return count;
        }
        public string ToPigLatin(string word){
            if(string.IsNullOrEmpty(word)){ return word;}
            string vowels = "aeiou";
            if(vowels.Contains(word[0])){
                return word + "ay";
            }
            return word.Substring(1) + word[0] + "ay";
        }
        public string RemoveWhitespace(string input){
            return input.Replace(" ", "").Replace("\t", "").Replace("\n", "");
        }
        public string Concatenate(params string[] strings){
            StringBuilder sb = new StringBuilder();
            foreach(string str in strings){
                sb.Append(str);
            }
            return sb.ToString();
        }
        public string MostFrequentChar(string input){
            if(string.IsNullOrEmpty(input)){ return null;}
            int[] counts = new int[256];
            foreach(char c in input){
                counts[c]++;
            }
            int maxIndex = 0;
            for(int i = 1; i < counts.Length; i++){
                if(counts[i] > counts[maxIndex]){
                    maxIndex = i;
                }
            }
            return ((char)maxIndex).ToString();
        }
    }
}
