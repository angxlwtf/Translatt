# Translatt
Playboi Carti translator written in C#

# Translation Method
```
public static string Translate(string word)
        {
            string translated = "END-RESULT";
            bool first = true;
            string last = "LAST-STRING";
            last = "";
            translated = "";

            foreach (char c in word)
            {
                if(first)
                {
                    translated = translated + char.ToUpper(c).ToString();
                    first = false;
                    last = char.ToLower(c).ToString();
                    continue;
                }

                if (char.IsUpper(c) && !first)
                {
                    translated = translated + char.ToLower(c).ToString();
                    last = char.ToLower(c).ToString();
                    continue;
                }

                if (c.ToString() == "0")
                {
                    translated = translated + "o";
                    continue;
                }
                if(last == "<") { } else
                {
                    if (c.ToString() == "3")
                    {
                        translated = translated + "e";
                        continue;
                    }
                }
                if (c.ToString() == "4")
                {
                    translated = translated + "for";
                    continue;
                }
                last = c.ToString();
                translated = translated + c.ToString();
                first = false;
            }
            return translated;
        }
        ```
