using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex5_1
{
    class CellPhone : IComputer, IMailer, IPhone
    {
        public void SendMail()
        {
            Console.WriteLine("メールを送る");
        }
     
        public void RecieveMail()
        {
            Console.WriteLine("メールを受信する");
        }
   
        public void BrowseWeb()
        {
            Console.WriteLine("ウェブを閲覧する");
        }
   
        public void PlayGame()
        {
            Console.WriteLine("ゲームをする");
        }
   
        public void CallPhone()
        {
            Console.WriteLine("電話を掛ける");
        }
   
        public void RecievePhone()
        {
            Console.WriteLine("電話を受ける");
        }
    }
}
