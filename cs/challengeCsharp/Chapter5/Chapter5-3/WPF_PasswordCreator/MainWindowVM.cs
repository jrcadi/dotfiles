using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordCreator;

namespace WPF_PasswordCreator {
    class MainWindowVM : ViewModel{
        private ILetterFactory factory;
        private bool isNonMark;     //radioButton 記号なしとバインド
        public bool IsNonMark {
            get { return isNonMark; }
            set {
                isNonMark = value;
                if(IsNonMark) factory = new NonMarkLetterFactory();
            }
        }
        private bool isAll;     //radioButton 記号ありとバインド
        public bool IsAll {
            get { return isAll; }
            set {
                isAll = value;
                if(isAll) factory = new AllLetterFactory();
            }
        }
        private bool isMark2;     //radioButton 記号2文字とバインド
        public bool IsMark2 {
            get { return isMark2; }
            set {
                isMark2 = value;
                if(isMark2) factory = new Mark2LetterFactory();
            }
        }
        private int numOfLetters;
        public int NumOfLetters {
            get { return numOfLetters; }
            set { numOfLetters = value; }
        }
        private string createdPassword;
        public string CreatedPassword {
            get { return createdPassword; }
            set { createdPassword = value; OnPropertyChanged(); }  
        }
        public DelegateCommand MakePassword{ get; private set; }
        private void MakePasswordExecute(){
            Random random = new Random();
            var generator = new PasswordGenerator(random);
            CreatedPassword = generator.MakePassword(NumOfLetters, factory);
        }
        private bool CanMakePasswordExecute(){
            //MakePasswordExecuteメソッドの実行条件を指定する
            return numOfLetters > 10;
        }
        public MainWindowVM() {
            NumOfLetters = 20;
            IsAll = true;
            MakePassword = new DelegateCommand(MakePasswordExecute, CanMakePasswordExecute);
        }
    }
}
