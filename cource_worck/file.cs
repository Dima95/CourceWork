using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NOTE_field;

namespace cource_worck
{
    sealed class file
    {
        public string way { get; set; }  // шлях до файлу із записами
        private List<string> text, part; // список для всього текту файлу(text) , і для фрагменту тексту(блоку) який обробляється (part)
        private List<string> key_words; // спсок ключових слів 
        private string[] mas;  
        public file()
        {
            // this.text = new List<string>();
            this.part = new List<string>();
            this.key_words = new List<string>(new String[] { "Роздатковий_Матеріал:", "Відповідь:", "Залік:", "Коментар:", "Джерело:", "Автор:" }); // ключові слова 
            mas = new string[7];
        } 
        public void to_List()   
        { 
            StreamReader st = new StreamReader(way, Encoding.GetEncoding(1251)); // 1251 - код кирилиці
            String s = st.ReadToEnd().Replace(Char.Parse("'"),'*'); // записуємо весь текст у стрінгову дану
            text = new List<string>(s.Split()); // розбиваємо її на список із слів
        }
        public void adding(Int32 b, ref String s) // для запису у стрінгову дану зі списку 
        {
            for (Byte i = 1; i < b; i++)
            {
                s += part[i] + " ";
            }
        }
        private Int32 search(int i) //для пошуку індексу ключового слова в блоці
        {
            return part.FindIndex(item => item == key_words[i]);
        }
        private void add_note(ref int j ,ref int k) // метод для зчитування запису 
        { 
            Int32 i = search(k); 
            if (i.Equals(-1))   // коли ключове сло відсутнє тоді буде записуватися "---"
            {
                mas[k + 1] = "---"; 
            }
            else 
            { 
                adding(i,ref mas[j]);
                part.RemoveRange(0, i); // видаляємо елементи які вже записали
                j = k + 1; 
            }   
        }
        private void masNull() // метод , який видаляє попередні значення з масиву mas
        { 
            for (int i = 0; i < mas.Count() - 1; i++)
            {
                mas[i] = null; 
            }
        }
        public void block(ref note n)
        {
            n = new note();
            //запис проводиться наступним чином : програма шукає ключове слово наступного поля і записує у попереднє поле
            //(наприклад , спочатку проводиться пошук слова "Відповідь" , всі слова які перед цим 
            //словом заисуються у поле "Питання" ) .  
            List<int> index = new List<int>(); 
            string s = null;
            s = null;
            int j = 0; 
            for (int i = 0; i < 6; i++)
            {
                add_note(ref j, ref i);
            }
            n.query = mas[0];
            n.way = mas[1];
            n.answer = mas[2];
            n.zalick = mas[3];
            n.coment = mas[4];
            n.source = mas[5];
            foreach (string elem in part) s += elem + " ";
            List<char> ch = new List<char>(s.ToList<char>());
            int a = ch.FindIndex(item => item == '(');
            int b = ch.FindIndex(item => item == ')');
            if (a.Equals(-1) || b.Equals(-1))
            {
                n.place = "---";
                part.RemoveRange(0,1);
                foreach (string elem in part) n.author += elem;
            }
            else
            {
                for (int i = 7; i < a; i++) // починаємо цикл із 7 щоб не виводило слова автор 
                {
                    n.author += ch[i]; // автор
                }
                for (int i = a + 1; i < b; i++)
                {
                    n.place += ch[i];  //місто
                }
            }
        }
        public void List_fields(ref List<note> ls) // метод повертає список записів 
        {
            to_List();
            ls = new List<note>(); 
            note n = new note();
            foreach (string el in text)
            {
                masNull(); 
                if (el.Equals("+++")) // "+++" - це ключоаий символ який позначає кінець блоку 
                {
                    block(ref n);
                    ls.Add(n);
                    n = null;
                    part.Clear();
                    continue;
                } 
                part.Add(el);
            }
        } 
    }
    }

