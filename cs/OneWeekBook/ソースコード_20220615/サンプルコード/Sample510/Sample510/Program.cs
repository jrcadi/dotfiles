﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample510
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone("hoge@email.com",
                 "090-1234-5678");
            //  携帯電話クラスで、電話とメールを送る
            cp.Call("011-123-4567");
            cp.SendMail("fuga@email.com");
            //  電話インターフェースでインスタンスにアクセス。
            IPhone phone = (IPhone)cp;
            phone.Call("011-987-6543");     //  電話をかける
            //  メールの送信メソッドは利用できない。
            //  phone.SendMail("foo@email.com");
            //  メールインターフェースでインスタンスにアクセス。
            IEmail mail = (IEmail)cp;
            mail.SendMail("bar@email.com"); //  メールを出す
            //  メールインターフェースでは、電話の機能を利用できない。
            //mail.Call("011-222-3333");    
        }
    }
}
