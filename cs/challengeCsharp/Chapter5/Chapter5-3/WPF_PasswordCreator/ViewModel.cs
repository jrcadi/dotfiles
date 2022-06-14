using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_PasswordCreator {
    public class ViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            if(PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            //上記2行は以下の1行に置き換えることができる。
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //PropertyChanged?. の ?. は、NUll条件演算子と呼び、?. の前がnullであればnullを返し、nullでなければ後続の処理の結果を返す
        }
    }
}
