public class Solution {
    public int RomanToInt(string s) {
        int sum = 0;
        char prev = 'a';
        Dictionary<char,int> rm = new Dictionary<char,int>();
        rm['I'] = 1;
        rm['V'] = 5;
        rm['X'] = 10;
        rm['L'] = 50;
        rm['C'] = 100;
        rm['D'] = 500;
        rm['M'] = 1000;


        foreach(char c in s){
            if (prev == 'I' && c == 'V'){
                sum += 3;
            }
            else if (prev == 'I' && c == 'X'){
                sum += 8;
            }
            else if (prev == 'X' && c == 'L'){
                sum += 30;
            }
            else if (prev == 'X' && c == 'C'){
                sum += 80;
            }
            else if (prev == 'C' && c == 'D'){
                sum += 300;
            }
            else if (prev == 'C' && c == 'M'){
                sum += 800;
            }
            else {
                sum += rm[c];
            }

            prev = c;
        }

        return sum;
//1000
// 1100
// 1900
// 1990
    }
}
