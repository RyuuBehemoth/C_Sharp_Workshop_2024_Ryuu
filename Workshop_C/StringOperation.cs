namespace Workshop_C;

public class StringOperation
{
   
    //Concatenate 2 strings with a space among it
   public string concat2trings(string txt1, string txt2)
    {
        return txt1+" "+txt2;
    }

   //Return the chars in the string
    public int charsInString(string txt1)
    {
        int l = txt1.Length;
        return l;
    }
    
    //return the letters in the string
    public int lettersInString(string txt)
    {
        txt = txt.Replace(" ","");
        int l = txt.Length;
        return l;
    }
    
    //Count the uppercase letters in a String
    public int upperInString(string txt)
    {
        int mayus = 0;
        for (int i = 0; i< txt.Length; i++)
        {
            if (Char.IsUpper(txt,i) == true)
            {
                mayus++;
            }
        }
        return mayus;
    }
    
    //count the times a char appears in the string (upper and lower)
    public int charInString(string txt, char a)
    {
        int repeat = 0;
        txt = txt.ToLower();
        for (int i = 0; i < txt.Length; i++)
        {
            if (txt[i] == a)
            {
                repeat++;
            }
        }
        return repeat;
    }
   
    //Reverse string
    public string reverseString(string txt)
    {
        var ctxt = txt.ToCharArray();
        Array.Reverse(ctxt);
        return new string(ctxt);
    }
    
    //Is palindrome?
    public bool isPalindrome(string txt)
    {
        txt = txt.ToLower();
        txt = txt.Replace(" ","");
        var ctxt = txt.ToCharArray();
        Array.Reverse(ctxt);
        if (txt == new string (ctxt))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    //substring in string
    public int substring(string txt, string substring)
    {
        int count = 0;
        int index = txt.IndexOf(substring);
        while (index >= 0)
        {
            index = txt.IndexOf(substring, index + substring.Length);
            count++;
        }
        return count;
    }
}