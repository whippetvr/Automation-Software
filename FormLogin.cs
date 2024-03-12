using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lrt_Ilukste
{
    public partial class FormLogin : Form
    {
        private const string AdminName = "ADMINISTRATOR";
        private const string AdminPWD = "e'z0;xke5y1";      //1f6cu99

        // Event on User was changed
        //public delegate void UserHandler(string UserName, int AccessLevel);
        //public event UserHandler OnUserChanged;              //  Define Event

        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            FormMain.ProgramUserName = "Нет регистрации";
            FormMain.ProgramAccessLevel = 0;

            //FormMain.ProgramUserName = AdminName;
            //FormMain.ProgramAccessLevel = 1000;
            //this.Close();

            //Check Administrator Password
            string str = textBoxUserName.Text.Trim();
            str = str.ToUpper();

            if (str.CompareTo(AdminName) == 0)
            {
                //OnUserChanged?.Invoke(AdminName, 1000);   // 2.Вызов события
                FormMain.ProgramUserName = AdminName;
                FormMain.ProgramAccessLevel = 1000;
            }
            else
            {
                //  Check User's Password
                using (IluksteEntities db = new IluksteEntities())
                {
                    // Get Users from DB
                    var users = db.Users.ToList();
                    foreach (Users u in users)
                    {
                        string s = u.UserName.ToUpper();
                        if (s.CompareTo(str) == 0)
                        {
                            string pwd = XORText(textBoxPassword.Text.Trim());
                            if (u.UserPWD.CompareTo(pwd) == 0)
                            {
                                FormMain.ProgramUserName = u.UserName;
                                FormMain.ProgramAccessLevel = (short)u.AccessLevel;
                            }
                            else
                            {
                                //MessageBox.Show("Неправильное имя оператора или пароль ...", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }

                        }
                        //Console.WriteLine($"{u.UserID}.{u.UserName} - {u.UserPWD}");
                    }
                    if (FormMain.ProgramUserName.CompareTo("Нет регистрации") == 0)
                    {
                        MessageBox.Show("Неправильное имя оператора или пароль ...", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            

            this.Close();

        }

        public static string XORText(string strText)
        {
            /*   Encrypt or decrypt a string using the XOR operator.
      ' In: strText:  Input text
      '     strPWD: Password to be used for encryption.
      ' Out: Return Value:  The encrypted/decrypted string. */

            char[] arr;
            //byte[] abytText;
            
            int intPWDPos;
            int intPWDLen;
          //  int intChar;
            const string strPWD = "TALSNARTSOR";

            if (strText.Length == 0)
                return "";

            while(strText.Length < 11)
            {
                strText += strText; 
            }
            strText = strText.Substring(0, 11);

            arr = strText.ToCharArray();
            byte[] abytText = {0,0,0,0,0,0,0,0,0,0,0};
            
            for(int i=0; i < arr.Length; i++)
            {
                abytText[i] = Convert.ToByte(arr[i]);
            }
            byte[] abytPWD = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            arr = strPWD.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                abytPWD[i] = Convert.ToByte(arr[i]);
            }
            
            intPWDLen = strPWD.ToCharArray().Length;

            for( int intChar = 0; intChar < abytText.Length; intChar++)
            {
                //Get the next number between 0 and intPWDLen - 1
                intPWDPos = (intChar % intPWDLen);
                abytText[intChar] = (byte)(abytText[intChar] ^ abytPWD[intPWDPos]);
            }
  
            string res = "";
            for (int i = 0; i < abytText.Length; i++)
            {
                arr[i] = Convert.ToChar(abytText[i]);
                res += arr[i].ToString();
            }
            return res;
         }

    }
}
