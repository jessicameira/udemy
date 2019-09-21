using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_secao9_aula121.Entities
{
    class Comments
    {
        public string Text { get; set; }

        public Comments()
        {
        }

        public Comments(string text)
        {
            Text = text;
        }
    }
}
